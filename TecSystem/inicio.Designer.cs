namespace TecSystem
{
    partial class inicio
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.l_hora = new System.Windows.Forms.Label();
            this.l_fecha = new System.Windows.Forms.Label();
            this.hora_fecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_hora
            // 
            this.l_hora.AutoSize = true;
            this.l_hora.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.l_hora.Location = new System.Drawing.Point(281, 37);
            this.l_hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_hora.Name = "l_hora";
            this.l_hora.Size = new System.Drawing.Size(170, 56);
            this.l_hora.TabIndex = 1;
            this.l_hora.Text = "label1";
            // 
            // l_fecha
            // 
            this.l_fecha.AutoSize = true;
            this.l_fecha.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_fecha.ForeColor = System.Drawing.Color.HotPink;
            this.l_fecha.Location = new System.Drawing.Point(148, 136);
            this.l_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_fecha.Name = "l_fecha";
            this.l_fecha.Size = new System.Drawing.Size(132, 44);
            this.l_fecha.TabIndex = 2;
            this.l_fecha.Text = "label1";
            // 
            // hora_fecha
            // 
            this.hora_fecha.Enabled = true;
            this.hora_fecha.Tick += new System.EventHandler(this.hora_fecha_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(141, 236);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 317);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l_fecha);
            this.Controls.Add(this.l_hora);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "inicio";
            this.Size = new System.Drawing.Size(782, 830);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_hora;
        private System.Windows.Forms.Label l_fecha;
        private System.Windows.Forms.Timer hora_fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
