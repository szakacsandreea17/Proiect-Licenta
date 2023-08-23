using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Dapper;
using Microsoft.Win32;
using SzakacsAndreea_2023_Licenta.Converters;
using SzakacsAndreea_2023_Licenta.DataLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace SzakacsAndreea_2023_Licenta.Pages
{
    /// <summary>
    /// Interaction logic for Pagina_Produse.xaml
    /// </summary>
    public partial class Pagina_Produse : Page
    {
       
        CollectionViewSource produsViewSource;
        private ObservableCollection<Produs> produse = new ObservableCollection<Produs>();
        private ImageConverter imageConverter = new ImageConverter();

        public Produs Produs { get; set; }
        public Pagina_Produse()
        {
            InitializeComponent();
            produsDataGrid.ItemsSource = produse;
        }


        //==================EVENIMENTE==================
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DefaultSettings();
            IncarcareDate();
        }
        private void btnAdaugaProdus_Click(object sender, RoutedEventArgs e)
        {
            AdaugaProdus();
        }
        private void btnStergeProdus_Click(object sender, RoutedEventArgs e)
        {
            StergereProdus();
        }
        private void btnAnulareProdus_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }
        private void btnEditareProdus_Click(object sender, RoutedEventArgs e)
        {
            EditareProdus();
        }
        private void produsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (produsDataGrid.SelectedItem != null)
            {
                // Obțineți rândul selectat
                Produs selectedRow = (Produs)produsDataGrid.SelectedItem;

                // Încărcați datele rândului selectat în TextBox
                codprodusTextBox.Text = selectedRow.CodProdus;
                denumireprodusTextBox.Text = selectedRow.DenumireProdus;
                codsortimentTextBox.Text = selectedRow.CodSortiment;
                sortimentTextBox.Text = selectedRow.Sortiment;
                cantitateTextBox.Text = selectedRow.Cantitate;
                pretTextBox.Text = selectedRow.Pret;
                descriereTextBox.Text = selectedRow.Descriere;
                if (produsDataGrid.SelectedItem != null)
                {
                    
                    if (selectedRow.Imagine != null && selectedRow.Imagine.Length > 0)
                    {
                        
                        BitmapImage bitmapImage = new BitmapImage();

                        using (MemoryStream memoryStream = new MemoryStream(selectedRow.Imagine))
                        {
                            bitmapImage.BeginInit();
                            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                            bitmapImage.StreamSource = memoryStream;
                            bitmapImage.EndInit();
                        }

                        Imagineprodus.Source = bitmapImage;
                    }
                    else
                    {
                        Imagineprodus.Source = null;
                    }
                }

            }
        }
        private void txtNameToSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nameFilter = txtNameToSearch.Text;
            FilterByName(nameFilter);
        }
        private void buttonLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            IncarcareImagine();
        }


        //====================METODE PRIVATE=======================

        private void DefaultSettings()
        {
            //setari initiale pentru fereastra curenta
            this.Title = "Produse - World Wide Caffe";

            //setari initiale pentru DataGrid
            produsDataGrid.IsReadOnly = false;
            produsDataGrid.CanUserAddRows = true;
            produsDataGrid.CanUserDeleteRows = true;
            produsDataGrid.CanUserResizeColumns = true;
            produsDataGrid.CanUserReorderColumns = true;

            //se determina obiectul de tip CollectionViewSource 
            produsViewSource = (CollectionViewSource)this.FindResource("produsViewSource");
        }
        private void IncarcareDate()
        {
            //se realizeaza conexiunea cu baza de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {    //se deschide conexiuneadacă nu este deja deschisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                //se folosește instrucțiune SQL pentru a selecta coloanele din tabela "Produse"
                string query = "SELECT CodProdus,CodSortiment,Sortiment,DenumireProdus,Cantitate,Pret,Descriere,Imagine FROM Produse";
                //se realizează interogarea asupra bazei de date
                IEnumerable<Produs> data = connection.Query<Produs>(query);

                //afisarea datelor in DataGrid
                produsDataGrid.ItemsSource = data;
            }

        }
        private void ClearData()
        {
            codprodusTextBox.Clear();
            denumireprodusTextBox.Clear();
            codsortimentTextBox.Clear();
            sortimentTextBox.Text="";
            cantitateTextBox.Clear();
            pretTextBox.Clear();
            descriereTextBox.Clear();
            Imagineprodus.Source=null;
        }
        private void StergereProdus()
        {
            string caption = "Stergere date";
            if (produsDataGrid.SelectedItem != null)
            {
                // Obțineți rândul selectat din DataGrid
                Produs selectedItem = (Produs)produsDataGrid.SelectedItem;

                string question = $"Doriti stergere produsului " +
                                      $"{selectedItem.DenumireProdus}\n" +
                                      $"avand codul={selectedItem.CodProdus}?";
                var response = MessageBox.Show(question, caption, MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (response == MessageBoxResult.OK)
                {
                    // Efectuați operația de ștergere în baza de date utilizând Dapper
                    using (IDbConnection connection = AppConnection.GetDbConnection())
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();

                        string query = "DELETE FROM Produse WHERE CodProdus = @CodProdus";
                        connection.Execute(query, new { CodProdus = selectedItem.CodProdus });
                    }
                    ClearData();
                    IncarcareDate();
                    //Utilizatorul este anuntat ca modificarile au fost salvate
                    string information = "Modificarile au fost salvate in baza de date";
                    MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
        }
        private void EditareProdus()
        {
            string caption = "Editare date";
            // Obțineți rândul selectat din DataGrid
            Produs selectedItem = (Produs)produsDataGrid.SelectedItem;

            selectedItem.DenumireProdus = denumireprodusTextBox.Text;
            selectedItem.CodSortiment = codsortimentTextBox.Text;
            selectedItem.Sortiment = sortimentTextBox.Text;
            selectedItem.Cantitate = cantitateTextBox.Text;
            selectedItem.Pret = pretTextBox.Text;
            selectedItem.Descriere = descriereTextBox.Text;

            if (Imagineprodus.Source is BitmapImage bitmapImage)
            {
                
                byte[] imageData;
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    encoder.Save(memoryStream);
                    imageData = memoryStream.ToArray();
                }
                selectedItem.Imagine = imageData;
            }

            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                string query = "UPDATE Produse SET CodSortiment=@CodSortiment,Sortiment=@Sortiment,DenumireProdus =@DenumireProdus,Cantitate=@Cantitate,Pret=@Pret,Descriere=@Descriere,Imagine=@Imagine WHERE CodProdus = @CodProdus";
                connection.Execute(query, selectedItem);
            }
            produsDataGrid.Items.Refresh();

            //Utilizatorul este anuntat ca modificarile au fost salvate
            string information = "Modificarile au fost salvate in baza de date";
            MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void AdaugaProdus()
        {
            string caption = "Adaugare date";
            byte[] imageBytes = ConvertBitmapImageToByteArray(Imagineprodus.Source as BitmapImage);

            Produs newItem = new Produs()
            {
                CodProdus = codprodusTextBox.Text,
                DenumireProdus = denumireprodusTextBox.Text,
                CodSortiment = codsortimentTextBox.Text,
                Sortiment = sortimentTextBox.Text,
                Cantitate = cantitateTextBox.Text,
                Pret = pretTextBox.Text,
                Descriere = descriereTextBox.Text,
                Imagine = imageBytes

            };
           

                using (IDbConnection connection = AppConnection.GetDbConnection())
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();


                    string query = "INSERT INTO Produse VALUES (@CodProdus,@CodSortiment,@Sortiment, @DenumireProdus,@Cantitate,@Pret,@Descriere,@Imagine)";
                    connection.Execute(query, newItem);

                }
            

            IncarcareDate();
            ClearData();

            //Utilizatorul este anuntat ca modificarile au fost salvate
            string information = "Modificarile au fost salvate in baza de date";
            MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void FilterByName(string name)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(produsDataGrid.ItemsSource);
            view.Filter = item =>
            {
                var person = item as Produs;
                return person.DenumireProdus.Contains(name);
            };
        }
        private void IncarcareImagine()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
                bitmapImage.EndInit();


                Imagineprodus.Source = bitmapImage;
            }
        }
        private byte[] ConvertBitmapImageToByteArray(BitmapImage bitmapImage)
        {
            if (bitmapImage == null)
                return null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                BitmapEncoder encoder = new PngBitmapEncoder(); 
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(memoryStream);

                return memoryStream.ToArray();
            }
        }

      
    }
}
