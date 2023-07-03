using System;
using System.Data;

namespace Entidades.Observacion
{
    public class ClsObservacion
    {
        #region Atributos privados

        private int _idObservacion;
        private DateTime fecha;
        private string descripcion;
        private int idLegajo;

        private string mensajeError, valorScalar;
        private DataTable dtResultados;




        #endregion

        #region Atributos publicos 

        public int IdObservacion { get => _idObservacion; set => _idObservacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdLegajo { get => idLegajo; set => idLegajo = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }


        #endregion
    }
}
