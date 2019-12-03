using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TecSystem
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            cuInicio.BringToFront();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            //bringto atraeer adelante
            cuInicio.BringToFront();
            //Para  atras el send
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void btn_alumno_Click(object sender, EventArgs e)
        {
            cuRegistro.BringToFront();
            cuInicio.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void cuRegistro_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cucarrera.BringToFront();
            cumateria.SendToBack();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cumateria.BringToFront();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cucali.BringToFront();
            cuRegistro.SendToBack();
            cuInicio.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void cucali_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cuinasistencias.BringToFront();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuInicio.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            cuespecialidad.BringToFront();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cuacademia.BringToFront();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cugrupo.BringToFront();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cudetallesalon.BringToFront();
            cuInicio.SendToBack(); 
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cuhorarioclase.BringToFront();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cuactividad.BringToFront();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cudetalleactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cudetalleactividad.BringToFront();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cumaestro.SendToBack();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            cumaestro.BringToFront();
            cuInicio.SendToBack();
            cuRegistro.SendToBack();
            cucali.SendToBack();
            cuinasistencias.SendToBack();
            cucarrera.SendToBack();
            cuespecialidad.SendToBack();
            cuacademia.SendToBack();
            cumateria.SendToBack();
            cugrupo.SendToBack();
            cudetallesalon.SendToBack();
            cuhorarioclase.SendToBack();
            cuactividad.SendToBack();
            cudetalleactividad.SendToBack();
        }
    }
}
