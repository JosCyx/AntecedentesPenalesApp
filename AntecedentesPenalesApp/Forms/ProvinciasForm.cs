using AntecedentesPenalesApp.Business;
using AntecedentesPenalesApp.Models;
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
    public partial class ProvinciasForm : Form
    {

        private readonly AntecedentesService _antecedentesService;
        public ProvinciasForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            _antecedentesService = new AntecedentesService();

            panelProvConsultas.Parent = this;
            panelDatosProvincias.Parent = this;

            panelProvConsultas.Visible = true;
            panelDatosProvincias.Visible = false;
        }

        private void ProvinciasForm_Load(object sender, EventArgs e)
        {
            CargarProvincias();
        }

        private void CargarProvincias()
        {
            DataTable resultados = _antecedentesService.BuscarProvincias();
            DataGridView dgvResultados = dataGridViewProvincias as DataGridView;
            if (resultados.Rows.Count > 0)
            {
                dgvResultados.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("No se encontraron registros de provincias.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearForm() 
        {
            dataGridViewProvincias.DataSource = null;

            textNombreProvincia.Clear();
            textBoxCodigoProvincia.Clear();
            textBoxTablaProvincia.Clear();
        }

        private void buttonRegistrarPersona_Click(object sender, EventArgs e)
        {
            //cambia de panel y limpia el formulario
            panelProvConsultas.Visible = false;
            panelDatosProvincias.Visible = true;

            ClearForm();
        }

        private void buttonSalirProvincias_Click(object sender, EventArgs e)
        {
            //salir del panel de datos de personas
            panelProvConsultas.Visible = true;
            panelDatosProvincias.Visible = false;

            ClearForm();
            CargarProvincias();
        }

        private void buttonGuardarProvincias_Click(object sender, EventArgs e)
        {
            //messagebox de confirmacion
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //validaciones

            //guardar las modificaciones de la provincia o registrar una nueva
            Provincia provincia = new Provincia();

            provincia.NombreProvincia = textNombreProvincia.Text;
            provincia.CodigoProvincia = textBoxCodigoProvincia.Text;
            provincia.TablaProvincia = textBoxTablaProvincia.Text;

            // Registrar la persona
            bool registroExitoso = _antecedentesService.InsertarProvincia(provincia);

            if (registroExitoso)
            {
                MessageBox.Show("Se han guardado los cambios correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                //salir del panel de datos de personas
                CargarProvincias();
                panelProvConsultas.Visible = true;
                panelDatosProvincias.Visible = false; 
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProvincias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            //consultar los datos de la persona seleccionada
            string codigo = dataGridViewProvincias.Rows[index].Cells[0].Value.ToString();
            Console.WriteLine("Celda seleccionada " + codigo);

            //cargar los datos de la persona en los campos del formulario
            Provincia provincia = _antecedentesService.BuscarProvinciaByCodigo(codigo);
            if (provincia != null)
            {
                textNombreProvincia.Text = provincia.NombreProvincia;
                textBoxCodigoProvincia.Text = provincia.CodigoProvincia;
                textBoxTablaProvincia.Text = provincia.TablaProvincia;

                //cambiar de panel cuando ya esten cargados los datos
                panelProvConsultas.Visible = false;
                panelDatosProvincias.Visible = true;
            }
            else
            {
                MessageBox.Show("No se encontraron registros de personas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
