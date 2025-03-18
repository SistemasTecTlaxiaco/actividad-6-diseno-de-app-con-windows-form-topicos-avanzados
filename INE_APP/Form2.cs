using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INE_APP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Contenedor.Dock = DockStyle.Fill;
            //Titulo.BackColor = ColorTranslator.FromHtml("#FF4D6D");
            this.BackColor = ColorTranslator.FromHtml("#FF4D6D");
        }

        private void Contenedor2_Paint(object sender, PaintEventArgs e)
        {
            Contenedor2.Left = (this.ClientSize.Width - Contenedor2.Width) / 2;
            Contenedor2.Top = (this.ClientSize.Height - Contenedor2.Height) / 2;
            Contenedor2.Width = 600;
            Contenedor2.Height = 280;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#FFB3C1");
            int radius = 40; // Radio de las esquinas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel1.Region = new Region(path);

            panel1.Height = 280;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#FFB3C1");
            int radius = 40; // Radio de las esquinas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel2.Width - radius, panel2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel2.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel2.Region = new Region(path);
            panel2.Height = 280;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#FFB3C1");
            int radius = 40; // Radio de las esquinas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel3.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel3.Width - radius, panel3.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel3.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel3.Region = new Region(path);
            panel3.Height = 280;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Titulo.BackColor = ColorTranslator.FromHtml("#FFB3C1");
            // Cargar la imagen original
            Image I1 = Image.FromFile(@"C:\Users\isaia\Desktop\AGENDAR.png");

            // Especificar el tamaño deseado en píxeles
            int width = 160; // Ancho de la imagen redimensionada
            int height = 160; // Alto de la imagen redimensionada

            // Crear una nueva imagen redimensionada
            Bitmap resizedImage = new Bitmap(I1, width, height);

            // Asignar la nueva imagen redimensionada al PictureBox
            pictureBox1.Image = resizedImage;

            Image I2 = Image.FromFile(@"C:\Users\isaia\Desktop\UBICACION.png");
            Bitmap I22 = new Bitmap(I2, width, height);
            pictureBox2.Image = I22;

            Image I3 = Image.FromFile(@"C:\Users\isaia\Desktop\TRAMITES.png");
            Bitmap I33 = new Bitmap(I3, width, height);
            pictureBox3.Image = I33;
            
            Btn_agendar.BackColor = ColorTranslator.FromHtml("#FFCCD5");
            Btn_ubicar.BackColor = ColorTranslator.FromHtml("#FFCCD5");
            Btn_ver.BackColor = ColorTranslator.FromHtml("#FFCCD5");

        }

        private void Btn_agendar_Click(object sender, EventArgs e)
        {
            // Crea una instancia de Form2
            Form3 form3 = new Form3();

            // Muestra el Form2
            form3.Show(); // Abre Form2 de forma no modal
                          // (el usuario puede interactuar con ambos formularios).}
        }
        private void Btn_ubicar_Click(object sender, EventArgs e)
        {
            // Crea una instancia de Form2
            Form4 form4 = new Form4();

            // Muestra el Form2
            form4.Show(); // Abre Form2 de forma no modal
                          // (el usuario puede interactuar con ambos formularios).
        }

        private void Btn_ver_Click(object sender, EventArgs e)
        {
            // Crea una instancia de Form2
            Form5 form5 = new Form5();

            // Muestra el Form2
            form5.Show(); // Abre Form2 de forma no modal
                          // (el usuario puede interactuar con ambos formularios).
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
