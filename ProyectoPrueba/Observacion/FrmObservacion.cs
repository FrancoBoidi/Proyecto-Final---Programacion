using Entidades.Empleado;
using Entidades.Observacion;
using LogicaNegocio.Empleado;
using LogicaNegocio.Observacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba.Observacion
{
    public partial class FrmObservacion : Form

    {
        private ClsObservacion ObjObservacion = null;
        private readonly ClsObservacionLn ObjObservacionLn = new ClsObservacionLn();

        private ClsEmpleado ObjEmpleado = null;
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();

       

        public FrmObservacion()
        {
            InitializeComponent();
            CargarComboBox();
            CargarListaObservacion();
        }

        private void CargarListaObservacion ()
        {
            //Inicializamos el objeto propietario
            ObjObservacion = new ClsObservacion();
            //llama al index de la clase de logica de negocio
            ObjObservacionLn.Index(ref ObjObservacion);
            if (ObjObservacion.MensajeError == null)
            {
                DgvObservacion.DataSource = ObjObservacion.DtResultados;


            }
            else
            {
                MessageBox.Show(ObjObservacion.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarComboBox()
        {
            //Inicializamos el objeto propietario
            ObjEmpleado = new ClsEmpleado();
            //llama al index de la clase de logica de negocio
            ObjEmpleadoLn.CargarCombo(ref ObjEmpleado);
            if (ObjEmpleado.MensajeError == null)
            {
                cbEmpleado.DataSource = ObjEmpleado.DtResultados;
                cbEmpleado.DisplayMember = "nombre";
                cbEmpleado.ValueMember = "legajo";
                int nro = 1;
                txtIdLegajo.Text = Convert.ToString(nro);

                


            }
            else
            {
                MessageBox.Show(ObjEmpleado.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ObjObservacion = new ClsObservacion()
            {
                Fecha = DtpFecha.Value,
                Descripcion = txtObservacion.Text,
                IdLegajo = Convert.ToInt32(txtIdLegajo.Text),
                


            };
            ObjObservacionLn.Agregar(ref ObjObservacion);

            if (ObjObservacion.MensajeError == null)
            {
                MessageBox.Show("El ID:" + ObjObservacion.ValorScalar + ", fue agregado correctamente.");
                CargarListaObservacion();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjObservacion.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpiar ()
        {
            txtObservacion.Text = "";
        }

        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdLegajo.Text=cbEmpleado.SelectedValue.ToString();   
        }

        private void DgvObservacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvObservacion.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjObservacion = new ClsObservacion()
                    {
                        IdObservacion = Convert.ToInt32(DgvObservacion.Rows[e.RowIndex].Cells["id_observacion"].Value.ToString())

                    };

                    lblIdObservacion.Text = ObjObservacion.IdObservacion.ToString();

                    ObjObservacionLn.Seleccionar(ref ObjObservacion);

                    DtpFecha.Value = ObjObservacion.Fecha;
                    txtObservacion.Text = ObjObservacion.Descripcion;
                    cbEmpleado.SelectedValue = ObjObservacion.IdLegajo;
                    

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObjObservacion = new ClsObservacion()
            {
                IdObservacion = Convert.ToInt32(lblIdObservacion.Text),
                Fecha = DtpFecha.Value,
                Descripcion = txtObservacion.Text,
                IdLegajo = Convert.ToInt32(txtIdLegajo.Text),


            };

            ObjObservacionLn.Modificar(ref ObjObservacion);

            if (ObjObservacion.MensajeError == null)
            {
                MessageBox.Show("El registro fue modificado correctamente.");
                CargarListaObservacion();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjObservacion.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjObservacion = new ClsObservacion()
            {
                IdObservacion = Convert.ToInt32(lblIdObservacion.Text)

            };



            ObjObservacionLn.Eliminar(ref ObjObservacion);

            if (ObjEmpleado.MensajeError == null)
            {
                MessageBox.Show("El registro fue eliminado correctamente.");
                CargarListaObservacion();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjObservacion.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
