using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_G3
{
    public partial class Form1 : Form
    {
        private List<Persona> Personas = new List<Persona>();
        private int edit_indice = -1;
        public Form1()
        {
            InitializeComponent();
        }
        private void actualizarGrip() {
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = Personas;
        }
        private void limpiar(){
            txtNombre.Clear();
            txtApellido.Clear();
            txtTel.Clear();
            txtCorreo.Clear();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();

            per.Nombre = txtNombre.Text.Trim();
            per.Apellido= txtApellido.Text.Trim();
            per.Telefono = txtTel.Text.Trim();
            per.Correo=txtCorreo.Text.Trim();

            if (edit_indice > -1)
            {
                Personas[edit_indice] = per;
                edit_indice = -1;
            }
            else {
                Personas.Add(per);
            }
            actualizarGrip();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                Personas.RemoveAt(edit_indice);
                edit_indice= - 1;
                actualizarGrip();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Contacto");
            }
        }

        private void dgvContactos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgvContactos.SelectedRows[0];
            int pos = dgvContactos.Rows.IndexOf(seleccion);
            edit_indice = pos;

            Persona per = Personas[pos];

            txtNombre.Text = per.Nombre;
            txtApellido.Text = per.Apellido;
            txtTel.Text = per.Telefono;
            txtCorreo.Text = per.Correo;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FRecibe form = new FRecibe();
            form.PersonaRecibe = Personas;
            form.Show();
        }
    }
}
