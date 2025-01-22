namespace AntecedentesPenalesApp.Forms
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPersonas = new System.Windows.Forms.Button();
            this.buttonProvincias = new System.Windows.Forms.Button();
            this.buttonRecords = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.buttonRecords);
            this.panel1.Controls.Add(this.buttonProvincias);
            this.panel1.Controls.Add(this.buttonPersonas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1800, 1005);
            this.panel1.TabIndex = 0;
            // 
            // buttonPersonas
            // 
            this.buttonPersonas.Location = new System.Drawing.Point(74, 150);
            this.buttonPersonas.Name = "buttonPersonas";
            this.buttonPersonas.Size = new System.Drawing.Size(199, 63);
            this.buttonPersonas.TabIndex = 0;
            this.buttonPersonas.Text = "Personas";
            this.buttonPersonas.UseVisualStyleBackColor = true;
            this.buttonPersonas.Click += new System.EventHandler(this.buttonPersonas_Click);
            // 
            // buttonProvincias
            // 
            this.buttonProvincias.Location = new System.Drawing.Point(74, 456);
            this.buttonProvincias.Name = "buttonProvincias";
            this.buttonProvincias.Size = new System.Drawing.Size(199, 63);
            this.buttonProvincias.TabIndex = 1;
            this.buttonProvincias.Text = "Provincias";
            this.buttonProvincias.UseVisualStyleBackColor = true;
            this.buttonProvincias.Click += new System.EventHandler(this.buttonProvincias_Click);
            // 
            // buttonRecords
            // 
            this.buttonRecords.Location = new System.Drawing.Point(74, 774);
            this.buttonRecords.Name = "buttonRecords";
            this.buttonRecords.Size = new System.Drawing.Size(199, 63);
            this.buttonRecords.TabIndex = 2;
            this.buttonRecords.Text = "Antecedentes";
            this.buttonRecords.UseVisualStyleBackColor = true;
            this.buttonRecords.Click += new System.EventHandler(this.buttonRecords_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(354, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1448, 1005);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1003);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPersonas;
        private System.Windows.Forms.Button buttonRecords;
        private System.Windows.Forms.Button buttonProvincias;
        private System.Windows.Forms.Panel panel2;
    }
}