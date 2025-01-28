namespace AntecedentesPenalesApp.Forms
{
    partial class AntecedentesForm
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
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.panelInsercion = new System.Windows.Forms.Panel();
            this.textFechaRegistroInsert = new System.Windows.Forms.TextBox();
            this.labelNombreInsert = new System.Windows.Forms.Label();
            this.textBoxNombreInsert = new System.Windows.Forms.TextBox();
            this.labelFechaInsert = new System.Windows.Forms.Label();
            this.labelAntecedenteInsert = new System.Windows.Forms.Label();
            this.labelCedulaInsert = new System.Windows.Forms.Label();
            this.buttonCancelInsert = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textAntecedenteInsert = new System.Windows.Forms.TextBox();
            this.textCedulaInsert = new System.Windows.Forms.TextBox();
            this.labelInsercion = new System.Windows.Forms.Label();
            this.borrarAntBtn = new System.Windows.Forms.Button();
            this.dataGridViewAnt = new System.Windows.Forms.DataGridView();
            this.consultarAntBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCedulaAnt = new System.Windows.Forms.TextBox();
            this.registrarAntecedentes = new System.Windows.Forms.Button();
            this.labelConsulta = new System.Windows.Forms.Label();
            this.panelConsulta.SuspendLayout();
            this.panelInsercion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnt)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsulta
            // 
            this.panelConsulta.BackColor = System.Drawing.Color.AliceBlue;
            this.panelConsulta.Controls.Add(this.panelInsercion);
            this.panelConsulta.Controls.Add(this.borrarAntBtn);
            this.panelConsulta.Controls.Add(this.dataGridViewAnt);
            this.panelConsulta.Controls.Add(this.consultarAntBtn);
            this.panelConsulta.Controls.Add(this.label1);
            this.panelConsulta.Controls.Add(this.textCedulaAnt);
            this.panelConsulta.Controls.Add(this.registrarAntecedentes);
            this.panelConsulta.Controls.Add(this.labelConsulta);
            this.panelConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsulta.Location = new System.Drawing.Point(0, 0);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(1514, 877);
            this.panelConsulta.TabIndex = 0;
            // 
            // panelInsercion
            // 
            this.panelInsercion.BackColor = System.Drawing.Color.AliceBlue;
            this.panelInsercion.Controls.Add(this.textFechaRegistroInsert);
            this.panelInsercion.Controls.Add(this.labelNombreInsert);
            this.panelInsercion.Controls.Add(this.textBoxNombreInsert);
            this.panelInsercion.Controls.Add(this.labelFechaInsert);
            this.panelInsercion.Controls.Add(this.labelAntecedenteInsert);
            this.panelInsercion.Controls.Add(this.labelCedulaInsert);
            this.panelInsercion.Controls.Add(this.buttonCancelInsert);
            this.panelInsercion.Controls.Add(this.buttonRegistrar);
            this.panelInsercion.Controls.Add(this.textAntecedenteInsert);
            this.panelInsercion.Controls.Add(this.textCedulaInsert);
            this.panelInsercion.Controls.Add(this.labelInsercion);
            this.panelInsercion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInsercion.Location = new System.Drawing.Point(0, 0);
            this.panelInsercion.Name = "panelInsercion";
            this.panelInsercion.Size = new System.Drawing.Size(1514, 877);
            this.panelInsercion.TabIndex = 10;
            this.panelInsercion.Visible = false;
            // 
            // textFechaRegistroInsert
            // 
            this.textFechaRegistroInsert.BackColor = System.Drawing.Color.White;
            this.textFechaRegistroInsert.Location = new System.Drawing.Point(125, 612);
            this.textFechaRegistroInsert.Name = "textFechaRegistroInsert";
            this.textFechaRegistroInsert.ReadOnly = true;
            this.textFechaRegistroInsert.Size = new System.Drawing.Size(399, 29);
            this.textFechaRegistroInsert.TabIndex = 24;
            // 
            // labelNombreInsert
            // 
            this.labelNombreInsert.AutoSize = true;
            this.labelNombreInsert.Location = new System.Drawing.Point(601, 167);
            this.labelNombreInsert.Name = "labelNombreInsert";
            this.labelNombreInsert.Size = new System.Drawing.Size(81, 25);
            this.labelNombreInsert.TabIndex = 23;
            this.labelNombreInsert.Text = "Nombre";
            // 
            // textBoxNombreInsert
            // 
            this.textBoxNombreInsert.Location = new System.Drawing.Point(596, 196);
            this.textBoxNombreInsert.Name = "textBoxNombreInsert";
            this.textBoxNombreInsert.ReadOnly = true;
            this.textBoxNombreInsert.Size = new System.Drawing.Size(753, 29);
            this.textBoxNombreInsert.TabIndex = 22;
            // 
            // labelFechaInsert
            // 
            this.labelFechaInsert.AutoSize = true;
            this.labelFechaInsert.Location = new System.Drawing.Point(130, 584);
            this.labelFechaInsert.Name = "labelFechaInsert";
            this.labelFechaInsert.Size = new System.Drawing.Size(163, 25);
            this.labelFechaInsert.TabIndex = 21;
            this.labelFechaInsert.Text = "Fecha de registro";
            // 
            // labelAntecedenteInsert
            // 
            this.labelAntecedenteInsert.AutoSize = true;
            this.labelAntecedenteInsert.Location = new System.Drawing.Point(130, 259);
            this.labelAntecedenteInsert.Name = "labelAntecedenteInsert";
            this.labelAntecedenteInsert.Size = new System.Drawing.Size(258, 25);
            this.labelAntecedenteInsert.TabIndex = 20;
            this.labelAntecedenteInsert.Text = "Descripción del antecedente";
            // 
            // labelCedulaInsert
            // 
            this.labelCedulaInsert.AutoSize = true;
            this.labelCedulaInsert.Location = new System.Drawing.Point(130, 167);
            this.labelCedulaInsert.Name = "labelCedulaInsert";
            this.labelCedulaInsert.Size = new System.Drawing.Size(75, 25);
            this.labelCedulaInsert.TabIndex = 19;
            this.labelCedulaInsert.Text = "Cédula";
            // 
            // buttonCancelInsert
            // 
            this.buttonCancelInsert.Location = new System.Drawing.Point(1020, 767);
            this.buttonCancelInsert.Name = "buttonCancelInsert";
            this.buttonCancelInsert.Size = new System.Drawing.Size(149, 39);
            this.buttonCancelInsert.TabIndex = 18;
            this.buttonCancelInsert.Text = "Atrás";
            this.buttonCancelInsert.UseVisualStyleBackColor = true;
            this.buttonCancelInsert.Click += new System.EventHandler(this.buttonCancelInsert_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(1189, 767);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(241, 40);
            this.buttonRegistrar.TabIndex = 17;
            this.buttonRegistrar.Text = "Registrar antecedente";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textAntecedenteInsert
            // 
            this.textAntecedenteInsert.Location = new System.Drawing.Point(125, 289);
            this.textAntecedenteInsert.Multiline = true;
            this.textAntecedenteInsert.Name = "textAntecedenteInsert";
            this.textAntecedenteInsert.Size = new System.Drawing.Size(1224, 258);
            this.textAntecedenteInsert.TabIndex = 15;
            // 
            // textCedulaInsert
            // 
            this.textCedulaInsert.Location = new System.Drawing.Point(125, 196);
            this.textCedulaInsert.Name = "textCedulaInsert";
            this.textCedulaInsert.Size = new System.Drawing.Size(311, 29);
            this.textCedulaInsert.TabIndex = 14;
            this.textCedulaInsert.TextChanged += new System.EventHandler(this.textCedulaInsert_TextChanged);
            // 
            // labelInsercion
            // 
            this.labelInsercion.AutoSize = true;
            this.labelInsercion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsercion.Location = new System.Drawing.Point(590, 25);
            this.labelInsercion.Name = "labelInsercion";
            this.labelInsercion.Size = new System.Drawing.Size(330, 32);
            this.labelInsercion.TabIndex = 13;
            this.labelInsercion.Text = "Registrar antecedentes";
            // 
            // borrarAntBtn
            // 
            this.borrarAntBtn.Location = new System.Drawing.Point(1105, 123);
            this.borrarAntBtn.Name = "borrarAntBtn";
            this.borrarAntBtn.Size = new System.Drawing.Size(162, 39);
            this.borrarAntBtn.TabIndex = 9;
            this.borrarAntBtn.Text = "Limpiar campos";
            this.borrarAntBtn.UseVisualStyleBackColor = true;
            this.borrarAntBtn.Click += new System.EventHandler(this.borrarAntBtn_Click);
            // 
            // dataGridViewAnt
            // 
            this.dataGridViewAnt.AllowUserToAddRows = false;
            this.dataGridViewAnt.AllowUserToDeleteRows = false;
            this.dataGridViewAnt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnt.Location = new System.Drawing.Point(65, 220);
            this.dataGridViewAnt.Name = "dataGridViewAnt";
            this.dataGridViewAnt.ReadOnly = true;
            this.dataGridViewAnt.RowHeadersVisible = false;
            this.dataGridViewAnt.RowHeadersWidth = 72;
            this.dataGridViewAnt.RowTemplate.Height = 31;
            this.dataGridViewAnt.Size = new System.Drawing.Size(1384, 541);
            this.dataGridViewAnt.TabIndex = 8;
            // 
            // consultarAntBtn
            // 
            this.consultarAntBtn.Location = new System.Drawing.Point(1285, 123);
            this.consultarAntBtn.Name = "consultarAntBtn";
            this.consultarAntBtn.Size = new System.Drawing.Size(162, 39);
            this.consultarAntBtn.TabIndex = 7;
            this.consultarAntBtn.Text = "Consultar";
            this.consultarAntBtn.UseVisualStyleBackColor = true;
            this.consultarAntBtn.Click += new System.EventHandler(this.consultarAntBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulta por número de cédula";
            // 
            // textCedulaAnt
            // 
            this.textCedulaAnt.Location = new System.Drawing.Point(68, 127);
            this.textCedulaAnt.Name = "textCedulaAnt";
            this.textCedulaAnt.Size = new System.Drawing.Size(425, 29);
            this.textCedulaAnt.TabIndex = 5;
            // 
            // registrarAntecedentes
            // 
            this.registrarAntecedentes.Location = new System.Drawing.Point(1189, 791);
            this.registrarAntecedentes.Name = "registrarAntecedentes";
            this.registrarAntecedentes.Size = new System.Drawing.Size(258, 43);
            this.registrarAntecedentes.TabIndex = 11;
            this.registrarAntecedentes.Text = "Registrar antecedentes";
            this.registrarAntecedentes.UseVisualStyleBackColor = true;
            this.registrarAntecedentes.Click += new System.EventHandler(this.registrarAntecedentes_Click);
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsulta.Location = new System.Drawing.Point(551, 25);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(369, 32);
            this.labelConsulta.TabIndex = 12;
            this.labelConsulta.Text = "Consulta de antecedentes";
            // 
            // AntecedentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 877);
            this.Controls.Add(this.panelConsulta);
            this.Name = "AntecedentesForm";
            this.Text = "AntecedentesForm";
            this.Load += new System.EventHandler(this.AntecedentesForm_Load);
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            this.panelInsercion.ResumeLayout(false);
            this.panelInsercion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.Panel panelInsercion;
        private System.Windows.Forms.Button borrarAntBtn;
        private System.Windows.Forms.DataGridView dataGridViewAnt;
        private System.Windows.Forms.Button consultarAntBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCedulaAnt;
        private System.Windows.Forms.Button registrarAntecedentes;
        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.Label labelInsercion;
        private System.Windows.Forms.TextBox textAntecedenteInsert;
        private System.Windows.Forms.TextBox textCedulaInsert;
        private System.Windows.Forms.Label labelFechaInsert;
        private System.Windows.Forms.Label labelAntecedenteInsert;
        private System.Windows.Forms.Label labelCedulaInsert;
        private System.Windows.Forms.Button buttonCancelInsert;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label labelNombreInsert;
        private System.Windows.Forms.TextBox textBoxNombreInsert;
        private System.Windows.Forms.TextBox textFechaRegistroInsert;
    }
}