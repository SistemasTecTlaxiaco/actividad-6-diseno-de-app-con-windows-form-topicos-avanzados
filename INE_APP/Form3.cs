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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INE_APP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Contenedor.Dock = DockStyle.Fill;
            this.BackColor = ColorTranslator.FromHtml("#FF4D6D");
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
            panel1.Height = 300;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Btn_confirmar.BackColor = ColorTranslator.FromHtml("#FFCCD5");
        }
        

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            bool datos_correctos = Validar();//llamado al metodo y guardado de su valor boleano
            if (datos_correctos)//comparación del valor voleano
            {
                DialogResult result = MessageBox.Show("¿Datos correctos?", "confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);//mensaje de confirmacion
                if (result == DialogResult.Yes)
                {//al aceptar
                    MessageBox.Show("CITA AGENDADA", "Informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);//mensaje de confirmacion
                    // Crea una instancia de Form
                    Form1 form1 = new Form1();
                    // Muestra el Form
                    form1.Show(); // Abre Form de forma no modal (el usuario puede
                                  // interactuar con ambos formularios).
                }
                else//al negar
                {
                    //borrar el contenido de los campos de texto
                    this.C_entidad.Focus();
                    this.C_entidad.Text="";
                    this.C_delegacion.Text = "";
                    this.C_modulo.Text = "";
                    this.C_fecha.Text = "";
                    this.C_tramite.Text = "";
                }
            }
        }
    }
}
