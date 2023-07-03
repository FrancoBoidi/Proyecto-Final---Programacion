using ProyectoPrueba.Empleado;
using ProyectoPrueba.Funcion;
using ProyectoPrueba.Observacion;
using ProyectoPrueba.Principal;
using ProyectoPrueba.Proyecto;
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

namespace ProyectoPrueba.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            FrmProyecto frmProyecto = new FrmProyecto();
            frmProyecto.Show();
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            FrmPropietario frmPropietario = new FrmPropietario();
            frmPropietario.Show();

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.Show();

        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            FrmFuncion frmFuncion = new FrmFuncion();
            frmFuncion.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmObservacion frmObservacion = new FrmObservacion();
            frmObservacion.Show();

        }
    }
}
