using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWindowsForms1
{
    public partial class User : Form
    {
        Login ventana1;
        private static int key = 0;
        private Conexion conex = new Conexion();
        public User(Login ventana)
        {
            InitializeComponent();
            ventana1 = ventana;
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar(object sender, FormClosedEventArgs e)
        {
            ventana1.Visible = true;
            ventana1.textUsuario.Text = "";
            ventana1.textPassword.Text = "";
        }
    }
}
