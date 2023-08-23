using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzakacsAndreea_2023_Licenta.DataLayer
{
    public class Comanda
    {
        public int IDComanda { get; set; }
        public int CodClient { get; set; }
        public string CodDistribuitor { get; set; }
        public string AdresaLivrare { get; set; }
        public string OrasLivrare { get; set; }
        public string JudetLivrare { get; set; }
        public DateTime DataComanda { get; set; }
        public Client Client { get; set; }

        public IEnumerable<DetaliiComanda> Detalii { get; set; }
        public List<Comanda> comenzi = new List<Comanda>();
    }
}
