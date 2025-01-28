using AntecedentesPenalesApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntecedentesPenalesApp.Forms
{
    public partial class AntecedentesForm : Form
    {
        private readonly AuxiliarClass _auxiliarClass = new AuxiliarClass();
        private readonly AntecedentesService _antecedentesService;
        private string[] codigosProvincias;
        public AntecedentesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            _antecedentesService = new AntecedentesService();

            panelConsulta.Parent = this;
            panelInsercion.Parent = this;

            panelConsulta.Visible = true;
            panelInsercion.Visible = false;
            textFechaRegistroInsert.Text = DateTime.Now.ToString();
        }

        private void AntecedentesForm_Load(object sender, EventArgs e)
        {
            //consultar codigos de provincia
            codigosProvincias = _antecedentesService.ConsultarCodigosProvincia();
        }

        private void consultarAntBtn_Click(object sender, EventArgs e)
        {
            string cedula = textCedulaAnt.Text;

            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Por favor, ingrese un número de cédula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
            
            //convertir los dos primeros digitos en un numero entero
            int codigoProvincia = int.Parse(cedula.Substring(0, 2));
            
            if (cedula.Length < 10)
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (codigoProvincia > 24 && codigoProvincia < 30 || codigoProvincia > 30)
            {
                MessageBox.Show("El número de cédula ingresado no pertenece a alguna provincia del Ecuador.\nPor favor, ingrese un número de cédula válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (!codigosProvincias.Contains(cedula.Substring(0, 2)))
            {
               MessageBox.Show("El número de cédula ingresado no pertenece a alguna provincia registrada en la base de datos.\nPor favor, ingrese un número de cédula válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            try
            {
                // Llama al servicio para obtener antecedentes.
                DataTable resultados = _antecedentesService.ObtenerAntecedentes(cedula);
                //resultados.Columns.RemoveAt(0);

                if (resultados.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron antecedentes para el número de cédula ingresado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Asigna los resultados al DataGridView.
                DataGridView dgvResultados = dataGridViewAnt as DataGridView;
                dgvResultados.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los antecedentes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrarAntBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        //limpia los campos del formulario de antecedentes
        public void ClearForm()
        {
            textCedulaAnt.Clear();
            dataGridViewAnt.DataSource = null;

            textCedulaInsert.Clear();
            textAntecedenteInsert.Clear();
            textFechaRegistroInsert.Text = DateTime.Now.ToString();
        }

        private void registrarAntecedentes_Click(object sender, EventArgs e)
        {
            panelInsercion.Visible = true;
            panelConsulta.Visible = false;

        }

        private void buttonCancelInsert_Click(object sender, EventArgs e)
        {
            textCedulaInsert.Clear();
            textAntecedenteInsert.Clear();
            textFechaRegistroInsert.Text = DateTime.Now.ToString();

            _auxiliarClass.LoadModule(new AntecedentesForm(), panelInsercion);
        }

        private void textCedulaInsert_TextChanged(object sender, EventArgs e)
        {
            if (textCedulaInsert.Text.Length >= 10)
            {
                string nombre = _antecedentesService.BuscarNombrePorCedula(textCedulaInsert.Text);

                textBoxNombreInsert.Text = nombre;

            } else if (textCedulaInsert.Text == "")
            {
                textBoxNombreInsert.Text = "";
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            //messagebox de confirmacion
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea registrar el antecedente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Validación de campos
            string cedula = textCedulaInsert.Text.Trim();
            string antecedente = textAntecedenteInsert.Text.Trim();
            string fechaRegistro = textFechaRegistroInsert.Text.Trim();

            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 10)
            {
                MessageBox.Show("Por favor, ingrese un número de cédula válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(antecedente))
            {
                MessageBox.Show("Por favor, ingrese el antecedente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el código de la provincia (primeros 2 dígitos de la cédula)
            string codigoProvincia = cedula.Substring(0, 2);

            try
            {
                // Verificar si la provincia es válida
                string nombreTabla = _antecedentesService.ObtenerTablaProvincia(codigoProvincia);
                if (string.IsNullOrEmpty(nombreTabla))
                {
                    MessageBox.Show("El código de provincia no es válido o no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si la persona existe
                bool personaExiste = _antecedentesService.VerificarPersona(cedula);
                if (!personaExiste)
                {
                    MessageBox.Show("La persona con la cédula ingresada no está registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Registrar el antecedente
                bool registroExitoso = _antecedentesService.RegistrarAntecedente(nombreTabla, cedula, antecedente, fechaRegistro);

                if (registroExitoso)
                {
                    MessageBox.Show("Antecedente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); 
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el antecedente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
