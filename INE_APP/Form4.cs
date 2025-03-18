using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INE_APP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Contenedor.Dock = DockStyle.Fill;
            this.BackColor = ColorTranslator.FromHtml("#FF4D6D");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Contenedor_main.Width = 300;
            Contenedor_main.Height = 350;
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
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Cargar la imagen original
            Image I1 = Image.FromFile(@"C:\Users\isaia\Desktop\UBICACION.png");

            // Especificar el tamaño deseado en píxeles
            int width = 100; // Ancho de la imagen redimensionada
            int height = 100; // Alto de la imagen redimensionada

            // Crear una nueva imagen redimensionada
            Bitmap resizedImage = new Bitmap(I1, width, height);

            // Asignar la nueva imagen redimensionada al PictureBox
            pictureBox1.Image = resizedImage;

            Btn_localizar.BackColor = ColorTranslator.FromHtml("#FFCCD5");
        }
        private Boolean Validar()//metodo para saber si los campos de texto están vacíos o no
        {
            if (C_entidad.Text != "" && C_municipio.Text != "")//validación de los campos de texto, que estén rellenados
            {
                return true;
            }
            else
            {
                DialogResult result = MessageBox.Show("INGRESE DATOS", "confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);//mensaje de alerta
                return false;//retorno del valor boleano
            }
        }
        private void Btn_localizar_Click(object sender, EventArgs e)
        {
            bool datos_correctos = Validar();//llamado al metodo y guardado de su valor boleano
            if (datos_correctos)//comparación del valor voleano
            {
                DialogResult result = MessageBox.Show("¿Datos correctos?", "confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);//mensaje de confirmacion
                    if (result == DialogResult.Yes){//al aceptar
                        MessageBox.Show("MODULO UBICADO", "Informacion", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);//mensaje de confirmacion
                    this.C_entidad.Text = "";
                    this.C_municipio.Text = "";
                    this.C_direccion.Text = "CALLE SIN NOMBRE SIN NÚMERO, COLONIA 1";
                }
                else//al negar
                {
                    //borrar el contenido de los campos de texto
                    this.C_entidad.Focus();
                    this.C_entidad.Text = "";
                    this.C_municipio.Text = "";
                }
            }
        }
    }
}
