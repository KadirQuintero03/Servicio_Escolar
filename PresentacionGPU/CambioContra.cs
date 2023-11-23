using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGPU
{
    public partial class CambioContra : Form
    {
        public CambioContra()
        {
            InitializeComponent();
        }

        //Llamada de los Servicios de la capa de Logica
        AdminServices adminServices = new AdminServices();

        //Evento del boton Cambiar que ejecuta el metodo/Procedimiento Actualizar
        private void btnCambio_Click(object sender, EventArgs e)
        {
            Actualizar(NuevaContraES, ConfiNContraES);
        }

        //Actualiza la contraseña de cada usuario que lo solicite
        private void Actualizar(TextBox ContraseñaNueva, TextBox ConfirmarContraseña)
        {
            string ContraseñaV = ContraseñaNueva.Text;
            string ContraseñaN = ConfirmarContraseña.Text;
            var mensaje = adminServices.Update(ContraseñaV, ContraseñaN);
            MessageBox.Show(mensaje);
        }

        private void NuevaContraES_Enter(object sender, EventArgs e)
        {
            if (NuevaContraES.Text == "Contraseña actual")
            {
                NuevaContraES.Text = "";
            }
        }

        private void NuevaContraES_Leave(object sender, EventArgs e)
        {
            if (NuevaContraES.Text == "")
            {
                NuevaContraES.Text = "Contraseña actual";
            }
        }

        private void ConfiNContraES_Enter(object sender, EventArgs e)
        {
            if (ConfiNContraES.Text == "Contraseña nueva")
            {
                ConfiNContraES.Text = "";
                ConfiNContraES.UseSystemPasswordChar = true;
            }
        }

        private void ConfiNContraES_Leave(object sender, EventArgs e)
        {
            if (ConfiNContraES.Text == "")
            {
                ConfiNContraES.Text = "Contraseña nueva";
                ConfiNContraES.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
