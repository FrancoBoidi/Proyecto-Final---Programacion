using System.Data;

namespace Entidades.Proyecto
{
    public class ClsProyecto
    {
        #region Atributos privados
        private int _idProyecto;
        private string nombre;
        private decimal monto;
        private int tiempo;
        private int idPropietario;
        private int idLegajo;

        //atrinutos de manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;

        #endregion

        #region Atributos publicos

        public int IdProyecto { get => _idProyecto; set => _idProyecto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public int Tiempo { get => tiempo; set => tiempo = value; }
        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public int IdLegajo { get => idLegajo; set => idLegajo = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }

        #endregion
    }
}
