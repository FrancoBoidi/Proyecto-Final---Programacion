using AccesoDatos.DataBase;
using Entidades.Proyecto;
using Entidades.Tarea;
using System.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using LogicaNegocio.Tarea;
using System.Runtime.Remoting.Messaging;

namespace LogicaNegocio.Proyecto
{
    public class ClsProyectoLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;


        #endregion

        #region Metodo Index
        //se utiliza para listar informacion y mostrarla en pantalla
        public void Index(ref ClsProyecto ObjProyecto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Proyecto",
                NombreSP = "[SP_Proyecto_Index]",
                Scalar = false,
            };
            Ejecutar(ref ObjProyecto);
        }

        #endregion

        #region CRUD Proyecto

        public void Agregar(ref ClsProyecto ObjProyecto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Proyecto",
                NombreSP = "[SP_Proyecto_Agregar]",
                Scalar = true,
            };
            //Vamos a agregar los 3 parametros que definimos en la capa datos, clase AccesoDatos
            //ver tipo de dato, mas que nada con los varchar y nvarchar
            //ObjDataBase.DtParametros.Rows.Add(@"@nro_tarea", "4", ObjTarea.IdTarea);
            ObjDataBase.DtParametros.Rows.Add(@"@nombre", "18", ObjProyecto.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@monto_estimado", "6", ObjProyecto.Monto);
            ObjDataBase.DtParametros.Rows.Add(@"@tiempo_estimado", "4", ObjProyecto.Tiempo);
            ObjDataBase.DtParametros.Rows.Add(@"@id_propietario_fk", "4", ObjProyecto.IdPropietario);
            ObjDataBase.DtParametros.Rows.Add(@"@legajo_fk", "4", ObjProyecto.IdLegajo);

            Ejecutar(ref ObjProyecto);


        }

        public void Seleccionar(ref ClsProyecto ObjProyecto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Proyecto",
                NombreSP = "[SP_Proyecto_Seleccionar]",
                //va ser true o false si devuelve un valor escalar
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@id_proyecto", "4", ObjProyecto.IdProyecto);
            Ejecutar(ref ObjProyecto);


        }

        public void Modificar(ref ClsProyecto ObjProyecto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Proyecto",
                NombreSP = "[SP_Proyecto_Modificar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_proyecto", "4", ObjProyecto.IdProyecto);
            ObjDataBase.DtParametros.Rows.Add(@"@nombre", "18", ObjProyecto.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@monto_estimado", "6", ObjProyecto.Monto);
            ObjDataBase.DtParametros.Rows.Add(@"@tiempo_estimado", "4", ObjProyecto.Tiempo);
            ObjDataBase.DtParametros.Rows.Add(@"@id_propietario_fk", "4", ObjProyecto.IdPropietario);
            ObjDataBase.DtParametros.Rows.Add(@"@legajo_fk", "4", ObjProyecto.IdLegajo);


            Ejecutar(ref ObjProyecto);


        }

        public void Eliminar(ref ClsProyecto ObjProyecto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Proyecto",
                NombreSP = "[SP_Proyecto_Eliminar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_proyecto", "4", ObjProyecto.IdProyecto);

            Ejecutar(ref ObjProyecto);


        }

        public void CargarCombo (ref ClsProyecto ObjProyecto)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Proyecto",
                NombreSP = "[SP_Proyecto_CargarCombo]",
                Scalar = false,
            };
            Ejecutar(ref ObjProyecto);
        }

        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsProyecto ObjProyecto)
        {
            //le estoy pasando los datos que cree en el metodo index y CRUD al instanciar el objeto DataBase.
            //Mando a ejecutar el metodo crud de la clase de la base de datos.

            ObjDataBase.CRUD(ref ObjDataBase);


            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {

                    ObjProyecto.ValorScalar = ObjDataBase.ValorScalar;

                }
                else
                {
                    //La tabla resultados va a ser igual a la tabla 0 que esta dentro del DataSet de la bdd.
                    //ver si es tabla 0.
                    ObjProyecto.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    //.rows.count me devuelve la cantidad de filas que tiene la tabla.
                    //Si es igual a 1 quiere decir que hice la busqueda de un solo usuario especifico, entonces rellena el objPropietario con esa informacion

                    if (ObjProyecto.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjProyecto.DtResultados.Rows)
                        {
                            //obtiene cada celda de la bdd de la fila evaluada y la convierte para ser procesada 
                            ObjProyecto.IdProyecto = Convert.ToInt32(item["id_proyecto"].ToString());
                            ObjProyecto.Nombre = item["nombre"].ToString();
                            ObjProyecto.Monto = Convert.ToDecimal(item["monto_estimado"].ToString());
                            ObjProyecto.Tiempo = Convert.ToInt32(item["tiempo_estimado"].ToString());
                            ObjProyecto.IdPropietario = Convert.ToInt32(item["id_propietario_FK"].ToString());
                            ObjProyecto.IdLegajo = Convert.ToInt32(item["legajo_FK"].ToString());
                        }

                    }

                    else
                    {
                        //el error que se genere lo va a transportar a la entidad Propietario.
                        //Luego el msj se valida en la capa presentacion para ver si viene o no viene con error.
                        ObjProyecto.MensajeError = ObjDataBase.MensajeErrorDB;

                    }



                }

                #endregion

            }
        }
    }
}
