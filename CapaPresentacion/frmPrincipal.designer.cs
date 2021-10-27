
namespace CapaPresentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombreComunidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFases = new System.Windows.Forms.Panel();
            this.btnCambiarComunidad = new System.Windows.Forms.Button();
            this.pnlBtnCambioClim = new System.Windows.Forms.Panel();
            this.pnlBtnContexto = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActoresLocales = new System.Windows.Forms.Button();
            this.pnlBtnActores = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelFases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.pbMinimizar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblNombreComunidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 68);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1165, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombreComunidad
            // 
            this.lblNombreComunidad.AutoSize = true;
            this.lblNombreComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreComunidad.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComunidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreComunidad.Location = new System.Drawing.Point(562, 15);
            this.lblNombreComunidad.Name = "lblNombreComunidad";
            this.lblNombreComunidad.Size = new System.Drawing.Size(194, 34);
            this.lblNombreComunidad.TabIndex = 3;
            this.lblNombreComunidad.Text = "COMUNIDAD";
            this.lblNombreComunidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "PACHA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelFases
            // 
            this.panelFases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.panelFases.Controls.Add(this.btnCambiarComunidad);
            this.panelFases.Controls.Add(this.pnlBtnCambioClim);
            this.panelFases.Controls.Add(this.pnlBtnContexto);
            this.panelFases.Controls.Add(this.button3);
            this.panelFases.Controls.Add(this.button2);
            this.panelFases.Controls.Add(this.btnActoresLocales);
            this.panelFases.Controls.Add(this.pnlBtnActores);
            this.panelFases.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFases.Location = new System.Drawing.Point(0, 68);
            this.panelFases.Name = "panelFases";
            this.panelFases.Size = new System.Drawing.Size(194, 603);
            this.panelFases.TabIndex = 1;
            // 
            // btnCambiarComunidad
            // 
            this.btnCambiarComunidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnCambiarComunidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.btnCambiarComunidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.btnCambiarComunidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarComunidad.Location = new System.Drawing.Point(6, 544);
            this.btnCambiarComunidad.Name = "btnCambiarComunidad";
            this.btnCambiarComunidad.Size = new System.Drawing.Size(182, 47);
            this.btnCambiarComunidad.TabIndex = 4;
            this.btnCambiarComunidad.Text = "Cambiar Comunidad";
            this.btnCambiarComunidad.UseVisualStyleBackColor = false;
            this.btnCambiarComunidad.Click += new System.EventHandler(this.btnCambiarComunidad_Click);
            // 
            // pnlBtnCambioClim
            // 
            this.pnlBtnCambioClim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.pnlBtnCambioClim.Location = new System.Drawing.Point(3, 188);
            this.pnlBtnCambioClim.Name = "pnlBtnCambioClim";
            this.pnlBtnCambioClim.Size = new System.Drawing.Size(11, 47);
            this.pnlBtnCambioClim.TabIndex = 3;
            this.pnlBtnCambioClim.Visible = false;
            // 
            // pnlBtnContexto
            // 
            this.pnlBtnContexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.pnlBtnContexto.Location = new System.Drawing.Point(3, 135);
            this.pnlBtnContexto.Name = "pnlBtnContexto";
            this.pnlBtnContexto.Size = new System.Drawing.Size(11, 47);
            this.pnlBtnContexto.TabIndex = 3;
            this.pnlBtnContexto.Visible = false;
            this.pnlBtnContexto.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Visualizar Datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "1.2 Contexto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActoresLocales
            // 
            this.btnActoresLocales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.btnActoresLocales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.btnActoresLocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActoresLocales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActoresLocales.Location = new System.Drawing.Point(12, 82);
            this.btnActoresLocales.Name = "btnActoresLocales";
            this.btnActoresLocales.Size = new System.Drawing.Size(182, 47);
            this.btnActoresLocales.TabIndex = 2;
            this.btnActoresLocales.Text = "1.1 Actores Locales";
            this.btnActoresLocales.UseVisualStyleBackColor = true;
            this.btnActoresLocales.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlBtnActores
            // 
            this.pnlBtnActores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(204)))), ((int)(((byte)(177)))));
            this.pnlBtnActores.Location = new System.Drawing.Point(3, 82);
            this.pnlBtnActores.Name = "pnlBtnActores";
            this.pnlBtnActores.Size = new System.Drawing.Size(11, 47);
            this.pnlBtnActores.TabIndex = 2;
            this.pnlBtnActores.Visible = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(194, 68);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1008, 603);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.logoPNG;
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Image = global::CapaPresentacion.Properties.Resources.iconMinimiz;
            this.pbMinimizar.Location = new System.Drawing.Point(1126, 19);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(23, 9);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 15;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1202, 671);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelFases);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelFases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreComunidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFases;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnActoresLocales;
        private System.Windows.Forms.Panel pnlBtnActores;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnlBtnCambioClim;
        private System.Windows.Forms.Panel pnlBtnContexto;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnCambiarComunidad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbMinimizar;
    }
}

