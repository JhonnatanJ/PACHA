﻿
namespace CapaPresentacion
{
    partial class frmLogComunidadUser
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.cboComunidad = new System.Windows.Forms.ComboBox();
            this.btnIngCom = new System.Windows.Forms.Button();
            this.btnCrearComunidad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGuia = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.ttLogComunidadUser = new System.Windows.Forms.ToolTip(this.components);
            this.pbAyuda = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelApellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 536);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.iconUser;
            this.pictureBox1.Location = new System.Drawing.Point(58, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelApellido
            // 
            this.labelApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelApellido.Location = new System.Drawing.Point(0, 368);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(283, 23);
            this.labelApellido.TabIndex = 10;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(35, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "BIENVENIDO/A";
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombre.Location = new System.Drawing.Point(0, 334);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(283, 23);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.Location = new System.Drawing.Point(55, 428);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(173, 38);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Cerrar Sesion";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.logoPacha_png;
            this.pictureBox2.Location = new System.Drawing.Point(30, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLogin.Location = new System.Drawing.Point(491, 30);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(307, 45);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "COMUNIDADES";
            // 
            // cboComunidad
            // 
            this.cboComunidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComunidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboComunidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboComunidad.FormattingEnabled = true;
            this.cboComunidad.Location = new System.Drawing.Point(12, 79);
            this.cboComunidad.Name = "cboComunidad";
            this.cboComunidad.Size = new System.Drawing.Size(350, 31);
            this.cboComunidad.TabIndex = 1;
            this.cboComunidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboComunidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboComunidad_KeyPress);
            // 
            // btnIngCom
            // 
            this.btnIngCom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngCom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnIngCom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnIngCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnIngCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngCom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngCom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngCom.Location = new System.Drawing.Point(371, 74);
            this.btnIngCom.Name = "btnIngCom";
            this.btnIngCom.Size = new System.Drawing.Size(225, 42);
            this.btnIngCom.TabIndex = 7;
            this.btnIngCom.Text = "Ingresar";
            this.btnIngCom.UseVisualStyleBackColor = false;
            this.btnIngCom.Click += new System.EventHandler(this.btnIngCom_Click);
            // 
            // btnCrearComunidad
            // 
            this.btnCrearComunidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearComunidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnCrearComunidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnCrearComunidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnCrearComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearComunidad.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearComunidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearComunidad.Location = new System.Drawing.Point(172, 22);
            this.btnCrearComunidad.Name = "btnCrearComunidad";
            this.btnCrearComunidad.Size = new System.Drawing.Size(267, 42);
            this.btnCrearComunidad.TabIndex = 10;
            this.btnCrearComunidad.Text = "Crear Comunidad";
            this.btnCrearComunidad.UseVisualStyleBackColor = false;
            this.btnCrearComunidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblGuia);
            this.panel2.Controls.Add(this.cboComunidad);
            this.panel2.Controls.Add(this.btnIngCom);
            this.panel2.Location = new System.Drawing.Point(325, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 150);
            this.panel2.TabIndex = 0;
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.BackColor = System.Drawing.Color.Transparent;
            this.lblGuia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGuia.Location = new System.Drawing.Point(135, 17);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(355, 30);
            this.lblGuia.TabIndex = 12;
            this.lblGuia.Text = "Seleccióne una comunidad:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnCrearComunidad);
            this.panel3.Location = new System.Drawing.Point(325, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 87);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(325, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 86);
            this.panel4.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(172, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Editar Perfil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Image = global::CapaPresentacion.Properties.Resources.iconMinimizar_B;
            this.pbMinimizar.Location = new System.Drawing.Point(899, 14);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(23, 15);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 14;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::CapaPresentacion.Properties.Resources.iconCerrar_B;
            this.pbCerrar.Location = new System.Drawing.Point(935, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(17, 17);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 13;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // ttLogComunidadUser
            // 
            this.ttLogComunidadUser.AutomaticDelay = 1000;
            this.ttLogComunidadUser.AutoPopDelay = 30000;
            this.ttLogComunidadUser.InitialDelay = 50;
            this.ttLogComunidadUser.IsBalloon = true;
            this.ttLogComunidadUser.ReshowDelay = 50;
            this.ttLogComunidadUser.ToolTipTitle = "MENU COMUNIDADES";
            // 
            // pbAyuda
            // 
            this.pbAyuda.Image = global::CapaPresentacion.Properties.Resources.iconAyuda2_B;
            this.pbAyuda.Location = new System.Drawing.Point(858, 3);
            this.pbAyuda.Name = "pbAyuda";
            this.pbAyuda.Size = new System.Drawing.Size(36, 33);
            this.pbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAyuda.TabIndex = 17;
            this.pbAyuda.TabStop = false;
            // 
            // frmLogComunidadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(964, 536);
            this.Controls.Add(this.pbAyuda);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogComunidadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogComunidad";
            this.Load += new System.EventHandler(this.frmLogComunidad_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogComunidad_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.ComboBox cboComunidad;
        private System.Windows.Forms.Button btnIngCom;
        private System.Windows.Forms.Button btnCrearComunidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip ttLogComunidadUser;
        private System.Windows.Forms.PictureBox pbAyuda;
    }
}