using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimientoGasto
{
    public partial class User : Form
    {
        Login ventana1;
        private int keyUsuario = 0;
        private Conexion conex = new Conexion();
        public User(Login ventana,int key)
        {
            InitializeComponent();
            ventana1 = ventana;
            this.keyUsuario = key;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Gastos re = new Gastos();
            re.tipoGasto = cbTipoGasto.Text;
            re.detalle = cbDetalle.Text;
            re.descripcion = txtDescripcion.Text;
            re.monto = Convert.ToInt32(txtMonto.Text);
            //re.idUsuario = 1; //txtContraseña.Text;
            re.idUsuario = 1; //txtContraseña.Text;
            if (keyUsuario > 0)
            {
                re.idUsuario = keyUsuario;
                lblUsuario.Text = keyUsuario.ToString();
                //lblUsuario.Text = keyUsuario.ToString();
            }

            conex.registrarGastos(re);
            Limpiar();
            MessageBox.Show("Registro de gasto realizado");
            listaGastos();
        }
        private void Limpiar()
        {
            cbTipoGasto.Text = String.Empty;
            cbDetalle.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtMonto.Text = "0";
            //txtContraseña.Text = String.Empty;
            keyUsuario = 0;
        }
        public void listaGastos()
        {
            /*
            List<Gastos> listaGastos = new List<Gastos> ();
            List<Gastos> listaUsuario = new List<Gastos>();
            */
            dgvUsuario.DataSource = conex.listarGastos();
            /*
            listaGastos = conex.listarGastos().ToList();
            foreach(object campo in listaGastos)
            {
                if (campo == keyUsuario)
                {
                    listaUsuario = campo;
                }
            }*/
        }
    }
}
