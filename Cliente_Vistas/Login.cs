using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cliente_Vistas.ServiceReference1;


namespace Cliente_Vistas
{
    public partial class Login : Form
    {
        Service1Client servicio = new Service1Client();
        public Login()
        {
            InitializeComponent();
        }

        private void pbingress_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();

            obj.codusuario = txtusuario.Text;
            obj.password = txtpassword.Text;
            obj = servicio.Loginusuario(obj);
            if (obj.estado == 0 && obj.tipo == "admin")
            {
                Menu objForm = new Menu();
                objForm.Show();
                this.Hide();
                objForm.datos(obj);
            }
            else
            {
                MessageBox.Show("No esta autorizado el ingreso con esta cuenta o su cuenta ha sido suspendida", "INGRESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Menu objForm = new Menu();
            //objForm.Show();
            //this.Hide();

        }
    }
}
