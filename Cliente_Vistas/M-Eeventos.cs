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
    public partial class M_Eeventos : Form
    {
        Service1Client servicio = new Service1Client();
        public M_Eeventos()
        {
            InitializeComponent();
        }

        private void M_Eeventos_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2, this.ParentForm.Height / 2 - this.Height / 2);
            this.Location = p;

            dataGridView1.DataSource = servicio.ListarEvento().Tables["eventos"];

        }

        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            Evento obj = new Evento();
            obj.nombre = textBox2.Text;
            dataGridView1.DataSource = servicio.BuscarEventoxnombre(obj).Tables["eventosb2"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpfecha.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void limpiarEvento()
        {
            textBox1.Text = "";
            txt2.Text = "";
            textBox3.Text = "";
            dtpfecha.Value = System.DateTime.Now;
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void btnAgregarArtista_Click(object sender, EventArgs e)
        {
            try
            {
                Evento obj = new Evento();
                obj.idevento = int.Parse(textBox1.Text);
                obj.nombre = txt2.Text;
                obj.promotor = textBox3.Text;
                obj.fecha = dtpfecha.Value;
                obj.lugar = textBox5.Text;
                obj.plataforma = textBox6.Text;
                servicio.EditarEvento(obj);
                

                MessageBox.Show("Se actualizo correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarEvento();
                dataGridView1.DataSource = servicio.ListarEvento().Tables["eventos"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podrido actualizar la informacion", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Evento obj = new Evento();
                obj.idevento = int.Parse(textBox1.Text);
                servicio.EliminarEvento(obj);


                MessageBox.Show("Se actualizo correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarEvento();
                dataGridView1.DataSource = servicio.ListarEvento().Tables["eventos"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podrido actualizar la informacion", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
