using AccesoDatos.DataBase;
using Entidades.Funcion;
using System;
using System.Data;

namespace LogicaNegocio.Funcion
{
    public class ClsFuncionLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;


        #endregion

        #region Metodo Index
        //se utiliza para listar informacion y mostrarla en pantalla
        public void Index(ref ClsFuncion ObjFuncion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Funcion",
                NombreSP = "[SP_Funcion_Index]",
                Scalar = false,
            };
            Ejecutar(ref ObjFuncion);


        }

        #endregion

        #region CRUD Funcion

        public void Agregar(ref ClsFuncion ObjFuncion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Funcion",
                NombreSP = "[SP_Funcion_Agregar]",
                Scalar = true,
            };
            //Vamos a agregar los 3 parametros que definimos en la capa datos, clase AccesoDatos
            //ver tipo de dato, mas que nada con los varchar y nvarchar
            
            ObjDataBase.DtParametros.Rows.Add(@"@descripcion", "18", ObjFuncion.Descripcion);
            
            Ejecutar(ref ObjFuncion);


        }

        public void Seleccionar(ref ClsFuncion ObjFuncion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Funcion",
                NombreSP = "[SP_Funcion_Seleccionar]",
                //va ser true o false si devuelve un valor escalar
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@id_funcion", "4", ObjFuncion.IdFuncion);
            Ejecutar(ref ObjFuncion);


        }
        public void Modificar(ref ClsFuncion ObjFuncion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Funcion",
                NombreSP = "[SP_Funcion_Modificar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_funcion", "4", ObjFuncion.IdFuncion);
            ObjDataBase.DtParametros.Rows.Add(@"@descripcion", "18", ObjFuncion.Descripcion);
          


            Ejecutar(ref ObjFuncion);


        }

        public void Eliminar(ref ClsFuncion ObjFuncion)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Funcion",
                NombreSP = "[SP_Funcion_Eliminar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_funcion", "4", ObjFuncion.IdFuncion);
            Ejecutar(ref ObjFuncion);


        }

        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsFuncion ObjFuncion)
        {
            //le estoy pasando los datos que cree en el metodo index y CRUD al instanciar el objeto DataBase.
            //Mando a ejecutar el metodo crud de la clase de la base de datos.
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {

                    ObjFuncion.ValorScalar = ObjDataBase.ValorScalar;

                }
                else
                {
                    //La tabla resultados va a ser igual a la tabla 0 que esta dentro del DataSet de la bdd.
                    //ver si es tabla 0.
                    ObjFuncion.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    //.rows.count me devuelve la cantidad de filas que tiene la tabla.
                    //Si es igual a 1 quiere decir que hice la busqueda de un solo usuario especifico, entonces rellena el objPropietario con esa informacion
                    if (ObjFuncion.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjFuncion.DtResultados.Rows)
                        {
                            //obtiene cada celda de la bdd de la fila evaluada y la convierte para ser procesada 
                            ObjFuncion.IdFuncion = Convert.ToInt32(item["id_funcion"].ToString());
                            ObjFuncion.Descripcion = item["descripcion"].ToString();
                         
                        }
                    }
                }

            }
            else
            {
                //el error que se genere lo va a transportar a la entidad Propietario.
                //Luego el msj se valida en la capa presentacion para ver si viene o no viene con error.
                ObjFuncion.MensajeError = ObjDataBase.MensajeErrorDB;
            }
        }

        #endregion


    }
}
