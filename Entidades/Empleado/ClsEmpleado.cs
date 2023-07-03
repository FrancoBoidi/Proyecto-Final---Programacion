using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Empleado
{
    public class ClsEmpleado
    {
        #region Atributos privados
        private int _idLegajo;
        private DateTime fechaNac;
        private string nombre;
        private string apellido;
        private string contacto;
        private string email;
        

        //atrinutos de manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;

        #endregion

        #region Atributos publicos

        public int IdLegajo { get => _idLegajo; set => _idLegajo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }

        #endregion

    }
}
