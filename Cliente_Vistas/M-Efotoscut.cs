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
    public partial class M_Efotoscut : Form
    {
        public M_Efotoscut()
        {
            InitializeComponent();
        }

        private void M_Efotoscut_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2, this.ParentForm.Height / 2 - this.Height / 2);
            this.Location = p;
        }
    }
}
