using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float num1;
        private float num2;
        private char operador;
        private int operacion;
        private bool operacionFlag;
        private bool operacionFlag2;
        private bool comienzo;
        private bool final;
        private bool coma;
        private bool error;
        private bool cambiarOperador;
        private String mensaje;
        private float resultado;

        private void Form1_Load(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            resultado = 0;
            comienzo = true;
            final = false;
            lblOperacion.Text = "0";
            operacionFlag = false;
            operacionFlag2 = false;
            coma = false;
            error = false;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                error = false;
                cogerValor(e.KeyValue);
                //compruebo si ya se habia hecho una operacion sin presionar enter.
                if (operacionFlag)
                {
                    //si la respuesta es afirmativa activo otra bandera
                    operacionFlag2 = true;
                }
               
            }
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Divide || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Subtract)
            {
                
                if (final)
                {
                    final = false;
                }
                cogerOperador(e.KeyValue);
                cambiarOperador = true;
                if (operacionFlag)
                {
                    lblOperacion.Text = Convert.ToString(num1)+Convert.ToString(operador);
                    //compruebo si es una operacion nueva, antes de hacerla debe coger un valor 
                    if (operacionFlag2)
                    {
                        num1 = resultado;
                        hacerOperacion();
                    }
                    
                }else
                {
                    lblOperacion.Text = Convert.ToString(num1)+Convert.ToString(operador);
                }
                
                coma = false;
                
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                if (!coma)
                    //compruebo si la coma ya se ha utilizado.
                {
                    lblResultat.Text = lblResultat.Text + ",";
                    coma = true;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (!final)
                {
                    hacerOperacion();
                    num1 = resultado;
                    operacionFlag = false;
                    operacionFlag2 = false;
                    final = true;
                }else
                {
                    //en caso que se presione enter por segunda vez se reinician las operaciones.
                    lblOperacion.Text = "0";
                    lblResultat.Text = "0";
                    operacionFlag = false;
                    operacionFlag2 = false;
                    final = false;
                    coma = false;
                    num1 = 0;
                    num2 = 0;

                }
                
            } else if (e.KeyCode == Keys.Back)
            {
                borrar1pos();
            }



        }
        private void operaciones(int valorTecla)
        {
            //una vez que se escoge una operacion se coge el valor de lblResultat i se convierte a float. Ya se controla en el inicio que no se puedan introducir numeros. 
            float.TryParse(lblResultat.Text, out num1);
            //una vez que se ha cogido su valor, se reinicia lblResultat.
            lblResultat.Text = "";
            //se coge el valor de la tecla presionada que es igual a la operacion
            operacion = valorTecla;
            coma = false;
            //operacionFlag = true; <-- Innecesario


        }
        private void hacerOperacion()
        {
           
            float.TryParse(lblResultat.Text, out num2);
            lblOperacion.Text += Convert.ToString(num2);
            if(num1 != 0 || num2 != 0) { 
            switch (operador)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            mensajes(1);
                        }
                        else
                        {
                            resultado = num1 / num2;
                        }
                        break;
                }
               if (!error)
                {
                    lblResultat.Text = Convert.ToString(resultado);
                }
                //buscarOperador sirve para encontrar el simbolo en char del operador a utilizado.
                buscarOperador();
               
                operacionFlag = true;
                comienzo = true;
                cambiarOperador = false;

            } else
            {
                lblOperacion.Text = "0";
                lblResultat.Text = "0";
            }

        }
        private void mensajes(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    mensaje = "Error!";
                    break;
            }
            error = true;
            lblResultat.Text = mensaje;
        }

        //Botones Operaciones                       <------------------------------------------

        private void bC_MouseUp(object sender, MouseEventArgs e)
        {
            lblResultat.Text = "0";
            this.KeyPreview = true;
        }

        private void bBorrar_MouseUp(object sender, MouseEventArgs e)
        {
            borrar1pos();
            this.KeyPreview = true;
        }
        private void bDividir_MouseUp(object sender, MouseEventArgs e)
        {
            if (final)
            {
                final = false;
            }
            this.KeyPreview = true;
            cogerOperador(111);
            if (operacionFlag)
            {
                lblOperacion.Text = Convert.ToString(num1) + Convert.ToString(operador);
                //compruebo si es una operacion nueva, antes de hacerla debe coger un valor 
                if (operacionFlag2)
                {
                    //si ya se ha hecho una operación pero se quiere continuar haciendo otra, operacionFlag2 estará en true
                    num1 = resultado;
                    hacerOperacion();
                }

            }
            else
            {
                lblOperacion.Text = Convert.ToString(num1) + Convert.ToString(operador);
            }
        }
        private void bMultiplicacion_MouseUp(object sender, MouseEventArgs e)
        {
            if (final)
            {
                final = false;
            }
            this.KeyPreview = true;
            cogerOperador(106);
            if (operacionFlag)
            {
                lblOperacion.Text = Convert.ToString(num1) + Convert.ToString(operador);
                //compruebo si es una operacion nueva, antes de hacerla debe coger un valor 
                if (operacionFlag2)
                {
                    num1 = resultado;
                    hacerOperacion();
                }

            }
            else
            {
                lblOperacion.Text = Convert.ToString(num1) + Convert.ToString(operador);
            }
        }
        private void bResta_MouseUp(object sender, MouseEventArgs e)
        {
            if (final)
            {
                final = false;
            }
            this.KeyPreview = true;
            cogerOperador(109);
            if (operacionFlag)
            {
                lblOperacion.Text = Convert.ToString(num1) + Convert.ToString(operador);
                //compruebo si es una operacion nueva, antes de hacerla debe coger un valor 
                if (operacionFlag2)
                {
                    num1 = resultado;
                    hacerOperacion();
                }

            }
            else
            {
                lblOperacion.Text = Convert.ToString(num1) + Convert.ToString(operador);
            }
        }
        private void bSuma_MouseUp(object sender, MouseEventArgs e)
        {
            if (final)
            {
                final = false;
            }
            this.KeyPreview = true;
            cogerOperador(107);
            if (operacionFlag)
            {
                lblOperacion.Text = Convert.ToString(num1) + Convert.ToString(operador);
                //compruebo si es una operacion nueva, antes de hacerla debe coger un valor 
                if (operacionFlag2)
                {
                    num1 = resultado;
                    hacerOperacion();
                }

            }
            else
            {
                lblOperacion.Text = Convert.ToString(num1) + Convert.ToString(operador);
            }
        }
        private void bIgual_MouseUp(object sender, MouseEventArgs e)
        {
            if (!final)
            {
                // si final aun no está en true quiere decir que es la primera vez que se aprieta el igual
                hacerOperacion();
                num1 = resultado;
                operacionFlag = false;
                operacionFlag2 = false;
                final = true;
            }
            else
            {
                //la segunda vez se reiniciaran todos los valores de la calculadora. 
                lblOperacion.Text = "0";
                lblResultat.Text = "0";
                operacionFlag = false;
                operacionFlag2 = false;
                final = false;
                coma = false;
                num1 = 0;
                num2 = 0;

            }
        }
        private void bCE_MouseUp(object sender, MouseEventArgs e)
        {
            lblOperacion.Text = "0";
            lblResultat.Text = "0";
            operacionFlag = false;
            operacionFlag2 = false;
            final = false;
            coma = false;
            num1 = 0;
            num2 = 0;
            this.KeyPreview = true;
        }
        private void bComa_MouseUp(object sender, MouseEventArgs e)
        {
            if (!coma)
            //compruebo si la coma ya se ha utilizado
            {
                lblResultat.Text = lblResultat.Text + ",";
                coma = true;
                this.KeyPreview = true;
            }
        }

        //Botones numeros                                           <------------------------------------------
        private void buttonsNumero_MouseUp(object sender, MouseEventArgs e)
        {
           Button botonNumero = (Button)sender;
            cogerBValor(int.Parse(botonNumero.Text));
 
            if (operacionFlag)
            {
                //si la respuesta es afirmativa activo otra bandera
                operacionFlag2 = true;
            }

            this.KeyPreview = true;
        }
       
        private void buscarOperador()
         {
             switch (operacion)
             {
                 case 107:
                     operador = '+';
                     break;
                 case 109:
                     operador = '-';
                     break;
                 case 106:
                    operador = '*';
                     break;
                 case 111:
                    operador = '/';
                    break;
             }
        }
     
        private void borrar()
        {
            String cambioLabel = "";

            if((lblOperacion.Text.Length == 1 || comienzo == true))
            {
                lblOperacion.Text = "0";
            }
            if ((lblResultat.Text.Length == 1 || comienzo == true)) 
            {
                lblResultat.Text = "0";
                
            }
            else if (lblOperacion.Text.Length > 1 && operacionFlag == true)  
            {

                lblOperacion.Text = lblOperacion.Text.Substring(0, lblOperacion.Text.Length - 1);
                
               
            }
            else if(lblResultat.Text.Length >= 1)
            {
                if (lblResultat.Text.Length - 1 == 0)
                {
                    lblResultat.Text = "0";
                }
                else
                {
                    lblResultat.Text = lblResultat.Text.Substring(0, lblResultat.Text.Length - 1);
                }
            }
            
        }
        private void borrar1pos()
        {
            if (lblResultat.Text.Length == 1 && !final)
            {
                lblResultat.Text = "0";

            }
            else if (lblResultat.Text.Length > 1 && !final)
            {

                lblResultat.Text = lblResultat.Text.Substring(0, lblResultat.Text.Length - 1);


            }
        }
        private void cogerOperador (int valor)
        {
            if (cambiarOperador)
            {
                //comprobar si ya hay un operador en uso y hacer el cambio.
                operacion = valor;
                borrar();

            }
            else
            {
                //en caso de no haber se coge directamente el que se haya introducido.
                operaciones(valor);

            }
            buscarOperador();
        }
        private void cogerValor(int valor)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = Convert.ToString(valor - ((int)Keys.NumPad0));
            }
            else
            {
                lblResultat.Text += Convert.ToString(valor - ((int)Keys.NumPad0));
            }
            
           
        }
        private void cogerBValor(int bNum)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = Convert.ToString(bNum);
            }
            else
            {
                lblResultat.Text += Convert.ToString(bNum);
            }
        }

        private void operacionesB (int valor)
        {
            this.KeyPreview = true;
            cogerOperador(valor);
            lblOperacion.Text += Convert.ToString(operador);
            if (operacionFlag2)
            {
                hacerOperacion();

                operacionFlag2 = false;
            }
            coma = false;
        }

        
    }
}
