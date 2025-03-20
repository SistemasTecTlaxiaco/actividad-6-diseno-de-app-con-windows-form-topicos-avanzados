using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        //MÉTODO DE CONFIRMACIÓN DE CITA_FORM 3
        private Boolean Validar(string C_entidad, string C_delegacion, string C_modulo,
            string C_fecha, string C_tramite)//metodo para saber si los campos de texto están vacíos o no
        {
            if (C_entidad != "" && C_delegacion != "" && C_modulo != "" &&
                C_fecha != "" && C_tramite != "")//validación de los campos de texto, que estén rellenados
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

        //MÉTODO DE UBICACIÓN DE MÓDULO_FORM 4
        private Boolean Validar(string C_entidad, string C_municipio)//metodo para saber si los campos de texto están vacíos o no
        {
            if (C_entidad != "" && C_municipio != "")//validación de los campos de texto, que estén rellenados
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
    }
}
