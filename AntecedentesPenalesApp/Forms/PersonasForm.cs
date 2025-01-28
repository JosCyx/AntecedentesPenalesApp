using AntecedentesPenalesApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntecedentesPenalesApp.Models;

namespace AntecedentesPenalesApp.Forms
{
    public partial class PersonasForm : Form
    {

        private readonly AntecedentesService _antecedentesService;
        public PersonasForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            _antecedentesService = new AntecedentesService();

            panelConsultaPersonas.Parent = this;
            panelDatosPersonas.Parent = this;

            panelConsultaPersonas.Visible = true;
            panelDatosPersonas.Visible = false;
        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {
            CargarPersonasdata();
            CargarProvincias();
        }

        private void CargarPersonasdata()
        {
            //consultar todas las personas registradas 
            DataTable resultados = _antecedentesService.BuscarPersonasAll();
            DataGridView dgvResultados = dataGridViewPersonas as DataGridView;
            if (resultados.Rows.Count > 0)
            {
                dgvResultados.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("No se encontraron registros de personas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarProvincias()
        {
            //consultar provincias registradas
            DataTable provincias = _antecedentesService.ObtenerProvincias();

            if (provincias.Rows.Count > 0)
            {
                // Configurar el ComboBox para mostrar nombres y asociar IDs
                comboBoxProvinciaPersonas.DisplayMember = "Nombre"; // Nombre de la provincia
                comboBoxProvinciaPersonas.ValueMember = "ProvinciaID"; // ID de la provincia
                comboBoxProvinciaPersonas.DataSource = provincias; // Asignar el origen de datos
            }
            else
            {
                MessageBox.Show("No se encontraron provincias en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClearForm()
        {
            dataGridViewPersonas.DataSource = null;

            textCedulaPersonas.Text = "";
            textNombresPersonas.Text = "";
            textApellidosPersonas.Text = "";
            datePickerNacimientoPersonas.Value = DateTime.Now;
            comboBoxProvinciaPersonas.SelectedIndex = 0;
        }

        private void dataGridViewPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            //consultar los datos de la persona seleccionada
            string cedula = dataGridViewPersonas.Rows[index].Cells[0].Value.ToString();
            Console.WriteLine("Celda seleccionada " + cedula);

            //cargar los datos de la persona en los campos del formulario
            Persona persona = _antecedentesService.BuscarPersonabyCedula(cedula);
            if (persona != null)
            {
                textCedulaPersonas.Text = persona.Cedula;
                textNombresPersonas.Text = persona.Nombres;
                textApellidosPersonas.Text = persona.Apellidos;
                datePickerNacimientoPersonas.Value = persona.FechaNacimiento;
                comboBoxProvinciaPersonas.SelectedValue = persona.ProvinciaID;

                //cambiar de panel cuando ya esten cargados los datos
                panelConsultaPersonas.Visible = false;
                panelDatosPersonas.Visible = true;
            }
            else
            {
                MessageBox.Show("No se encontraron registros de personas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonRegistrarPersona_Click(object sender, EventArgs e)
        {
            //cambia de panel y limpia el formulario
            panelConsultaPersonas.Visible = false;
            panelDatosPersonas.Visible = true;

            ClearForm();
        }

        private void buttonGuardarPersonas_Click(object sender, EventArgs e)
        {
            //messagebox de confirmacion
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //validaciones

            //guardar las modificaciones de la persona o registrar una nueva
            Persona persona = new Persona();

            persona.Cedula = textCedulaPersonas.Text;
            persona.Nombres = textNombresPersonas.Text;
            persona.Apellidos = textApellidosPersonas.Text;
            persona.FechaNacimiento = datePickerNacimientoPersonas.Value;
            persona.ProvinciaID = (int)comboBoxProvinciaPersonas.SelectedValue;

            // Registrar la persona
            bool registroExitoso = _antecedentesService.RegistrarPersona(persona);

            if (registroExitoso)
            {
                MessageBox.Show("Se han guardado los cambios correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                //salir del panel de datos de personas
                CargarPersonasdata();
                panelConsultaPersonas.Visible = true;
                panelDatosPersonas.Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSalirPersonas_Click(object sender, EventArgs e)
        {
            //salir del panel de datos de personas
            panelConsultaPersonas.Visible = true;
            panelDatosPersonas.Visible = false;

            ClearForm();
            CargarPersonasdata();
        }

        private void panelDatosPersonas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
