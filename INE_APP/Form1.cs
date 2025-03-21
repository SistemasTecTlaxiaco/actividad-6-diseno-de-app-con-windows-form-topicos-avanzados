using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INE_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_entrar.BackColor = ColorTranslator.FromHtml("#FFCCD5");
            Titulo.BackColor = ColorTranslator.FromHtml("#FFB3C1");
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Centrar el Label horizontal y verticalmente en el formulario
            Titulo.Left = (this.ClientSize.Width - Correo.Width) / 2;
            Titulo.Top = (this.ClientSize.Height - Correo.Height) / 2;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Contenedor_1.Dock = DockStyle.Fill; 
            Titulo.BackColor = ColorTranslator.FromHtml("#FF4D6D");
            this.BackColor = ColorTranslator.FromHtml("#FF4D6D");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           Menu_1.Width = 300;
            Menu_1.Height = 270;
            this.BackColor = ColorTranslator.FromHtml("#FFB3C1");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.Width = 300;
            panel1.Height = 270;
            int radius = 40; // Radio de las esquinas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel1.Region = new Region(path);
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void textBox1_Paint(object sender, PaintEventArgs e)
        {
            // Establecer el padding para el TextBox
            int paddingLeft = 20;
            int paddingTop = 10;
            int paddingRight = 20;
            int paddingBottom = 10;
            // Crear un rectángulo con el padding definido
            Rectangle rect = new Rectangle(
                paddingLeft,
                paddingTop,
                C_correo.ClientSize.Width - paddingLeft - paddingRight,
                C_correo.ClientSize.Height - paddingTop - paddingBottom
            );
            // Dibujar el texto dentro del área con padding
            e.Graphics.FillRectangle(Brushes.White, rect);
            e.Graphics.DrawString(C_correo.Text, C_correo.Font, Brushes.Black, rect);
        }
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
                bool datos_correctos = Validar();//llamado al metodo y guardado de su valor boleano
                if (datos_correctos)//comparación del valor voleano
                {
                    DialogResult result = MessageBox.Show("¿Datos correctos?", "confirmación", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);//mensaje de confirmacion
                    if (result == DialogResult.Yes){//al aceptar
                        MessageBox.Show("SESIÓN INICIADA", "Informacion", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);//mensaje de confirmacion
                        // Crea una instancia de Form2
                        Form2 form2 = new Form2();
                        // Muestra el Form2
                        form2.Show(); // Abre Form2 de forma no modal (el usuario puede interactuar con ambos
                                      // formularios).

                    }else{//al negar
                        C_correo.Focus();
                        this.C_correo.Text = "";
                        this.C_contraseña.Text = "";
                    }
                }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            // Crea una instancia de Form2
            Form6 form6 = new Form6();
            // Muestra el Form2
            form6.Show(); // Abre Form2 de forma no modal
                          // (el usuario puede interactuar con ambos formularios).
        }

    }
}
