namespace AntecedentesPenalesApp.Forms
{
    partial class PersonasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelConsultaPersonas = new System.Windows.Forms.Panel();
            this.panelDatosPersonas = new System.Windows.Forms.Panel();
            this.buttonRegistrarPersona = new System.Windows.Forms.Button();
            this.dataGridViewPersonas = new System.Windows.Forms.DataGridView();
            this.labelPersonasConsulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCedulaPersonas = new System.Windows.Forms.TextBox();
            this.labelCedulaPersonas = new System.Windows.Forms.Label();
            this.labelNombresPersonas = new System.Windows.Forms.Label();
            this.textNombresPersonas = new System.Windows.Forms.TextBox();
            this.labelApellidosPersonas = new System.Windows.Forms.Label();
            this.textApellidosPersonas = new System.Windows.Forms.TextBox();
            this.datePickerNacimientoPersonas = new System.Windows.Forms.DateTimePicker();
            this.labelNacimientoPersonas = new System.Windows.Forms.Label();
            this.comboBoxProvinciaPersonas = new System.Windows.Forms.ComboBox();
            this.labelProvinciaPersonas = new System.Windows.Forms.Label();
            this.buttonGuardarPersonas = new System.Windows.Forms.Button();
            this.buttonSalirPersonas = new System.Windows.Forms.Button();
            this.panelConsultaPersonas.SuspendLayout();
            this.panelDatosPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaPersonas
            // 
            this.panelConsultaPersonas.BackColor = System.Drawing.Color.AliceBlue;
            this.panelConsultaPersonas.Controls.Add(this.panelDatosPersonas);
            this.panelConsultaPersonas.Controls.Add(this.buttonRegistrarPersona);
            this.panelConsultaPersonas.Controls.Add(this.dataGridViewPersonas);
            this.panelConsultaPersonas.Controls.Add(this.labelPersonasConsulta);
            this.panelConsultaPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultaPersonas.Location = new System.Drawing.Point(0, 0);
            this.panelConsultaPersonas.Name = "panelConsultaPersonas";
            this.panelConsultaPersonas.Size = new System.Drawing.Size(1505, 879);
            this.panelConsultaPersonas.TabIndex = 0;
            // 
            // panelDatosPersonas
            // 
            this.panelDatosPersonas.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDatosPersonas.Controls.Add(this.buttonSalirPersonas);
            this.panelDatosPersonas.Controls.Add(this.buttonGuardarPersonas);
            this.panelDatosPersonas.Controls.Add(this.labelProvinciaPersonas);
            this.panelDatosPersonas.Controls.Add(this.comboBoxProvinciaPersonas);
            this.panelDatosPersonas.Controls.Add(this.labelNacimientoPersonas);
            this.panelDatosPersonas.Controls.Add(this.datePickerNacimientoPersonas);
            this.panelDatosPersonas.Controls.Add(this.labelApellidosPersonas);
            this.panelDatosPersonas.Controls.Add(this.textApellidosPersonas);
            this.panelDatosPersonas.Controls.Add(this.labelNombresPersonas);
            this.panelDatosPersonas.Controls.Add(this.textNombresPersonas);
            this.panelDatosPersonas.Controls.Add(this.labelCedulaPersonas);
            this.panelDatosPersonas.Controls.Add(this.textCedulaPersonas);
            this.panelDatosPersonas.Controls.Add(this.label1);
            this.panelDatosPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosPersonas.Location = new System.Drawing.Point(0, 0);
            this.panelDatosPersonas.Name = "panelDatosPersonas";
            this.panelDatosPersonas.Size = new System.Drawing.Size(1505, 879);
            this.panelDatosPersonas.TabIndex = 19;
            this.panelDatosPersonas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDatosPersonas_Paint);
            // 
            // buttonRegistrarPersona
            // 
            this.buttonRegistrarPersona.Location = new System.Drawing.Point(1193, 797);
            this.buttonRegistrarPersona.Name = "buttonRegistrarPersona";
            this.buttonRegistrarPersona.Size = new System.Drawing.Size(241, 40);
            this.buttonRegistrarPersona.TabIndex = 18;
            this.buttonRegistrarPersona.Text = "Registrar persona";
            this.buttonRegistrarPersona.UseVisualStyleBackColor = true;
            this.buttonRegistrarPersona.Click += new System.EventHandler(this.buttonRegistrarPersona_Click);
            // 
            // dataGridViewPersonas
            // 
            this.dataGridViewPersonas.AllowUserToAddRows = false;
            this.dataGridViewPersonas.AllowUserToDeleteRows = false;
            this.dataGridViewPersonas.AllowUserToResizeColumns = false;
            this.dataGridViewPersonas.AllowUserToResizeRows = false;
            this.dataGridViewPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonas.Location = new System.Drawing.Point(78, 153);
            this.dataGridViewPersonas.MultiSelect = false;
            this.dataGridViewPersonas.Name = "dataGridViewPersonas";
            this.dataGridViewPersonas.ReadOnly = true;
            this.dataGridViewPersonas.RowHeadersVisible = false;
            this.dataGridViewPersonas.RowHeadersWidth = 72;
            this.dataGridViewPersonas.RowTemplate.Height = 31;
            this.dataGridViewPersonas.Size = new System.Drawing.Size(1356, 608);
            this.dataGridViewPersonas.TabIndex = 15;
            this.dataGridViewPersonas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonas_CellClick);
            // 
            // labelPersonasConsulta
            // 
            this.labelPersonasConsulta.AutoSize = true;
            this.labelPersonasConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonasConsulta.Location = new System.Drawing.Point(507, 47);
            this.labelPersonasConsulta.Name = "labelPersonasConsulta";
            this.labelPersonasConsulta.Size = new System.Drawing.Size(438, 32);
            this.labelPersonasConsulta.TabIndex = 14;
            this.labelPersonasConsulta.Text = "Consultar personas registradas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modificar datos de personas";
            // 
            // textCedulaPersonas
            // 
            this.textCedulaPersonas.Location = new System.Drawing.Point(194, 249);
            this.textCedulaPersonas.Name = "textCedulaPersonas";
            this.textCedulaPersonas.Size = new System.Drawing.Size(411, 29);
            this.textCedulaPersonas.TabIndex = 16;
            // 
            // labelCedulaPersonas
            // 
            this.labelCedulaPersonas.AutoSize = true;
            this.labelCedulaPersonas.Location = new System.Drawing.Point(200, 220);
            this.labelCedulaPersonas.Name = "labelCedulaPersonas";
            this.labelCedulaPersonas.Size = new System.Drawing.Size(75, 25);
            this.labelCedulaPersonas.TabIndex = 17;
            this.labelCedulaPersonas.Text = "Cédula";
            // 
            // labelNombresPersonas
            // 
            this.labelNombresPersonas.AutoSize = true;
            this.labelNombresPersonas.Location = new System.Drawing.Point(200, 324);
            this.labelNombresPersonas.Name = "labelNombresPersonas";
            this.labelNombresPersonas.Size = new System.Drawing.Size(91, 25);
            this.labelNombresPersonas.TabIndex = 19;
            this.labelNombresPersonas.Text = "Nombres";
            // 
            // textNombresPersonas
            // 
            this.textNombresPersonas.Location = new System.Drawing.Point(194, 353);
            this.textNombresPersonas.Name = "textNombresPersonas";
            this.textNombresPersonas.Size = new System.Drawing.Size(411, 29);
            this.textNombresPersonas.TabIndex = 18;
            // 
            // labelApellidosPersonas
            // 
            this.labelApellidosPersonas.AutoSize = true;
            this.labelApellidosPersonas.Location = new System.Drawing.Point(847, 324);
            this.labelApellidosPersonas.Name = "labelApellidosPersonas";
            this.labelApellidosPersonas.Size = new System.Drawing.Size(92, 25);
            this.labelApellidosPersonas.TabIndex = 21;
            this.labelApellidosPersonas.Text = "Apellidos";
            // 
            // textApellidosPersonas
            // 
            this.textApellidosPersonas.Location = new System.Drawing.Point(841, 353);
            this.textApellidosPersonas.Name = "textApellidosPersonas";
            this.textApellidosPersonas.Size = new System.Drawing.Size(411, 29);
            this.textApellidosPersonas.TabIndex = 20;
            // 
            // datePickerNacimientoPersonas
            // 
            this.datePickerNacimientoPersonas.Location = new System.Drawing.Point(841, 249);
            this.datePickerNacimientoPersonas.Name = "datePickerNacimientoPersonas";
            this.datePickerNacimientoPersonas.Size = new System.Drawing.Size(411, 29);
            this.datePickerNacimientoPersonas.TabIndex = 22;
            // 
            // labelNacimientoPersonas
            // 
            this.labelNacimientoPersonas.AutoSize = true;
            this.labelNacimientoPersonas.Location = new System.Drawing.Point(846, 220);
            this.labelNacimientoPersonas.Name = "labelNacimientoPersonas";
            this.labelNacimientoPersonas.Size = new System.Drawing.Size(193, 25);
            this.labelNacimientoPersonas.TabIndex = 23;
            this.labelNacimientoPersonas.Text = "Fecha de nacimiento";
            // 
            // comboBoxProvinciaPersonas
            // 
            this.comboBoxProvinciaPersonas.FormattingEnabled = true;
            this.comboBoxProvinciaPersonas.Location = new System.Drawing.Point(194, 451);
            this.comboBoxProvinciaPersonas.Name = "comboBoxProvinciaPersonas";
            this.comboBoxProvinciaPersonas.Size = new System.Drawing.Size(411, 32);
            this.comboBoxProvinciaPersonas.TabIndex = 24;
            // 
            // labelProvinciaPersonas
            // 
            this.labelProvinciaPersonas.AutoSize = true;
            this.labelProvinciaPersonas.Location = new System.Drawing.Point(199, 421);
            this.labelProvinciaPersonas.Name = "labelProvinciaPersonas";
            this.labelProvinciaPersonas.Size = new System.Drawing.Size(92, 25);
            this.labelProvinciaPersonas.TabIndex = 25;
            this.labelProvinciaPersonas.Text = "Provincia";
            // 
            // buttonGuardarPersonas
            // 
            this.buttonGuardarPersonas.Location = new System.Drawing.Point(1051, 680);
            this.buttonGuardarPersonas.Name = "buttonGuardarPersonas";
            this.buttonGuardarPersonas.Size = new System.Drawing.Size(200, 42);
            this.buttonGuardarPersonas.TabIndex = 26;
            this.buttonGuardarPersonas.Text = "Guardar";
            this.buttonGuardarPersonas.UseVisualStyleBackColor = true;
            this.buttonGuardarPersonas.Click += new System.EventHandler(this.buttonGuardarPersonas_Click);
            // 
            // buttonSalirPersonas
            // 
            this.buttonSalirPersonas.Location = new System.Drawing.Point(839, 680);
            this.buttonSalirPersonas.Name = "buttonSalirPersonas";
            this.buttonSalirPersonas.Size = new System.Drawing.Size(200, 42);
            this.buttonSalirPersonas.TabIndex = 27;
            this.buttonSalirPersonas.Text = "Atrás";
            this.buttonSalirPersonas.UseVisualStyleBackColor = true;
            this.buttonSalirPersonas.Click += new System.EventHandler(this.buttonSalirPersonas_Click);
            // 
            // PersonasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 879);
            this.Controls.Add(this.panelConsultaPersonas);
            this.Name = "PersonasForm";
            this.ShowInTaskbar = false;
            this.Text = "PersonasForm";
            this.Load += new System.EventHandler(this.PersonasForm_Load);
            this.panelConsultaPersonas.ResumeLayout(false);
            this.panelConsultaPersonas.PerformLayout();
            this.panelDatosPersonas.ResumeLayout(false);
            this.panelDatosPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaPersonas;
        private System.Windows.Forms.Label labelPersonasConsulta;
        private System.Windows.Forms.DataGridView dataGridViewPersonas;
        private System.Windows.Forms.Button buttonRegistrarPersona;
        private System.Windows.Forms.Panel panelDatosPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNacimientoPersonas;
        private System.Windows.Forms.DateTimePicker datePickerNacimientoPersonas;
        private System.Windows.Forms.Label labelApellidosPersonas;
        private System.Windows.Forms.TextBox textApellidosPersonas;
        private System.Windows.Forms.Label labelNombresPersonas;
        private System.Windows.Forms.TextBox textNombresPersonas;
        private System.Windows.Forms.Label labelCedulaPersonas;
        private System.Windows.Forms.TextBox textCedulaPersonas;
        private System.Windows.Forms.Button buttonSalirPersonas;
        private System.Windows.Forms.Button buttonGuardarPersonas;
        private System.Windows.Forms.Label labelProvinciaPersonas;
        private System.Windows.Forms.ComboBox comboBoxProvinciaPersonas;
    }
}