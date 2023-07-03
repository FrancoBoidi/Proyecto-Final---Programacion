using AccesoDatos.DataBase;
using Entidades.Empleado;
using Entidades.Observacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Observacion
{
    public class ClsObservacionLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;


        #endregion

        #region Metodo Index
        //se utiliza para listar informacion y mostrarla en pantalla
        public void Index(ref ClsObservacion ObjObservacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "observacion",
                NombreSP = "[SP_Observacion_Index]",
                Scalar = false,
            };
            Ejecutar(ref ObjObservacion);


        }

        #endregion

        #region CRUD Observacion

        public void Agregar(ref ClsObservacion ObjObservacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "observacion",
                NombreSP = "[SP_Observacion_Agregar]",
                Scalar = true,
            };
            //Vamos a agregar los 3 parametros que definimos en la capa datos, clase AccesoDatos
            //ver tipo de dato, mas que nada con los varchar y nvarchar
            ObjDataBase.DtParametros.Rows.Add(@"@fecha", "12", ObjObservacion.Fecha);
            ObjDataBase.DtParametros.Rows.Add(@"@observacion", "18", ObjObservacion.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@legajo_FK", "4", ObjObservacion.IdLegajo);
          
            Ejecutar(ref ObjObservacion);


        }

        public void Seleccionar(ref ClsObservacion ObjObservacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "observacion",
                NombreSP = "[SP_Observacion_Seleccionar]",
                //va ser true o false si devuelve un valor escalar
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@id_observacion", "4", ObjObservacion.IdObservacion);
            Ejecutar(ref ObjObservacion);


        }

        public void Modificar(ref ClsObservacion ObjObservacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "observacion",
                NombreSP = "[SP_Observacion_Modificar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_observacion", "4", ObjObservacion.IdObservacion);
            ObjDataBase.DtParametros.Rows.Add(@"@fecha", "12", ObjObservacion.Fecha);
            ObjDataBase.DtParametros.Rows.Add(@"@observacion", "18", ObjObservacion.Descripcion);
            ObjDataBase.DtParametros.Rows.Add(@"@legajo_FK", "4", ObjObservacion.IdLegajo);



            Ejecutar(ref ObjObservacion);


        }

        public void Eliminar(ref ClsObservacion ObjObservacion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "observacion",
                NombreSP = "[SP_Observacion_Eliminar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_observacion", "4", ObjObservacion.IdObservacion);
            Ejecutar(ref ObjObservacion);


        }
        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsObservacion ObjObservacion)
        {
            //le estoy pasando los datos que cree en el metodo index y CRUD al instanciar el objeto DataBase.
            //Mando a ejecutar el metodo crud de la clase de la base de datos.
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {

                    ObjObservacion.ValorScalar = ObjDataBase.ValorScalar;

                }
                else
                {
                    //La tabla resultados va a ser igual a la tabla 0 que esta dentro del DataSet de la bdd.
                    //ver si es tabla 0.
                    ObjObservacion.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    //.rows.count me devuelve la cantidad de filas que tiene la tabla.
                    //Si es igual a 1 quiere decir que hice la busqueda de un solo usuario especifico, entonces rellena el objPropietario con esa informacion
                    if (ObjObservacion.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjObservacion.DtResultados.Rows)
                        {
                            //obtiene cada celda de la bdd de la fila evaluada y la convierte para ser procesada 
                            ObjObservacion.IdObservacion = Convert.ToInt32(item["id_observacion"].ToString());
                            ObjObservacion.Fecha = Convert.ToDateTime(item["fecha"].ToString());
                            ObjObservacion.Descripcion = item["observacion"].ToString();
                            ObjObservacion.IdLegajo = Convert.ToInt32(item["legajo_FK"].ToString());


                        }
                    }
                }

            }
            else
            {
                //el error que se genere lo va a transportar a la entidad Propietario.
                //Luego el msj se valida en la capa presentacion para ver si viene o no viene con error.
                ObjObservacion.MensajeError = ObjDataBase.MensajeErrorDB;
            }
        }

        #endregion
    }

}
