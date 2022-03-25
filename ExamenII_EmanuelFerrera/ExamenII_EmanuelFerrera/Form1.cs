using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenII_EmanuelFerrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // NOMBRE EL USUARIO: eferrera
        // CLAVE: 123

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuarioTextBox.Text, ClaveTextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("El usuario no existe.");
            }

            if (UsuarioTextBox.Text == "")
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese el nombre del usuario.");
                UsuarioTextBox.Focus();
                return;
            }

            if (ClaveTextBox.Text == "")
            {
                errorProvider1.SetError(ClaveTextBox, "Ingrese la clave del usuario.");
                ClaveTextBox.Focus();
                return;
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
