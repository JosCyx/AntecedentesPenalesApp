namespace AntecedentesPenalesApp.Forms
{
    partial class ProvinciasForm
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
            this.panelProvConsultas = new System.Windows.Forms.Panel();
            this.labelPersonasConsulta = new System.Windows.Forms.Label();
            this.dataGridViewProvincias = new System.Windows.Forms.DataGridView();
            this.buttonRegistrarPersona = new System.Windows.Forms.Button();
            this.panelDatosProvincias = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombreProvincia = new System.Windows.Forms.TextBox();
            this.labelNombreProvincia = new System.Windows.Forms.Label();
            this.labelCodigoProvincia = new System.Windows.Forms.Label();
            this.textBoxCodigoProvincia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTablaProvincia = new System.Windows.Forms.TextBox();
            this.buttonSalirProvincias = new System.Windows.Forms.Button();
            this.buttonGuardarProvincias = new System.Windows.Forms.Button();
            this.panelProvConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvincias)).BeginInit();
            this.panelDatosProvincias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProvConsultas
            // 
            this.panelProvConsultas.BackColor = System.Drawing.Color.AliceBlue;
            this.panelProvConsultas.Controls.Add(this.panelDatosProvincias);
            this.panelProvConsultas.Controls.Add(this.buttonRegistrarPersona);
            this.panelProvConsultas.Controls.Add(this.dataGridViewProvincias);
            this.panelProvConsultas.Controls.Add(this.labelPersonasConsulta);
            this.panelProvConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProvConsultas.Location = new System.Drawing.Point(0, 0);
            this.panelProvConsultas.Name = "panelProvConsultas";
            this.panelProvConsultas.Size = new System.Drawing.Size(1498, 889);
            this.panelProvConsultas.TabIndex = 0;
            // 
            // labelPersonasConsulta
            // 
            this.labelPersonasConsulta.AutoSize = true;
            this.labelPersonasConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonasConsulta.Location = new System.Drawing.Point(501, 70);
            this.labelPersonasConsulta.Name = "labelPersonasConsulta";
            this.labelPersonasConsulta.Size = new System.Drawing.Size(452, 32);
            this.labelPersonasConsulta.TabIndex = 15;
            this.labelPersonasConsulta.Text = "Consultar provincias registradas";
            // 
            // dataGridViewProvincias
            // 
            this.dataGridViewProvincias.AllowUserToAddRows = false;
            this.dataGridViewProvincias.AllowUserToDeleteRows = false;
            this.dataGridViewProvincias.AllowUserToResizeColumns = false;
            this.dataGridViewProvincias.AllowUserToResizeRows = false;
            this.dataGridViewProvincias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvincias.Location = new System.Drawing.Point(71, 140);
            this.dataGridViewProvincias.MultiSelect = false;
            this.dataGridViewProvincias.Name = "dataGridViewProvincias";
            this.dataGridViewProvincias.ReadOnly = true;
            this.dataGridViewProvincias.RowHeadersVisible = false;
            this.dataGridViewProvincias.RowHeadersWidth = 72;
            this.dataGridViewProvincias.RowTemplate.Height = 31;
            this.dataGridViewProvincias.Size = new System.Drawing.Size(1356, 608);
            this.dataGridViewProvincias.TabIndex = 16;
            this.dataGridViewProvincias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProvincias_CellDoubleClick);
            // 
            // buttonRegistrarPersona
            // 
            this.buttonRegistrarPersona.Location = new System.Drawing.Point(1186, 801);
            this.buttonRegistrarPersona.Name = "buttonRegistrarPersona";
            this.buttonRegistrarPersona.Size = new System.Drawing.Size(241, 40);
            this.buttonRegistrarPersona.TabIndex = 19;
            this.buttonRegistrarPersona.Text = "Registrar provincia";
            this.buttonRegistrarPersona.UseVisualStyleBackColor = true;
            this.buttonRegistrarPersona.Click += new System.EventHandler(this.buttonRegistrarPersona_Click);
            // 
            // panelDatosProvincias
            // 
            this.panelDatosProvincias.Controls.Add(this.buttonSalirProvincias);
            this.panelDatosProvincias.Controls.Add(this.buttonGuardarProvincias);
            this.panelDatosProvincias.Controls.Add(this.label2);
            this.panelDatosProvincias.Controls.Add(this.textBoxTablaProvincia);
            this.panelDatosProvincias.Controls.Add(this.labelCodigoProvincia);
            this.panelDatosProvincias.Controls.Add(this.textBoxCodigoProvincia);
            this.panelDatosProvincias.Controls.Add(this.labelNombreProvincia);
            this.panelDatosProvincias.Controls.Add(this.textNombreProvincia);
            this.panelDatosProvincias.Controls.Add(this.label1);
            this.panelDatosProvincias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosProvincias.Location = new System.Drawing.Point(0, 0);
            this.panelDatosProvincias.Name = "panelDatosProvincias";
            this.panelDatosProvincias.Size = new System.Drawing.Size(1498, 889);
            this.panelDatosProvincias.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modificar datos de provincias";
            // 
            // textNombreProvincia
            // 
            this.textNombreProvincia.Location = new System.Drawing.Point(182, 241);
            this.textNombreProvincia.Name = "textNombreProvincia";
            this.textNombreProvincia.Size = new System.Drawing.Size(404, 29);
            this.textNombreProvincia.TabIndex = 17;
            // 
            // labelNombreProvincia
            // 
            this.labelNombreProvincia.AutoSize = true;
            this.labelNombreProvincia.Location = new System.Drawing.Point(187, 212);
            this.labelNombreProvincia.Name = "labelNombreProvincia";
            this.labelNombreProvincia.Size = new System.Drawing.Size(211, 25);
            this.labelNombreProvincia.TabIndex = 18;
            this.labelNombreProvincia.Text = "Nombre de la provincia";
            // 
            // labelCodigoProvincia
            // 
            this.labelCodigoProvincia.AutoSize = true;
            this.labelCodigoProvincia.Location = new System.Drawing.Point(840, 212);
            this.labelCodigoProvincia.Name = "labelCodigoProvincia";
            this.labelCodigoProvincia.Size = new System.Drawing.Size(205, 25);
            this.labelCodigoProvincia.TabIndex = 20;
            this.labelCodigoProvincia.Text = "Código de la provincia";
            // 
            // textBoxCodigoProvincia
            // 
            this.textBoxCodigoProvincia.Location = new System.Drawing.Point(835, 241);
            this.textBoxCodigoProvincia.Name = "textBoxCodigoProvincia";
            this.textBoxCodigoProvincia.Size = new System.Drawing.Size(404, 29);
            this.textBoxCodigoProvincia.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre de la tabla asociada";
            // 
            // textBoxTablaProvincia
            // 
            this.textBoxTablaProvincia.Location = new System.Drawing.Point(182, 378);
            this.textBoxTablaProvincia.Name = "textBoxTablaProvincia";
            this.textBoxTablaProvincia.Size = new System.Drawing.Size(404, 29);
            this.textBoxTablaProvincia.TabIndex = 21;
            // 
            // buttonSalirProvincias
            // 
            this.buttonSalirProvincias.Location = new System.Drawing.Point(827, 614);
            this.buttonSalirProvincias.Name = "buttonSalirProvincias";
            this.buttonSalirProvincias.Size = new System.Drawing.Size(200, 42);
            this.buttonSalirProvincias.TabIndex = 29;
            this.buttonSalirProvincias.Text = "Atrás";
            this.buttonSalirProvincias.UseVisualStyleBackColor = true;
            this.buttonSalirProvincias.Click += new System.EventHandler(this.buttonSalirProvincias_Click);
            // 
            // buttonGuardarProvincias
            // 
            this.buttonGuardarProvincias.Location = new System.Drawing.Point(1039, 614);
            this.buttonGuardarProvincias.Name = "buttonGuardarProvincias";
            this.buttonGuardarProvincias.Size = new System.Drawing.Size(200, 42);
            this.buttonGuardarProvincias.TabIndex = 28;
            this.buttonGuardarProvincias.Text = "Guardar";
            this.buttonGuardarProvincias.UseVisualStyleBackColor = true;
            this.buttonGuardarProvincias.Click += new System.EventHandler(this.buttonGuardarProvincias_Click);
            // 
            // ProvinciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 889);
            this.Controls.Add(this.panelProvConsultas);
            this.Name = "ProvinciasForm";
            this.Text = "ProvinciasForm";
            this.Load += new System.EventHandler(this.ProvinciasForm_Load);
            this.panelProvConsultas.ResumeLayout(false);
            this.panelProvConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvincias)).EndInit();
            this.panelDatosProvincias.ResumeLayout(false);
            this.panelDatosProvincias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProvConsultas;
        private System.Windows.Forms.Label labelPersonasConsulta;
        private System.Windows.Forms.DataGridView dataGridViewProvincias;
        private System.Windows.Forms.Button buttonRegistrarPersona;
        private System.Windows.Forms.Panel panelDatosProvincias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTablaProvincia;
        private System.Windows.Forms.Label labelCodigoProvincia;
        private System.Windows.Forms.TextBox textBoxCodigoProvincia;
        private System.Windows.Forms.Label labelNombreProvincia;
        private System.Windows.Forms.TextBox textNombreProvincia;
        private System.Windows.Forms.Button buttonSalirProvincias;
        private System.Windows.Forms.Button buttonGuardarProvincias;
    }
}