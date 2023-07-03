using Entidades.Empleado;
using Entidades.Propietario;
using Entidades.Proyecto;
using Entidades.Tarea;
using LogicaNegocio.Proyecto;
using LogicaNegocio.Tarea;
using ProyectoPrueba.Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba.Tarea
{
    public partial class FrmTarea : Form
    {
        private ClsTarea ObjTarea = null;
        private readonly ClsTareaLn ObjTareaLn = new ClsTareaLn();

        private ClsProyecto ObjProyecto = null;
        private readonly ClsProyectoLn ObjProyectoLn = new ClsProyectoLn();
        public FrmTarea(int id_proyecto)
        {
            InitializeComponent();
            
            CargarListaPrevia(id_proyecto);

            txtIdProyecto.Text = Convert.ToString(id_proyecto);
        }

        private void CargarListaPrevia (int id_proyecto)
        {
            //Inicializamos el objeto propietario
            ObjTarea = new ClsTarea()
            {
                IdProyecto = id_proyecto

            };

            id_proyecto = ObjTarea.IdProyecto;
            //llama al index de la clase de logica de negocio
            ObjTareaLn.Index(ref ObjTarea);
            if (ObjTarea.MensajeError == null)
            {
                DgvTarea.DataSource = ObjTarea.DtResultados;


            }
            else
            {
                MessageBox.Show(ObjTarea.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            ObjTarea = new ClsTarea()
            {
                IdProyecto = Convert.ToInt32(txtIdProyecto.Text),
                Descripcion = txtDescrip.Text,
                HorasEst = Convert.ToInt32(txtHorasEst.Text),
                MontoEst = Convert.ToInt64(txtCostoEst.Text),
                FechaFinal = DtpFecha.Value,
                Estado = Convert.ToInt32(txtEstado.Text),



            };
            ObjTareaLn.Agregar(ref ObjTarea);
            int id = Convert.ToInt32(txtIdProyecto.Text);

            if (ObjTarea.MensajeError == null)
            {
                MessageBox.Show("El ID:" + ObjTarea.ValorScalar + ", fue agregado correctamente.");
                CargarListaPrevia(id);
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjTarea.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpiar ()
        {
            txtDescrip.Text = "";
            txtHorasEst.Text = "";
            txtCostoEst.Text = "";
            txtHorasReal.Text = "";
            txtCostoReal.Text = "";
            txtEstado.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmProyecto frmProyecto = new FrmProyecto();
            frmProyecto.Show();
        }

        private void DgvTarea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvTarea.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjTarea = new ClsTarea()
                    {
                        IdTarea = Convert.ToInt32(DgvTarea.Rows[e.RowIndex].Cells["nro_tarea"].Value.ToString())

                    };

                    lblIdTarea.Text = ObjTarea.IdTarea.ToString();

                    ObjTareaLn.Seleccionar(ref ObjTarea);

                    txtIdProyecto.Text = ObjTarea.IdProyecto.ToString();
                    txtDescrip.Text = ObjTarea.Descripcion;
                    txtHorasEst.Text = ObjTarea.HorasEst.ToString();
                    txtCostoEst.Text = ObjTarea.MontoEst.ToString();
                    txtHorasReal.Text = ObjTarea.HorasReal.ToString();
                    txtCostoReal.Text = ObjTarea.MontoReal.ToString();
                    DtpFecha.Value = ObjTarea.FechaFinal;
                    txtEstado.Text = ObjTarea.Estado.ToString();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObjTarea = new ClsTarea()
            {
                IdTarea = Convert.ToInt32(lblIdTarea.Text),
                IdProyecto = Convert.ToInt32(txtIdProyecto.Text),
                Descripcion = txtDescrip.Text,
                HorasEst = Convert.ToInt32(txtHorasEst.Text),
                MontoEst = Convert.ToDecimal(txtCostoEst.Text),
                FechaFinal = DtpFecha.Value,
                Estado = Convert.ToInt32(txtEstado.Text),




            };

            ObjTareaLn.Modificar(ref ObjTarea);
            int id = Convert.ToInt32(txtIdProyecto.Text);

            if (ObjTarea.MensajeError == null)
            {
                MessageBox.Show("El registro fue modificado correctamente.");
                CargarListaPrevia(id);
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjTarea.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarTarea_Click(object sender, EventArgs e)
        {
            ObjTarea = new ClsTarea()
            {
                IdTarea = Convert.ToInt32(lblIdTarea.Text),
                IdProyecto = Convert.ToInt32(txtIdProyecto.Text),
                Descripcion = txtDescrip.Text,
                HorasEst = Convert.ToInt32(txtHorasEst.Text),
                MontoEst = Convert.ToDecimal(txtCostoEst.Text),
                HorasReal = Convert.ToInt32(txtHorasReal.Text),
                MontoReal = Convert.ToDecimal(txtCostoReal.Text),
                FechaFinal = DtpFecha.Value,
                Estado = Convert.ToInt32(txtEstado.Text),




            };

            ObjTareaLn.Modificar(ref ObjTarea);
            int id = Convert.ToInt32(txtIdProyecto.Text);

            if (ObjTarea.MensajeError == null)
            {
                MessageBox.Show("El registro fue cerrado correctamente.");
                CargarListaPrevia(id);
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjTarea.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjTarea = new ClsTarea()
            {
                IdTarea = Convert.ToInt32(lblIdTarea.Text)

            };



            ObjTareaLn.Eliminar(ref ObjTarea);
            int id = Convert.ToInt32(txtIdProyecto.Text);

            if (ObjTarea.MensajeError == null)
            {
                MessageBox.Show("El registro fue eliminado correctamente.");
                CargarListaPrevia(id);
                Limpiar();


            }
            else
            {
                MessageBox.Show(ObjTarea.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
