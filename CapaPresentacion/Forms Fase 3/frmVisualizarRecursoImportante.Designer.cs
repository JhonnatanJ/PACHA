
namespace CapaPresentacion.Forms_Fase_3
{
    partial class frmVisualizarRecursoImportante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarClima = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecursoImportante = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursoImportante)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvRecursoImportante);
            this.panel2.Location = new System.Drawing.Point(14, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 529);
            this.panel2.TabIndex = 5;
            // 
            // btnEliminarClima
            // 
            this.btnEliminarClima.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarClima.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarClima.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnEliminarClima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnEliminarClima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnEliminarClima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClima.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClima.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarClima.Location = new System.Drawing.Point(407, 576);
            this.btnEliminarClima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarClima.Name = "btnEliminarClima";
            this.btnEliminarClima.Size = new System.Drawing.Size(210, 46);
            this.btnEliminarClima.TabIndex = 14;
            this.btnEliminarClima.Text = "Eliminar";
            this.btnEliminarClima.UseVisualStyleBackColor = false;
            this.btnEliminarClima.Click += new System.EventHandler(this.btnEliminarClima_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(153, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "RECURSOS IMPORTANTES PARA LOS MEDIOS DE VIDA";
            // 
            // dgvRecursoImportante
            // 
            this.dgvRecursoImportante.AllowUserToAddRows = false;
            this.dgvRecursoImportante.AllowUserToDeleteRows = false;
            this.dgvRecursoImportante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecursoImportante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecursoImportante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecursoImportante.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRecursoImportante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecursoImportante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecursoImportante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecursoImportante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecursoImportante.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecursoImportante.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvRecursoImportante.Location = new System.Drawing.Point(19, 73);
            this.dgvRecursoImportante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecursoImportante.MultiSelect = false;
            this.dgvRecursoImportante.Name = "dgvRecursoImportante";
            this.dgvRecursoImportante.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecursoImportante.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecursoImportante.RowHeadersVisible = false;
            this.dgvRecursoImportante.RowHeadersWidth = 51;
            this.dgvRecursoImportante.RowTemplate.Height = 24;
            this.dgvRecursoImportante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursoImportante.Size = new System.Drawing.Size(967, 431);
            this.dgvRecursoImportante.TabIndex = 5;
            // 
            // frmVisualizarRecursoImportante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1033, 704);
            this.Controls.Add(this.btnEliminarClima);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVisualizarRecursoImportante";
            this.Text = "frmIngresarRiesgoClimatico";
            this.Load += new System.EventHandler(this.frmVisualizarRecursoImportante_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursoImportante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvRecursoImportante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarClima;
    }
}