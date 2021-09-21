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
            int tam_list = PersonaRecibe.Count();
            string dato = txtdato.Text.Trim();
            for (int i = 0; i < tam_list; i++)
            {
                if (PersonaRecibe[i].Nombre == dato)
                {
                    PersonaBusqueda.Add(PersonaRecibe[i]);                 
                }
                dgvInfo.DataSource = PersonaBusqueda;
            }
        }
        public void BuscarTelefono()
        {
            PersonaBusqueda.Clear();
            dgvInfo.DataSource = null;
            int tam_list = PersonaRecibe.Count();
            string dato = txtdato.Text.Trim();
            for (int i = 0; i < tam_list; i++)
            {
                if (PersonaRecibe[i].Telefono == dato)
                {
                    PersonaBusqueda.Add(PersonaRecibe[i]);
                }
                dgvInfo.DataSource = PersonaBusqueda;
            }
        }
        public void BuscarApellido()
        {
            PersonaBusqueda.Clear();
            dgvInfo.DataSource = null;
            int tam_list = PersonaRecibe.Count();
            string dato = txtdato.Text.Trim();
            for (int i = 0; i < tam_list; i++)
            {
                if (PersonaRecibe[i].Apellido == dato)
                {
                    PersonaBusqueda.Add(PersonaRecibe[i]);
                }
                dgvInfo.DataSource = PersonaBusqueda;
            }
        }
    }
}
