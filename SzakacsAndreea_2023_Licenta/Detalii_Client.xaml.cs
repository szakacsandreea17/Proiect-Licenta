using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using SzakacsAndreea_2023_Licenta.DataLayer;

namespace SzakacsAndreea_2023_Licenta
{
    /// <summary>
    /// Interaction logic for Detalii_Client.xaml
    /// </summary>
    public partial class Detalii_Client : Window
    {
        public Client Client { get; set; }


        //----------------CONSTRUCTORI----------------
        public Detalii_Client()
        {
            InitializeComponent();
        }

        public Detalii_Client(Client client)
        {
            InitializeComponent();
            this.Client= client;
        }

        //===============EVENIMENTE=====================

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult= false;
            this.Client = null;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //setari initiale
            codclientTextBox.IsReadOnly = false;
            codclientTextBox.Background=System.Windows.Media.Brushes.WhiteSmoke;

            //obiectul din clasa Client trebuie incarcat in contextul de date
            //pentru a putea fi legat la controalele din fereastra
            this.DataContext = this.Client;
        }
    }
}
