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
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

        Usuario ibj1 = new Usuario();

        public void datos(Usuario ibj)
        {
            ibj1 = ibj;
        }

        private void Asociados_Load(object sender, EventArgs e)
        {
            //Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2, this.ParentForm.Height / 2 - this.Height / 2);
            //this.Location = p;
        }

        private void modificacionDePostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormCreacion esteform = new FormCreacion();
            //esteform.IsMdiContainer = true;

            //Asociados asociados = new Asociados();
            //asociados.MdiParent = esteform;
            //asociados.Show();

            M_Epost asociados = new M_Epost();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void eliminaciónDeToolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea salir de el área de administración?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        
        private void modificaciónDeToolStripMenuItem6_Click(object sender, EventArgs e)
        {
           
        }

        private void modificaciónDeToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            
        }

        private void modificaciónDeToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            
        }

        private void modificaciónDeToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }

        private void modificaciónDeToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            
        }
        ///new
        private void toolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {
            M_Epost asociados = new M_Epost();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton2_Click_1(object sender, EventArgs e)
        {
            M_Eeventos asociados = new M_Eeventos();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton8_Click(object sender, EventArgs e)
        {
            M_Erecursosoficiales asociados = new M_Erecursosoficiales();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton9_Click(object sender, EventArgs e)
        {
            M_Erecursosartistas asociados = new M_Erecursosartistas();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton10_Click(object sender, EventArgs e)
        {
            M_Elinkstream asociados = new M_Elinkstream();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton11_Click(object sender, EventArgs e)
        {
            M_Esubworld asociados = new M_Esubworld();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton12_Click(object sender, EventArgs e)
        {
            M_Eprensa asociados = new M_Eprensa();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton13_Click(object sender, EventArgs e)
        {
            M_Efotosfan asociados = new M_Efotosfan();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton14_Click(object sender, EventArgs e)
        {
            M_Efotoscut asociados = new M_Efotoscut();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            M_Eadmin asociados = new M_Eadmin();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {
            M_Efandom asociados = new M_Efandom();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {
            M_Eartistas asociados = new M_Eartistas();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton6_Click(object sender, EventArgs e)
        {
            M_Eagencia asociados = new M_Eagencia();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }

        private void toolStripDropDownButton7_Click(object sender, EventArgs e)
        {
            M_Efan asociados = new M_Efan();
            asociados.TopLevel = false;
            this.Controls.Add(asociados);
            asociados.Show();
            asociados.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
