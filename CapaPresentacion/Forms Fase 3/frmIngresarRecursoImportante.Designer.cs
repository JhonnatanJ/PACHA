
namespace CapaPresentacion.Forms_Fase_3
{
    partial class frmRecursoImportante
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
            this.btnGuardarCambio = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxAcceso = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxCalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCantidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoRecurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRecurso = new System.Windows.Forms.ComboBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSectorRecurso = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecursoSector = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarCambio
            // 
            this.btnGuardarCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarCambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarCambio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnGuardarCambio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnGuardarCambio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnGuardarCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarCambio.Location = new System.Drawing.Point(252, 439);
            this.btnGuardarCambio.Name = "btnGuardarCambio";
            this.btnGuardarCambio.Size = new System.Drawing.Size(177, 46);
            this.btnGuardarCambio.TabIndex = 14;
            this.btnGuardarCambio.Text = "Guardar Datos";
            this.btnGuardarCambio.UseVisualStyleBackColor = false;
            this.btnGuardarCambio.Click += new System.EventHandler(this.btnGuardarCambio_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.btnGuardarCambio);
            this.panel4.Controls.Add(this.cbxAcceso);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cbxCalidad);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbxCantidad);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbxTipoRecurso);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbxRecurso);
            this.panel4.Controls.Add(this.txtNotas);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtControl);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cbxSectorRecurso);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblRecursoSector);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 501);
            this.panel4.TabIndex = 13;
            // 
            // cbxAcceso
            // 
            this.cbxAcceso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxAcceso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAcceso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxAcceso.FormattingEnabled = true;
            this.cbxAcceso.Items.AddRange(new object[] {
            "Pobladores",
            "Familia",
            "Niños (5 a 14 años)",
            "Jóvenes (15 a 24 años) ",
            "Adultos (25 a 64 años)",
            "Adultos mayores (más de 65 años)"});
            this.cbxAcceso.Location = new System.Drawing.Point(174, 304);
            this.cbxAcceso.Name = "cbxAcceso";
            this.cbxAcceso.Size = new System.Drawing.Size(489, 29);
            this.cbxAcceso.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(22, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Acceso:";
            // 
            // cbxCalidad
            // 
            this.cbxCalidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxCalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCalidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxCalidad.FormattingEnabled = true;
            this.cbxCalidad.Items.AddRange(new object[] {
            "Inadecuado",
            "Adecuado"});
            this.cbxCalidad.Location = new System.Drawing.Point(174, 253);
            this.cbxCalidad.Name = "cbxCalidad";
            this.cbxCalidad.Size = new System.Drawing.Size(489, 29);
            this.cbxCalidad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(22, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Calidad:";
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxCantidad.FormattingEnabled = true;
            this.cbxCantidad.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.cbxCantidad.Location = new System.Drawing.Point(174, 203);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(489, 29);
            this.cbxCantidad.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(22, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad:";
            // 
            // cbxTipoRecurso
            // 
            this.cbxTipoRecurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxTipoRecurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoRecurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxTipoRecurso.FormattingEnabled = true;
            this.cbxTipoRecurso.Items.AddRange(new object[] {
            "Recursos Naturales",
            "Recursos Físicos",
            "Recursos Humanos",
            "Recursos Sociales",
            "Recursos Económicos",
            "Recursos Políticos"});
            this.cbxTipoRecurso.Location = new System.Drawing.Point(174, 105);
            this.cbxTipoRecurso.Name = "cbxTipoRecurso";
            this.cbxTipoRecurso.Size = new System.Drawing.Size(489, 29);
            this.cbxTipoRecurso.TabIndex = 15;
            this.cbxTipoRecurso.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de Recurso:";
            // 
            // cbxRecurso
            // 
            this.cbxRecurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxRecurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRecurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxRecurso.FormattingEnabled = true;
            this.cbxRecurso.Location = new System.Drawing.Point(174, 152);
            this.cbxRecurso.Name = "cbxRecurso";
            this.cbxRecurso.Size = new System.Drawing.Size(489, 29);
            this.cbxRecurso.TabIndex = 13;
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNotas.Location = new System.Drawing.Point(174, 408);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(489, 20);
            this.txtNotas.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(22, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notas:";
            // 
            // txtControl
            // 
            this.txtControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtControl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtControl.Location = new System.Drawing.Point(174, 357);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(489, 20);
            this.txtControl.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(22, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Control:";
            // 
            // cbxSectorRecurso
            // 
            this.cbxSectorRecurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxSectorRecurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSectorRecurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxSectorRecurso.FormattingEnabled = true;
            this.cbxSectorRecurso.Items.AddRange(new object[] {
            "REGION ",
            "PAIS",
            "PROVINCIA",
            "CANTON",
            "PARROQUIA/COMUNIDAD"});
            this.cbxSectorRecurso.Location = new System.Drawing.Point(174, 54);
            this.cbxSectorRecurso.Name = "cbxSectorRecurso";
            this.cbxSectorRecurso.Size = new System.Drawing.Size(227, 29);
            this.cbxSectorRecurso.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(509, -68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 22);
            this.label17.TabIndex = 2;
            this.label17.Text = "ACTOR";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(509, -33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 22);
            this.label16.TabIndex = 2;
            this.label16.Text = "ACTOR";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "RECURSOS IMPORTANTES PARA LOS MEDIOS DE VIDA";
            // 
            // lblRecursoSector
            // 
            this.lblRecursoSector.AutoSize = true;
            this.lblRecursoSector.BackColor = System.Drawing.Color.Transparent;
            this.lblRecursoSector.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecursoSector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecursoSector.Location = new System.Drawing.Point(22, 57);
            this.lblRecursoSector.Name = "lblRecursoSector";
            this.lblRecursoSector.Size = new System.Drawing.Size(64, 21);
            this.lblRecursoSector.TabIndex = 3;
            this.lblRecursoSector.Text = "Sector:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Recurso:";
            // 
            // frmRecursoImportante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(711, 525);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRecursoImportante";
            this.Text = "frmIngresarRiesgoClimatico";
            this.Load += new System.EventHandler(this.frmRecursoImportante_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarCambio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxAcceso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxCalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoRecurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRecurso;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSectorRecurso;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecursoSector;
        private System.Windows.Forms.Label label5;
    }
}