using Entidades.Empleado;
using Entidades.Observacion;
using Entidades.Propietario;
using Entidades.Proyecto;
using LogicaNegocio.Empleado;
using LogicaNegocio.Propietario;
using LogicaNegocio.Proyecto;
using ProyectoPrueba.Empleado;
using ProyectoPrueba.Principal;
using ProyectoPrueba.Tarea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba.Proyecto
{
    public partial class FrmProyecto : Form
    {
        private ClsProyecto ObjProyecto = null;
        private readonly ClsProyectoLn ObjProyectoLn = new ClsProyectoLn();

        private ClsEmpleado ObjEmpleado = null;
        private readonly ClsEmpleadoLn ObjEmpleadoLn = new ClsEmpleadoLn();

        private ClsPropietario ObjPropietario = null;
        private readonly ClsPropietarioLn ObjPropietarioLn = new ClsPropietarioLn();

        public FrmProyecto()
        {
            InitializeComponent();
            CargarListaProyecto();
            CargarComboBoxEmpledo();  
            CargarComboBoxPropietario();
        }

        private void CargarListaProyecto()
        {
            //Inicializamos el objeto propietario
            ObjProyecto = new ClsProyecto();
            //llama al index de la clase de logica de negocio
            ObjProyectoLn.Index(ref ObjProyecto);
            if (ObjProyecto.MensajeError == null)
            {
                DgvProyecto.DataSource = ObjProyecto.DtResultados;


            }
            else
            {
                MessageBox.Show(ObjProyecto.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxEmpledo()
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
                txtIdEmpleado.Text = Convert.ToString(nro);




            }
            else
            {
                MessageBox.Show(ObjEmpleado.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxPropietario()
        {
            //Inicializamos el objeto propietario
            ObjPropietario = new ClsPropietario();
            //llama al index de la clase de logica de negocio
            ObjPropietarioLn.CargarCombo(ref ObjPropietario);
            if (ObjPropietario.MensajeError == null)
            {
                cbPropietario.DataSource = ObjPropietario.DtResultados;
                cbPropietario.DisplayMember = "razon_social";
                cbPropietario.ValueMember = "id_propietario";
                int nro = 1;
                txtIdProp.Text = Convert.ToString(nro);
                

                




            }
            else
            {
                MessageBox.Show(ObjEmpleado.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DgvProyecto.CurrentRow != null)
            {
                DataGridViewRow row = DgvProyecto.CurrentRow;

                int id_proyecto = Convert.ToInt32(row.Cells["IdProyecto"].Value);

                
                FrmTarea frmTarea = new FrmTarea(id_proyecto);
                frmTarea.Show();
                


            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ObjProyecto = new ClsProyecto()
            {

                Nombre = txtNombre.Text,
                IdPropietario = Convert.ToInt32(txtIdProp.Text),
                IdLegajo = Convert.ToInt32(txtIdEmpleado.Text),
                Tiempo = Convert.ToInt32(txtTiempoEstP.Text),
                Monto = Convert.ToInt64(txtCostoEstP.Text),



            };
            ObjProyectoLn.Agregar(ref ObjProyecto);

            if (ObjProyecto.MensajeError == null)
            {
                MessageBox.Show("El ID:" + ObjProyecto.ValorScalar + ", fue agregado correctamente.");
                CargarListaProyecto();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjProyecto.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtCostoEstP.Text = "";
            txtTiempoEstP.Text = "";
        }

        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdEmpleado.Text = cbEmpleado.SelectedValue.ToString();
        }

        private void cbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdProp.Text = cbPropietario.SelectedValue.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObjProyecto = new ClsProyecto()
            {
                IdProyecto = Convert.ToInt32(lblIdProyecto.Text),
                Nombre = txtNombre.Text,
                IdPropietario = Convert.ToInt32(txtIdProp.Text),
                IdLegajo = Convert.ToInt32(txtIdEmpleado.Text),
                Tiempo = Convert.ToInt32(txtTiempoEstP.Text),
                Monto = Convert.ToDecimal(txtCostoEstP.Text),
               


            };

            ObjProyectoLn.Modificar(ref ObjProyecto);

            if (ObjProyecto.MensajeError == null)
            {
                MessageBox.Show("El registro fue modificado correctamente.");
                CargarListaProyecto();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjProyecto.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvProyecto.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjProyecto = new ClsProyecto()
                    {
                        IdProyecto = Convert.ToInt32(DgvProyecto.Rows[e.RowIndex].Cells["id_proyecto"].Value.ToString())

                    };

                    lblIdProyecto.Text = ObjProyecto.IdProyecto.ToString();

                    ObjProyectoLn.Seleccionar(ref ObjProyecto);

                    
                    txtNombre.Text = ObjProyecto.Nombre;
                    cbPropietario.SelectedValue = ObjProyecto.IdLegajo;
                    cbEmpleado.SelectedValue = ObjProyecto.IdLegajo;
                    txtTiempoEstP.Text = ObjProyecto.Tiempo.ToString();
                    txtCostoEstP.Text = ObjProyecto.Monto.ToString();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjProyecto = new ClsProyecto()
            {
                IdProyecto = Convert.ToInt32(lblIdProyecto.Text)

            };



            ObjProyectoLn.Eliminar(ref ObjProyecto);

            if (ObjProyecto.MensajeError == null)
            {
                MessageBox.Show("Si el registro no contenia tareas fue eliminado correctamente.");
                CargarListaProyecto();
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjProyecto.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            FrmPropietario frmPropietario = new FrmPropietario();
            frmPropietario.Show();

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.Show();
        }
    }
}
