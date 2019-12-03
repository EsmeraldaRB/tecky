namespace TecSystem
{
    partial class menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_mini = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cumaestro = new TecSystem.maestro();
            this.cudetalleactividad = new TecSystem.detalleactividad();
            this.cuactividad = new TecSystem.actividad();
            this.cuhorarioclase = new TecSystem.horarioclase();
            this.cudetallesalon = new TecSystem.detallesalon();
            this.cugrupo = new TecSystem.salon();
            this.cumateria = new TecSystem.mate();
            this.cuacademia = new TecSystem.acadmia();
            this.cuespecialidad = new TecSystem.especia();
            this.cucarrera = new TecSystem.carre();
            this.cuinasistencias = new TecSystem.inas();
            this.inicio1 = new TecSystem.inicio();
            this.cucali = new TecSystem.calif();
            this.cuRegistro = new TecSystem.registro();
            this.cuInicio = new TecSystem.inicio();
            this.btn_alumno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.btn_mini);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 65);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.ErrorImage = global::TecSystem.Properties.Resources.xx;
            this.btn_cerrar.Image = global::TecSystem.Properties.Resources.xx;
            this.btn_cerrar.Location = new System.Drawing.Point(1075, 9);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(47, 39);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_mini
            // 
            this.btn_mini.ErrorImage = global::TecSystem.Properties.Resources.miniz;
            this.btn_mini.Image = global::TecSystem.Properties.Resources.miniz;
            this.btn_mini.Location = new System.Drawing.Point(1006, 9);
            this.btn_mini.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(48, 39);
            this.btn_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_mini.TabIndex = 0;
            this.btn_mini.TabStop = false;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.cumaestro);
            this.panel5.Controls.Add(this.cudetalleactividad);
            this.panel5.Controls.Add(this.cuactividad);
            this.panel5.Controls.Add(this.cuhorarioclase);
            this.panel5.Controls.Add(this.cudetallesalon);
            this.panel5.Controls.Add(this.cugrupo);
            this.panel5.Controls.Add(this.cumateria);
            this.panel5.Controls.Add(this.cuacademia);
            this.panel5.Controls.Add(this.cuespecialidad);
            this.panel5.Controls.Add(this.cucarrera);
            this.panel5.Controls.Add(this.cuinasistencias);
            this.panel5.Controls.Add(this.inicio1);
            this.panel5.Controls.Add(this.cucali);
            this.panel5.Controls.Add(this.cuRegistro);
            this.panel5.Controls.Add(this.cuInicio);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(236, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(892, 618);
            this.panel5.TabIndex = 3;
            // 
            // cumaestro
            // 
            this.cumaestro.BackColor = System.Drawing.Color.White;
            this.cumaestro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cumaestro.Location = new System.Drawing.Point(0, 0);
            this.cumaestro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cumaestro.Name = "cumaestro";
            this.cumaestro.Size = new System.Drawing.Size(892, 618);
            this.cumaestro.TabIndex = 14;
            // 
            // cudetalleactividad
            // 
            this.cudetalleactividad.BackColor = System.Drawing.Color.White;
            this.cudetalleactividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cudetalleactividad.Location = new System.Drawing.Point(0, 0);
            this.cudetalleactividad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cudetalleactividad.Name = "cudetalleactividad";
            this.cudetalleactividad.Size = new System.Drawing.Size(892, 618);
            this.cudetalleactividad.TabIndex = 13;
            // 
            // cuactividad
            // 
            this.cuactividad.BackColor = System.Drawing.Color.White;
            this.cuactividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuactividad.Location = new System.Drawing.Point(0, 0);
            this.cuactividad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuactividad.Name = "cuactividad";
            this.cuactividad.Size = new System.Drawing.Size(892, 618);
            this.cuactividad.TabIndex = 12;
            // 
            // cuhorarioclase
            // 
            this.cuhorarioclase.BackColor = System.Drawing.Color.White;
            this.cuhorarioclase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuhorarioclase.Location = new System.Drawing.Point(0, 0);
            this.cuhorarioclase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuhorarioclase.Name = "cuhorarioclase";
            this.cuhorarioclase.Size = new System.Drawing.Size(892, 618);
            this.cuhorarioclase.TabIndex = 11;
            // 
            // cudetallesalon
            // 
            this.cudetallesalon.BackColor = System.Drawing.Color.White;
            this.cudetallesalon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cudetallesalon.Location = new System.Drawing.Point(0, 0);
            this.cudetallesalon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cudetallesalon.Name = "cudetallesalon";
            this.cudetallesalon.Size = new System.Drawing.Size(892, 618);
            this.cudetallesalon.TabIndex = 10;
            // 
            // cugrupo
            // 
            this.cugrupo.BackColor = System.Drawing.Color.White;
            this.cugrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cugrupo.Location = new System.Drawing.Point(0, 0);
            this.cugrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cugrupo.Name = "cugrupo";
            this.cugrupo.Size = new System.Drawing.Size(892, 618);
            this.cugrupo.TabIndex = 9;
            // 
            // cumateria
            // 
            this.cumateria.BackColor = System.Drawing.Color.White;
            this.cumateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cumateria.Location = new System.Drawing.Point(0, 0);
            this.cumateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cumateria.Name = "cumateria";
            this.cumateria.Size = new System.Drawing.Size(892, 618);
            this.cumateria.TabIndex = 8;
            // 
            // cuacademia
            // 
            this.cuacademia.BackColor = System.Drawing.Color.White;
            this.cuacademia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuacademia.Location = new System.Drawing.Point(0, 0);
            this.cuacademia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuacademia.Name = "cuacademia";
            this.cuacademia.Size = new System.Drawing.Size(892, 618);
            this.cuacademia.TabIndex = 7;
            // 
            // cuespecialidad
            // 
            this.cuespecialidad.BackColor = System.Drawing.Color.White;
            this.cuespecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuespecialidad.Location = new System.Drawing.Point(0, 0);
            this.cuespecialidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuespecialidad.Name = "cuespecialidad";
            this.cuespecialidad.Size = new System.Drawing.Size(892, 618);
            this.cuespecialidad.TabIndex = 6;
            // 
            // cucarrera
            // 
            this.cucarrera.BackColor = System.Drawing.Color.White;
            this.cucarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cucarrera.Location = new System.Drawing.Point(0, 0);
            this.cucarrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cucarrera.Name = "cucarrera";
            this.cucarrera.Size = new System.Drawing.Size(892, 618);
            this.cucarrera.TabIndex = 5;
            // 
            // cuinasistencias
            // 
            this.cuinasistencias.BackColor = System.Drawing.Color.White;
            this.cuinasistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuinasistencias.Location = new System.Drawing.Point(0, 0);
            this.cuinasistencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuinasistencias.Name = "cuinasistencias";
            this.cuinasistencias.Size = new System.Drawing.Size(892, 618);
            this.cuinasistencias.TabIndex = 4;
            // 
            // inicio1
            // 
            this.inicio1.BackColor = System.Drawing.Color.White;
            this.inicio1.Location = new System.Drawing.Point(874, 277);
            this.inicio1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(782, 830);
            this.inicio1.TabIndex = 3;
            // 
            // cucali
            // 
            this.cucali.BackColor = System.Drawing.Color.White;
            this.cucali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cucali.Location = new System.Drawing.Point(0, 0);
            this.cucali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cucali.Name = "cucali";
            this.cucali.Size = new System.Drawing.Size(892, 618);
            this.cucali.TabIndex = 2;
            this.cucali.Load += new System.EventHandler(this.cucali_Load);
            // 
            // cuRegistro
            // 
            this.cuRegistro.BackColor = System.Drawing.Color.White;
            this.cuRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuRegistro.Location = new System.Drawing.Point(0, 0);
            this.cuRegistro.Name = "cuRegistro";
            this.cuRegistro.Size = new System.Drawing.Size(892, 618);
            this.cuRegistro.TabIndex = 1;
            this.cuRegistro.Load += new System.EventHandler(this.cuRegistro_Load);
            // 
            // cuInicio
            // 
            this.cuInicio.BackColor = System.Drawing.Color.White;
            this.cuInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuInicio.Location = new System.Drawing.Point(0, 0);
            this.cuInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuInicio.Name = "cuInicio";
            this.cuInicio.Size = new System.Drawing.Size(892, 618);
            this.cuInicio.TabIndex = 0;
            // 
            // btn_alumno
            // 
            this.btn_alumno.FlatAppearance.BorderSize = 0;
            this.btn_alumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_alumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alumno.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumno.ForeColor = System.Drawing.Color.White;
            this.btn_alumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alumno.Location = new System.Drawing.Point(14, 93);
            this.btn_alumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_alumno.Name = "btn_alumno";
            this.btn_alumno.Size = new System.Drawing.Size(206, 30);
            this.btn_alumno.TabIndex = 2;
            this.btn_alumno.Text = "           ALUMNOS";
            this.btn_alumno.UseVisualStyleBackColor = true;
            this.btn_alumno.Click += new System.EventHandler(this.btn_alumno_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel18);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Controls.Add(this.btn_alumno);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 618);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel10.Location = new System.Drawing.Point(16, 288);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(8, 38);
            this.panel10.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(23, 511);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 41);
            this.panel4.TabIndex = 25;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel18.Location = new System.Drawing.Point(16, 187);
            this.panel18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(8, 34);
            this.panel18.TabIndex = 25;
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(30, 515);
            this.button19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(206, 31);
            this.button19.TabIndex = 42;
            this.button19.Text = "PROFESORES";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel15.Location = new System.Drawing.Point(46, 447);
            this.panel15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(8, 45);
            this.panel15.TabIndex = 31;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(51, 446);
            this.button12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(178, 46);
            this.button12.TabIndex = 30;
            this.button12.Text = "Detalle de \r\nactividades";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(53, 387);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 25);
            this.button8.TabIndex = 28;
            this.button8.Text = "Horarios";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel12.Location = new System.Drawing.Point(46, 418);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(8, 25);
            this.panel12.TabIndex = 27;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(51, 417);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(158, 25);
            this.button10.TabIndex = 26;
            this.button10.Text = "Actividades";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel14.Location = new System.Drawing.Point(45, 387);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(8, 25);
            this.panel14.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(16, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 41);
            this.panel3.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(53, 327);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 25);
            this.button3.TabIndex = 23;
            this.button3.Text = "Grupos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel6.Location = new System.Drawing.Point(46, 358);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 25);
            this.panel6.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(51, 357);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 25);
            this.button4.TabIndex = 21;
            this.button4.Text = "Detalle de grupo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel7.Location = new System.Drawing.Point(45, 327);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 25);
            this.panel7.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "      MATERIAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(51, 223);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(158, 25);
            this.button9.TabIndex = 17;
            this.button9.Text = "Especialidades";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel13.Location = new System.Drawing.Point(44, 254);
            this.panel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(8, 25);
            this.panel13.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(49, 254);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 25);
            this.button7.TabIndex = 15;
            this.button7.Text = "Academias";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel11.Location = new System.Drawing.Point(43, 223);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(8, 25);
            this.panel11.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(21, 187);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 31);
            this.button6.TabIndex = 10;
            this.button6.Text = "      CARRERAS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel9.Location = new System.Drawing.Point(43, 154);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(8, 25);
            this.panel9.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(49, 154);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 25);
            this.button5.TabIndex = 8;
            this.button5.Text = "     Inasistencias";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel8.Location = new System.Drawing.Point(43, 126);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 25);
            this.panel8.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(49, 126);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "       Calificaciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logo
            // 
            this.logo.ErrorImage = global::TecSystem.Properties.Resources.logotec;
            this.logo.Image = global::TecSystem.Properties.Resources.logotec;
            this.logo.Location = new System.Drawing.Point(76, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(110, 64);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 683);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_mini;
        private System.Windows.Forms.Panel panel5;
        private registro cuRegistro;
        private inicio cuInicio;
        private System.Windows.Forms.Button btn_alumno;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel10;
        private calif cucali;
        private inicio inicio1;
        private inas cuinasistencias;
        private carre cucarrera;
        private especia cuespecialidad;
        private acadmia cuacademia;
        private mate cumateria;
        private salon cugrupo;
        private detallesalon cudetallesalon;
        private horarioclase cuhorarioclase;
        private System.Windows.Forms.Button button12;
        private actividad cuactividad;
        private detalleactividad cudetalleactividad;
        private maestro cumaestro;
    }
}