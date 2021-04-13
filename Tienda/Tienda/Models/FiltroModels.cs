using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class FiltroModels
    {
        private int id_linea;
        private int id_sublinea;
        private string linea;
        private string sublinea;
        private string categoria;
             
        private string producto;

        public FiltroModels(string sublinea, string categoria, string producto)
        {
            this.sublinea = sublinea;
            this.categoria = categoria;
            this.producto = producto;
        }

        public FiltroModels(string linea, string sublinea, string categoria, string producto)
        {
            this.linea = linea;
            this.sublinea = sublinea;
            this.categoria = categoria;
            this.producto = producto;
        }

        public int Id_linea { get => id_linea; set => id_linea = value; }
        public int Id_sublinea { get => id_sublinea; set => id_sublinea = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Sublinea { get => sublinea; set => sublinea = value; }
        public string Linea { get => linea; set => linea = value; }
        public string Producto { get => producto; set => producto = value; }
    }
}