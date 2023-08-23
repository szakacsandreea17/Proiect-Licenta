using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
    /// Interaction logic for Pagina_Distribuitori.xaml
    /// </summary>
    public partial class Pagina_Distribuitori : Page
    {

        //ObservableCollection<Distribuitor> distribuitori = new ObservableCollection<Distribuitor>();
       
        
        public Pagina_Distribuitori()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DefaultSettings();
            LoadData();
         
        }

        //------------------------------EVENIMENTE---------------------
        private void btnAdaugaDistribuitor_Click(object sender, RoutedEventArgs e)
        {
            AdaugaDistribuitor();
        }
        private void btnEditeazaDistribuitor_Click(object sender, RoutedEventArgs e)
        {
            EditeazaDistribuitor();
        }
        private void btnStergereDistribuitor_Click(object sender, RoutedEventArgs e)
        {
            StergereDistribuitor();
        }
        private void btnAnulareDistribuitor_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }
        private void txtCautaDistribuitor_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nameFilter = txtCautaDistribuitor.Text;
            FilterByName(nameFilter);
        }
        private void distribuitorDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (distribuitorDataGrid.SelectedItem != null)
            {
                // Obțineți rândul selectat
                Distribuitor selectedRow = (Distribuitor)distribuitorDataGrid.SelectedItem;

                // Încărcați datele rândului selectat în TextBox
                coddistribuitorTextBox.Text = selectedRow.CodDistribuitor;
                distribuitorTextBox.Text = selectedRow.NumeDistribuitor;
                codfiscalTextBox.Text = selectedRow.CodFiscal;
                telefonTextBox.Text = selectedRow.Telefon;
                persoanaComboBox.Text = selectedRow.Persoana;
                sediuTextBox.Text = selectedRow.Sediu;
                judetComboBox.Text = selectedRow.Judet;
                emailTextBox.Text = selectedRow.Email;
                obsDistribuitorTextBox.Text = selectedRow.ObsDistribuitor;
                nrAutoTextBox.Text = selectedRow.NrAuto;

            }
        }


        //------------------METODE PRIVATE----------
        private void DefaultSettings()
        {
            //setari initiale pentru pagina curenta
            this.Title = "Distribuitori - World Wide Caffe";
            
            //setari initiale pentru DataGrid
            distribuitorDataGrid.IsReadOnly = true;
            distribuitorDataGrid.CanUserAddRows = false;
            distribuitorDataGrid.CanUserDeleteRows = true;
            distribuitorDataGrid.CanUserResizeColumns = true;
            distribuitorDataGrid.CanUserReorderColumns = true;

        }
        private void ClearData()
        {
            coddistribuitorTextBox.Clear();
            distribuitorTextBox.Clear();
            codfiscalTextBox.Clear();
            telefonTextBox.Clear();
            persoanaComboBox.Text = "";
            sediuTextBox.Clear();
            judetComboBox.Text = "";
            emailTextBox.Clear();
            obsDistribuitorTextBox.Clear();
            nrAutoTextBox.Clear();
        }
        private void LoadData()
        {
            //se realizeaza conexiunea cu baza de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                //se deschide conexiuneadacă nu este deja deschisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                //se folosește instrucțiune SQL pentru a selecta coloanele din tabela "Distribuitori"
                string query = "SELECT CodDistribuitor,NumeDistribuitor,CodFiscal,Telefon,Persoana,Sediu,Judet,Email,ObsDistribuitor,NrAuto FROM Distribuitori";
                //se realizează interogarea asupra bazei de date
                IEnumerable<Distribuitor> data = connection.Query<Distribuitor>(query);

                //afisarea datelor in DataGrid
                distribuitorDataGrid.ItemsSource = data;
            }
        }
        private void AdaugaDistribuitor()
        {
            string caption = "Adaugare date";
            Distribuitor newItem = new Distribuitor()
            {
                CodDistribuitor = coddistribuitorTextBox.Text,
                NumeDistribuitor = distribuitorTextBox.Text,
                CodFiscal = codfiscalTextBox.Text,
                Telefon = telefonTextBox.Text,
                Persoana = persoanaComboBox.Text,
                Sediu = sediuTextBox.Text,
                Judet = judetComboBox.Text,
                Email = emailTextBox.Text,
                ObsDistribuitor = obsDistribuitorTextBox.Text,
                NrAuto = nrAutoTextBox.Text
            };
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                string query = "INSERT INTO Distribuitori VALUES (@CodDistribuitor, @NumeDistribuitor,@CodFiscal," +
                    "@Telefon,@Persoana,@Sediu,@Judet,@Email,@ObsDistribuitor,@NrAuto)";
                connection.Execute(query, newItem);

                //utilizatorul este anuntat ca modificarile au fost salvate
                MessageBox.Show("Modificarile au fost salvate in baza de date", caption,
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            LoadData();
            ClearData();
        }
        private void EditeazaDistribuitor()
        {
            string caption = "Editare date";
            // Obțineți rândul selectat din DataGrid
            Distribuitor selectedItem = (Distribuitor)distribuitorDataGrid.SelectedItem;

            selectedItem.NumeDistribuitor = distribuitorTextBox.Text;
            selectedItem.CodFiscal = codfiscalTextBox.Text;
            selectedItem.Telefon = telefonTextBox.Text;
            selectedItem.Persoana = persoanaComboBox.Text;
            selectedItem.Sediu = sediuTextBox.Text;
            selectedItem.Judet = judetComboBox.Text;
            selectedItem.Email = emailTextBox.Text;
            selectedItem.ObsDistribuitor = obsDistribuitorTextBox.Text;
            selectedItem.NrAuto = nrAutoTextBox.Text;

            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                string query = "UPDATE Distribuitori SET NumeDistribuitor =@NumeDistribuitor,CodFiscal=@CodFiscal,Telefon=@Telefon,Persoana=@Persoana,Sediu=@Sediu,Judet=@Judet,Email=@Email,ObsDistribuitor=@ObsDistribuitor,NrAuto=@NrAuto WHERE CodDistribuitor = @CodDistribuitor";
                connection.Execute(query, selectedItem);
            }
            distribuitorDataGrid.Items.Refresh();
            //utilizatorul este anuntat ca modificarile au fost salvate
            MessageBox.Show("Modificarile au fost salvate in baza de date", caption,
                            MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void StergereDistribuitor()
        {
            string caption = "Stergere date";
            if (distribuitorDataGrid.SelectedItem != null)
            {
                // Obțineți rândul selectat din DataGrid
                Distribuitor selectedItem = (Distribuitor)distribuitorDataGrid.SelectedItem;

                string question = $"Doriti stergere furnizorului " +
                                      $"{selectedItem.NumeDistribuitor}\n" +
                                      $"avand codul={selectedItem.CodDistribuitor}?";
                var response = MessageBox.Show(question, caption, MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (response == MessageBoxResult.OK)
                {
                    // Efectuați operația de ștergere în baza de date utilizând Dapper
                    using (IDbConnection connection = AppConnection.GetDbConnection())
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();
                        string query = "DELETE FROM Distribuitori WHERE CodDistribuitor = @CodDistribuitor";
                        connection.Execute(query, new { CodDistribuitor = selectedItem.CodDistribuitor });
                    }

                    ClearData();
                    LoadData();

                    //Utilizatorul este anuntat ca modificarile au fost salvate
                    string information = "Modificarile au fost salvate in baza de date";
                    MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
        private void FilterByName(string name)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(distribuitorDataGrid.ItemsSource);
            view.Filter = item =>
            {
                var f = item as Distribuitor;
                return f.NumeDistribuitor.Contains(name);
            };
        } 
    }
}
