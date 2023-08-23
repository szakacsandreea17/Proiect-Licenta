using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SzakacsAndreea_2023_Licenta.DataLayer;
using SzakacsAndreea_2023_Licenta.Pages;

namespace SzakacsAndreea_2023_Licenta
{
    
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
           
        }

        //============EVENIMENTE====================
        private void buttonConectare_Click(object sender, RoutedEventArgs e)
        {
            Conectare();
            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        //================METODE PRIVATE=============

        private void Conectare()
        {
            string username = Utilizator.Text;
            string password = Parola.Password;

            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                
                Logare user = connection.QueryFirstOrDefault<Logare>
                    ("SELECT * FROM Autentificare WHERE Utilizator = @Utilizator AND Parola = @Parola AND Status = @Status",
                    new { Utilizator = username, Parola = password, Status = "Admin" });

                if (user != null)
                {
                    string role = user.Status;
                    OpenMainWindow(role);
                }
                else
                {       user = connection.QueryFirstOrDefault<Logare>
                        ("SELECT * FROM Autentificare WHERE Utilizator = @Utilizator AND Parola = @Parola AND Status = @Status",
                        new { Utilizator = username, Parola = password, Status= "User" });

                    if (user != null)
                    {
                        string role = user.Status;
                        OpenMainWindow(role);
                    }
                    else
                    {
                       
                        MessageBox.Show("Date invalide!");
                    }
                }
            }
        }
        private void OpenMainWindow(string role)
        {
            HomeWindow homeWindow = new HomeWindow(role);
            homeWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            homeWindow.Show();
            this.Close();
        }
       

    }
}
