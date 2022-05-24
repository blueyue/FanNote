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
    public partial class M_Eagencia : Form
    {
        public M_Eagencia()
        {
            InitializeComponent();
        }

        private void M_Eagencia_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2, this.ParentForm.Height / 2 - this.Height / 2);
            this.Location = p;
        }
    }
}
