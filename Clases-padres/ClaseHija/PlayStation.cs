using Clases_padres.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_padres.ClaseHija
{
    internal class PlayStation:ClsConsola
    {
        public string ModeloCotrolador { get; set; }

        public string MostrarDetallePlay()
        {
            return MostrarDetalles() + "Controlador:" + ModeloCotrolador;
        }
    }
}
