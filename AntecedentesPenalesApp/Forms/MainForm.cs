using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntecedentesPenalesApp.Business;

namespace AntecedentesPenalesApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly AuxiliarClass _auxiliarClass = new AuxiliarClass();
        public MainForm()
        {
            InitializeComponent();

            LoginPanel.Parent = this;
            MainPanel.Parent = this;

            LoginPanel.Visible = true;
            MainPanel.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            loginPicture.Focus();
        }

        private void buttonPersonas_Click(object sender, EventArgs e)
        {
            _auxiliarClass.LoadModule(new PersonasForm(), ModulePanel);
        }

        private void buttonProvincias_Click(object sender, EventArgs e)
        {
            _auxiliarClass.LoadModule(new ProvinciasForm(), ModulePanel);
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            _auxiliarClass.LoadModule(new AntecedentesForm(), ModulePanel);
        }

        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ModulePanel.Controls.Clear();

            //limpiar campos del formulario de antecedentes
            AntecedentesForm antecedentesForm = new AntecedentesForm();
            antecedentesForm.ClearForm();

            //limpiar campos del formulario de personas

            //limpiar campos del formulario de provincias

            LoginPanel.Visible = true;
            MainPanel.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void contraseniaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = usuarioTxt.Text;
            string password = contraseniaTxt.Text;

            if (username == "admin" && password == "admin") 
            {
                LoginPanel.Visible = false;
                MainPanel.Visible = true;

                usuarioTxt.Clear();
                contraseniaTxt.Clear();

                //cargar el modulo de antecedentes
                _auxiliarClass.LoadModule(new AntecedentesForm(), ModulePanel);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpiar campos
                usuarioTxt.Text = "Ingrese su usuario";
                contraseniaTxt.Text = "Ingrese su contraseña";
            }
        }

        private void usuarioTxt_Enter(object sender, EventArgs e)
        {
            if(usuarioTxt.Text == "Ingrese su usuario")
            {
               usuarioTxt.Clear();
            }
        }

        private void contraseniaTxt_Enter(object sender, EventArgs e)
        {
            if (contraseniaTxt.Text == "Ingrese su contraseña")
            {
                contraseniaTxt.Clear();
            }
        }
    }
}
