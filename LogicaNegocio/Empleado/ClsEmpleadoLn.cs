using AccesoDatos.DataBase;
using Entidades.Empleado;
using System;
using System.Data;

namespace LogicaNegocio.Empleado
{
    public class ClsEmpleadoLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;


        #endregion

        #region Metodo Index
        //se utiliza para listar informacion y mostrarla en pantalla
        public void Index(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Empleado",
                NombreSP = "[SP_Empleado_Index]",
                Scalar = false,
            };
            Ejecutar(ref ObjEmpleado);


        }

        #endregion

        #region CRUD Empleado

        public void Agregar(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Empleado",
                NombreSP = "[SP_Empleado_Agregar]",
                Scalar = true,
            };
            //Vamos a agregar los 3 parametros que definimos en la capa datos, clase AccesoDatos
            //ver tipo de dato, mas que nada con los varchar y nvarchar
            ObjDataBase.DtParametros.Rows.Add(@"@fecha_ingreso", "12", ObjEmpleado.FechaNac);
            ObjDataBase.DtParametros.Rows.Add(@"@nombre", "18", ObjEmpleado.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@apellido", "18", ObjEmpleado.Apellido);
            ObjDataBase.DtParametros.Rows.Add(@"@celular", "18", ObjEmpleado.Contacto);
            ObjDataBase.DtParametros.Rows.Add(@"@email", "18", ObjEmpleado.Email);
            Ejecutar(ref ObjEmpleado);


        }

        public void Seleccionar(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Empleado",
                NombreSP = "[SP_Empleado_Seleccionar]",
                //va ser true o false si devuelve un valor escalar
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@legajo", "4", ObjEmpleado.IdLegajo);
            Ejecutar(ref ObjEmpleado);


        }

        public void Modificar(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Empleado",
                NombreSP = "[SP_Empleado_Modificar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@legajo", "4", ObjEmpleado.IdLegajo);
            ObjDataBase.DtParametros.Rows.Add(@"@fecha_ingreso", "12", ObjEmpleado.FechaNac);
            ObjDataBase.DtParametros.Rows.Add(@"@nombre", "18", ObjEmpleado.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@apellido", "18", ObjEmpleado.Apellido);
            ObjDataBase.DtParametros.Rows.Add(@"@celular", "18", ObjEmpleado.Contacto);
            ObjDataBase.DtParametros.Rows.Add(@"@email", "18", ObjEmpleado.Email);


            Ejecutar(ref ObjEmpleado);


        }

        public void Eliminar(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Empleado",
                NombreSP = "[SP_Empleado_Eliminar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@legajo", "4", ObjEmpleado.IdLegajo);
            Ejecutar(ref ObjEmpleado);


        }

        public void CargarCombo(ref ClsEmpleado ObjEmpleado)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Empleado",
                NombreSP = "[SP_Empleado_CargarCombo]",
                Scalar = false,
            };
            Ejecutar(ref ObjEmpleado);


        }

        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsEmpleado ObjEmpleado)
        {
            //le estoy pasando los datos que cree en el metodo index y CRUD al instanciar el objeto DataBase.
            //Mando a ejecutar el metodo crud de la clase de la base de datos.
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {

                    ObjEmpleado.ValorScalar = ObjDataBase.ValorScalar;

                }
                else
                {
                    //La tabla resultados va a ser igual a la tabla 0 que esta dentro del DataSet de la bdd.
                    //ver si es tabla 0.
                    ObjEmpleado.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    //.rows.count me devuelve la cantidad de filas que tiene la tabla.
                    //Si es igual a 1 quiere decir que hice la busqueda de un solo usuario especifico, entonces rellena el objPropietario con esa informacion
                    if (ObjEmpleado.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjEmpleado.DtResultados.Rows)
                        {
                            //obtiene cada celda de la bdd de la fila evaluada y la convierte para ser procesada 
                            ObjEmpleado.IdLegajo = Convert.ToInt32(item["legajo"].ToString());
                            ObjEmpleado.FechaNac = Convert.ToDateTime(item["fecha_ingreso"].ToString());
                            ObjEmpleado.Nombre = item["nombre"].ToString();
                            ObjEmpleado.Apellido = item["apellido"].ToString();
                            ObjEmpleado.Contacto = item["celular"].ToString();
                            ObjEmpleado.Email = item["email"].ToString();


                        }
                    }
                }

            }
            else
            {
                //el error que se genere lo va a transportar a la entidad Propietario.
                //Luego el msj se valida en la capa presentacion para ver si viene o no viene con error.
                ObjEmpleado.MensajeError = ObjDataBase.MensajeErrorDB;
            }
        }

        #endregion
    }


}
