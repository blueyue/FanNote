using Cliente_Vistas.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Vistas
{
    public partial class FormCreacion : Form
    {
        Service1Client servicio = new Service1Client();
        public FormCreacion()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        Usuario ibj1 = new Usuario();

        private void crearArtistaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string adminpassword = ibj1.password;//contraseña almacenada real
            string confirpassword = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña nuevamente", "CONFIRMACION DE ACCESO", "password");
            if (adminpassword == confirpassword)
            {
                panelAdmin.Visible = false;
                panelEvento.Visible = false;
                panelPost.Visible = false;
                tabControl1.Visible = true;

                tabControl1.SelectedIndex = 0;

                cboagencia.DataSource = servicio.CboAgencia();
                cboagencia.DisplayMember = "nombre";
                cboagencia.ValueMember = "idagencia";
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea salir de el area de creación?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelEvento.Visible = false;
            panelPost.Visible = true;
            tabControl1.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelEvento.Visible = true;
            panelPost.Visible = false;
            tabControl1.Visible = false;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = true;
            panelEvento.Visible = false;
            panelPost.Visible = false;
            tabControl1.Visible = false;
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

        private void tabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl1.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl1.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl1.Font, Brushes.Black, x, y);
        }

        private void crearFandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string adminpassword = ibj1.password;//contraseña almacenada real
            string confirpassword = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña nuevamente", "CONFIRMACION DE ACCESO", "password");
            if (adminpassword == confirpassword)
            {
                panelAdmin.Visible = false;
                panelEvento.Visible = false;
                panelPost.Visible = false;
                tabControl1.Visible = true;

                tabControl1.SelectedIndex = 1;

                cboartistafandom.DataSource = servicio.CboArtista();
                cboartistafandom.DisplayMember = "nombre";
                cboartistafandom.ValueMember = "idartista";
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void crearAgenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string adminpassword = ibj1.password;//contraseña almacenada real
            string confirpassword = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña nuevamente", "CONFIRMACION DE ACCESO", "password");
            if (adminpassword == confirpassword)
            {
                panelAdmin.Visible = false;
                panelEvento.Visible = false;
                panelPost.Visible = false;
                tabControl1.Visible = true;

                tabControl1.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void datos(Usuario ibj)
        {
            ibj1 = ibj;
            lblNomAdLogin.Text = ibj.username;
            lblEmailAdLogin.Text = ibj.email;
            if (ibj.imagen != "null")
            {
                pbAdminLogin.Image = Image.FromFile(ibj.imagen);
                pbAdminLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
        private void FormCreacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    string tipoimagen = imagen.Substring(imagen.LastIndexOf("."), imagen.Length - imagen.LastIndexOf("."));
                    pbFotoPost.Image = Image.FromFile(imagen);
                    pbFotoPost.SizeMode = PictureBoxSizeMode.StretchImage;

                    //File.Copy(source, destination);
                    //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                    string ourproyect = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    string our = new Uri(Path.Combine(ourproyect.Replace("bin\\Debug", ""), @"Recursos\Cargar\post" + ibj1.username + System.DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "_") + tipoimagen)).LocalPath;
                    lblsource.Text = our;
                    //string our = @"~Recursos\Cargar\post" + ibj1.username + System.DateTime.Now.ToShortDateString().Replace("/", "_") + tipoimagen;
                    //txtPost.Text = ourproyect;
                    File.Copy(imagen, our);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void limpiarPost()
        {
            txtPost.Text = "";
            lblsource.Text = "";
            pbFotoPost.Image = (null);
        }
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            try
            {
                Post obj = new Post();
                obj.idusuario = ibj1.idusuario;
                obj.contenido = txtPost.Text;
                obj.fotopost = lblsource.Text;
                servicio.CrearPost(obj);
                MessageBox.Show("Se registro correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarPost();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podrido ingresar la informacion", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void limpiarEvento()
        {
            txtNomEvento.Text = "";
            txtPromotorEvento.Text = "";
            txtFechaEvento.Text = "";
            txtLugarEvento.Text = "";
            txtPlataformaEvento.Text = "";
            txtParrafoEvento.Text = "";
        }
        private void btnInsertEvento_Click(object sender, EventArgs e)
        {

            try
            {
                Evento obj = new Evento();
                obj.nombre = txtNomEvento.Text;
                obj.promotor = txtPromotorEvento.Text;
                obj.fecha = DateTime.Parse(txtFechaEvento.Text);
                obj.lugar = txtLugarEvento.Text;
                obj.plataforma = txtPlataformaEvento.Text;
                servicio.CrearEvento(obj);

                txtParrafoEvento.Text = DateTime.Parse(txtFechaEvento.Text).ToString();

                MessageBox.Show("Se registro correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarEvento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podrido ingresar la informacion", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnFotoAdminUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    string tipoimagen = imagen.Substring(imagen.LastIndexOf("."), imagen.Length - imagen.LastIndexOf("."));
                    pbFotoAdmin.Image = Image.FromFile(imagen);
                    pbFotoAdmin.SizeMode = PictureBoxSizeMode.StretchImage;

                    string ourproyect = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    string our = new Uri(Path.Combine(ourproyect.Replace("bin\\Debug", ""), @"Recursos\Cargar\admin" + ibj1.username + System.DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "_") + tipoimagen)).LocalPath;
                    lblsourceadmin.Text = our;
                    File.Copy(imagen, our);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
        private void limpiarAdmin()
        {
            txtCodigoAdPlus.Text = "";
            txtContrasenaAdPlus.Text = "";
            txtNomAdPlus.Text = "";
            txtEmailAdPlus.Text = "";
            lblsourceadmin.Text = "";
            pbFotoAdmin.Image = (null);
        }
        private void btnAgregarAdPlus_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario obj = new Usuario();
                obj.codusuario = txtCodigoAdPlus.Text;
                obj.password = txtContrasenaAdPlus.Text;
                obj.username = txtNomAdPlus.Text;
                obj.email = txtEmailAdPlus.Text;
                obj.imagen = lblsourceadmin.Text;
                obj.tipo = "admin";
                obj.estado = 0;
                servicio.CrearAdmin(obj);

                MessageBox.Show("Se registro correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarAdmin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podrido ingresar la informacion", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnFotoArtista_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    string tipoimagen = imagen.Substring(imagen.LastIndexOf("."), imagen.Length - imagen.LastIndexOf("."));
                    pbFotoArtista.Image = Image.FromFile(imagen);
                    pbFotoArtista.SizeMode = PictureBoxSizeMode.StretchImage;

                    string ourproyect = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    string our = new Uri(Path.Combine(ourproyect.Replace("bin\\Debug", ""), @"Recursos\Cargar\artista" + ibj1.username + System.DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "_") + tipoimagen)).LocalPath;
                    lblsourceartistas.Text = our;
                    File.Copy(imagen, our);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
        private void limpiarArtista()
        {
            txtNomArtistas.Text = "";
            lblsourceartistas.Text = "";
            cboagencia.SelectedIndex = 0;
            dtpdebut.Value = System.DateTime.Now;
            pbFotoArtista.Image = (null);
        }
        private void btnAgregarArtista_Click(object sender, EventArgs e)
        {
            try
            {
                Artista obj = new Artista();
                obj.nombre = txtNomArtistas.Text;
                obj.agencia = int.Parse(cboagencia.SelectedValue.ToString());
                obj.debut = dtpdebut.Value;
                obj.fotoartista = lblsourceartistas.Text;
                servicio.CrearArtistas(obj);

                MessageBox.Show("Se registro correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarArtista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podrido ingresar la informacion", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void limpiarFandom()
        {
            txtFandom.Text = "";
            txtTotalFandom.Text = "";
            cboartistafandom.SelectedIndex = 0;
            dtpcreacionfandom.Value = System.DateTime.Now;
            lblsourcefandom.Text = "";
            pbFotoFandom.Image = (null);
        }

        private void btnAgragarFandom_Click(object sender, EventArgs e)
        {
            try
            {
                Fandom obj = new Fandom();
                obj.nombre = txtFandom.Text;
                obj.creacion = dtpcreacionfandom.Value;
                obj.miembros = 0;/*int.Parse(txtTotalFandom.Text);*/
                obj.idartista = int.Parse(cboartistafandom.SelectedValue.ToString());
                obj.fotofandom = lblsourcefandom.Text;
                servicio.CrearFandom(obj);

                MessageBox.Show("Se registro correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarFandom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podrido ingresar la informacion", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnFotoFandom_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    string tipoimagen = imagen.Substring(imagen.LastIndexOf("."), imagen.Length - imagen.LastIndexOf("."));
                    pbFotoFandom.Image = Image.FromFile(imagen);
                    pbFotoFandom.SizeMode = PictureBoxSizeMode.StretchImage;

                    string ourproyect = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    string our = new Uri(Path.Combine(ourproyect.Replace("bin\\Debug", ""), @"Recursos\Cargar\fandom" + ibj1.username + System.DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "_") + tipoimagen)).LocalPath;
                    lblsourcefandom.Text = our;
                    File.Copy(imagen, our);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void limpiarAgencia()
        {
            txtag1.Text = "";
            txtag2.Text = "";
            txtag3.Text = "";
            txtag4.Text = "";
            txtag5.Text = "";
            lblsourceagencia.Text = "";
            pbagencia.Image = (null);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    string tipoimagen = imagen.Substring(imagen.LastIndexOf("."), imagen.Length - imagen.LastIndexOf("."));
                    pbagencia.Image = Image.FromFile(imagen);
                    pbagencia.SizeMode = PictureBoxSizeMode.StretchImage;

                    string ourproyect = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    string our = new Uri(Path.Combine(ourproyect.Replace("bin\\Debug", ""), @"Recursos\Cargar\agencia" + ibj1.username + System.DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "_") + tipoimagen)).LocalPath;
                    lblsourceagencia.Text = our;
                    File.Copy(imagen, our);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Agencia obj = new Agencia();
                obj.nombre = txtag1.Text;
                obj.direccion = txtag2.Text;
                obj.telefono = int.Parse(txtag3.Text);
                obj.email = txtag4.Text;
                obj.web = txtag5.Text;
                obj.fotoagencia = lblsourceagencia.Text;

                servicio.CrearAgencia(obj);

                MessageBox.Show("Se registro correctamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarAgencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podrido ingresar la informacion", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    cboagencia.DataSource = servicio.CboAgencia();
                    cboagencia.DisplayMember = "nombre";
                    cboagencia.ValueMember = "idagencia";
                    break;
                case 1:
                    cboartistafandom.DataSource = servicio.CboArtista();
                    cboartistafandom.DisplayMember = "nombre";
                    cboartistafandom.ValueMember = "idartista";
                    break;
            }
        }
    }
}
