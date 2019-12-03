using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TecSystem
{
    public partial class inicio : UserControl

    {
       // Conexion conexion = new Conexion();
        public inicio()
        {
            InitializeComponent();
        }

        private void hora_fecha_Tick(object sender, EventArgs e)
        {
            l_hora.Text = DateTime.Now.ToLongTimeString();
            l_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection("server=JADE;DataBase=bdtec2;integrated Security=true");
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
        }
    }
}
