using AccesoDatos.DataBase;
using Entidades.Empleado;
using Entidades.Propietario;
using System;
using System.Data;
using System.Runtime.Remoting.Lifetime;

namespace LogicaNegocio.Propietario
{
    public class ClsPropietarioLn
    {
        #region Variables privadas
        private ClsDataBase ObjDataBase = null;


        #endregion

        #region Metodo Index
        //se utiliza para listar informacion y mostrarla en pantalla (select?)
        public void Index(ref ClsPropietario ObjPropietario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Propietario",
                NombreSP = "[SP_Propietario_Index]",
                Scalar = false,
            };
            Ejecutar(ref ObjPropietario);


        }

        #endregion

        #region CRUD Propietario

        public void Agregar(ref ClsPropietario ObjPropietario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Propietario",
                NombreSP = "[SP_Propietario_Agregar]",
                Scalar = true,
            };
            //Vamos a agregar los 3 parametros que definimos en la capa datos, clase AccesoDatos
            //ver tipo de dato, mas que nada con los varchar y nvarchar
            ObjDataBase.DtParametros.Rows.Add(@"@razon_social","18",ObjPropietario.RazonSocial);
            ObjDataBase.DtParametros.Rows.Add(@"@telefono", "18", ObjPropietario.Telefono);
            ObjDataBase.DtParametros.Rows.Add(@"@email", "18", ObjPropietario.Email);
            ObjDataBase.DtParametros.Rows.Add(@"@cuit", "5", ObjPropietario.Cuit);
            ObjDataBase.DtParametros.Rows.Add(@"@persona_contacto", "18", ObjPropietario.Contacto);
            Ejecutar(ref ObjPropietario);
                

        }

        public void Seleccionar(ref ClsPropietario ObjPropietario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Propietario",
                NombreSP = "[SP_Propietario_Seleccionar]",
                //va ser true o false si devuelve un valor escalar
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@id_propietario", "4", ObjPropietario.IdPropietario);
            Ejecutar(ref ObjPropietario);


        }

        public void Modificar(ref ClsPropietario ObjPropietario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Propietario",
                NombreSP = "[SP_Propietario_Modificar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_propietario", "4", ObjPropietario.IdPropietario);
            ObjDataBase.DtParametros.Rows.Add(@"@razon_social", "18", ObjPropietario.RazonSocial);
            ObjDataBase.DtParametros.Rows.Add(@"@telefono", "18", ObjPropietario.Telefono);
            ObjDataBase.DtParametros.Rows.Add(@"@email", "18", ObjPropietario.Email);
            ObjDataBase.DtParametros.Rows.Add(@"@cuit", "5", ObjPropietario.Cuit);
            ObjDataBase.DtParametros.Rows.Add(@"@persona_contacto", "18", ObjPropietario.Contacto);
            

            Ejecutar(ref ObjPropietario);


        }

        public void Eliminar(ref ClsPropietario ObjPropietario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Propietario",
                NombreSP = "[SP_Propietario_Eliminar]",
                Scalar = true,
            };

            ObjDataBase.DtParametros.Rows.Add(@"@id_propietario", "4", ObjPropietario.IdPropietario);
            Ejecutar(ref ObjPropietario);


        }

        public void CargarCombo(ref ClsPropietario ObjPropietario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Propietario",
                NombreSP = "[SP_Propietario_CargarCombo]",
                Scalar = false,
            };
            Ejecutar(ref ObjPropietario);


        }


        #endregion

        #region Metodos Privados
        private void Ejecutar (ref ClsPropietario ObjPropietario)
        {
            //le estoy pasando los datos que cree en el metodo index y CRUD al instanciar el objeto DataBase.
            //Mando a ejecutar el metodo crud de la clase de la base de datos.
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar) {

                    ObjPropietario.ValorScalar = ObjDataBase.ValorScalar;
                    
                } else
                {
                    //La tabla resultados va a ser igual a la tabla 0 que esta dentro del DataSet de la bdd.
                    //ver si es tabla 0.
                    ObjPropietario.DtResultados= ObjDataBase.DsResultados.Tables[0];
                    //.rows.count me devuelve la cantidad de filas que tiene la tabla.
                    //Si es igual a 1 quiere decir que hice la busqueda de un solo usuario especifico, entonces rellena el objPropietario con esa informacion
                    if (ObjPropietario.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjPropietario.DtResultados.Rows)
                        {
                            //obtiene cada celda de la bdd de la fila evaluada y la convierte para ser procesada 
                            ObjPropietario.IdPropietario= Convert.ToInt32(item["id_propietario"].ToString());
                            ObjPropietario.RazonSocial = item["razon_social"].ToString();
                            ObjPropietario.Telefono = item["id_propietario"].ToString();
                            ObjPropietario.Email = item["id_propietario"].ToString();
                            ObjPropietario.Cuit = Convert.ToInt32(item["id_propietario"].ToString());
                            ObjPropietario.Contacto = item["id_propietario"].ToString();    


                        }
                    }
                }

            } else
            {
                //el error que se genere lo va a transportar a la entidad Propietario.
                //Luego el msj se valida en la capa presentacion para ver si viene o no viene con error.
                ObjPropietario.MensajeError = ObjDataBase.MensajeErrorDB;
            }
        }

        #endregion

    }
}
