using Entidades.Empleado;
using Entidades.Propietario;
using LogicaNegocio.Empleado;
using LogicaNegocio.Propietario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba.Empleado
{
    public partial class FrmEmpleado : Form
    {
        private ClsEmpleado ObjEmpleado = null;
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();
        public FrmEmpleado()
        {
            InitializeComponent();
            CargarListaEmpleado();

        }

        private void CargarListaEmpleado()
        {
            //Inicializamos el objeto propietario
            ObjEmpleado = new ClsEmpleado();
            //llama al index de la clase de logica de negocio
            ObjEmpleadoLn.Index(ref ObjEmpleado);
            if (ObjEmpleado.MensajeError == null)
            {
                DgvEmpleado.DataSource = ObjEmpleado.DtResultados;


            }
            else
            {
                MessageBox.Show(ObjEmpleado.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           ObjEmpleado = new ClsEmpleado()
            {
                FechaNac = DtpFecha.Value,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Contacto = txtContacto.Text,
                Email = txtEmail.Text,


            };
            ObjEmpleadoLn.Agregar(ref ObjEmpleado);

            if (ObjEmpleado.MensajeError == null)
            {
                MessageBox.Show("El ID:" + ObjEmpleado.ValorScalar + ", fue agregado correctamente.");
                CargarListaEmpleado();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjEmpleado.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtContacto.Text = "";
            txtEmail.Text = "";

        }

        private void DgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvEmpleado.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjEmpleado = new ClsEmpleado()
                    {
                        IdLegajo = Convert.ToInt32(DgvEmpleado.Rows[e.RowIndex].Cells["legajo"].Value.ToString())

                    };

                    lblIdEmpleado.Text = ObjEmpleado.IdLegajo.ToString();

                    ObjEmpleadoLn.Seleccionar(ref ObjEmpleado);

                    DtpFecha.Value = ObjEmpleado.FechaNac;
                    txtNombre.Text = ObjEmpleado.Nombre;
                    txtApellido.Text = ObjEmpleado.Apellido;
                    txtContacto.Text = ObjEmpleado.Contacto;
                    txtEmail.Text = ObjEmpleado.Email;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObjEmpleado = new ClsEmpleado()
            {
                IdLegajo = Convert.ToInt32(lblIdEmpleado.Text),
                FechaNac = DtpFecha.Value,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Contacto = txtContacto.Text,
                Email = txtEmail.Text,


            };

            ObjEmpleadoLn.Modificar(ref ObjEmpleado);

            if (ObjEmpleado.MensajeError == null)
            {
                MessageBox.Show("El registro fue modificado correctamente.");
                CargarListaEmpleado();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjEmpleado.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjEmpleado = new ClsEmpleado()
            {
                IdLegajo = Convert.ToInt32(lblIdEmpleado.Text)

            };



            ObjEmpleadoLn.Eliminar(ref ObjEmpleado);

            if (ObjEmpleado.MensajeError == null)
            {
                MessageBox.Show("El registro fue eliminado correctamente.");
                CargarListaEmpleado();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjEmpleado.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
