using Dapper;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SzakacsAndreea_2023_Licenta.DataLayer
{
    public class DataRepository : IDataRepository
    {
        //------------CLIENTI-----------------
        public IEnumerable<Client> AfisareClienti()
        {
            //se verifică dacă conexiunea este disponibilă
            if (AppConnection.IsAvailable() == false) return null;

            //se obține o conexiune la sursa de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                //este important să se verifice și să se deschidă conexiunea în cazul în care aceasta este închisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                //se specifică numele procedurii stocate
                string storedProcedure = "spAfisare_Clienti";

                //se returnează sub formă de colecție de obiecte de tip "Client" rezultatul obținut prin execuția procedurii stocate
                return connection.Query<Client>(storedProcedure, commandType: CommandType.StoredProcedure);
            }
        }
        public int EditareClient(Client client)
        {
            //se definește instrucțiunea SQL pentru actualizarea unei înregistrări
            string sql = "UPDATE Clienti SET " +
              "Nume = @Nume, " +
              "PersoanaContact = @PersoanaContact, " +
              "Telefon = @Telefon, " +
              "Adresa = @Adresa, " +
              "Oras = @Oras, " +
              "Judet = @Judet "+
              "WHERE CodClient = @CodClient";


            var parameters = client;

            //se obține o conexiune la sursa de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                //se execută instrucțiunea SQL
                return connection.Execute(sql, parameters);
            }
        }
        public int StergereClient(Client client)
        {
            if (AppConnection.IsAvailable() == false) return -1;

            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                var parameters = new { CodClient = client.CodClient };

                string storedProcedure = "spStergere_Clienti";

                return connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public int AdaugareClient(Client client)
        {
            string sql = "INSERT INTO Clienti (CodClient,Nume,PersoanaContact,Telefon,Adresa,Oras,Judet)" +
                "VALUES (@CodClient,@Nume,@PersoanaContact,@Telefon,@Adresa,@Oras,@Judet)";
            var parameters = client;
            using(IDbConnection connection = AppConnection.GetDbConnection())
            {
                return connection.Execute(sql, parameters);
            }
         
        }

        
        //---------------COMENZI------------
        public IEnumerable<Comanda> AfisareComenzi()
        {
            //se verifică dacă conexiunea este disponibilă
            if (AppConnection.IsAvailable() == false) return null;

            //se obține o conexiune la sursa de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                //este important să se verifice și să se deschidă conexiunea în cazul în care aceasta este închisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                //se specifică numele procedurii stocate
                string storedProcedure = "spAfisare_Comenzi";

                //se returnează sub formă de colecție de obiecte de tip "Comanda" rezultatul obținut prin execuția procedurii stocate
                return connection.Query<Comanda>(storedProcedure, commandType: CommandType.StoredProcedure);
            }
        }

        //--------------------DETALII COMANDA----------------
        public IEnumerable<DetaliiComanda> AfisareDetaliiComanda(int idComanda)
        {
            //se verifică dacă conexiunea este disponibilă
            if (AppConnection.IsAvailable() == false) return null;

            //se obține o conexiune la sursa de date
            using (IDbConnection connection = AppConnection.GetDbConnection())
            {
                //este important să se verifice și să se deschidă conexiunea în cazul în care aceasta este închisă
                if (connection.State == ConnectionState.Closed) connection.Open();

                var parameters = new { IDComanda = idComanda };

                string storedProcedure = "spAfisare_Detalii_Comanda";

                return connection.Query<DetaliiComanda>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }


       
    }
}
