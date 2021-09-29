using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class Form1 : Form
    {
        private int segundos = 0;
        private int segundos2 = 0;
        private String codigo = "";
        public Form1()
        {
            InitializeComponent();
            Cargar.BackColor = Color.Transparent;
            Demo.BackColor = Color.Transparent;
            Logo.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AvisoError.Text = "No se pudo escanear el \nproducto, Intente de nuevo o \npase a servicio al cliente";

            Logo.Location = new Point(this.Width / 4 - Logo.Width / 2, this.Height/3-Logo.Height/2);
            Demo.Location = new Point(3*this.Width / 4 - Demo.Width / 2, this.Height / 3 - Demo.Height / 2);
            Lector.Location = new Point(this.Width/2 - Lector.Width/2,this.Height-Lector.Height-50);
            Aviso.Location = new Point(this.Width / 2 - Aviso.Width / 2, this.Height-Lector.Height - 90);
            ErrorImg.Location = new Point(this.Width / 2 - ErrorImg.Width / 2, this.Height / 2 - ErrorImg.Height / 2 - 100);
            AvisoError.Location = new Point(this.Width / 2 - AvisoError.Width/2, this.Height/2 - AvisoError.Height+200);
            Cargar.Location = new Point(this.Width / 2 - Cargar.Width / 2, this.Height/2 - Cargar.Height/2);
            ImagenP.Location = new Point(this.Width/8,this.Height/2-ImagenP.Height+100);
            Datos.Location = new Point(this.Width / 2, ImagenP.Location.Y);

            Cargar.Image = Image.FromFile("C:\\Users\\teo_2\\source\\repos\\Verificador_Precios\\Verificador_Precios\\img\\loading-waiting.gif");
            Demo.Image = Image.FromFile("C:\\Users\\teo_2\\source\\repos\\Verificador_Precios\\Verificador_Precios\\img\\LectorGif.gif");
            Cargar.SizeMode = PictureBoxSizeMode.StretchImage;
            Demo.SizeMode = PictureBoxSizeMode.StretchImage;
            Cargar.BackColor = Color.Transparent;
            Demo.BackColor = Color.Transparent;

            ImagenP.Visible = false;
            Cargar.Visible = false;
            ErrorImg.Visible = false;
            AvisoError.Visible = false;

        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //MessageBox.Show("vamos a buscar el producto "+codigo);
                Datos.Visible = false;
                AvisoError.Visible = false;
                ErrorImg.Visible = false;
                ImagenP.Visible = false;
                Logo.Height = 95;
                Logo.Width = 158;
                Logo.Location = new Point(this.Width / 4 - Logo.Width / 2, this.Height - Logo.Height - 50);
                Demo.Visible = false;
                Aviso.Visible = false;
                Lector.Visible = false;
                Cargar.Visible = true;
                segundos2 = 0;
                timer2.Enabled = true;

                try
                {
                    MySqlConnection servidor;
                    servidor = new MySqlConnection("server = 127.0.0.1; user = root; database = verificador_precios; SSL Mode = None; ");
                    servidor.Open();
                    string query = "SELECT producto_nombre, producto_precio, producto_stock, producto_imagen FROM productos WHERE producto_codigo =" + codigo + ";";
                    //MessageBox.Show(query);
                    MySqlCommand consulta;
                    consulta = new MySqlCommand(query, servidor);
                    MySqlDataReader resultado = consulta.ExecuteReader();

                    if (resultado.HasRows)
                    {
                        resultado.Read();
                        Demo.Visible = false;
                        Datos.Visible = true;
                        Lector.Visible=true;
                        ImagenP.Visible = true;
                        Logo.Visible = true;
                        Aviso.Visible = true;
                        Aviso.Text = "Esperando por nuevo articulo";
                        Aviso.Location = new Point(this.Width / 2 - Aviso.Width / 2, this.Height - Lector.Height - 90);
                        Datos.Text = resultado.GetString(0)+Environment.NewLine+"Precio: $"+resultado.GetString(1) +
                            Environment.NewLine + "Stock:" + resultado.GetString(2);
                        ImagenP.ImageLocation = resultado.GetString(3);
                        ImagenP.SizeMode = PictureBoxSizeMode.StretchImage;

                        segundos = 0;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        Lector.Visible = true;
                        ErrorImg.Visible = true;
                        Aviso.Visible = true;
                        AvisoError.Visible = true;
                        Datos.Visible = false;
                        ImagenP.Visible = false;
                        segundos = 0;
                        timer1.Enabled = true;
                    }
                }
                catch (Exception x)
                {
                    Datos.Visible = false;
                    Lector.Visible = true;
                    Aviso.Visible = true;
                    ImagenP.Visible = false;
                    ErrorImg.Visible = true;
                    AvisoError.Visible = true;
                    segundos = 0;
                    timer1.Enabled = true;
                }
                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            segundos++;

            if (segundos == 8)
            {
                timer1.Enabled = false;
                Lector.Visible = true;
                ImagenP.Visible = false;
                Logo.Height = 285;
                Logo.Width = 474;
                Logo.Location = new Point(this.Width / 4 - Logo.Width / 2, this.Height / 3 - Logo.Height / 2);
                Demo.Visible = true;
                Datos.Text = "";
                Aviso.Visible = true;
                Aviso.Text = "Esperando por articulo...";
                Aviso.Location = new Point(this.Width / 2 - Aviso.Width / 2, this.Height - Lector.Height - 90);
                ErrorImg.Visible = false;
                AvisoError.Visible = false;

            }
		}

        private void Cargar_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segundos2++;
            if (segundos2==2)
            {
                timer2.Enabled = false;
                Cargar.Visible = false;
            }
        }

        private void Datos_Click(object sender, EventArgs e)
        {

        }
    }
}