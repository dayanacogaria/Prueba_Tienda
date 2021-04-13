using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class CateModels
    {

        private int id_categoria;
        private string categoria;
        private int id_sublinea;
        private string sublinea;

        public CateModels(int id_categoria, string categoria, int id_sublinea, string sublinea)
        {
            this.id_categoria = id_categoria;
            this.categoria = categoria;
            this.id_sublinea = id_sublinea;
            this.sublinea = sublinea;
        }

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Id_sublinea { get => id_sublinea; set => id_sublinea = value; }
        public string Sublinea { get => sublinea; set => sublinea = value; }
    }
}