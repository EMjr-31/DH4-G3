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
    }
}
