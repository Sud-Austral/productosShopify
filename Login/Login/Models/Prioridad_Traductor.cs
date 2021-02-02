using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Prioridad_Traductor
    {
        private static listaProductosEntities data_db = new listaProductosEntities();
        private static listaProductosOriginal d_data_db = new listaProductosOriginal();

        public Prioridad_Traductor()
        {

        }

        public static D_PRIORIZACION Traductor(Prioridad prioridad)
        {
            D_PRIORIZACION d_PRIORIZACION = new D_PRIORIZACION();
            d_PRIORIZACION.id = prioridad.id;
            d_PRIORIZACION.producto_previo
            return d_PRIORIZACION;
        }
    }
}