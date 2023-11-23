namespace PresentacionGPU
{
    partial class CambioContra
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
            this.btnCambio = new System.Windows.Forms.Button();
            this.ConfiNContraES = new System.Windows.Forms.TextBox();
            this.NuevaContraES = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambio
            // 
            this.btnCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(85)))));
            this.btnCambio.FlatAppearance.BorderSize = 0;
            this.btnCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambio.Location = new System.Drawing.Point(337, 409);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(161, 34);
            this.btnCambio.TabIndex = 0;
            this.btnCambio.Text = "Cambiar";
            this.btnCambio.UseVisualStyleBackColor = false;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // ConfiNContraES
            // 
            this.ConfiNContraES.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfiNContraES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfiNContraES.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfiNContraES.Location = new System.Drawing.Point(330, 337);
            this.ConfiNContraES.Name = "ConfiNContraES";
            this.ConfiNContraES.Size = new System.Drawing.Size(217, 20);
            this.ConfiNContraES.TabIndex = 1;
            this.ConfiNContraES.Text = "Contraseña nueva";
            this.ConfiNContraES.Enter += new System.EventHandler(this.ConfiNContraES_Enter);
            this.ConfiNContraES.Leave += new System.EventHandler(this.ConfiNContraES_Leave);
            // 
            // NuevaContraES
            // 
            this.NuevaContraES.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NuevaContraES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NuevaContraES.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaContraES.Location = new System.Drawing.Point(330, 247);
            this.NuevaContraES.Name = "NuevaContraES";
            this.NuevaContraES.Size = new System.Drawing.Size(217, 20);
            this.NuevaContraES.TabIndex = 2;
            this.NuevaContraES.Text = "Contraseña actual";
            this.NuevaContraES.Enter += new System.EventHandler(this.NuevaContraES_Enter);
            this.NuevaContraES.Leave += new System.EventHandler(this.NuevaContraES_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PresentacionGPU.Properties.Resources.exit_icon_icons_com_70975;
            this.pictureBox1.Location = new System.Drawing.Point(770, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CambioContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PresentacionGPU.Properties.Resources.a21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(832, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NuevaContraES);
            this.Controls.Add(this.ConfiNContraES);
            this.Controls.Add(this.btnCambio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambioContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambioContra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.TextBox ConfiNContraES;
        private System.Windows.Forms.TextBox NuevaContraES;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}