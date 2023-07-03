using Entidades.Propietario;
using LogicaNegocio.Propietario;
using System;
using System.Windows.Forms;

namespace ProyectoPrueba.Principal
{
    public partial class FrmPropietario : Form
    {
        private ClsPropietario ObjPropietario = null;
        private readonly ClsPropietarioLn ObjPropietarioLn = new ClsPropietarioLn();
        public FrmPropietario()
        {
            InitializeComponent();
            CargarListaPropietario();
        }

        //DataTimePicker para agregar campo sobre la fecha de nacimiento

        private void CargarListaPropietario()
        {
            //Inicializamos el objeto propietario
            ObjPropietario = new ClsPropietario();
            //llama al index de la clase de logica de negocio
            ObjPropietarioLn.Index (ref ObjPropietario);
            if (ObjPropietario.MensajeError == null)
            {
                DgvPropietario.DataSource = ObjPropietario.DtResultados;


            } else
            {
                MessageBox.Show(ObjPropietario.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ObjPropietario = new ClsPropietario()
            {
                IdPropietario = Convert.ToInt32(lblIdProp.Text),
                RazonSocial = txtRznSoc.Text,
                Telefono = txtTel.Text,
                Email = txtEmail.Text,
                Cuit = Convert.ToInt64(txtCuit.Text),
                Contacto = txtContacto.Text,


            };

            ObjPropietarioLn.Modificar(ref ObjPropietario);

            if (ObjPropietario.MensajeError == null)
            {
                MessageBox.Show("El registro fue modificado correctamente.");
                CargarListaPropietario();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjPropietario.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //objeto que le vmaos a pasar al metodo crear
            ObjPropietario = new ClsPropietario()
            {
                RazonSocial = txtRznSoc.Text,
                Telefono = txtTel.Text,
                Email = txtEmail.Text,
                Cuit = Convert.ToInt64(txtCuit.Text),
                Contacto = txtContacto.Text,


            };
            ObjPropietarioLn.Agregar(ref ObjPropietario);

            if (ObjPropietario.MensajeError == null)
            {
                MessageBox.Show("El ID:" + ObjPropietario.ValorScalar + ", fue agregado correctamente.");
                CargarListaPropietario();
                Limpiar();
                    

            } else
            {
                MessageBox.Show(ObjPropietario.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpiar()
        {
            txtRznSoc.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtCuit.Text = "";
            txtContacto.Text = "";
        }

        private void DgvPropietario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvPropietario.Columns[e.ColumnIndex].Name=="Editar")
                {
                    ObjPropietario = new ClsPropietario()
                    {
                        IdPropietario = Convert.ToInt32(DgvPropietario.Rows[e.RowIndex].Cells["id_propietario"].Value.ToString())

                    };

                    lblIdProp.Text = ObjPropietario.IdPropietario.ToString();

                    ObjPropietarioLn.Seleccionar(ref ObjPropietario);

                    txtRznSoc.Text = ObjPropietario.RazonSocial;
                    txtTel.Text = ObjPropietario.Telefono;
                    txtEmail.Text= ObjPropietario.Email;
                    txtCuit.Text = ObjPropietario.Cuit.ToString();
                    txtContacto.Text=ObjPropietario.Contacto;

                }
            } catch (Exception ex)
            {
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjPropietario = new ClsPropietario()
            {
                IdPropietario = Convert.ToInt32(lblIdProp.Text)

            };

            

            ObjPropietarioLn.Eliminar(ref ObjPropietario);

            if (ObjPropietario.MensajeError == null)
            {
                MessageBox.Show("El registro fue eliminado correctamente.");
                CargarListaPropietario();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjPropietario.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
