using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzakacsAndreea_2023_Licenta.DataLayer
{
    public interface IDataRepository
    {  
        
        //==================CLIENTI==========
        IEnumerable<Client> AfisareClienti();
        int AdaugareClient(Client client);
        int EditareClient(Client client);
        int StergereClient(Client client);

        //===================COMENZI===========
        IEnumerable<Comanda> AfisareComenzi();
        IEnumerable<DetaliiComanda> AfisareDetaliiComanda(int idComanda);

    }
}
