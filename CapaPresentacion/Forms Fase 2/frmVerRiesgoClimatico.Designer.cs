
namespace CapaPresentacion.Forms_Fase_2
{
    partial class frmVerRiesgoClimatico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRiesgoClimatico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarClima = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiesgoClimatico)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRiesgoClimatico
            // 
            this.dgvRiesgoClimatico.AllowUserToAddRows = false;
            this.dgvRiesgoClimatico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRiesgoClimatico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRiesgoClimatico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiesgoClimatico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiesgoClimatico.Location = new System.Drawing.Point(15, 80);
            this.dgvRiesgoClimatico.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRiesgoClimatico.Name = "dgvRiesgoClimatico";
            this.dgvRiesgoClimatico.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRiesgoClimatico.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRiesgoClimatico.RowHeadersWidth = 51;
            this.dgvRiesgoClimatico.RowTemplate.Height = 24;
            this.dgvRiesgoClimatico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRiesgoClimatico.Size = new System.Drawing.Size(816, 324);
            this.dgvRiesgoClimatico.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(220, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "RIESGO CLIMÁTICO EN LA UNIDAD DE ANÁLISIS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnEliminarClima);
            this.panel2.Controls.Add(this.dgvRiesgoClimatico);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 463);
            this.panel2.TabIndex = 8;
            // 
            // btnEliminarClima
            // 
            this.btnEliminarClima.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarClima.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnEliminarClima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnEliminarClima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.btnEliminarClima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClima.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClima.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarClima.Location = new System.Drawing.Point(356, 415);
            this.btnEliminarClima.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarClima.Name = "btnEliminarClima";
            this.btnEliminarClima.Size = new System.Drawing.Size(132, 37);
            this.btnEliminarClima.TabIndex = 15;
            this.btnEliminarClima.Text = "Eliminar";
            this.btnEliminarClima.UseVisualStyleBackColor = false;
            this.btnEliminarClima.Click += new System.EventHandler(this.btnEliminarClima_Click);
            // 
            // frmVerRiesgoClimatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(867, 485);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVerRiesgoClimatico";
            this.Text = "frmVerRiesgoClimatico";
            this.Load += new System.EventHandler(this.frmVerRiesgoClimatico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiesgoClimatico)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRiesgoClimatico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminarClima;
    }
}