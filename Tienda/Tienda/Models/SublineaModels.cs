using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class SublineaModels
    {

        private int id_sublinea;
        private string sublinea;
        private int id_linea;
        private String linea;

        public SublineaModels(int id_sublinea, string sublinea, int id_linea, string linea)
        {
            this.id_sublinea = id_sublinea;
            this.sublinea = sublinea;
            this.id_linea = id_linea;
            this.linea = linea;
        }

        public int Id_sublinea { get => id_sublinea; set => id_sublinea = value; }
        public string Sublinea { get => sublinea; set => sublinea = value; }
        public int Id_linea { get => id_linea; set => id_linea = value; }
        public string Linea { get => linea; set => linea = value; }
    }
}