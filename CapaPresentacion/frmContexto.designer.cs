
namespace CapaPresentacion
{
    partial class frmContexto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClima = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarClima = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClima)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.dgvClima);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(35, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 480);
            this.panel2.TabIndex = 4;
            // 
            // dgvClima
            // 
            this.dgvClima.AllowUserToAddRows = false;
            this.dgvClima.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClima.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClima.Location = new System.Drawing.Point(23, 64);
            this.dgvClima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClima.Name = "dgvClima";
            this.dgvClima.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClima.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClima.RowHeadersWidth = 51;
            this.dgvClima.RowTemplate.Height = 24;
            this.dgvClima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClima.Size = new System.Drawing.Size(1100, 399);
            this.dgvClima.TabIndex = 5;
            this.dgvClima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClima_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(373, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "CONTEXTO DE CAMBIO CLIMÁTICO";
            // 
            // btnEliminarClima
            // 
            this.btnEliminarClima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnEliminarClima.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarClima.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarClima.Location = new System.Drawing.Point(499, 550);
            this.btnEliminarClima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarClima.Name = "btnEliminarClima";
            this.btnEliminarClima.Size = new System.Drawing.Size(176, 46);
            this.btnEliminarClima.TabIndex = 13;
            this.btnEliminarClima.Text = "Eliminar";
            this.btnEliminarClima.UseVisualStyleBackColor = false;
            this.btnEliminarClima.Click += new System.EventHandler(this.btnEliminarClima_Click);
            // 
            // frmContexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1209, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminarClima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmContexto";
            this.Text = "frmContexto";
            this.Load += new System.EventHandler(this.frmContexto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminarClima;
        private System.Windows.Forms.DataGridView dgvClima;
        private System.Windows.Forms.Label label1;
    }
}