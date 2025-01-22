using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntecedentesPenalesApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPersonas_Click(object sender, EventArgs e)
        {
            LoadModule(new PersonasForm());
        }

        private void buttonProvincias_Click(object sender, EventArgs e)
        {
            LoadModule(new ProvinciasForm());
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            LoadModule(new AntecedentesForm());
        }

        private void LoadModule(Form moduleForm)
        {
            // Limpia el panel
            panel2.Controls.Clear();

            // Configura el formulario para que se muestre dentro del panel
            moduleForm.TopLevel = false;
            moduleForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(moduleForm);
            moduleForm.Show();
        }
    }
}
