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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ModulePanel = new System.Windows.Forms.Panel();
            this.modulePicture = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRecords = new System.Windows.Forms.Button();
            this.buttonProvincias = new System.Windows.Forms.Button();
            this.buttonPersonas = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.contraseniaTxt = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulePicture)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainPanel.Controls.Add(this.ModulePanel);
            this.MainPanel.Controls.Add(this.modulePicture);
            this.MainPanel.Controls.Add(this.buttonBack);
            this.MainPanel.Controls.Add(this.buttonRecords);
            this.MainPanel.Controls.Add(this.buttonProvincias);
            this.MainPanel.Controls.Add(this.buttonPersonas);
            this.MainPanel.Controls.Add(this.LoginPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1800, 1003);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Visible = false;
            // 
            // ModulePanel
            // 
            this.ModulePanel.BackColor = System.Drawing.Color.AliceBlue;
            this.ModulePanel.Location = new System.Drawing.Point(277, 0);
            this.ModulePanel.Name = "ModulePanel";
            this.ModulePanel.Size = new System.Drawing.Size(1523, 1002);
            this.ModulePanel.TabIndex = 6;
            // 
            // modulePicture
            // 
            this.modulePicture.Image = global::AntecedentesPenalesApp.Properties.Resources.police;
            this.modulePicture.Location = new System.Drawing.Point(35, 100);
            this.modulePicture.Name = "modulePicture";
            this.modulePicture.Size = new System.Drawing.Size(199, 205);
            this.modulePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modulePicture.TabIndex = 5;
            this.modulePicture.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(53, 924);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 45);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Cerrar sesión";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRecords
            // 
            this.buttonRecords.Location = new System.Drawing.Point(35, 433);
            this.buttonRecords.Name = "buttonRecords";
            this.buttonRecords.Size = new System.Drawing.Size(199, 63);
            this.buttonRecords.TabIndex = 2;
            this.buttonRecords.Text = "Antecedentes";
            this.buttonRecords.UseVisualStyleBackColor = true;
            this.buttonRecords.Click += new System.EventHandler(this.buttonRecords_Click);
            // 
            // buttonProvincias
            // 
            this.buttonProvincias.Location = new System.Drawing.Point(35, 694);
            this.buttonProvincias.Name = "buttonProvincias";
            this.buttonProvincias.Size = new System.Drawing.Size(199, 63);
            this.buttonProvincias.TabIndex = 1;
            this.buttonProvincias.Text = "Provincias";
            this.buttonProvincias.UseVisualStyleBackColor = true;
            this.buttonProvincias.Click += new System.EventHandler(this.buttonProvincias_Click);
            // 
            // buttonPersonas
            // 
            this.buttonPersonas.Location = new System.Drawing.Point(35, 565);
            this.buttonPersonas.Name = "buttonPersonas";
            this.buttonPersonas.Size = new System.Drawing.Size(199, 63);
            this.buttonPersonas.TabIndex = 0;
            this.buttonPersonas.Text = "Personas";
            this.buttonPersonas.UseVisualStyleBackColor = true;
            this.buttonPersonas.Click += new System.EventHandler(this.buttonPersonas_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LoginPanel.Controls.Add(this.labelLogin);
            this.LoginPanel.Controls.Add(this.loginPicture);
            this.LoginPanel.Controls.Add(this.contraseniaTxt);
            this.LoginPanel.Controls.Add(this.buttonLogin);
            this.LoginPanel.Controls.Add(this.usuarioTxt);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1800, 1003);
            this.LoginPanel.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(437, 449);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(931, 47);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "SISTEMA DE CONSULTA DE ANTECEDENTES PENALES";
            // 
            // loginPicture
            // 
            this.loginPicture.Image = global::AntecedentesPenalesApp.Properties.Resources.police;
            this.loginPicture.Location = new System.Drawing.Point(726, 54);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(371, 356);
            this.loginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPicture.TabIndex = 3;
            this.loginPicture.TabStop = false;
            // 
            // contraseniaTxt
            // 
            this.contraseniaTxt.Location = new System.Drawing.Point(699, 705);
            this.contraseniaTxt.Name = "contraseniaTxt";
            this.contraseniaTxt.Size = new System.Drawing.Size(419, 29);
            this.contraseniaTxt.TabIndex = 2;
            this.contraseniaTxt.Text = "Ingrese su contraseña";
            this.contraseniaTxt.TextChanged += new System.EventHandler(this.contraseniaTxt_TextChanged);
            this.contraseniaTxt.Enter += new System.EventHandler(this.contraseniaTxt_Enter);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(790, 813);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(218, 50);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Iniciar sesión";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(699, 599);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(419, 29);
            this.usuarioTxt.TabIndex = 0;
            this.usuarioTxt.Text = "Ingrese su usuario";
            this.usuarioTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.usuarioTxt.Enter += new System.EventHandler(this.usuarioTxt_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1003);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de consulta de antecedentes penales";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modulePicture)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button buttonPersonas;
        private System.Windows.Forms.Button buttonRecords;
        private System.Windows.Forms.Button buttonProvincias;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox modulePicture;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel ModulePanel;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox contraseniaTxt;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.Label labelLogin;
    }
}