using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWindowsForms1
{
    public partial class Admin : Form
    {
        Login ventana1;
        private static int key = 0;
        private Conexion conex = new Conexion();
        public Admin(Login ventana)
        {
            InitializeComponent();
            ventana1 = ventana;
            //// lblNombre.Text = ventana1.textUsuario.Text;
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {   // Evento ForClosing
            ventana1.Visible = true;
            ventana1.textUsuario.Text = "";
            ventana1.textPassword.Text = "";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listaUsuarios();
            listaDepartamentos();
            listaGastos();
        }

        public void listaUsuarios()
        {
            dgvUsuarios.DataSource = conex.listarUsuarios();
        }

        public void listaDepartamentos()
        {
            dgvDepto.DataSource = conex.listarDepartamentos();
        }

        public void listaGastos()
        {
            dgvGastos.DataSource = conex.listarGastos();
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            // Área cliente del formulario.
            //
            //// Rectangle r = this.ClientRectangle;

            // Punto intermedio del área cliente.
            //
            //// int c = r.Width / 2;

            // Establecemos la nueva posición de los controles Label.
            //
            //// lblNombre.Location = new Point(c - lblNombre.Width / 2, lblNombre.Location.Y);
            //// lblBienvenido.Location = new Point(c - lblBienvenido.Width / 2, lblBienvenido.Location.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // ESTE NO, NO BORRAR
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rbDepto.Checked == true)
            {
                Departamentos re = new Departamentos();
                re.nombreDepto = txtDepto.Text;

                conex.registrarDepartamentos(re);
                Limpiar();
                MessageBox.Show("Registro realizado");
                listaDepartamentos();
            }else if(rbUsuarios.Checked == true)
            {
                Usuarios re = new Usuarios();
                re.nombres = txtNombres.Text;
                re.apellidos = txtApellidos.Text;
                re.run = txtRun.Text;
                re.usuario = txtUsuario.Text;
                re.contraseña = txtContraseña.Text;
                //string date = DateTime.ParseExact(txtFechaContrato.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                //string date = txtFechaContrato.Text;
                //re.fechaContrato = txtFechaContrato.Text;
                //////re.fechaContrato = Convert.ToDateTime(txtFechaContrato);
                //////re.fechaContrato = Convert.ToDateTime((txtFechaContrato.Text)item["LeaveFromDate"]).ToString("dd/MM/yyyy")
                //
                // AQUI ESTA EL ERROR
                ////re.fechaContrato = Convert.ToDateTime(txtFechaContrato).ToString("yyyy-MM-dd"); /// AQUI ERROR
                if (cbDepto.Text == "finanzas")
                {
                    re.idDepto = 1;
                }else if(cbDepto.Text == "informatica")
                {
                    re.idDepto = 2;
                }
                else if (cbDepto.Text == "rrhh")
                {
                    re.idDepto = 3;
                }
                else if(cbDepto.Text == "mantencion")
                {
                    re.idDepto = 4;
                }


                conex.registrarUsuarios(re);
                Limpiar();
                MessageBox.Show("Registro realizado");
                listaUsuarios();
            }
        }

        private void Limpiar()
        {
            if(rbDepto.Checked == true)
            {
                txtDepto.Text = String.Empty;
                key = 0;
            }else if(rbUsuarios.Checked == true)
            {
                txtNombres.Text = String.Empty;
                txtApellidos.Text = String.Empty;
                txtRun.Text = String.Empty;
                txtUsuario.Text = String.Empty;
                txtContraseña.Text = String.Empty;
                //string date = DateTime.ParseExact(txtFechaContrato.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                //string date = txtFechaContrato.Text;
                //re.fechaContrato = txtFechaContrato.Text;
                ////txtFechaContrato.Text = String.Empty;
                cbDepto.Text = String.Empty;
                key = 0;
            }
        }

        private void obtener(int key)
        {
            if (rbDepto.Checked == true)
            {
                Departamentos obj = conex.obtenerDepartamentos(key);
                txtDepto.Text = obj.nombreDepto;

            }
            else if (rbUsuarios.Checked == true)
            {
                Usuarios obj = conex.obtenerUsuarios(key);
                txtNombres.Text = obj.nombres;
                txtApellidos.Text = obj.apellidos;
                txtRun.Text = obj.run;
                txtUsuario.Text = obj.usuario;
                txtContraseña.Text = obj.contraseña;
                ////txtFechaContrato.Text = Convert.ToString(obj.fechaContrato);
                if (obj.idDepto == 1)
                {
                    cbDepto.Text = "finanzas";
                }
                else if (obj.idDepto == 2)
                {
                    cbDepto.Text = "informatica";
                }
                else if (obj.idDepto == 3)
                {
                    cbDepto.Text = "rrhh";
                }
                else if(obj.idDepto == 4)
                {
                    cbDepto.Text = "mantencion";
                }
            }

            //Usuarios obj = p.obtener(key);
            //txtNombre.Text = obj.nombre;
            //txtApellido.Text = obj.apellido;

        }

        private void tpDepto_Click(object sender, EventArgs e)
        {
            // ESTE NO, NO BORRAR
        }

        private void dgvDepto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ESTE NO, NO BORRAR
        }

        private void dgvDepto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDepto.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    key = int.Parse(row.Cells[0].Value.ToString());
                    obtener(key);
                }
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ESTE NO, NO BORRAR
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    key = int.Parse(row.Cells[0].Value.ToString());
                    obtener(key);
                }
            }
        }

        private void dgvGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ESTE NO, NO BORRAR
        }

        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGastos.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    key = int.Parse(row.Cells[0].Value.ToString());
                    obtener(key);
                }
            }
        }
    }
}
