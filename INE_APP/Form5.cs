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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.BackColor = ColorTranslator.FromHtml("#FF4D6D");
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
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Cargar la imagen original
            Image I1 = Image.FromFile(@"C:\Users\isaia\Desktop\TRAMITES.png");

            // Especificar el tamaño deseado en píxeles
            int width = 100; // Ancho de la imagen redimensionada
            int height = 100; // Alto de la imagen redimensionada

            // Crear una nueva imagen redimensionada
            Bitmap resizedImage = new Bitmap(I1, width, height);

            // Asignar la nueva imagen redimensionada al PictureBox
            pictureBox1.Image = resizedImage;
            
        }
    }
}
