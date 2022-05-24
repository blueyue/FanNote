using Cliente_Vistas.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Vistas
{
    public partial class FormListado : Form
    {
        Service1Client servicio = new Service1Client();
        public FormListado()
        {
            InitializeComponent();
        }

        Usuario ibj1 = new Usuario();

        public void datos(Usuario ibj)
        {
            ibj1 = ibj;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea salir de el area de listados?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (opcion == DialogResult.OK)
            {
                Menu objForm = new Menu();
                objForm.Show();
                this.Hide();
                objForm.datos(ibj1);
            }
            else
            {
                return;
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl1.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl1.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl1.Font, Brushes.Black, x, y);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dgvArtista.DataSource = servicio.ListarArtista().Tables["artistas"];
                    break;
                case 1:
                    dgvEventoBusqueda.DataSource = servicio.ListarEvento().Tables["eventos"];
                    break;
                case 2:
                    dgvFandom.DataSource = servicio.ListarFandom().Tables["fandoms"];
                    break;
                case 3:
                    dgvagencia.DataSource = servicio.ListarAgencia().Tables["agencias"];
                    break;
                case 4:
                    dgvPosts.DataSource = servicio.ListarPost().Tables["posts"];
                    break;
                case 5:
                    dgvAdmins.DataSource = servicio.ListarAdmin().Tables["admins"];
                    break;


            }
            
        }

        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            Artista obj = new Artista();
            obj.nombre = txtNomArtistas.Text;
            dgvArtista.DataSource = servicio.BuscarArtista(obj).Tables["artistasb"];
        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            dgvArtista.DataSource = servicio.ListarArtista().Tables["artistas"];
        }


        private void btnbuscarfechaEvento_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpFecha1.Value;
            DateTime fin = dtpFecha2.Value;
            dgvEventoBusqueda.DataSource = servicio.BuscarEventoxfecha(inicio, fin).Tables["eventosb1"];

        }
    }
}
