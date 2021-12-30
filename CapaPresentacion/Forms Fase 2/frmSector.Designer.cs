
namespace CapaPresentacion.Forms_Fase_2
{
    partial class frmSector
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtNombreSector = new System.Windows.Forms.TextBox();
            this.lblNombreSector = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.lblNombreSector);
            this.panel2.Controls.Add(this.txtNombreSector);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.lblSector);
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 210);
            this.panel2.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(226, 142);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 34);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(98)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsert.Location = new System.Drawing.Point(355, 142);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 34);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblSector
            // 
            this.lblSector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSector.AutoSize = true;
            this.lblSector.BackColor = System.Drawing.Color.Transparent;
            this.lblSector.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblSector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSector.Location = new System.Drawing.Point(302, 19);
            this.lblSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(81, 22);
            this.lblSector.TabIndex = 12;
            this.lblSector.Text = "SECTOR";
            // 
            // txtNombreSector
            // 
            this.txtNombreSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtNombreSector.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombreSector.Location = new System.Drawing.Point(337, 77);
            this.txtNombreSector.Name = "txtNombreSector";
            this.txtNombreSector.Size = new System.Drawing.Size(255, 27);
            this.txtNombreSector.TabIndex = 57;
            // 
            // lblNombreSector
            // 
            this.lblNombreSector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreSector.AutoSize = true;
            this.lblNombreSector.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreSector.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreSector.Location = new System.Drawing.Point(71, 80);
            this.lblNombreSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreSector.Name = "lblNombreSector";
            this.lblNombreSector.Size = new System.Drawing.Size(235, 21);
            this.lblNombreSector.TabIndex = 58;
            this.lblNombreSector.Text = "Ingrese el nombre del Sector:";
            // 
            // frmSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(695, 232);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txtNombreSector;
        private System.Windows.Forms.Label lblNombreSector;
    }
}