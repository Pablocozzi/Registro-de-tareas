using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroTareas.pry
{
    public partial class frmRegistroTareas : Form
    {
        public frmRegistroTareas()
        {
            InitializeComponent();
        }

        clsTareas tareas = new clsTareas();

        private void btnTarea_Click(object sender, EventArgs e)
        {
            tareas.Estado = cmbNueva.SelectedItem.ToString();
            tareas.Tarea = txtTarea.Text;
            tareas.Fecha = dtpNueva.Value.Date;
            tareas.Agregar(dgvTareas);
            txtTarea.Text = "";
            cmbNueva.SelectedIndex = 0;
            dtpNueva.Value = DateTime.Today.Date ;
            btnBuscarFechas.Enabled= true;
            btnListar.Enabled= true;
            btnUnaFecha.Enabled= true;

        }

        private void frmRegistroTareas_Load(object sender, EventArgs e)
        {        
            cmbNueva.Items.Add("Pendiente");
            cmbNueva.Items.Add("En proceso");
            cmbNueva.Items.Add("Completada");
            cmbNueva.SelectedIndex = 0;
            cmbEntreFechas.Items.Add("Pendiente");
            cmbEntreFechas.Items.Add("En proceso");
            cmbEntreFechas.Items.Add("Completada");
            cmbEntreFechas.SelectedIndex = 0;
            cmbFecha.Items.Add("Pendiente");
            cmbFecha.Items.Add("En proceso");
            cmbFecha.Items.Add("Completada");    
            cmbFecha.SelectedIndex = 0;
        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {
            if (txtTarea.Text != "")
            {
                btnTarea.Enabled = true;
            } 
            else if (txtTarea.Text == "")
            {
                btnTarea.Enabled = false;
            }
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {    
            tareas.Desde=dtpDesde.Value.Date;
            tareas.Hasta=dtpHasta.Value.Date;
            tareas.EstadoRango= cmbEntreFechas.SelectedItem.ToString();
            tareas.RangoFechas(dgvTareas);
            if (dgvTareas.Rows.Count == 0)
            {
                MessageBox.Show("No existen datos");

            }
            cmbEntreFechas.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Today.Date;
            dtpHasta.Value = DateTime.Today.Date;
        }

        private void btnUnaFecha_Click_1(object sender, EventArgs e)
        {
            tareas.Unica = dtpUnaFecha.Value.Date;
            tareas.EstadoUnicaFecha = cmbFecha.SelectedItem.ToString();
            tareas.UnaFecha(dgvTareas);
            if (dgvTareas.Rows.Count == 0)
            {
                MessageBox.Show("No existen datos");

            }
            cmbFecha.SelectedIndex = 0;
            dtpUnaFecha.Value = DateTime.Today.Date;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            tareas.Listar(dgvTareas);
            if(dgvTareas.Rows.Count == 0) 
            {
                MessageBox.Show("No existen datos");

            }
        }
    }
}
