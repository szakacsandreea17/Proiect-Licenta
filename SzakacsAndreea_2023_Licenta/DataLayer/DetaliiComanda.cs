using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzakacsAndreea_2023_Licenta.DataLayer
{
    public class DetaliiComanda
    {
        public int IDComanda { get; set; }
        public string CodProdus { get; set; }
        public float Pret { get; set; }
        public int Cantitate { get; set; }
        public float Suma { get; set; }
        public Comanda Comanda { get; set; }
        public object SelectedCells { get; internal set; }
    }
}
