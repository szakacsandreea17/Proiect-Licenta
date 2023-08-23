using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SzakacsAndreea_2023_Licenta.Pages
{
    /// <summary>
    /// Interaction logic for Pagina_Clienti.xaml
    /// </summary>
    /// 

    public partial class Pagina_Clienti : Page
    {

        DataRepository clientRepository = new DataRepository();
        CollectionViewSource clientViewSource;
        //List<Client> clienti = new List<Client> { };

        public Client Client { get; set; }


        public Pagina_Clienti()
        {
            InitializeComponent();
            
           
        }

        //==============EVENIMENTE==========================
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DefaultSettings();
            
        }
      
        private void buttonEditData_Click(object sender, RoutedEventArgs e)
        {
           EditData();
        }

        private void buttonAddData_Click(object sender, RoutedEventArgs e)
        {
            AddNewData();
        }

        private void buttonDeleteData_Click(object sender, RoutedEventArgs e)
        {
            DeleteData();
        }
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchBox.Text == null)
            {
                clientDataGrid.Items.Filter = null;
            }
            else
            {
                clientDataGrid.Items.Filter =GetFilter();
            }
        }
        private void clientiComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (clientDataGrid != null)
            {
               clientDataGrid.Items.Filter  = GetFilter();
            }

        }


        //====================METODE PRIVATE==============

        private void DefaultSettings()
        {
            //setari initiale pentru fereastra curenta
            this.Title = "Clienti - World Wide Caffe";

            //setari initiale pentru DataGrid
            clientDataGrid.IsReadOnly = false;
            clientDataGrid.CanUserAddRows = true;
            clientDataGrid.CanUserDeleteRows = true;
            clientDataGrid.CanUserResizeColumns = true;
            clientDataGrid.CanUserReorderColumns = true;

            //se determina obiectul de tip CollectionViewSource 
            clientViewSource = (CollectionViewSource)this.FindResource("clientViewSource");

            //incarcarea datelor in DataGrid
            LoadData();

        }
        private void LoadData()
        {

            //se pregateste un titlu pentru mesajele afisate cu MessageBox
            string caption = "Încărcare Clienti";

            //se seteaza cursorul de asteptare
            Cursor defaultCursor = this.Cursor;
            Cursor = Cursors.Wait;

            try
            {
                //daca elementul CollectionViewSource este nul, atunci nu se poate continua
                if (clientViewSource == null) return;

                //se creeaza un nou obiect DataRepository folosind
                //conexiunea setata in clasa statica AppConnection
                clientRepository = new DataRepository();

                //colectia de obiecte obtinuta din DataRepository este incarcata in 
                //obiectul tip CollectionViewSource (iar acest obiect este sursa pentru DataGrid)
                clientViewSource.Source = clientRepository.AfisareClienti();

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
        private void DeleteData()
        {

            //se pregateste un titlu pentru mesajele afisate cu MessageBox
            string caption = "Stergere date";

            try
            {
                //daca nu exista date incarcate in DataGrid, operatia nu poate continua
                if (clientViewSource == null || clientViewSource.View == null)
                {
                    MessageBox.Show("Mai intai incarcati datele.\n" +
                                      "Operatia nu poate continua.", caption,
                                      MessageBoxButton.OK, MessageBoxImage.Warning);
                    return; //operatia nu poate continua
                }

                if (clientViewSource.View.CurrentItem != null)
                {
                    //se determina elementul curent selectat
                    Client selectedClient = clientViewSource.View.CurrentItem as Client;

                    //se cere o confirmare pentru stergere
                    string question = $"Doriti stergere clientului" +
                                      $"{selectedClient.Nume}\n" +
                                      $"avand ID={selectedClient.CodClient}?";
                    var response = MessageBox.Show(question, caption, MessageBoxButton.OKCancel, MessageBoxImage.Question);
                    //se verifica daca dilogul a fost finalizat cu OK
                    if (response == MessageBoxResult.OK)
                    {
                        //daca utilizatorul a confirmat operatia, atunci
                        //modificarile sunt transmise in baza de date
                        clientRepository = new DataRepository();
                        clientRepository.StergereClient(selectedClient);

                        //se actualizeaza datele afisate in fereastra
                        LoadData();

                        //Utilizatorul este anuntat ca modificarile au fost salvate
                        string information = "Modificarile au fost salvate in baza de date";
                        MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
           catch(Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
               
        }
        private void EditData()
        {
            //se pregateste un titlu pentru mesajele afisate cu MessageBox
            string caption = "Actualizare date";

            try
            {
                //verificari initiale
                if (clientViewSource == null || clientViewSource.View == null)
                {
                    MessageBox.Show("Mai intai incarcati datele. \n" +
                                     "Operatia nu poate continua.", caption,
                                     MessageBoxButton.OK, MessageBoxImage.Warning);
                    return; //operatia nu poate continua
                }

                //daca nu exista un rand selectat, operatia nu poate continua
                if (clientViewSource.View.CurrentItem != null)
                {
                    //se determina elementul curent selectat
                    Client selectedClient = clientViewSource.View.CurrentItem as Client;

                    //se pregateste pentru editare un nou obiect din clasa Client
                    Client client = new Client();

                    //se preiau toate proprietatile elementului selectat intr-un nou obiect
                    client.CodClient = selectedClient.CodClient;
                    client.Nume = selectedClient.Nume ;
                    client.PersoanaContact = selectedClient.PersoanaContact;
                    client.Telefon = selectedClient.Telefon;
                    client.Adresa = selectedClient.Adresa ;
                    client.Oras = selectedClient.Oras ;
                    client.Judet= selectedClient.Judet ;

                    //se deschide o fereastra specializata pentru editarea proprietatilor obiectului
                    Detalii_Client win = new Detalii_Client(client);
                    win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    bool? result = win.ShowDialog();

                    //se verifica daca dialogul a fost finalizat cu OK
                    if (result == true)
                    {
                        //se preia obiectul editat de utilizator in fereastra cu detalii
                        Client modifiedClient = win.Client;


                        //se preiau proprietatile setate
                        selectedClient.Nume = modifiedClient.Nume;
                        selectedClient.PersoanaContact = modifiedClient.PersoanaContact;
                        selectedClient.Telefon = modifiedClient.Telefon;
                        selectedClient.Adresa= modifiedClient.Adresa;
                        selectedClient.Oras = modifiedClient.Oras;
                        selectedClient.Judet = modifiedClient.Judet;

                        //se salveaza modificarile in baza de date
                        clientRepository = new DataRepository();
                        clientRepository.EditareClient(selectedClient);

                        //se actualizeaza datele afisate in fereastra
                        LoadData();

                        //utilizatorul este anuntat ca modificarile au fost salvate
                        MessageBox.Show("Modificarile au fost salvate in baza de date", caption,
                                        MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, caption,
                                 MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void AddNewData()
        {
            //se pregateste un titlu pentru mesajele afisate cu MessageBox
            string caption = "Adaugarea date";

            try
            {
                //verificari initiale
                if (clientViewSource == null || clientViewSource.View == null)
                {
                    MessageBox.Show("Mai intai incarcati datele. \n" +
                                     "Operatia nu poate continua.", caption,
                                     MessageBoxButton.OK, MessageBoxImage.Warning);
                    return; //operatia nu poate continua
                }

                //se pregateste un nou obiect
                Client client = new Client();

                //se deschide o fereastra specializata pentru editarea proprietatilor obiectului
                Detalii_Client win = new Detalii_Client(client);
                win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                bool? result = win.ShowDialog();

                //se verifica daca dialogul a fost finalizat cu OK
                if (result == true)
                {
                    Client customerToInsert = win.Client;
                    clientRepository = new DataRepository();
                    clientRepository.AdaugareClient(customerToInsert);

                    //se actualizeaza datele afișate in fereastra
                    LoadData();

                    //utilizatorul este anuntat ca modificarile au fost salvate
                    MessageBox.Show("Modificarile au fost salvate in baza de date", caption,
                                       MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public Predicate<object> GetFilter()
        {
            //se extrage elementul selectat din ComboBox
            var select = clientiComboBox.SelectedItem as ComboBoxItem;
         
            //se verifică conținutul elementului selectat sub forma unui șir de caractere
            switch (select.Content as string)
            {
                case "Nume":
                    return NameFilter;

                case "Judet":
                    return JudetFilter;

            }
            return NameFilter;
        }
        private bool NameFilter(object obj)
        {
                var Filterobj = obj as Client;
                return Filterobj.Nume.Contains(SearchBox.Text);
        }
        private bool JudetFilter(object obj)
        {
            var Filterobj = obj as Client;
            return Filterobj.Judet.Contains(SearchBox.Text);
        }

    }
}
