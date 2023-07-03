using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.DataBase
{
    public class ClsDataBase
    {
        #region Variables privadas

        //permite crear la conexion con la bdd. Debemos brindarle servidor, usuario y contraseña
        private SqlConnection _objSqlConnection;
        //formas de enviar una consulta a la bdd. Permite hacer una lectura de datos, se utiliza cuando usamos un select
        private SqlDataAdapter _objSqlDataAdapter;
        //Permite enviar los comandos para crear, actualizar y para borrar informacion
        private SqlCommand _objSqlCommand;
        //de un sqladapter vamos a tener un resultado, es decir, una tabla con una o mas filas.
        //Eso es lo que se alamcena en el DataSet.Es una lista de tablas.
        private DataSet _dsResultados;
        //En esta tabla vamos a construir los parametros que le vamos a pasar a command y dataAdapter,
        //ya que vamos a usar procedimientos almacenados para ejecutar nuestras consultas.
        //Estos proced llevan una lista de parametros
        private DataTable _dtParametros;
        //_mensajeErrorDB: almacenar cualq error que devuelva la bdd para luego enviarselo a la siguiente capa y
        //ser mostrado por la presentacion. Lo importante es que el sistema no pare por alguna excepcion.
        //Hay algunos errores que el usuario no entendera y no deberia ver, por eso vamos a capturar, personalizar y luego enviar los errores.
        //nombreTabla: nombre que voy a asignar cuando reciba los datos de objResultados.
        //_nombreSP: es el nombre que le vamos a pasar como parametro a command y dataAdapter.
        //_mensajeErroDB: va a ser lo que me devuelva si command o dataAdapter falla.
        // _valorScalar: cuando voy a hacer un insert, update o delete le podemos decir a la bdd que nos devuelva un numero
        //ej: cuando hago un insert le podemos decir que nos devuelva el id del registro.
        //La variable se crea bajo la necesidad de que retorne algo, Cuando no ocupo un valor es porque lo que voy a recibir es una tabla resultado.
        private string _nombreTabla, _nombreSP, _mensajeErrorDB, _valorScalar, _nombreDB;
        //cuando sea true voy a recibir un valorScalar.
        private bool _scalar;
        private SqlTransaction _objSqlTransaction;

        #endregion

        //Encapsulamiento: para poder usar esos metodos en el resto de las capas 
        #region Variables publicas

        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }

        public DataSet DsResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string NombreSP { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorDB { get => _mensajeErrorDB; set => _mensajeErrorDB = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public string NombreDB { get => _nombreDB; set => _nombreDB = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }
        public SqlTransaction ObjSqlTransaction { get => _objSqlTransaction; set => _objSqlTransaction = value; }

        #endregion

        #region Constructores
        //Cuando yo tengo una clase, esa clase la puedo instanciar y llamo a todos los atributos.
        //Si los atributos no estan inicializados van a tomar un valor por default.
        //Dentro de un constructor yo puedo ejecutar o inicializar las variables o ejecutar metodos que considere pertinentes para la instancia.

        public ClsDataBase ()
        {
            //vamos a inicializar la tabla de parametros porque la vamos a necesitar cuando este mandando a guardar los parametros que este enviando a los SP.
            DtParametros = new DataTable("SpParametros");
            DtParametros.Columns.Add("Nombre");
            DtParametros.Columns.Add("TipoDato");
            DtParametros.Columns.Add("Valor");

            NombreDB = "DB_BasePruebas";
        }
        #endregion


        #region Metodos Privados
        //Cada vez que ejecutemos estos procedimientos al ser por referencia, solo van a afectar al objeto en esa posicion de memoria.

        private void CrearConexionBaseDatos (ref ClsDataBase ObjDataBase)
        {
            switch (ObjDataBase.NombreDB)
            {
                //Creo conexion con base de datos, para hacerlo: clic derecho en AccesoDatos,Propiedades,Configuracion
                //y agregamos cadena de conexion, en otro case con su respectivo nombre de bdd.
                case "DB_BasePruebas":
                    ObjDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConexion_DB_BasePruebas);

                    break;
                default:
                    break;
            }
        }

        private void ValidarConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            //Verificar o validar si la bdd esta cerrada o abierta. Osea si esta abierta para que la cierre y viseversa.
            if(ObjDataBase._objSqlConnection.State == ConnectionState.Closed)
            {
                ObjDataBase.ObjSqlConnection.Open();

            } else
            {
                //cerrar
                ObjDataBase.ObjSqlConnection.Close();
                //quitar de memoria
                ObjDataBase.ObjSqlConnection.Dispose();

            }
        }

        private void AgregarParametros(ref ClsDataBase ObjDataBase)
        {
            //tipos de datos de sql server y del programa deben ser compatibles, se debe tener
            //cuidado a la hora de definirlos por la cantidad de memoria que vamos a utilizar.
            if (ObjDataBase.DtParametros != null)
            {
                //inicializamos un objeto para recorre la tabla e ir asignando el tipo de dato
                SqlDbType TipoDatoSQL = new SqlDbType();

                //validar las lineas de la tabla con un DataRow en la conexion tabla de parametros.
                //vamos a recorrer un switch
                foreach (DataRow item in ObjDataBase.DtParametros.Rows)
                {
                    //cuando mande un parametro, va a validar si esta vacia la tabla de parametros
                    //y sino, crea un tipo de dato y lo asigna segun el parametro que le pase
                    switch (item[1])
                    {
                        case "1":
                            TipoDatoSQL = SqlDbType.Bit;
                            break;
                        case "2":
                            TipoDatoSQL = SqlDbType.TinyInt;
                            break;
                        case "3":
                            TipoDatoSQL = SqlDbType.SmallInt;
                            break;
                        case "4":
                            TipoDatoSQL = SqlDbType.Int;
                            break;
                        case "5":
                            TipoDatoSQL = SqlDbType.BigInt;
                            break;
                        case "6":
                            TipoDatoSQL = SqlDbType.Decimal;
                            break;
                        case "7":
                            TipoDatoSQL = SqlDbType.SmallMoney;
                            break;
                        case "8":
                            TipoDatoSQL = SqlDbType.Money;
                            break;
                        case "9":
                            TipoDatoSQL = SqlDbType.Float;
                            break;
                        case "10":
                            TipoDatoSQL = SqlDbType.Real;
                            break;
                        case "11":
                            TipoDatoSQL = SqlDbType.Bit;
                            break;
                        case "12":
                            TipoDatoSQL = SqlDbType.Date;
                            break;
                        case "13":
                            TipoDatoSQL = SqlDbType.Time;
                            break;
                        case "14":
                            TipoDatoSQL = SqlDbType.SmallDateTime;
                            break;
                        case "15":
                            TipoDatoSQL = SqlDbType.Char;
                            break;
                        case "16":
                            TipoDatoSQL = SqlDbType.NChar;
                            break;
                        case "17":
                            TipoDatoSQL = SqlDbType.VarChar;
                            break;
                        case "18":
                            TipoDatoSQL = SqlDbType.NVarChar;
                            break;
                        case "19":
                            TipoDatoSQL = SqlDbType.Structured;
                            break;
                        default:
                            break;


                    }
                    //si es escalar lo enviamos a un sqlcommand, sino a un sqladapter
                    if (ObjDataBase.Scalar)
                    {
                        //si esta vacio, quiere decir que es null
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(),TipoDatoSQL).Value = DBNull.Value;
                        } else
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();

                        }
                    } else
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();

                        }

                    }
                }



            }
        }

        private void PrepararConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            CrearConexionBaseDatos (ref ObjDataBase);
            ValidarConexionBaseDatos(ref ObjDataBase);
        }

        private void EjecutarDataAdapter(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PrepararConexionBaseDatos (ref ObjDataBase);
                //le pasamos al dataAdapter el nombre del procedimiento y la conexion a la bdd.
                ObjDataBase.ObjSqlDataAdapter = new SqlDataAdapter(ObjDataBase.NombreSP,ObjDataBase.ObjSqlConnection);
                //le decimos al dataAdapter que le vamos a pasar un procedimiento almacenado.
                ObjDataBase.ObjSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametros(ref ObjDataBase);
                //Rellenamos los datos en la tabla.
                ObjDataBase.DsResultados = new DataSet();
                //a fill le pasamos el objeto para llenar la informacion y el nombre de la tabla.
                ObjDataBase.ObjSqlDataAdapter.Fill(ObjDataBase.DsResultados,ObjDataBase.NombreTabla);



            } 
            catch (Exception ex)
            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();
                
            } finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref ObjDataBase);
                }

            }

        }

        private void EjecutarCommand(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PrepararConexionBaseDatos(ref ObjDataBase);
                ObjDataBase.ObjSqlCommand = new SqlCommand(ObjDataBase.NombreSP, ObjDataBase.ObjSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                AgregarParametros(ref ObjDataBase);
                if (ObjDataBase.Scalar)
                {
                    ObjDataBase.ValorScalar = ObjDataBase.ObjSqlCommand.ExecuteScalar().ToString().Trim();

                } else
                {
                    ObjDataBase.ObjSqlCommand.ExecuteNonQuery();
                }


            } 
            catch (Exception ex)

            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();

            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref ObjDataBase);
                }

            }

        }

        public void SetTransaccion(ref ClsDataBase ObjDataBase)
        {
            _objSqlTransaction = ObjDataBase.ObjSqlConnection.BeginTransaction();
            this.ObjSqlCommand.Transaction = _objSqlTransaction;
        }

        public void ComitTransaccion()
        {
            ObjSqlTransaction.Commit();
        }

        public void TransaccionRollback()
        {
            ObjSqlTransaction.Rollback();
        }
        #endregion

        #region Metodos Publicos

        public void CRUD(ref ClsDataBase ObjDataBase)
        {
            if (ObjDataBase.Scalar)
            {
                EjecutarCommand(ref ObjDataBase);
                
                
            }
            else
            {
                EjecutarDataAdapter(ref ObjDataBase);
            }

        }

        #endregion
    }
}
