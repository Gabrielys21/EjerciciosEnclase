using Clases_padres.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_padres.ClaseHija
{
    internal class Nintendo:ClsConsola
    {
        public bool esPortable { get; set; }

        public string MostrarDetalleNintendo()
        {
            string detallePadre = MostrarDetalles();
            return detallePadre + "Es portable " + esPortable; 
        }
    }
}
