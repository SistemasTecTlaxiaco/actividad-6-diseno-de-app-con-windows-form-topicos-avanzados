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
    public partial class Form6 : Form
    {
        public Form6()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#FFB3C1");
            int radius = 40; // Radio de las esquinas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel2.Width - radius, panel2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel2.Region = new Region(path);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Btn_registrar.BackColor = ColorTranslator.FromHtml("#FFCCD5");
        }

            {
                DialogResult result = MessageBox.Show("INGRESE DATOS", "confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);//mensaje de alerta
                return false;//retorno del valor boleano
            }
        }
        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            bool datos_correctos = Validar();//llamado al metodo y guardado de su valor boleano
            if (datos_correctos)//comparación del valor voleano
            {
                DialogResult result = MessageBox.Show("¿Datos correctos?", "confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);//mensaje de confirmacion
                if (result == DialogResult.Yes)
                {//al aceptar
                    MessageBox.Show("CUENTA REGISTRADA", "Informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);//mensaje de confirmacion
                    this.Close();//cierrra la ventana
                }
                else//al negar
                {
                    //borrar el contenido de los campos de texto
                    this.C_nombre.Focus();
                    this.C_nombre.Text = "";
                    this.C_apellidop.Text = "";
                    this.C_apellidom.Text = "";
                    this.C_telefono.Text = "";
                    this.C_correo.Text = "";
                    this.C_correo2.Text = "";
                    this.C_contraseña.Text = "";
                    this.C_fecha.Text = "";
                }
            }
        }
    }
}
