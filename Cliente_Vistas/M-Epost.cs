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
    public partial class M_Epost : Form
    {
        public M_Epost()
        {
            InitializeComponent();
        }

        private void M_Epost_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2, this.ParentForm.Height / 2 - this.Height / 2);
            this.Location = p;
        }

        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tp = tabControl1.TabPages[e.Index];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            // Este sera el rectangulo que se dibujara sobre el titutlo del tab 
            RectangleF headerRect = new RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);

            // Este sera el color por defecto del tab no seleccionado 
            SolidBrush sb = new SolidBrush(Color.LightSeaGreen);

            // color del tab que se selecciona
            if (tabControl1.SelectedIndex == e.Index)
                sb.Color = Color.Aqua;

            // aplica el color sobre el tabpage actual 
            g.FillRectangle(sb, e.Bounds);

            //escribe el texto que tenia el tab 
            g.DrawString(tp.Text, tabControl1.Font, new SolidBrush(Color.Black), headerRect, sf);
        }
    }
}
