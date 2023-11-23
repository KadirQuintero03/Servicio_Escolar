namespace PresentacionGPU
{
    partial class UserType
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
            this.BoxUser = new System.Windows.Forms.TextBox();
            this.BoxUserType = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxUser
            // 
            this.BoxUser.AutoCompleteCustomSource.AddRange(new string[] {
            "Kendrys",
            "Kadir",
            "nose"});
            this.BoxUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BoxUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BoxUser.BackColor = System.Drawing.Color.White;
            this.BoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUser.Location = new System.Drawing.Point(374, 317);
            this.BoxUser.Name = "BoxUser";
            this.BoxUser.Size = new System.Drawing.Size(182, 20);
            this.BoxUser.TabIndex = 1;
            this.BoxUser.Text = "Usuario";
            this.BoxUser.Enter += new System.EventHandler(this.BoxUser_Enter);
            this.BoxUser.Leave += new System.EventHandler(this.BoxUser_Leave);
            // 
            // BoxUserType
            // 
            this.BoxUserType.BackColor = System.Drawing.Color.White;
            this.BoxUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoxUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxUserType.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUserType.FormattingEnabled = true;
            this.BoxUserType.Items.AddRange(new object[] {
            "Administrador",
            "Estudiante",
            "Profesor"});
            this.BoxUserType.Location = new System.Drawing.Point(356, 245);
            this.BoxUserType.Name = "BoxUserType";
            this.BoxUserType.Size = new System.Drawing.Size(182, 24);
            this.BoxUserType.TabIndex = 0;
            this.BoxUserType.SelectionChangeCommitted += new System.EventHandler(this.BoxUserType_SelectionChangeCommitted);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(213)))), ((int)(((byte)(99)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(335, 455);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(232, 41);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ACCEDER";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAceptar_KeyPress);
            // 
            // BoxPassword
            // 
            this.BoxPassword.AutoCompleteCustomSource.AddRange(new string[] {
            "Kendrys",
            "Kadir",
            "nose"});
            this.BoxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BoxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BoxPassword.BackColor = System.Drawing.Color.White;
            this.BoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPassword.Location = new System.Drawing.Point(374, 385);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(182, 20);
            this.BoxPassword.TabIndex = 2;
            this.BoxPassword.Text = "Contraseña";
            this.BoxPassword.Enter += new System.EventHandler(this.BoxPassword_Enter);
            this.BoxPassword.Leave += new System.EventHandler(this.BoxPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(364, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Image = global::PresentacionGPU.Properties.Resources.cerrar;
            this.BtnSalir.Location = new System.Drawing.Point(857, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(40, 28);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::PresentacionGPU.Properties.Resources.minimizar_signo;
            this.BtnMinimizar.Location = new System.Drawing.Point(811, 2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(40, 28);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 6;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // UserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::PresentacionGPU.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.BoxUserType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxPassword);
            this.Controls.Add(this.BoxUser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserType";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso de usuario";
            this.Load += new System.EventHandler(this.UserType_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserType_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BoxUser;
        private System.Windows.Forms.ComboBox BoxUserType;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.PictureBox BtnMinimizar;
    }
}

