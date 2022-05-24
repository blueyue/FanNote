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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Usuario ibj1 = new Usuario();

        public void datos (Usuario ibj)
        {
            ibj1 = ibj;
        }
        private void btnCreacionLista_Click(object sender, EventArgs e)
        {
            FormCreacion objForm = new FormCreacion();
            objForm.Show();
            this.Hide();
            objForm.datos(ibj1);
        }

        private void btnListadosLista_Click(object sender, EventArgs e)
        {
            FormListado objForm = new FormListado();
            objForm.Show();
            this.Hide();
            objForm.datos(ibj1);
        }

        private void btnAdminLista_Click(object sender, EventArgs e)
        {
            FormAdministracion objForm = new FormAdministracion();
            objForm.Show();
            this.Hide();
            objForm.datos(ibj1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea salir del programa?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (opcion == DialogResult.OK)
            {
                Close();
            }
            else
            {
                return;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            datos(ibj1);
        }
    }
}
