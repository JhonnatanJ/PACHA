﻿
namespace CapaPresentacion
{
    partial class frmVisualizarActores
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
            this.dgvActores = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarActor = new System.Windows.Forms.Button();
            this.lblGuia = new System.Windows.Forms.Label();
            this.cboActores = new System.Windows.Forms.ComboBox();
            this.btnModificarActor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProyectos = new System.Windows.Forms.ComboBox();
            this.btnModificarProyecto = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.panelActor = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtrelacionAnalisis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcompetenciaRel = new System.Windows.Forms.TextBox();
            this.txtsiglas = new System.Windows.Forms.TextBox();
            this.txtnombreActor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarActor = new System.Windows.Forms.Button();
            this.btnCancelarActor = new System.Windows.Forms.Button();
            this.panelProyecto = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtresponsable = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtobjetivo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtnombreProyecto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGuardarProyecto = new System.Windows.Forms.Button();
            this.btnCancelarProyecto = new System.Windows.Forms.Button();
            this.btnInsertarProyecto = new System.Windows.Forms.Button();
            this.btnInsProy = new System.Windows.Forms.Button();
            this.panelInsProy = new System.Windows.Forms.Panel();
            this.btnCanIns = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsEm = new System.Windows.Forms.TextBox();
            this.txtInsTel = new System.Windows.Forms.TextBox();
            this.txtInsResp = new System.Windows.Forms.TextBox();
            this.txtInsCarg = new System.Windows.Forms.TextBox();
            this.txtInsObj = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtInsNom = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.panelActor.SuspendLayout();
            this.panelProyecto.SuspendLayout();
            this.panelInsProy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActores
            // 
            this.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActores.Location = new System.Drawing.Point(12, 95);
            this.dgvActores.Name = "dgvActores";
            this.dgvActores.RowHeadersWidth = 51;
            this.dgvActores.RowTemplate.Height = 24;
            this.dgvActores.Size = new System.Drawing.Size(984, 70);
            this.dgvActores.TabIndex = 0;
            this.dgvActores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.btnInsProy);
            this.panel2.Controls.Add(this.btnEliminarActor);
            this.panel2.Controls.Add(this.lblGuia);
            this.panel2.Controls.Add(this.cboActores);
            this.panel2.Controls.Add(this.btnModificarActor);
            this.panel2.Location = new System.Drawing.Point(183, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 77);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnEliminarActor
            // 
            this.btnEliminarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnEliminarActor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarActor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarActor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarActor.Location = new System.Drawing.Point(371, 36);
            this.btnEliminarActor.Name = "btnEliminarActor";
            this.btnEliminarActor.Size = new System.Drawing.Size(109, 31);
            this.btnEliminarActor.TabIndex = 13;
            this.btnEliminarActor.Text = "Eliminar";
            this.btnEliminarActor.UseVisualStyleBackColor = false;
            this.btnEliminarActor.Click += new System.EventHandler(this.btnEliminarActor_Click);
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.BackColor = System.Drawing.Color.Transparent;
            this.lblGuia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuia.Location = new System.Drawing.Point(152, 10);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(201, 23);
            this.lblGuia.TabIndex = 12;
            this.lblGuia.Text = "Seleccióne el actor";
            // 
            // cboActores
            // 
            this.cboActores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.cboActores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboActores.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboActores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboActores.FormattingEnabled = true;
            this.cboActores.Location = new System.Drawing.Point(46, 36);
            this.cboActores.Name = "cboActores";
            this.cboActores.Size = new System.Drawing.Size(203, 31);
            this.cboActores.TabIndex = 1;
            this.cboActores.SelectedIndexChanged += new System.EventHandler(this.cboActores_SelectedIndexChanged);
            // 
            // btnModificarActor
            // 
            this.btnModificarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnModificarActor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarActor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarActor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarActor.Location = new System.Drawing.Point(255, 36);
            this.btnModificarActor.Name = "btnModificarActor";
            this.btnModificarActor.Size = new System.Drawing.Size(110, 31);
            this.btnModificarActor.TabIndex = 7;
            this.btnModificarActor.Text = "Modificar";
            this.btnModificarActor.UseVisualStyleBackColor = false;
            this.btnModificarActor.Click += new System.EventHandler(this.btnModificarActor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.btnEliminarProyecto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboProyectos);
            this.panel1.Controls.Add(this.btnModificarProyecto);
            this.panel1.Location = new System.Drawing.Point(267, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 77);
            this.panel1.TabIndex = 4;
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProyecto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(371, 36);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(109, 31);
            this.btnEliminarProyecto.TabIndex = 13;
            this.btnEliminarProyecto.Text = "Eliminar";
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(152, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccióne el proyecto";
            // 
            // cboProyectos
            // 
            this.cboProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.cboProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboProyectos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboProyectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboProyectos.FormattingEnabled = true;
            this.cboProyectos.Location = new System.Drawing.Point(46, 36);
            this.cboProyectos.Name = "cboProyectos";
            this.cboProyectos.Size = new System.Drawing.Size(203, 31);
            this.cboProyectos.TabIndex = 1;
            this.cboProyectos.SelectedIndexChanged += new System.EventHandler(this.cboProyectos_SelectedIndexChanged);
            // 
            // btnModificarProyecto
            // 
            this.btnModificarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnModificarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarProyecto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarProyecto.Location = new System.Drawing.Point(255, 36);
            this.btnModificarProyecto.Name = "btnModificarProyecto";
            this.btnModificarProyecto.Size = new System.Drawing.Size(110, 31);
            this.btnModificarProyecto.TabIndex = 7;
            this.btnModificarProyecto.Text = "Modificar";
            this.btnModificarProyecto.UseVisualStyleBackColor = false;
            this.btnModificarProyecto.Click += new System.EventHandler(this.btnModificarProyecto_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(12, 254);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 24;
            this.dgvProyectos.Size = new System.Drawing.Size(984, 70);
            this.dgvProyectos.TabIndex = 5;
            // 
            // panelActor
            // 
            this.panelActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.panelActor.Controls.Add(this.btnCancelarActor);
            this.panelActor.Controls.Add(this.btnGuardarActor);
            this.panelActor.Controls.Add(this.label17);
            this.panelActor.Controls.Add(this.label16);
            this.panelActor.Controls.Add(this.txttipo);
            this.panelActor.Controls.Add(this.txtrelacionAnalisis);
            this.panelActor.Controls.Add(this.label3);
            this.panelActor.Controls.Add(this.txtcompetenciaRel);
            this.panelActor.Controls.Add(this.txtsiglas);
            this.panelActor.Controls.Add(this.txtnombreActor);
            this.panelActor.Controls.Add(this.label6);
            this.panelActor.Controls.Add(this.label4);
            this.panelActor.Controls.Add(this.label8);
            this.panelActor.Controls.Add(this.label7);
            this.panelActor.Controls.Add(this.label5);
            this.panelActor.Location = new System.Drawing.Point(12, 342);
            this.panelActor.Name = "panelActor";
            this.panelActor.Size = new System.Drawing.Size(984, 205);
            this.panelActor.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(509, -68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 30);
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
            this.label16.Size = new System.Drawing.Size(97, 30);
            this.label16.TabIndex = 2;
            this.label16.Text = "ACTOR";
            // 
            // txttipo
            // 
            this.txttipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txttipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttipo.Location = new System.Drawing.Point(123, 122);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(224, 25);
            this.txttipo.TabIndex = 4;
            // 
            // txtrelacionAnalisis
            // 
            this.txtrelacionAnalisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtrelacionAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrelacionAnalisis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrelacionAnalisis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtrelacionAnalisis.Location = new System.Drawing.Point(730, 49);
            this.txtrelacionAnalisis.Name = "txtrelacionAnalisis";
            this.txtrelacionAnalisis.Size = new System.Drawing.Size(224, 25);
            this.txtrelacionAnalisis.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(365, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "MODIFICAR ACTOR";
            // 
            // txtcompetenciaRel
            // 
            this.txtcompetenciaRel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtcompetenciaRel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcompetenciaRel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompetenciaRel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcompetenciaRel.Location = new System.Drawing.Point(730, 100);
            this.txtcompetenciaRel.Name = "txtcompetenciaRel";
            this.txtcompetenciaRel.Size = new System.Drawing.Size(224, 25);
            this.txtcompetenciaRel.TabIndex = 4;
            // 
            // txtsiglas
            // 
            this.txtsiglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtsiglas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsiglas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsiglas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsiglas.Location = new System.Drawing.Point(123, 81);
            this.txtsiglas.Name = "txtsiglas";
            this.txtsiglas.Size = new System.Drawing.Size(224, 25);
            this.txtsiglas.TabIndex = 4;
            // 
            // txtnombreActor
            // 
            this.txtnombreActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtnombreActor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombreActor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreActor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnombreActor.Location = new System.Drawing.Point(123, 34);
            this.txtnombreActor.Name = "txtnombreActor";
            this.txtnombreActor.Size = new System.Drawing.Size(224, 25);
            this.txtnombreActor.TabIndex = 4;
            this.txtnombreActor.TextChanged += new System.EventHandler(this.txtnombreActor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(64, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(423, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Competencias Relacionadas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(376, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(348, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Relaciones con Unidad de Análisis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(49, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Siglas:";
            // 
            // btnGuardarActor
            // 
            this.btnGuardarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnGuardarActor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarActor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarActor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarActor.Location = new System.Drawing.Point(345, 162);
            this.btnGuardarActor.Name = "btnGuardarActor";
            this.btnGuardarActor.Size = new System.Drawing.Size(110, 31);
            this.btnGuardarActor.TabIndex = 8;
            this.btnGuardarActor.Text = "Guardar";
            this.btnGuardarActor.UseVisualStyleBackColor = false;
            this.btnGuardarActor.Click += new System.EventHandler(this.btnGuardarActor_Click);
            // 
            // btnCancelarActor
            // 
            this.btnCancelarActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnCancelarActor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarActor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarActor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarActor.Location = new System.Drawing.Point(510, 162);
            this.btnCancelarActor.Name = "btnCancelarActor";
            this.btnCancelarActor.Size = new System.Drawing.Size(110, 31);
            this.btnCancelarActor.TabIndex = 9;
            this.btnCancelarActor.Text = "Cancelar";
            this.btnCancelarActor.UseVisualStyleBackColor = false;
            this.btnCancelarActor.Click += new System.EventHandler(this.btnCancelarActor_Click);
            // 
            // panelProyecto
            // 
            this.panelProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.panelProyecto.Controls.Add(this.btnCancelarProyecto);
            this.panelProyecto.Controls.Add(this.btnGuardarProyecto);
            this.panelProyecto.Controls.Add(this.label9);
            this.panelProyecto.Controls.Add(this.txtemail);
            this.panelProyecto.Controls.Add(this.txttelefono);
            this.panelProyecto.Controls.Add(this.txtresponsable);
            this.panelProyecto.Controls.Add(this.txtcargo);
            this.panelProyecto.Controls.Add(this.txtobjetivo);
            this.panelProyecto.Controls.Add(this.label13);
            this.panelProyecto.Controls.Add(this.txtnombreProyecto);
            this.panelProyecto.Controls.Add(this.label12);
            this.panelProyecto.Controls.Add(this.label11);
            this.panelProyecto.Controls.Add(this.label10);
            this.panelProyecto.Controls.Add(this.label15);
            this.panelProyecto.Controls.Add(this.label14);
            this.panelProyecto.Location = new System.Drawing.Point(9, 345);
            this.panelProyecto.Name = "panelProyecto";
            this.panelProyecto.Size = new System.Drawing.Size(984, 208);
            this.panelProyecto.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(372, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "MODIFICAR PROYECTO";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtemail.Location = new System.Drawing.Point(708, 133);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(246, 25);
            this.txtemail.TabIndex = 4;
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttelefono.Location = new System.Drawing.Point(730, 90);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(224, 25);
            this.txttelefono.TabIndex = 4;
            // 
            // txtresponsable
            // 
            this.txtresponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtresponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtresponsable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresponsable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtresponsable.Location = new System.Drawing.Point(153, 131);
            this.txtresponsable.Name = "txtresponsable";
            this.txtresponsable.Size = new System.Drawing.Size(224, 25);
            this.txtresponsable.TabIndex = 4;
            // 
            // txtcargo
            // 
            this.txtcargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtcargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcargo.Location = new System.Drawing.Point(730, 46);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(224, 25);
            this.txtcargo.TabIndex = 4;
            // 
            // txtobjetivo
            // 
            this.txtobjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtobjetivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtobjetivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobjetivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtobjetivo.Location = new System.Drawing.Point(153, 90);
            this.txtobjetivo.Name = "txtobjetivo";
            this.txtobjetivo.Size = new System.Drawing.Size(302, 25);
            this.txtobjetivo.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(637, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cargo:";
            // 
            // txtnombreProyecto
            // 
            this.txtnombreProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtnombreProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombreProyecto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnombreProyecto.Location = new System.Drawing.Point(153, 46);
            this.txtnombreProyecto.Name = "txtnombreProyecto";
            this.txtnombreProyecto.Size = new System.Drawing.Size(224, 25);
            this.txtnombreProyecto.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(626, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "e-mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(52, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(626, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Teléfono:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(9, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Responsable:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(52, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "Objetivo:";
            // 
            // btnGuardarProyecto
            // 
            this.btnGuardarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnGuardarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarProyecto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarProyecto.Location = new System.Drawing.Point(377, 167);
            this.btnGuardarProyecto.Name = "btnGuardarProyecto";
            this.btnGuardarProyecto.Size = new System.Drawing.Size(110, 31);
            this.btnGuardarProyecto.TabIndex = 9;
            this.btnGuardarProyecto.Text = "Guardar";
            this.btnGuardarProyecto.UseVisualStyleBackColor = false;
            this.btnGuardarProyecto.Click += new System.EventHandler(this.btnGuardarProyecto_Click);
            // 
            // btnCancelarProyecto
            // 
            this.btnCancelarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnCancelarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarProyecto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarProyecto.Location = new System.Drawing.Point(532, 167);
            this.btnCancelarProyecto.Name = "btnCancelarProyecto";
            this.btnCancelarProyecto.Size = new System.Drawing.Size(110, 31);
            this.btnCancelarProyecto.TabIndex = 10;
            this.btnCancelarProyecto.Text = "Cancelar";
            this.btnCancelarProyecto.UseVisualStyleBackColor = false;
            this.btnCancelarProyecto.Click += new System.EventHandler(this.btnCancelarProyecto_Click);
            // 
            // btnInsertarProyecto
            // 
            this.btnInsertarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnInsertarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertarProyecto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertarProyecto.Location = new System.Drawing.Point(380, 167);
            this.btnInsertarProyecto.Name = "btnInsertarProyecto";
            this.btnInsertarProyecto.Size = new System.Drawing.Size(110, 31);
            this.btnInsertarProyecto.TabIndex = 11;
            this.btnInsertarProyecto.Text = "Insertar";
            this.btnInsertarProyecto.UseVisualStyleBackColor = false;
            this.btnInsertarProyecto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsProy
            // 
            this.btnInsProy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnInsProy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsProy.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsProy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsProy.Location = new System.Drawing.Point(486, 36);
            this.btnInsProy.Name = "btnInsProy";
            this.btnInsProy.Size = new System.Drawing.Size(176, 31);
            this.btnInsProy.TabIndex = 14;
            this.btnInsProy.Text = "Insertar Proyecto";
            this.btnInsProy.UseVisualStyleBackColor = false;
            this.btnInsProy.Click += new System.EventHandler(this.btnInsProy_Click);
            // 
            // panelInsProy
            // 
            this.panelInsProy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.panelInsProy.Controls.Add(this.btnCanIns);
            this.panelInsProy.Controls.Add(this.label2);
            this.panelInsProy.Controls.Add(this.btnInsertarProyecto);
            this.panelInsProy.Controls.Add(this.txtInsEm);
            this.panelInsProy.Controls.Add(this.txtInsTel);
            this.panelInsProy.Controls.Add(this.txtInsResp);
            this.panelInsProy.Controls.Add(this.txtInsCarg);
            this.panelInsProy.Controls.Add(this.txtInsObj);
            this.panelInsProy.Controls.Add(this.label18);
            this.panelInsProy.Controls.Add(this.txtInsNom);
            this.panelInsProy.Controls.Add(this.label19);
            this.panelInsProy.Controls.Add(this.label20);
            this.panelInsProy.Controls.Add(this.label21);
            this.panelInsProy.Controls.Add(this.label22);
            this.panelInsProy.Controls.Add(this.label23);
            this.panelInsProy.Location = new System.Drawing.Point(22, 335);
            this.panelInsProy.Name = "panelInsProy";
            this.panelInsProy.Size = new System.Drawing.Size(984, 208);
            this.panelInsProy.TabIndex = 12;
            // 
            // btnCanIns
            // 
            this.btnCanIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnCanIns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanIns.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanIns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCanIns.Location = new System.Drawing.Point(532, 167);
            this.btnCanIns.Name = "btnCanIns";
            this.btnCanIns.Size = new System.Drawing.Size(110, 31);
            this.btnCanIns.TabIndex = 10;
            this.btnCanIns.Text = "Cancelar";
            this.btnCanIns.UseVisualStyleBackColor = false;
            this.btnCanIns.Click += new System.EventHandler(this.btnCanIns_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(365, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "INSERTAR PROYECTO";
            // 
            // txtInsEm
            // 
            this.txtInsEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtInsEm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsEm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsEm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInsEm.Location = new System.Drawing.Point(708, 133);
            this.txtInsEm.Name = "txtInsEm";
            this.txtInsEm.Size = new System.Drawing.Size(246, 25);
            this.txtInsEm.TabIndex = 4;
            // 
            // txtInsTel
            // 
            this.txtInsTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtInsTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInsTel.Location = new System.Drawing.Point(730, 90);
            this.txtInsTel.Name = "txtInsTel";
            this.txtInsTel.Size = new System.Drawing.Size(224, 25);
            this.txtInsTel.TabIndex = 4;
            // 
            // txtInsResp
            // 
            this.txtInsResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtInsResp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsResp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsResp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInsResp.Location = new System.Drawing.Point(153, 131);
            this.txtInsResp.Name = "txtInsResp";
            this.txtInsResp.Size = new System.Drawing.Size(224, 25);
            this.txtInsResp.TabIndex = 4;
            // 
            // txtInsCarg
            // 
            this.txtInsCarg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtInsCarg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsCarg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsCarg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInsCarg.Location = new System.Drawing.Point(730, 46);
            this.txtInsCarg.Name = "txtInsCarg";
            this.txtInsCarg.Size = new System.Drawing.Size(224, 25);
            this.txtInsCarg.TabIndex = 4;
            // 
            // txtInsObj
            // 
            this.txtInsObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtInsObj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsObj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsObj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInsObj.Location = new System.Drawing.Point(153, 90);
            this.txtInsObj.Name = "txtInsObj";
            this.txtInsObj.Size = new System.Drawing.Size(302, 25);
            this.txtInsObj.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(637, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 23);
            this.label18.TabIndex = 3;
            this.label18.Text = "Cargo:";
            // 
            // txtInsNom
            // 
            this.txtInsNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtInsNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsNom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInsNom.Location = new System.Drawing.Point(153, 46);
            this.txtInsNom.Name = "txtInsNom";
            this.txtInsNom.Size = new System.Drawing.Size(224, 25);
            this.txtInsNom.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(626, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 23);
            this.label19.TabIndex = 3;
            this.label19.Text = "e-mail:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(52, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 23);
            this.label20.TabIndex = 3;
            this.label20.Text = "Nombre:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(626, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 23);
            this.label21.TabIndex = 3;
            this.label21.Text = "Teléfono:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(9, 131);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 23);
            this.label22.TabIndex = 3;
            this.label22.Text = "Responsable:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(52, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 23);
            this.label23.TabIndex = 3;
            this.label23.Text = "Objetivo:";
            // 
            // frmVisualizarActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1048, 670);
            this.Controls.Add(this.panelInsProy);
            this.Controls.Add(this.panelProyecto);
            this.Controls.Add(this.panelActor);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvActores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisualizarActores";
            this.Text = "frmCambioClimatico";
            this.Load += new System.EventHandler(this.frmCambioClimatico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.panelActor.ResumeLayout(false);
            this.panelActor.PerformLayout();
            this.panelProyecto.ResumeLayout(false);
            this.panelProyecto.PerformLayout();
            this.panelInsProy.ResumeLayout(false);
            this.panelInsProy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminarActor;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.ComboBox cboActores;
        private System.Windows.Forms.Button btnModificarActor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProyectos;
        private System.Windows.Forms.Button btnModificarProyecto;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Panel panelActor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtrelacionAnalisis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcompetenciaRel;
        private System.Windows.Forms.TextBox txtsiglas;
        private System.Windows.Forms.TextBox txtnombreActor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarActor;
        private System.Windows.Forms.Button btnCancelarActor;
        private System.Windows.Forms.Panel panelProyecto;
        private System.Windows.Forms.Button btnCancelarProyecto;
        private System.Windows.Forms.Button btnGuardarProyecto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtresponsable;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtobjetivo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtnombreProyecto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnInsertarProyecto;
        private System.Windows.Forms.Button btnInsProy;
        private System.Windows.Forms.Panel panelInsProy;
        private System.Windows.Forms.Button btnCanIns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsEm;
        private System.Windows.Forms.TextBox txtInsTel;
        private System.Windows.Forms.TextBox txtInsResp;
        private System.Windows.Forms.TextBox txtInsCarg;
        private System.Windows.Forms.TextBox txtInsObj;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtInsNom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}