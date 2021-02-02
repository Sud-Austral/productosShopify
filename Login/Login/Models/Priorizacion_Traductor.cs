using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Priorizacion_Traductor
    {
        private static listaProductosEntities priorizacion_db = new listaProductosEntities();
        private static listaProductosOriginal d_priorizacion_db = new listaProductosOriginal();

        public Priorizacion_Traductor()
        {

        }

        public static D_PRIORIZACION Traductor(Prioridad prioridad)
        {
            D_PRIORIZACION d_PRIORIZACION = new D_PRIORIZACION();
            d_PRIORIZACION.id = prioridad.id;
            d_PRIORIZACION.producto_previo = prioridad.Producto_Previos;
            d_PRIORIZACION.secuencia = prioridad.Secuencia;
            d_PRIORIZACION.pais = prioridad.País;
            d_PRIORIZACION.integrado = prioridad.Integrado_PRODUCTOS;
            d_PRIORIZACION.id_producto = prioridad.id_producto;
            d_PRIORIZACION.prioridad = prioridad.Prioridad1;
            d_PRIORIZACION.estado = prioridad.Estado;
            d_PRIORIZACION.avance = prioridad.Avance;
            d_PRIORIZACION.responsable_desarrollo = prioridad.Responsable_Desarrollo;
            d_PRIORIZACION.responsable_informacion = prioridad.Responsable_Información;
            d_PRIORIZACION.tecnologia = prioridad.Tecnología;
            d_PRIORIZACION.tarea = prioridad.Tareas_Elementos;
            d_PRIORIZACION.db = "Lista";
            d_PRIORIZACION.plataforma = "Lista";
            d_PRIORIZACION.control_calidad = "En proceso";
            d_PRIORIZACION.odoo = "";
            d_PRIORIZACION.shopify = "";
            d_PRIORIZACION.fecha_estimada = prioridad.Fecha_Actualizacion;
            d_PRIORIZACION.fecha_actualizacion = prioridad.Fecha_Actualizacion;
            
            return d_PRIORIZACION;
        }
    }
}