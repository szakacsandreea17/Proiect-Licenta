using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SzakacsAndreea_2023_Licenta.DataLayer;
using System.ComponentModel;
using Dapper;
using System.Collections.ObjectModel;

namespace SzakacsAndreea_2023_Licenta.Pages
{
    /// <summary>
    /// Interaction logic for Pagina_Producatori.xaml
    /// </summary>
    public partial class Pagina_Producatori : Page
    {

       

        List<Producator[]> producator= new List<Producator[]>();
        ObservableCollection<Producator> producatori = new ObservableCollection<Producator>();

        public Pagina_Producatori()
        {
            InitializeComponent();
            producatorDataGrid.ItemsSource = producatori;
        }

      //==============EVENIMENTE=================
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DefaultSettings();
            LoadData();
        }
        private void btnAdaugaProducator_Click(object sender, RoutedEventArgs e)
        {
            AdaugaProducator();
        }
        private void btnStergereDate_Click(object sender, RoutedEventArgs e)
        {
            DeleteData();
        }
        private void btnEditeazaProducator_Click(object sender, RoutedEventArgs e)
        {
           EditeazaProducator();
        }
        private void btnAnulareDate_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }
        private void txtCautaProducator_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nameFilter = txtCautaProducator.Text;
            FilterByName(nameFilter);
        }
        private void producatorDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (producatorDataGrid.SelectedItem != null)
            {
                // Obțineți rândul selectat
                Producator selectedRow = (Producator)producatorDataGrid.SelectedItem;

                // Încărcați datele rândului selectat în TextBox
                codproducatorTextBox.Text = selectedRow.CodProducator;// Exemplu: CodFurnizor este o proprietate a modelului
                producatorTextBox.Text = selectedRow.Nume;
                persoanacontactTextBox.Text = selectedRow.PersoanaContact;
                telefonTextBox.Text = selectedRow.Telefon;
                taraTextBox.Text = selectedRow.Tara;
                orasTextBox.Text = selectedRow.Oras;
                adresaTextBox.Text = selectedRow.Adresa;
            }
        }



        //=================METODE PRIVATE===============
        private void DefaultSettings()
        {
            //setari initiale pentru fereastra curenta
            this.Title = "Producatori - World Wide Caffe";


            //setari initiale pentru DataGrid
            producatorDataGrid.IsReadOnly = false;
            producatorDataGrid.CanUserAddRows = true;
            producatorDataGrid.CanUserDeleteRows = true;
            producatorDataGrid.CanUserResizeColumns = true;
            producatorDataGrid.CanUserReorderColumns = true;

            
        }
        private void LoadData()
        {  
            //se realizeaza conexiunea cu baza de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {   
                //se deschide conexiuneadacă nu este deja deschisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                //se folosește instrucțiune SQL pentru a selecta coloanele din tabela "Producatori"
                string query = "SELECT CodProducator, Nume,PersoanaContact,Adresa,Oras,Tara,Telefon FROM Producatori";
                //se realizează interogarea asupra bazei de date
                IEnumerable<Producator> data = connection.Query<Producator>(query);

                //afisarea datelor in DataGrid
                producatorDataGrid.ItemsSource = data;

            }
        }
        private void DeleteData()
        {
            string caption = "Stergere date";
            if (producatorDataGrid.SelectedItem != null)
            {
                // Obțineți rândul selectat din DataGrid
               Producator selectedItem = (Producator)producatorDataGrid.SelectedItem;

                string question = $"Doriti stergere producatorului " +
                                      $"{selectedItem.Nume}\n" +
                                      $"avand codul={selectedItem.CodProducator}?";
                var response = MessageBox.Show(question, caption, MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (response == MessageBoxResult.OK)
                {
                    
                    using (IDbConnection connection = AppConnection.GetDbConnection())
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();

                        string query = "DELETE FROM Producatori WHERE CodProducator = @Codproducator";
                        connection.Execute(query, new { CodProducator= selectedItem.CodProducator });
                    }
                    ClearData();
                    LoadData();
                    //Utilizatorul este anuntat ca modificarile au fost salvate
                    string information = "Modificarile au fost salvate in baza de date";
                    MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
        }
        private void ClearData()
        {
            codproducatorTextBox.Clear();
            producatorTextBox.Clear();
            persoanacontactTextBox.Clear();
            telefonTextBox.Clear();
            taraTextBox.Clear();
            orasTextBox.Clear();
            adresaTextBox.Clear();
         }
        private void AdaugaProducator()
        {
            string caption = "Adaugare date";
            //se creează un nou obiect 'Producator'
            Producator newItem = new Producator()
            {   
                //obiectul nou creat se inițializează cu valorile preluate din câmpurile de introducere ale interfeței utilizatorului
                CodProducator = codproducatorTextBox.Text,
                Nume = producatorTextBox.Text,
                PersoanaContact = persoanacontactTextBox.Text,
                Telefon = telefonTextBox.Text,
                Tara= taraTextBox.Text,
                Oras = orasTextBox.Text,
                Adresa = adresaTextBox.Text
                
            };

            //se obține o conexiune la baza de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                //se verifică și se deschide conexiunea în cazul în care aceasta este închisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                //se specifică interogarea de inserare
                string query = "INSERT INTO Producatori VALUES (@CodProducator, @Nume,@PersoanaContact,@Adresa,@Oras,@Tara,@Telefon)";
                
                //se execută interogarea
                connection.Execute(query, newItem);
            }

            //se incarcă datele actualizate
            LoadData();

            //se sterg valorile din câmpurile de introducere
            ClearData();

            //Utilizatorul este anuntat ca modificarile au fost salvate
            string information = "Modificarile au fost salvate in baza de date";
            MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void EditeazaProducator()
        {
            string caption = "Editare date";
            // Obțineți rândul selectat din DataGrid
            Producator selectedItem = (Producator)producatorDataGrid.SelectedItem;

            //se actualizează proprietățile obiectului "selectedItem" cu valorile preluate din câmpurile de introducere
            selectedItem.Nume = producatorTextBox.Text;
            selectedItem.PersoanaContact = persoanacontactTextBox.Text;
            selectedItem.Telefon = telefonTextBox.Text;
            selectedItem.Tara = taraTextBox.Text;
            selectedItem.Oras = orasTextBox.Text;
            selectedItem.Adresa = adresaTextBox.Text;
            
            //se obține o conexiune la sursa de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                //se verifică să fie deschisă conexiunea în cazul în care aceasta este închisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                //se specifică interogarea de actualizare
                string query = "UPDATE Producatori SET Nume =@Nume,PersoanaContact=@PersoanaContact,Adresa=@Adresa,Oras=@Oras,Tara=@Tara,Telefon=@Telefon WHERE CodProducator = @CodProducator";
               
                //se execută interogarea
                connection.Execute(query, selectedItem);
            }

            //se actualizează conținutul DataGrid-ului
            producatorDataGrid.Items.Refresh();

            //Utilizatorul este anuntat ca modificarile au fost salvate
            string information = "Modificarile au fost salvate in baza de date";
            MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void FilterByName(string name)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(producatorDataGrid.ItemsSource);
            view.Filter = item =>
            {
                var f = item as Producator;
                return f.Nume.Contains(name);
            };
        }

       
        
    }
}
