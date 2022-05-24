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
    public partial class M_Efan : Form
    {
        Service1Client servicio = new Service1Client();
        public M_Efan()
        {
            InitializeComponent();
        }

        private void M_Efan_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2, this.ParentForm.Height / 2 - this.Height / 2);
            this.Location = p;
        }

        private void btnBuscarFans_Click(object sender, EventArgs e)
        {
            try
            {
                Fan obj = new Fan();
                obj.idfan = int.Parse(txtNomFan.Text);
                dgvFans.DataSource = servicio.BuscarFan(obj).Tables["fansb"];
            }catch(Exception ex)
            {
                MessageBox.Show("debe ingresar un codigo", "ERROR DE BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btndesactivarfan_Click(object sender, EventArgs e)
        {
            try
            {
                Fan obj = new Fan();
                obj.idfan = int.Parse(txtNomFan.Text);
                servicio.DeshabilitarFan(obj);
                MessageBox.Show("Se deshabilito al usuario correctamente", "MODIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo dehabilitar el usuario", "ERROR MODIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fan obj = new Fan();
                obj.idfan = int.Parse(txtNomFan.Text);
                servicio.EliminarFan(obj);
                MessageBox.Show("Se ELIMINO al usuario correctamente", "ELIMINACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo ELIMINAR el usuario", "ERROR ELIMINACION", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvFans_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            txtNomFan.Text = dgvFans.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
