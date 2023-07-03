using Entidades.Empleado;
using Entidades.Funcion;
using LogicaNegocio.Empleado;
using LogicaNegocio.Funcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba.Funcion
{
    public partial class FrmFuncion : Form
    {
        private ClsFuncion ObjFuncion = null;
        private readonly ClsFuncionLn ObjFuncionLn = new ClsFuncionLn();
        public FrmFuncion()
        {
            InitializeComponent();
            CargarListaFuncion();
        }

        private void CargarListaFuncion()
        {
            //Inicializamos el objeto propietario
            ObjFuncion = new ClsFuncion();
            //llama al index de la clase de logica de negocio
            ObjFuncionLn.Index(ref ObjFuncion);
            if (ObjFuncion.MensajeError == null)
            {
                DgvFuncion.DataSource = ObjFuncion.DtResultados;


            }
            else
            {
                MessageBox.Show(ObjFuncion.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ObjFuncion = new ClsFuncion()
            { 
                Descripcion = txtFuncion.Text,
               
            };

            ObjFuncionLn.Agregar(ref ObjFuncion);

            if (ObjFuncion.MensajeError == null)
            {
                MessageBox.Show("El ID:" + ObjFuncion.ValorScalar + ", fue agregado correctamente.");
                CargarListaFuncion();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjFuncion.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpiar()
        {
            txtFuncion.Text = "";

        }

        private void DgvFuncion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvFuncion.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjFuncion = new ClsFuncion()
                    {
                        IdFuncion = Convert.ToInt32(DgvFuncion.Rows[e.RowIndex].Cells["id_funcion"].Value.ToString())

                    };

                    lblIdFuncion.Text = ObjFuncion.IdFuncion.ToString();

                    ObjFuncionLn.Seleccionar(ref ObjFuncion);

                    
                    txtFuncion.Text = ObjFuncion.Descripcion;
                    

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjFuncion = new ClsFuncion()
            {
                IdFuncion = Convert.ToInt32(lblIdFuncion.Text)

            };



            ObjFuncionLn.Eliminar(ref ObjFuncion);

            if (ObjFuncion.MensajeError == null)
            {
                MessageBox.Show("El registro fue eliminado correctamente.");
                CargarListaFuncion();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjFuncion.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            ObjFuncion = new ClsFuncion()
            {
                IdFuncion = Convert.ToInt32(lblIdFuncion.Text),

                Descripcion = txtFuncion.Text,

            };

            ObjFuncionLn.Modificar(ref ObjFuncion);

            if (ObjFuncion.MensajeError == null)
            {
                MessageBox.Show("El registro fue modificado correctamente.");
                CargarListaFuncion();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjFuncion.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
