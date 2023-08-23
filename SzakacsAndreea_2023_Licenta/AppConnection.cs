using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SzakacsAndreea_2023_Licenta
{
    public class AppConnection
    {
        //sirul de conectare pentru serverul SQL este preluat din fisierul 'app.config'
        private static string connectionString =ConfigurationManager.ConnectionStrings["AppConnectionString"].ConnectionString;

        //metoda returneaza un obiect de tip DbConnection pentru metodele din aplicatie
        public static IDbConnection GetDbConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool IsAvailable()
        {
            using(IDbConnection connection = GetDbConnection())
            {
                if (connection == null) return false;
                try
                {
                    connection.Open();
                    return true;
                }
                catch(Exception ex)
                {
                    string errorMessage = "Nu s-a putut realiza conexiunea spre baza de date. \n" +
                        "Verficați șirul de conectare în fișierul de configurare al aplicației" +
                        "\n\n" + ex.Message;
                    throw new Exception(errorMessage);
                }
            }
        }
    }
}
