namespace PresentacionGPU
{
    partial class AdminDashboard
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
            this.GPR = new System.Windows.Forms.TabPage();
            this.BtnFIltro = new System.Windows.Forms.TextBox();
            this.AggGenero = new System.Windows.Forms.ComboBox();
            this.AggMateriaPR = new System.Windows.Forms.ComboBox();
            this.AggCursoPR = new System.Windows.Forms.ComboBox();
            this.AggDocPR = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.AggSedePR = new System.Windows.Forms.TextBox();
            this.AggCorreoPR = new System.Windows.Forms.TextBox();
            this.AggIdPR = new System.Windows.Forms.TextBox();
            this.Agg2ApellidoPR = new System.Windows.Forms.TextBox();
            this.Agg2NombrePR = new System.Windows.Forms.TextBox();
            this.AggApellidoPR = new System.Windows.Forms.TextBox();
            this.AggNombrePR = new System.Windows.Forms.TextBox();
            this.GridPR = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnNuevoPR = new System.Windows.Forms.Button();
            this.BtnModificarPR = new System.Windows.Forms.Button();
            this.BtnAgregarPR = new System.Windows.Forms.Button();
            this.GES = new System.Windows.Forms.TabPage();
            this.FIltro = new System.Windows.Forms.TextBox();
            this.AggCursoES = new System.Windows.Forms.ComboBox();
            this.AggDocES = new System.Windows.Forms.ComboBox();
            this.AggGeneroES = new System.Windows.Forms.ComboBox();
            this.GridES = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.AggSedeES = new System.Windows.Forms.TextBox();
            this.AggCorreoES = new System.Windows.Forms.TextBox();
            this.AggIdES = new System.Windows.Forms.TextBox();
            this.Agg2ApellidoES = new System.Windows.Forms.TextBox();
            this.Agg2NombreES = new System.Windows.Forms.TextBox();
            this.AggApellidoES = new System.Windows.Forms.TextBox();
            this.AggNombreES = new System.Windows.Forms.TextBox();
            this.BtnNuevoES = new System.Windows.Forms.Button();
            this.BtnModificarES = new System.Windows.Forms.Button();
            this.BtnAgregarES = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BtnMinUserType = new System.Windows.Forms.PictureBox();
            this.BtnSalirUserType = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GPR.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPR)).BeginInit();
            this.GES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridES)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinUserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirUserType)).BeginInit();
            this.SuspendLayout();
            // 
            // GPR
            // 
            this.GPR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GPR.BackgroundImage = global::PresentacionGPU.Properties.Resources.Blue_Minimalist_Corporate_Desktop_Prototype__1_1;
            this.GPR.Controls.Add(this.BtnFIltro);
            this.GPR.Controls.Add(this.AggGenero);
            this.GPR.Controls.Add(this.AggMateriaPR);
            this.GPR.Controls.Add(this.AggCursoPR);
            this.GPR.Controls.Add(this.AggDocPR);
            this.GPR.Controls.Add(this.panel2);
            this.GPR.Controls.Add(this.AggSedePR);
            this.GPR.Controls.Add(this.AggCorreoPR);
            this.GPR.Controls.Add(this.AggIdPR);
            this.GPR.Controls.Add(this.Agg2ApellidoPR);
            this.GPR.Controls.Add(this.Agg2NombrePR);
            this.GPR.Controls.Add(this.AggApellidoPR);
            this.GPR.Controls.Add(this.AggNombrePR);
            this.GPR.Controls.Add(this.GridPR);
            this.GPR.Controls.Add(this.BtnNuevoPR);
            this.GPR.Controls.Add(this.BtnModificarPR);
            this.GPR.Controls.Add(this.BtnAgregarPR);
            this.GPR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPR.Location = new System.Drawing.Point(4, 25);
            this.GPR.Name = "GPR";
            this.GPR.Padding = new System.Windows.Forms.Padding(3);
            this.GPR.Size = new System.Drawing.Size(1077, 541);
            this.GPR.TabIndex = 1;
            this.GPR.Text = "Gestion profesor";
            // 
            // BtnFIltro
            // 
            this.BtnFIltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BtnFIltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BtnFIltro.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnFIltro.Location = new System.Drawing.Point(154, 286);
            this.BtnFIltro.Name = "BtnFIltro";
            this.BtnFIltro.Size = new System.Drawing.Size(166, 22);
            this.BtnFIltro.TabIndex = 44;
            this.BtnFIltro.TextChanged += new System.EventHandler(this.BtnFIltro_TextChanged);
            // 
            // AggGenero
            // 
            this.AggGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggGenero.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AggGenero.FormattingEnabled = true;
            this.AggGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro\t\t"});
            this.AggGenero.Location = new System.Drawing.Point(884, 75);
            this.AggGenero.Name = "AggGenero";
            this.AggGenero.Size = new System.Drawing.Size(131, 29);
            this.AggGenero.TabIndex = 43;
            // 
            // AggMateriaPR
            // 
            this.AggMateriaPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggMateriaPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggMateriaPR.FormattingEnabled = true;
            this.AggMateriaPR.Items.AddRange(new object[] {
            "Español",
            "Matematicas",
            "Arte",
            "Estadistica",
            "Ingles",
            "Quimica",
            "Fisica"});
            this.AggMateriaPR.Location = new System.Drawing.Point(886, 201);
            this.AggMateriaPR.Name = "AggMateriaPR";
            this.AggMateriaPR.Size = new System.Drawing.Size(128, 25);
            this.AggMateriaPR.TabIndex = 39;
            // 
            // AggCursoPR
            // 
            this.AggCursoPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggCursoPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggCursoPR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AggCursoPR.FormattingEnabled = true;
            this.AggCursoPR.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.AggCursoPR.Location = new System.Drawing.Point(692, 76);
            this.AggCursoPR.Name = "AggCursoPR";
            this.AggCursoPR.Size = new System.Drawing.Size(156, 29);
            this.AggCursoPR.TabIndex = 38;
            // 
            // AggDocPR
            // 
            this.AggDocPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggDocPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggDocPR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AggDocPR.FormattingEnabled = true;
            this.AggDocPR.Items.AddRange(new object[] {
            "Tarjeta de Identidad",
            "Cédula de Ciudadanía",
            "Cédula de Extranjería"});
            this.AggDocPR.Location = new System.Drawing.Point(62, 152);
            this.AggDocPR.Name = "AggDocPR";
            this.AggDocPR.Size = new System.Drawing.Size(157, 29);
            this.AggDocPR.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 34);
            this.panel2.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(988, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 22);
            this.label18.TabIndex = 8;
            this.label18.Text = "UAK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentacionGPU.Properties.Resources.universidad;
            this.pictureBox1.Location = new System.Drawing.Point(1032, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(7, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // AggSedePR
            // 
            this.AggSedePR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggSedePR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggSedePR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AggSedePR.Location = new System.Drawing.Point(884, 155);
            this.AggSedePR.Name = "AggSedePR";
            this.AggSedePR.Size = new System.Drawing.Size(127, 22);
            this.AggSedePR.TabIndex = 7;
            // 
            // AggCorreoPR
            // 
            this.AggCorreoPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggCorreoPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggCorreoPR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AggCorreoPR.Location = new System.Drawing.Point(691, 156);
            this.AggCorreoPR.Name = "AggCorreoPR";
            this.AggCorreoPR.Size = new System.Drawing.Size(156, 22);
            this.AggCorreoPR.TabIndex = 5;
            // 
            // AggIdPR
            // 
            this.AggIdPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggIdPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggIdPR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AggIdPR.Location = new System.Drawing.Point(64, 79);
            this.AggIdPR.Name = "AggIdPR";
            this.AggIdPR.Size = new System.Drawing.Size(156, 22);
            this.AggIdPR.TabIndex = 4;
            this.AggIdPR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AggIdPR_KeyPress);
            // 
            // Agg2ApellidoPR
            // 
            this.Agg2ApellidoPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Agg2ApellidoPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Agg2ApellidoPR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Agg2ApellidoPR.Location = new System.Drawing.Point(480, 156);
            this.Agg2ApellidoPR.Name = "Agg2ApellidoPR";
            this.Agg2ApellidoPR.Size = new System.Drawing.Size(153, 22);
            this.Agg2ApellidoPR.TabIndex = 3;
            this.Agg2ApellidoPR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Agg2ApellidoPR_KeyPress);
            // 
            // Agg2NombrePR
            // 
            this.Agg2NombrePR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Agg2NombrePR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Agg2NombrePR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Agg2NombrePR.Location = new System.Drawing.Point(278, 156);
            this.Agg2NombrePR.Name = "Agg2NombrePR";
            this.Agg2NombrePR.Size = new System.Drawing.Size(156, 22);
            this.Agg2NombrePR.TabIndex = 1;
            this.Agg2NombrePR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Agg2NombrePR_KeyPress);
            // 
            // AggApellidoPR
            // 
            this.AggApellidoPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggApellidoPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggApellidoPR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AggApellidoPR.Location = new System.Drawing.Point(477, 80);
            this.AggApellidoPR.Name = "AggApellidoPR";
            this.AggApellidoPR.Size = new System.Drawing.Size(156, 22);
            this.AggApellidoPR.TabIndex = 2;
            this.AggApellidoPR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AggApellidoPR_KeyPress);
            // 
            // AggNombrePR
            // 
            this.AggNombrePR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggNombrePR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggNombrePR.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AggNombrePR.Location = new System.Drawing.Point(277, 80);
            this.AggNombrePR.Name = "AggNombrePR";
            this.AggNombrePR.Size = new System.Drawing.Size(156, 22);
            this.AggNombrePR.TabIndex = 0;
            this.AggNombrePR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AggNombrePR_KeyPress);
            // 
            // GridPR
            // 
            this.GridPR.AllowUserToAddRows = false;
            this.GridPR.AllowUserToOrderColumns = true;
            this.GridPR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridPR.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar});
            this.GridPR.Location = new System.Drawing.Point(31, 314);
            this.GridPR.Name = "GridPR";
            this.GridPR.ReadOnly = true;
            this.GridPR.Size = new System.Drawing.Size(1010, 193);
            this.GridPR.TabIndex = 14;
            this.GridPR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPR_CellClick);
            this.GridPR.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPR_CellContentDoubleClick);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Eliminar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Width = 64;
            // 
            // BtnNuevoPR
            // 
            this.BtnNuevoPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(5)))), ((int)(((byte)(242)))));
            this.BtnNuevoPR.FlatAppearance.BorderSize = 0;
            this.BtnNuevoPR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnNuevoPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoPR.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoPR.ForeColor = System.Drawing.Color.White;
            this.BtnNuevoPR.Location = new System.Drawing.Point(308, 200);
            this.BtnNuevoPR.Name = "BtnNuevoPR";
            this.BtnNuevoPR.Size = new System.Drawing.Size(108, 25);
            this.BtnNuevoPR.TabIndex = 10;
            this.BtnNuevoPR.Text = "Nuevo";
            this.BtnNuevoPR.UseVisualStyleBackColor = false;
            this.BtnNuevoPR.Click += new System.EventHandler(this.BtnNuevoPR_Click);
            // 
            // BtnModificarPR
            // 
            this.BtnModificarPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(5)))), ((int)(((byte)(242)))));
            this.BtnModificarPR.FlatAppearance.BorderSize = 0;
            this.BtnModificarPR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnModificarPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarPR.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarPR.ForeColor = System.Drawing.Color.White;
            this.BtnModificarPR.Location = new System.Drawing.Point(507, 200);
            this.BtnModificarPR.Name = "BtnModificarPR";
            this.BtnModificarPR.Size = new System.Drawing.Size(107, 27);
            this.BtnModificarPR.TabIndex = 11;
            this.BtnModificarPR.Text = "Modificar";
            this.BtnModificarPR.UseVisualStyleBackColor = false;
            this.BtnModificarPR.Click += new System.EventHandler(this.BtnModificarPR_Click);
            // 
            // BtnAgregarPR
            // 
            this.BtnAgregarPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(5)))), ((int)(((byte)(242)))));
            this.BtnAgregarPR.FlatAppearance.BorderSize = 0;
            this.BtnAgregarPR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPR.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPR.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarPR.Location = new System.Drawing.Point(85, 201);
            this.BtnAgregarPR.Name = "BtnAgregarPR";
            this.BtnAgregarPR.Size = new System.Drawing.Size(109, 26);
            this.BtnAgregarPR.TabIndex = 9;
            this.BtnAgregarPR.Text = "Agregar";
            this.BtnAgregarPR.UseVisualStyleBackColor = false;
            this.BtnAgregarPR.Click += new System.EventHandler(this.BtnAgregarPR_Click);
            // 
            // GES
            // 
            this.GES.BackgroundImage = global::PresentacionGPU.Properties.Resources.Blue_Minimalist_Corporate_Desktop_Prototype1;
            this.GES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GES.Controls.Add(this.FIltro);
            this.GES.Controls.Add(this.AggCursoES);
            this.GES.Controls.Add(this.AggDocES);
            this.GES.Controls.Add(this.AggGeneroES);
            this.GES.Controls.Add(this.GridES);
            this.GES.Controls.Add(this.panel1);
            this.GES.Controls.Add(this.AggSedeES);
            this.GES.Controls.Add(this.AggCorreoES);
            this.GES.Controls.Add(this.AggIdES);
            this.GES.Controls.Add(this.Agg2ApellidoES);
            this.GES.Controls.Add(this.Agg2NombreES);
            this.GES.Controls.Add(this.AggApellidoES);
            this.GES.Controls.Add(this.AggNombreES);
            this.GES.Controls.Add(this.BtnNuevoES);
            this.GES.Controls.Add(this.BtnModificarES);
            this.GES.Controls.Add(this.BtnAgregarES);
            this.GES.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GES.Location = new System.Drawing.Point(4, 25);
            this.GES.Name = "GES";
            this.GES.Padding = new System.Windows.Forms.Padding(3);
            this.GES.Size = new System.Drawing.Size(1077, 541);
            this.GES.TabIndex = 0;
            this.GES.Text = "Gestion estudiante";
            // 
            // FIltro
            // 
            this.FIltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.FIltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FIltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIltro.Location = new System.Drawing.Point(785, 204);
            this.FIltro.Name = "FIltro";
            this.FIltro.Size = new System.Drawing.Size(180, 19);
            this.FIltro.TabIndex = 34;
            this.FIltro.TextChanged += new System.EventHandler(this.FIltro_TextChanged);
            // 
            // AggCursoES
            // 
            this.AggCursoES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggCursoES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggCursoES.FormattingEnabled = true;
            this.AggCursoES.Items.AddRange(new object[] {
            "A601",
            "A602",
            "B701",
            "B702",
            "C801",
            "C802",
            "D901",
            "D902",
            "E101",
            "E102",
            "F111",
            "F112"});
            this.AggCursoES.Location = new System.Drawing.Point(689, 77);
            this.AggCursoES.Name = "AggCursoES";
            this.AggCursoES.Size = new System.Drawing.Size(159, 25);
            this.AggCursoES.TabIndex = 6;
            // 
            // AggDocES
            // 
            this.AggDocES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggDocES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggDocES.FormattingEnabled = true;
            this.AggDocES.Items.AddRange(new object[] {
            "Tarjeta de Identidad",
            "Cédula de Ciudadanía",
            "Cédula de Extranjería"});
            this.AggDocES.Location = new System.Drawing.Point(67, 153);
            this.AggDocES.Name = "AggDocES";
            this.AggDocES.Size = new System.Drawing.Size(149, 25);
            this.AggDocES.TabIndex = 1;
            // 
            // AggGeneroES
            // 
            this.AggGeneroES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggGeneroES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggGeneroES.FormattingEnabled = true;
            this.AggGeneroES.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.AggGeneroES.Location = new System.Drawing.Point(884, 77);
            this.AggGeneroES.Name = "AggGeneroES";
            this.AggGeneroES.Size = new System.Drawing.Size(131, 25);
            this.AggGeneroES.TabIndex = 9;
            // 
            // GridES
            // 
            this.GridES.AllowUserToAddRows = false;
            this.GridES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridES.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.GridES.Location = new System.Drawing.Point(33, 285);
            this.GridES.Name = "GridES";
            this.GridES.Size = new System.Drawing.Size(1008, 221);
            this.GridES.TabIndex = 17;
            this.GridES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridES_CellClick);
            this.GridES.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridES_CellContentDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(2, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 34);
            this.panel1.TabIndex = 29;
            this.panel1.UseWaitCursor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(983, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 22);
            this.label24.TabIndex = 8;
            this.label24.Text = "UAK";
            this.label24.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Thistle;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PresentacionGPU.Properties.Resources.universidad;
            this.pictureBox4.Location = new System.Drawing.Point(1027, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.UseWaitCursor = true;
            // 
            // AggSedeES
            // 
            this.AggSedeES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggSedeES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggSedeES.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AggSedeES.Location = new System.Drawing.Point(883, 155);
            this.AggSedeES.Name = "AggSedeES";
            this.AggSedeES.Size = new System.Drawing.Size(130, 20);
            this.AggSedeES.TabIndex = 8;
            // 
            // AggCorreoES
            // 
            this.AggCorreoES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggCorreoES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggCorreoES.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AggCorreoES.Location = new System.Drawing.Point(693, 156);
            this.AggCorreoES.Name = "AggCorreoES";
            this.AggCorreoES.Size = new System.Drawing.Size(152, 20);
            this.AggCorreoES.TabIndex = 7;
            // 
            // AggIdES
            // 
            this.AggIdES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggIdES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggIdES.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AggIdES.Location = new System.Drawing.Point(64, 80);
            this.AggIdES.Name = "AggIdES";
            this.AggIdES.Size = new System.Drawing.Size(154, 20);
            this.AggIdES.TabIndex = 0;
            this.AggIdES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AggIdES_KeyPress);
            // 
            // Agg2ApellidoES
            // 
            this.Agg2ApellidoES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Agg2ApellidoES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Agg2ApellidoES.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agg2ApellidoES.Location = new System.Drawing.Point(481, 156);
            this.Agg2ApellidoES.Name = "Agg2ApellidoES";
            this.Agg2ApellidoES.Size = new System.Drawing.Size(149, 20);
            this.Agg2ApellidoES.TabIndex = 5;
            this.Agg2ApellidoES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Agg2ApellidoES_KeyPress);
            // 
            // Agg2NombreES
            // 
            this.Agg2NombreES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Agg2NombreES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Agg2NombreES.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agg2NombreES.Location = new System.Drawing.Point(279, 156);
            this.Agg2NombreES.Name = "Agg2NombreES";
            this.Agg2NombreES.Size = new System.Drawing.Size(154, 20);
            this.Agg2NombreES.TabIndex = 3;
            this.Agg2NombreES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Agg2NombreES_KeyPress);
            // 
            // AggApellidoES
            // 
            this.AggApellidoES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggApellidoES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggApellidoES.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AggApellidoES.Location = new System.Drawing.Point(480, 80);
            this.AggApellidoES.Name = "AggApellidoES";
            this.AggApellidoES.Size = new System.Drawing.Size(149, 20);
            this.AggApellidoES.TabIndex = 4;
            this.AggApellidoES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AggApellidoES_KeyPress);
            // 
            // AggNombreES
            // 
            this.AggNombreES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AggNombreES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggNombreES.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AggNombreES.Location = new System.Drawing.Point(279, 80);
            this.AggNombreES.Name = "AggNombreES";
            this.AggNombreES.Size = new System.Drawing.Size(154, 20);
            this.AggNombreES.TabIndex = 2;
            this.AggNombreES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AggNombreES_KeyPress);
            // 
            // BtnNuevoES
            // 
            this.BtnNuevoES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(5)))), ((int)(((byte)(242)))));
            this.BtnNuevoES.FlatAppearance.BorderSize = 0;
            this.BtnNuevoES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoES.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoES.ForeColor = System.Drawing.Color.White;
            this.BtnNuevoES.Location = new System.Drawing.Point(309, 200);
            this.BtnNuevoES.Name = "BtnNuevoES";
            this.BtnNuevoES.Size = new System.Drawing.Size(99, 26);
            this.BtnNuevoES.TabIndex = 11;
            this.BtnNuevoES.Text = "Nuevo";
            this.BtnNuevoES.UseVisualStyleBackColor = false;
            this.BtnNuevoES.Click += new System.EventHandler(this.BtnNuevoES_Click);
            // 
            // BtnModificarES
            // 
            this.BtnModificarES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(5)))), ((int)(((byte)(242)))));
            this.BtnModificarES.FlatAppearance.BorderSize = 0;
            this.BtnModificarES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarES.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarES.ForeColor = System.Drawing.Color.White;
            this.BtnModificarES.Location = new System.Drawing.Point(503, 201);
            this.BtnModificarES.Name = "BtnModificarES";
            this.BtnModificarES.Size = new System.Drawing.Size(104, 26);
            this.BtnModificarES.TabIndex = 12;
            this.BtnModificarES.Text = "Modificar";
            this.BtnModificarES.UseVisualStyleBackColor = false;
            this.BtnModificarES.Click += new System.EventHandler(this.BtnModificarES_Click);
            // 
            // BtnAgregarES
            // 
            this.BtnAgregarES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(5)))), ((int)(((byte)(242)))));
            this.BtnAgregarES.FlatAppearance.BorderSize = 0;
            this.BtnAgregarES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarES.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarES.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarES.Location = new System.Drawing.Point(94, 201);
            this.BtnAgregarES.Name = "BtnAgregarES";
            this.BtnAgregarES.Size = new System.Drawing.Size(92, 26);
            this.BtnAgregarES.TabIndex = 10;
            this.BtnAgregarES.Text = "Agregar";
            this.BtnAgregarES.UseVisualStyleBackColor = false;
            this.BtnAgregarES.Click += new System.EventHandler(this.BtnAgregarES_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.GES);
            this.tabControl1.Controls.Add(this.GPR);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 570);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // BtnMinUserType
            // 
            this.BtnMinUserType.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinUserType.Image = global::PresentacionGPU.Properties.Resources.minimizar_signo;
            this.BtnMinUserType.Location = new System.Drawing.Point(1019, 3);
            this.BtnMinUserType.Name = "BtnMinUserType";
            this.BtnMinUserType.Size = new System.Drawing.Size(38, 21);
            this.BtnMinUserType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinUserType.TabIndex = 11;
            this.BtnMinUserType.TabStop = false;
            this.BtnMinUserType.Click += new System.EventHandler(this.BtnMinUserType_Click);
            // 
            // BtnSalirUserType
            // 
            this.BtnSalirUserType.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirUserType.Image = global::PresentacionGPU.Properties.Resources.cerrar;
            this.BtnSalirUserType.Location = new System.Drawing.Point(1063, 3);
            this.BtnSalirUserType.Name = "BtnSalirUserType";
            this.BtnSalirUserType.Size = new System.Drawing.Size(38, 21);
            this.BtnSalirUserType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirUserType.TabIndex = 10;
            this.BtnSalirUserType.TabStop = false;
            this.BtnSalirUserType.Click += new System.EventHandler(this.BtnSalirUserType_Click_1);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 586);
            this.Controls.Add(this.BtnMinUserType);
            this.Controls.Add(this.BtnSalirUserType);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminDashboard_MouseDown);
            this.GPR.ResumeLayout(false);
            this.GPR.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPR)).EndInit();
            this.GES.ResumeLayout(false);
            this.GES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinUserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirUserType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage GPR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox AggSedePR;
        private System.Windows.Forms.TextBox AggCorreoPR;
        private System.Windows.Forms.TextBox AggIdPR;
        private System.Windows.Forms.TextBox Agg2ApellidoPR;
        private System.Windows.Forms.TextBox Agg2NombrePR;
        private System.Windows.Forms.TextBox AggApellidoPR;
        private System.Windows.Forms.TextBox AggNombrePR;
        private System.Windows.Forms.DataGridView GridPR;
        private System.Windows.Forms.Button BtnNuevoPR;
        private System.Windows.Forms.Button BtnModificarPR;
        private System.Windows.Forms.Button BtnAgregarPR;
        private System.Windows.Forms.TabPage GES;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox AggSedeES;
        public System.Windows.Forms.TextBox AggCorreoES;
        public System.Windows.Forms.TextBox AggIdES;
        public System.Windows.Forms.TextBox Agg2ApellidoES;
        public System.Windows.Forms.TextBox Agg2NombreES;
        public System.Windows.Forms.TextBox AggApellidoES;
        public System.Windows.Forms.TextBox AggNombreES;
        private System.Windows.Forms.Button BtnNuevoES;
        private System.Windows.Forms.Button BtnModificarES;
        private System.Windows.Forms.Button BtnAgregarES;
        public System.Windows.Forms.DataGridView GridES;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox AggGeneroES;
        private System.Windows.Forms.ComboBox AggCursoES;
        private System.Windows.Forms.ComboBox AggDocES;
        private System.Windows.Forms.ComboBox AggMateriaPR;
        private System.Windows.Forms.ComboBox AggCursoPR;
        private System.Windows.Forms.ComboBox AggDocPR;
        private System.Windows.Forms.PictureBox BtnMinUserType;
        private System.Windows.Forms.PictureBox BtnSalirUserType;
        private System.Windows.Forms.ComboBox AggGenero;
        private System.Windows.Forms.TextBox FIltro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox BtnFIltro;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
    }
}