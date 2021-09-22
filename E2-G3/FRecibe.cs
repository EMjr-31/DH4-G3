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
    public partial class FRecibe : Form
    {
        public List<Persona> PersonaRecibe = null;

        public FRecibe()
        {
            InitializeComponent();
        }
        private void actualizarGrid() {
            dgvInfo.DataSource = null;
            dgvInfo.DataSource = PersonaRecibe;
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbtnNombre.Checked == true)
            {
                BuscarNombre();
            }
            if (rbtnApellido.Checked == true)
            {
                BuscarApellido();
            }
            if (rbtnTelefono.Checked == true)
            {
                BuscarTelefono();
            }
        }
        //Funcion busqueda por nombre
        List<Persona> PersonaBusqueda = new List<Persona>();
        public void BuscarNombre()
        {
            PersonaBusqueda.Clear();
            dgvInfo.DataSource = null;
            string dato = txtdato.Text.Trim();
            dgvInfo.DataSource = PersonaRecibe.FindAll(p => p.Nombre.StartsWith(dato));

        }
        public void BuscarTelefono()
        {
            PersonaBusqueda.Clear();
            dgvInfo.DataSource = null;
            string dato = txtdato.Text.Trim();
            dgvInfo.DataSource = PersonaRecibe.FindAll(p => p.Telefono.StartsWith(dato));

        }
        public void BuscarApellido()
        {
            PersonaBusqueda.Clear();
            dgvInfo.DataSource = null;
            string dato = txtdato.Text.Trim();
            dgvInfo.DataSource = PersonaRecibe.FindAll(p => p.Apellido.StartsWith(dato));

        }
    }
}
