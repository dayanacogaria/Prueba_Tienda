using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class LineaModels
    {
        
        private String linea;
    
        private int id_linea;

        
        //listar lineas
        public LineaModels(int id_linea, string linea)
        {
            this.id_linea = id_linea;
            this.linea = linea;
        }
     



        public int Id_linea { get => id_linea; set => id_linea = value; }
        public string Linea { get => linea; set => linea = value; }
       
    }
}