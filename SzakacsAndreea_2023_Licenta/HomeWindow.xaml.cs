using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using SzakacsAndreea_2023_Licenta.DataLayer;
using SzakacsAndreea_2023_Licenta.Pages;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Windows.Interop;
using System.Windows.Forms;

namespace SzakacsAndreea_2023_Licenta
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    /// 
   
    public partial class HomeWindow : Window
    {
        private readonly string _userRole;

        public HomeWindow(string userRole)
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            _userRole = userRole;
           // HideButtonsBasedOnRole();
        }



        //===================EVENIMENTE==================
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            workspace.Content = new Pagina_Principala();
        }
        private void btnPaginaPrincipala_Click(object sender, RoutedEventArgs e)
        {
            workspace.Content = new Pagina_Principala();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;

            }
            else this.WindowState = WindowState.Normal;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void buttonClienti_Click(object sender, RoutedEventArgs e)
        {
            workspace.Content = new Pagina_Clienti();
        }
        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {

            workspace.Content = new Pagina_Comenzi();

        }
        private void btnDitribuitori_Click(object sender, RoutedEventArgs e)
        {
            workspace.Content = new Pagina_Distribuitori();
        }
        private void btnDeconectare_Click(object sender, RoutedEventArgs e)
        {
            MainWindow autentificare = new MainWindow();
            autentificare.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            autentificare.Show();
            this.Close();
        }
        private void btnProducatori_Click(object sender, RoutedEventArgs e)
        {
            workspace.Content = new Pagina_Producatori();
        }
        private void btnProduse_Click(object sender, RoutedEventArgs e)
        {
            workspace.Content = new Pagina_Produse();
        }

        private void btnSortimente_Click(object sender, RoutedEventArgs e)
        {
            workspace.Content = new Pagina_Sortimente();
        }


        //=====================METODE PRIVATE===============
        /*private void HideButtonsBasedOnRole()
        {
            // Hide buttons based on user role
            if (_userRole != "Admin")
            {
                da.Visibility = Visibility.Collapsed;
            }
        }*/


    }
}
