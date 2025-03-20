using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_INE
{
    public class Clase_validaciones
    {
        //BIBLIOTECA AÑADIDA
        //MÉTODO DE CONFIRMACIÓN DE INICIO DE SESIÓN_FORM 1
        public static Boolean Validar_form1(string C_correo, string C_contraseña)//metodo para saber si los campos de texto están vacíos o no
        {
            if (C_correo == "" && C_contraseña == "" || C_correo == "" ||
                C_contraseña == "")//validación de los campos de texto, que no estén vacios
            {
                DialogResult result = MessageBox.Show("INGRESE DATOS", "confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);//mensaje de alerta
                return false;//retorno del valor boleano
            }
            else
            {
                return true;
            }
        }
    }
}
