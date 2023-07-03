using System;
using System.Data;

namespace Entidades.Tarea
{
    public class ClsTarea
    {
        #region Atributos privados

        private int _idProyecto;
        private int _idTarea;
        private string descripcion;
        private int horasEst;
        private decimal montoEst;
        private int horasReal;
        private decimal montoReal;
        private DateTime fechaFinal;
        private int estado;

        //atrinutos de manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;


        #endregion

        #region Atributos publicos

        public int IdProyecto { get => _idProyecto; set => _idProyecto = value; }
        public int IdTarea { get => _idTarea; set => _idTarea = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int HorasEst { get => horasEst; set => horasEst = value; }
        public decimal MontoEst { get => montoEst; set => montoEst = value; }
        public int HorasReal { get => horasReal; set => horasReal = value; }
        public decimal MontoReal { get => montoReal; set => montoReal = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        public int Estado { get => estado; set => estado = value; }


        #endregion

    }
}
