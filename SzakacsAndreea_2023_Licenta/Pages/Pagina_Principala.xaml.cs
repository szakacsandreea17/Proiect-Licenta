using Dapper;
using LiveCharts.Wpf;
using LiveCharts;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using SzakacsAndreea_2023_Licenta.DataLayer;
using System.Collections;
using LiveCharts.Wpf.Charts.Base;
using System.Windows.Forms;


namespace SzakacsAndreea_2023_Licenta.Pages
{
    /// <summary>
    /// Interaction logic for Pagina_Principala.xaml
    /// </summary>
    public partial class Pagina_Principala : Page
    {
        
        
        List<Comanda> comenzi = new List<Comanda>();
        CollectionViewSource comandaViewSource;
       
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<int, string> Formatter { get; set; }
       
        public Pagina_Principala()
        {
            InitializeComponent();
            comandaViewSource = (CollectionViewSource)this.FindResource("comandaViewSource");
            IncarcareGrafic();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                var query = "select * from Comenzi";
                var result = connection.Query(query);
                int comenziCount =result.Count();
                labelcomenzi.Content = comenziCount;
                

                var query1 = "select * from Clienti";
                var result1 = connection.Query(query1);
                int clientiCount = result1.Count();
                labelclienti.Content = clientiCount;

                var query2 = "select * from Producatori";
                var result2 = connection.Query(query2);
                int producatoriCount = result2.Count();
                labelproducatori.Content = producatoriCount;
                
            }
        }

        private void IncarcareGrafic()
        {
            using (IDbConnection connection = AppConnection.GetDbConnection())

            {
                //se deschide conexiuneadacă nu este deja deschisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                List<string> luna = new List<string> { "Ianuarie", "Februarie", "Martie", "Aprilie" };

                string query = "SELECT MONTH(DataComanda) AS Luna, COUNT(*) AS NumarComenzi FROM Comenzi GROUP BY MONTH(DataComanda)";

                var result = connection.Query(query);

                List<int> Luna = new List<int>();
                List<int> numarComenzi = new List<int>();
                foreach (var row in result)
                {
                    int lunavalue = (int)row.Luna;
                    int numar = (int)row.NumarComenzi;

                    Luna.Add(lunavalue);
                    numarComenzi.Add(numar);
                }

                SeriesCollection = new SeriesCollection
                   {
                     new RowSeries
                      {
                         Title = "Numar comenzi",
                         Values = new ChartValues<int>(numarComenzi)
                      }
                    };

                Labels = luna.Select(x => x.ToString()).ToArray();

                DataContext = this;
            }
        }


        
    }
}
