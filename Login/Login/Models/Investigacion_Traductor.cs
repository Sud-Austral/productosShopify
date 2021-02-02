using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Investigacion_Traductor
    {
        private static listaProductosEntities investigacion_db = new listaProductosEntities();
        private static listaProductosOriginal d_investigacion_db = new listaProductosOriginal();

        public Investigacion_Traductor()
        {

        }

        public static D_INVESTIGACION Traductor(Investigacio investigacio)
        {
            D_INVESTIGACION d_INVESTIGACION = new D_INVESTIGACION();
            d_INVESTIGACION.id = investigacio.id;
            d_INVESTIGACION.numero = investigacio.N_;
            d_INVESTIGACION.tema = investigacio.Tema_Investigación_;
            d_INVESTIGACION.responsable = investigacio.Responsables_;
            d_INVESTIGACION.fecha_inicio = investigacio.Fecha_inicio;
            d_INVESTIGACION.fecha_avance = investigacio.Fecha_inicio;
            d_INVESTIGACION.fecha_termino = investigacio.Fecha_Termino;
            d_INVESTIGACION.comentario = "";
            d_INVESTIGACION.accion = "";
            d_INVESTIGACION.seguimiento = "";
            d_INVESTIGACION.D_Data_id_data = 0;
            return d_INVESTIGACION;
        }

        public static void InsetarDatos()
        {
            foreach (var item in investigacion_db.Investigacios)
            {
                if (d_investigacion_db.D_INVESTIGACION.Where(x => x.id == item.id).Count() == 0)
                {
                    D_INVESTIGACION fila = Traductor(item);
                    d_investigacion_db.D_INVESTIGACION.Add(fila);
                }

            }
            try
            {
                d_investigacion_db.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
            }

        }
    }
}