using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SzakacsAndreea_2023_Licenta.DataLayer
{
    public class Produs
    {
        public string CodProdus { get; set; }
        public string CodSortiment { get; set; }
        public string Sortiment { get; set; }
        public string DenumireProdus { get; set; }
        public string Cantitate { get; set; }
        public string Pret { get; set; }
        public string Descriere { get; set; }
        public byte[] Imagine { get; set; }


    }
}
