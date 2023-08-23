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

namespace SzakacsAndreea_2023_Licenta.Pages
{
    /// <summary>
    /// Interaction logic for Pagina_Sortimente.xaml
    /// </summary>
    public partial class Pagina_Sortimente : Page
    {
        ObservableCollection<Sortimente> sortimente = new ObservableCollection<Sortimente>();
        public Pagina_Sortimente()
        {
            InitializeComponent();
        }
        //===============EVENIMENTE=================

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DefaultSettings();
            LoadData();
        }
        private void btnAdaugaSortiment_Click(object sender, RoutedEventArgs e)
        {
            AdaugaSortiment();
        }

        private void btnEditeazaSortiment_Click(object sender, RoutedEventArgs e)
        {
            EditeazaSortiment();
        }

        private void btnStergereSortiment_Click(object sender, RoutedEventArgs e)
        {
            StergereSortiment();
        }
        private void btnAnulareSortiment_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }

        private void txtCautaOrigine_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nameFilter = txtCautaOrigine.Text;
            FilterByName(nameFilter);
        }

        private void sortimenteDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (sortimenteDataGrid.SelectedItem != null)
            {
                // Obțineți rândul selectat
                Sortimente selectedRow = (Sortimente)sortimenteDataGrid.SelectedItem;

                // Încărcați datele rândului selectat în TextBox
                codsortimentTextBox.Text = selectedRow.CodSortiment.ToString();
                sortimentTextBox.Text = selectedRow.Sortiment;
                codproducatorTextBox.Text = selectedRow.CodProducator;
                origineTextBox.Text = selectedRow.Origine;


            }
        }


        //=============METODE PRIVATE===================

        private void DefaultSettings()
        {    //setari initiale pentru fereastra curenta
            this.Title = "Sortimente - World Wide Caffe";

            //setari initiale pentru DataGrid
            sortimenteDataGrid.IsReadOnly = false;
            sortimenteDataGrid.CanUserAddRows = true;
            sortimenteDataGrid.CanUserDeleteRows = true;
            sortimenteDataGrid.CanUserResizeColumns = true;
            sortimenteDataGrid.CanUserReorderColumns = true;
        }
        private void LoadData()
        {
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();


                string query = "SELECT CodSortiment,Sortiment,CodProducator, Origine FROM Sortimente";
                IEnumerable<Sortimente> data = connection.Query<Sortimente>(query);

                // Set the ItemsSource of the DataGrid to the retrieved data
               sortimenteDataGrid.ItemsSource = data;
            }


        }
        private void ClearData()
        {
            codsortimentTextBox.Clear();
            sortimentTextBox.Clear();
            codproducatorTextBox.Clear();
            origineTextBox.Clear();
      
        }
        private void StergereSortiment()
        {
            string caption = "Stergere date";
            if (sortimenteDataGrid.SelectedItem != null)
            {
                // Obțineți rândul selectat din DataGrid
                Sortimente selectedItem = (Sortimente)sortimenteDataGrid.SelectedItem;

                string question = $"Doriti stergere sortimentului " +
                                      $"{selectedItem.Sortiment}\n" +
                                      $"avand codul={selectedItem.CodSortiment}?";
                var response = MessageBox.Show(question, caption, MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (response == MessageBoxResult.OK)
                {
                    // Efectuați operația de ștergere în baza de date utilizând Dapper
                    using (IDbConnection connection = AppConnection.GetDbConnection())
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();

                        string query = "DELETE FROM Sortimente WHERE CodSortiment = @CodSortiment";
                        connection.Execute(query, new { CodSortiment = selectedItem.CodSortiment });
                    }
                    ClearData();
                    LoadData();
                    //Utilizatorul este anuntat ca modificarile au fost salvate
                    string information = "Modificarile au fost salvate in baza de date";
                    MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }



        }
        private void EditeazaSortiment()
        {
            string caption = "Editare date";
            // Obțineți rândul selectat din DataGrid
            Sortimente selectedItem = (Sortimente)sortimenteDataGrid.SelectedItem;

            //selectedItem.CodFurnizor = codfurnizorTextBox.Text;
            selectedItem.Sortiment = sortimentTextBox.Text;
            selectedItem.CodProducator = codproducatorTextBox.Text;
            selectedItem.Origine = origineTextBox.Text;
          
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                string query = "UPDATE Sortimente SET Sortiment =@Sortiment,CodProducator=@CodProducator,Origine=@Origine WHERE CodSortiment = @CodSortiment";
                connection.Execute(query, selectedItem);
            }
            sortimenteDataGrid.Items.Refresh();

            //Utilizatorul este anuntat ca modificarile au fost salvate
            string information = "Modificarile au fost salvate in baza de date";
            MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void AdaugaSortiment()
        {
            string caption = "Adaugare date";
            Sortimente newItem = new Sortimente()
            {
                CodSortiment =codsortimentTextBox.Text,
                Sortiment = sortimentTextBox.Text,
                CodProducator = codproducatorTextBox.Text,
                Origine = origineTextBox.Text
               
            };
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                string query = "INSERT INTO Sortimente VALUES (@CodSortiment, @Sortiment,@CodProducator,@Origine)";
                connection.Execute(query, newItem);
            }

            LoadData();
            ClearData();

            //Utilizatorul este anuntat ca modificarile au fost salvate
            string information = "Modificarile au fost salvate in baza de date";
            MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void FilterByName(string name)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(sortimenteDataGrid.ItemsSource);
            view.Filter = item =>
            {
                var f = item as Sortimente;
                return f.Origine.Contains(name);
            };
        }


    }
}
