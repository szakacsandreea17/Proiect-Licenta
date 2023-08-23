using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using SzakacsAndreea_2023_Licenta.DataLayer;


namespace SzakacsAndreea_2023_Licenta.Pages
{
    /// <summary>
    /// Interaction logic for Pagina_Comenzi.xaml
    /// </summary>
    public partial class Pagina_Comenzi : Page
    {

        DataRepository comandaRepository = null;
        CollectionViewSource detaliiComandaViewSource;
        CollectionViewSource comandaViewSource;
        double total1;
        List<DetaliiComanda> detalii = new List<DetaliiComanda>();
        public List<Comanda> comenzi { get; set; }

        public Pagina_Comenzi()
        {
            InitializeComponent();
        }
        //==============EVENIMENTE===================
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DefaultSettings();
            IncarcareDate();
        }
        private void comandaDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IncarcareDetaliiComanda();
            
        }


        //==================METODE PRIVATE============================

        private void DefaultSettings()
        {
            //setari initiale pentru fereastra curenta
            this.Title = "Comenzi - World Wide Caffe";
            

            //setari initiale pentru DataGrid
            comandaDataGrid.IsReadOnly = true;
            comandaDataGrid.CanUserAddRows = false;
            comandaDataGrid.CanUserDeleteRows = true;
            comandaDataGrid.CanUserResizeColumns = true;
            comandaDataGrid.CanUserReorderColumns = true;

            //se determina obiectul de tip CollectionViewSource 
            detaliiComandaViewSource = (CollectionViewSource)this.FindResource("detaliiComandaViewSource");
            comandaViewSource = (CollectionViewSource)this.FindResource("comandaViewSource");

        }
        private void IncarcareDate()
        {

            //se pregateste un titlu pentru mesajele afisate cu MessageBox
            string caption = "Încărcare Comenzi";

            //se seteaza cursorul de asteptare
            Cursor defaultCursor = this.Cursor;
            Cursor = Cursors.Wait;

            try
            {
                //daca elementul CollectionViewSource este nul, atunci nu se poate continua
                if (comandaViewSource == null) return;

                //se creeaza un nou obiect DataRepository folosind conexiunea setata in clasa statica AppConnection
                comandaRepository = new DataRepository();

                //colectia de obiecte obtinuta din comandaRepository este incarcata in obiectul tip CollectionViewSource (iar acest obiect este sursa pentru DataGrid)
                comandaViewSource.Source = comandaRepository.AfisareComenzi();

                Cursor = defaultCursor;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }

            //se revine la cursorul initial
            Cursor = defaultCursor;

        }
        private void IncarcareDetaliiComanda()
        {
            calcularesuma();
            //se pregateste un titlu pentru mesajele afisate cu MessageBox
            string caption = "Incarcare date";

            //se seteaza cursorul de asteptare
            Cursor defaultCursor = this.Cursor;
            Cursor = Cursors.Wait;

            try
            {
                if (comandaViewSource == null || comandaViewSource.View == null)
                {
                    MessageBox.Show("Mai intai incarcati datele. \n" +
                                     "Operatia nu poate continua.", caption,
                                      MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (comandaViewSource.View.CurrentItem != null)
                {
                    //se determina comanda selectata, se determina ID-ul sau si se afiseaza
                    Comanda selectedComanda = comandaViewSource.View.CurrentItem as Comanda;
                    int idComanda = selectedComanda.IDComanda;
                    

                    //se creeaza un nou Repository si se incarca toate detaliile comenzii
                    comandaRepository = new DataRepository();
                    detaliiComandaViewSource.Source = comandaRepository.AfisareDetaliiComanda(idComanda);
                    
                    total1 = 0;
                    txtTotal.Content = "0";

                    detalii = detaliiComandaDataGrid.Items.OfType<DetaliiComanda>().ToList();

                    foreach (var detail in detalii)
                    {
                        total1 += detail.Suma;
                    }

                    txtTotal.Content =total1.ToString();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            //se revine la cursorul initial
            Cursor = defaultCursor;
        }
        private void calcularesuma()
        {
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                //se deschide conexiuneadacă nu este deja deschisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                //se specifcă numele procedurii stocate
                string query = "spAfisare_Suma";
                
                //se execută procedura stocată utilizându-se metode 'Execute'
                connection.Execute(query, commandType: CommandType.StoredProcedure);

                
            }
        }
    }
}
