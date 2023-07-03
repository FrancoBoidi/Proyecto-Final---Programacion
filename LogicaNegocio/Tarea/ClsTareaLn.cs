using AccesoDatos.DataBase;
using Entidades.Empleado;
using Entidades.Tarea;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Tarea
{
    public class ClsTareaLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;


        #endregion

        #region Metodo Index
        //se utiliza para listar informacion y mostrarla en pantalla
        public void Index(ref ClsTarea ObjTarea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Tarea",
                NombreSP = "[SP_Tarea_Index]",
                Scalar = false,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id", "4", ObjTarea.IdProyecto);
            Ejecutar(ref ObjTarea);


        }

        #endregion

        #region CRUD Tarea

        public void Agregar(ref ClsTarea ObjTarea)
        {
            
            
                ObjDataBase = new ClsDataBase()
                {
                    NombreTabla = "Tarea",
                    NombreSP = "[SP_Tarea_Agregar]",
                    Scalar = true,
                };
                //Vamos a agregar los 3 parametros que definimos en la capa datos, clase AccesoDatos
                //ver tipo de dato, mas que nada con los varchar y nvarchar
                ObjDataBase.DtParametros.Rows.Add(@"@id_proyecto", "4", ObjTarea.IdProyecto);
                ObjDataBase.DtParametros.Rows.Add(@"@descripcion", "18", ObjTarea.Descripcion);
                ObjDataBase.DtParametros.Rows.Add(@"@horas_estimadas", "4", ObjTarea.HorasEst);
                ObjDataBase.DtParametros.Rows.Add(@"@costo_estimado", "6", ObjTarea.MontoEst);
                ObjDataBase.DtParametros.Rows.Add(@"@horas_reales", "4", ObjTarea.HorasReal);
                ObjDataBase.DtParametros.Rows.Add(@"@costo_real", "6", ObjTarea.MontoReal);
                ObjDataBase.DtParametros.Rows.Add(@"@fecha_final", "12", ObjTarea.FechaFinal);
                ObjDataBase.DtParametros.Rows.Add(@"@estado", "4", ObjTarea.Estado);


                Ejecutar(ref ObjTarea);




        }

        public void Seleccionar(ref ClsTarea ObjTarea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Tarea",
                NombreSP = "[SP_Tarea_Seleccionar]",
                //va ser true o false si devuelve un valor escalar
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@nro_tarea", "4", ObjTarea.IdTarea);
            Ejecutar(ref ObjTarea);


        }

        public void Modificar(ref ClsTarea ObjTarea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Tarea",
                NombreSP = "[SP_Tarea_Modificar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_proyecto", "4", ObjTarea.IdProyecto);
            ObjDataBase.DtParametros.Rows.Add(@"@nro_tarea", "4", ObjTarea.IdTarea);
            ObjDataBase.DtParametros.Rows.Add(@"@descripcion", "18", ObjTarea.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@horas_estimadas", "4", ObjTarea.HorasEst);
            ObjDataBase.DtParametros.Rows.Add(@"@costo_estimado", "6", ObjTarea.MontoEst);
            ObjDataBase.DtParametros.Rows.Add(@"@horas_reales", "4", ObjTarea.HorasReal);
            ObjDataBase.DtParametros.Rows.Add(@"@costo_real", "6", ObjTarea.MontoReal);
            ObjDataBase.DtParametros.Rows.Add(@"@fecha_final", "12", ObjTarea.FechaFinal);
            ObjDataBase.DtParametros.Rows.Add(@"@estado", "4", ObjTarea.Estado);



            Ejecutar(ref ObjTarea);


        }

        public void Eliminar(ref ClsTarea ObjTarea)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Tarea",
                NombreSP = "[SP_Tarea_Eliminar]",
                Scalar = true,
            };

            
            ObjDataBase.DtParametros.Rows.Add(@"@nro_tarea", "4", ObjTarea.IdTarea);
            Ejecutar(ref ObjTarea);


        }

        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsTarea ObjTarea)
        {
            //le estoy pasando los datos que cree en el metodo index y CRUD al instanciar el objeto DataBase.
            //Mando a ejecutar el metodo crud de la clase de la base de datos.
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {

                    ObjTarea.ValorScalar = ObjDataBase.ValorScalar;

                }
                else
                {
                    //La tabla resultados va a ser igual a la tabla 0 que esta dentro del DataSet de la bdd.
                    //ver si es tabla 0.
                    try
                    {
                        ObjTarea.DtResultados = ObjDataBase.DsResultados.Tables[0];

                        //.rows.count me devuelve la cantidad de filas que tiene la tabla.
                        //Si es igual a 1 quiere decir que hice la busqueda de un solo usuario especifico, entonces rellena el objPropietario con esa informacion
                        if (ObjTarea.DtResultados.Rows.Count == 1)
                        {
                            foreach (DataRow item in ObjTarea.DtResultados.Rows)
                            {
                                //obtiene cada celda de la bdd de la fila evaluada y la convierte para ser procesada 
                                ObjTarea.IdProyecto = Convert.ToInt32(item["id_proyecto"].ToString());
                                ObjTarea.IdTarea = Convert.ToInt32(item["nro_tarea"].ToString());
                                ObjTarea.Descripcion = item["descripcion"].ToString();
                                ObjTarea.HorasEst = Convert.ToInt32(item["horas_estimadas"].ToString());
                                ObjTarea.MontoEst = Convert.ToDecimal(item["costo_estimado"].ToString());
                                ObjTarea.HorasReal = Convert.ToInt32(item["horas_reales"].ToString());
                                ObjTarea.MontoReal = Convert.ToDecimal(item["costo_real"].ToString());
                                ObjTarea.FechaFinal = Convert.ToDateTime(item["fecha_final"].ToString());
                                ObjTarea.Estado = Convert.ToInt32(item["id_proyecto"].ToString());


                            }
                        }
                    }catch (Exception ex)
                    {
                        

                    }
                    }

            }
            
            else
            {
                //el error que se genere lo va a transportar a la entidad Propietario.
                //Luego el msj se valida en la capa presentacion para ver si viene o no viene con error.
                ObjTarea.MensajeError = ObjDataBase.MensajeErrorDB;
            }
        }

        #endregion
    }


}
