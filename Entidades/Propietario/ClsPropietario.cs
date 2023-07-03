using System;
using System.Data;

namespace Entidades.Propietario
{
    public class ClsPropietario
    {
        #region Atributos privados
        private int _idPropietario;
        private string razonSocial;
        private string telefono;
        private string email;
        //ver si lo convierte a bigint en base de datos
        private long cuit;
        private string contacto;

        //atrinutos de manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;


        #endregion

        #region Atributos publicos
        public int IdPropietario { get => _idPropietario; set => _idPropietario = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public long Cuit { get => cuit; set => cuit = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }

        


        #endregion

    }
}
