using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Funcion
{
    public class ClsFuncion
    {
        #region Atributos privados

        private int _idFuncion;
        private string descripcion;

        private string mensajeError, valorScalar;
        private DataTable dtResultados;


        #endregion

        #region Atributos publicos

        public int IdFuncion { get => _idFuncion; set => _idFuncion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }


        #endregion


    }
}
