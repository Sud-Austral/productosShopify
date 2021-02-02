using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Data_Traductor
    {
        private static listaProductosEntities data_db = new listaProductosEntities();
        private static listaProductosOriginal d_data_db = new listaProductosOriginal();

        public Data_Traductor()
        {

        }

        public static D_Data Traductor(Data data)
        {
            D_Data d_Data = new D_Data();
            d_Data.id = data.id;
            d_Data.id_data = data.id_data.ToString();
            d_Data.data = data.Data1;
            d_Data.estado = data.Estado;
            d_Data.desarrollo = data.Desarrollo;
            d_Data.investigacion = data.Investigación;
            d_Data.descripcion = data.Breve_Descripción;
            d_Data.slogan = data.Slogan___Cita;
            d_Data.vista = data.Vistas;
            d_Data.repositorio_dropbox = data.Repositorio_Dropbox;
            d_Data.logo = data.Link_Logo;
            return d_Data;
        }

        public static void InsetarDatos()
        {
            foreach (var item  in data_db.Datas)
            {
                if(d_data_db.D_Data.Where(x => x.id == item.id).Count() == 0)
                {
                    D_Data fila = Traductor(item);
                    d_data_db.D_Data.Add(fila);
                }
                               
            }
            try
            {
                d_data_db.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
            }
            
        }



    }
}