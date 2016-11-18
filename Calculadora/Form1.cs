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
       
        private bool operacionFlag;
        private bool operacionFlag2;
        private bool comienzo;
        //La variable final marca cuando se ha hecho una operación y da paso a la siguiente en caso de que se presione otra operación sin entrar numeros nuevos.
        private bool final;
        private bool coma;
        private bool error;
        private bool cambiarOperador;
        

        Calculadora calculadora;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comienzo = true;
            final = false;
            lblOperacion.Text = "0";
            operacionFlag = false;
            operacionFlag2 = false;
            coma = false;
            error = false;
            calculadora = new Calculadora();
            calculadora.setResultado(0);
            calculadora.setOperante2(0);
            calculadora.setOperante1(0);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                error = false;
                cogerValorTeclado(e.KeyValue);
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
                     lblOperacion.Text = Convert.ToString(calculadora.getOperante1()) + Convert.ToString(calculadora.getOperador());
                    
                    //compruebo si es una operacion nueva, antes de hacerla debe coger un valor 

                    if (operacionFlag2)
                     {
                        
                        calculadora.setOperante1(calculadora.getResultado());
                        calculadora.setOperante2(float.Parse(lblResultat.Text));
                        lblOperacion.Text += Convert.ToString(calculadora.getOperante2());
                        hacerOperacion();
                    }

                 }else
                 {
                
                    lblOperacion.Text = Convert.ToString(calculadora.getOperante1()) + Convert.ToString(calculadora.getOperador());
                }
               

                comienzo = false;
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
                    
                    calculadora.setOperante2(float.Parse(lblResultat.Text));
                    lblOperacion.Text += Convert.ToString(calculadora.getOperante2());
                    hacerOperacion();
                    calculadora.setOperante1(calculadora.getResultado());
                    operacionFlag = false;
                    operacionFlag2 = false;
                    final = true;
                }else
                {
                    //en caso que se presione enter por segunda vez se reinician las operaciones.
                    calculadora.setResultado(0);
                    calculadora.setOperante2(0);
                    calculadora.setOperante1(0);
                    operacionFlag = false;
                    operacionFlag2 = false;
                    final = false;
                    coma = false;
                    lblOperacion.Text = Convert.ToString(calculadora.getResultado());
                    lblResultat.Text = Convert.ToString(calculadora.getResultado());

                }
                
            } else if (e.KeyCode == Keys.Back)
            {
                lblResultat.Text = borrarUnaPosicion();
            }



        }
        private int operacionesTeclado(int valorTecla)
        {
            int operacion = 0;
            //una vez que se escoge una operacion se coge el valor de lblResultat i se convierte a float. Ya se controla en el inicio que no se puedan introducir numeros. 
            try
            {
                calculadora.setOperante1(float.Parse(lblResultat.Text));
            }catch
            {
                calculadora.setOperante1(0); 
            }
            //una vez que se ha cogido su valor, se reinicia lblResultat.
            //se coge el valor de la tecla presionada que es igual a la operacion
            operacion = valorTecla;
            coma = false;
            

            return operacion;
        }
        private void operacionesBotones(int valor)
        {
            this.KeyPreview = true;
            cogerOperador(valor);
            lblOperacion.Text += calculadora.getOperador();
            if (operacionFlag2)
            {
                calculadora.setOperante2(float.Parse(lblResultat.Text));
                lblOperacion.Text += Convert.ToString(calculadora.getOperante2());
                hacerOperacion();

                operacionFlag2 = false;
            }
            coma = false;
        }
        private void hacerOperacion()
        {
            try { 
            switch (Convert.ToChar(calculadora.getOperador()))
                {
                    case '+':
                         calculadora.setResultado(calculadora.Sumar());
                        break;
                    case '-':

                    calculadora.setResultado(calculadora.Restar());
                        break;
                    case '*':
                    calculadora.setResultado(calculadora.Multiplicar());
                        break;
                    case '/':
                        if (calculadora.getOperante2() != 0)
                        {
                        calculadora.setResultado(calculadora.Dividir());
                        }else if (calculadora.getOperante2()==0)
                        {
                            lblResultat.Text = "Error!";
                            error = true;
                        }
                        break;
                default:
                    lblResultat.Text = Convert.ToString(calculadora.getResultado());
                    break;
                }
            }
            catch
            {
                lblResultat.Text = "Error!";
                error = true;
            }
            if (!error)
                {
                    
                    lblResultat.Text = Convert.ToString(calculadora.getResultado());
                }
             
               
                operacionFlag = true;
                comienzo = false;
                cambiarOperador = false;
            
        }
       
        private void botonesNumero_MouseUp(object sender, MouseEventArgs e)
        {
            Button botonNumero = (Button)sender;
            cogerValorBoton(int.Parse(botonNumero.Text));

            if (operacionFlag)
            {
                //si la respuesta es afirmativa activo otra bandera
                operacionFlag2 = true;
            }

            this.KeyPreview = true;
        }
        private void botonesOperaciones_MouseUp(object sender, MouseEventArgs e)
        {
            Button botones = ((Button)sender);
            int iOperador = 0;

            if (final)
            {
                final = false;
            }
            iOperador = operadorEnInt(botones.Text);
            this.KeyPreview = true;
            cogerOperador(iOperador);
            
            if (operacionFlag)
            {
                lblOperacion.Text = Convert.ToString(calculadora.getOperante1()) + Convert.ToString(calculadora.getOperador());
                //compruebo si es una operacion nueva, antes de hacerla debe coger un valor 
                if (operacionFlag2)
                {
                    //si ya se ha hecho una operación pero se quiere continuar haciendo otra, operacionFlag2 estará en true
                    calculadora.setOperante1(calculadora.getResultado());
                    calculadora.setOperante2(float.Parse(lblResultat.Text));
                    lblOperacion.Text += Convert.ToString(calculadora.getOperante2());
                    hacerOperacion();
                }

            }
            else
            {
                lblOperacion.Text = Convert.ToString(calculadora.getOperante1()) + Convert.ToString(calculadora.getOperador());
            }
            comienzo = false;
        }
        
        #region botonesAccionesYComa
        private void bIgual_MouseUp(object sender, MouseEventArgs e)
        {
            if (!final)
            {
                // si final aun no está en true quiere decir que es la primera vez que se aprieta el igual
                calculadora.setOperante2(float.Parse(lblResultat.Text));
                lblOperacion.Text += Convert.ToString(calculadora.getOperante2());
                hacerOperacion();
                calculadora.setOperante1(calculadora.getResultado());
                operacionFlag = false;
                operacionFlag2 = false;
                final = true;
            }
            else
            {
                //la segunda vez se reiniciaran todos los valores de la calculadora. 
                calculadora.setResultado(0);
                calculadora.setOperante2(0);
                calculadora.setOperante1(0);
                operacionFlag = false;
                operacionFlag2 = false;
                final = false;
                coma = false;
                lblOperacion.Text = Convert.ToString(calculadora.getResultado());
                lblResultat.Text = Convert.ToString(calculadora.getResultado());

            }
        }
        private void bCE_MouseUp(object sender, MouseEventArgs e)
        {
            lblResultat.Text = "0";
            this.KeyPreview = true;
        }

        private void bBorrar_MouseUp(object sender, MouseEventArgs e)
        {
            lblResultat.Text = borrarUnaPosicion();
            this.KeyPreview = true;
        }
        private void bC_MouseUp(object sender, MouseEventArgs e)
        {
            calculadora.setResultado(0);
            calculadora.setOperante2(0);
            calculadora.setOperante1(0);
            operacionFlag = false;
            operacionFlag2 = false;
            final = false;
            coma = false;
            lblOperacion.Text = Convert.ToString(calculadora.getResultado());
            lblResultat.Text = Convert.ToString(calculadora.getResultado());
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
        #endregion

        
       
        private void buscarOperador( int operacion)
         {
            char operador = ' ';

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
            calculadora.setOperador(Convert.ToString(operador));
        }

        private String borrarUnaPosicion()
        {

            String cambioLabel = "";

            if (lblResultat.Text.Length == 1 && !final)
            {
                cambioLabel = "0";

            }
            else if (lblResultat.Text.Length > 1 && !final)
            {
                if (lblResultat.Text.Substring(lblResultat.Text.Length - 1 , 1) == ",")
                {
                    coma = false;
                }
                cambioLabel = lblResultat.Text.Substring(0, lblResultat.Text.Length - 1);

                
            }
            return cambioLabel; 
        }
        private void cogerOperador (int valor)
        {
            int operacion = 0;
            if (cambiarOperador)
            {
                //comprobar si ya hay un operador en uso y hacer el cambio.
                operacion = valor;
                borrarUnaPosicion();

            }
            else
            {
                //en caso de no haber se coge directamente el que se haya introducido.
                operacion = operacionesTeclado(valor);

            }
            buscarOperador(operacion);
        }
        private void cogerValorTeclado(int valor)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = Convert.ToString(valor - ((int)Keys.NumPad0));
            }
            else
            {
                if (comienzo == false)
                {
                    lblResultat.Text = "";
                    comienzo = true;
                }
                lblResultat.Text += Convert.ToString(valor - ((int)Keys.NumPad0));
            }
            
           
        }
        private void cogerValorBoton(int bNum)
        {
            if (lblResultat.Text == "0")
            {
                lblResultat.Text = Convert.ToString(bNum);
            }
            else
            {
                if (comienzo == false)
                {
                    lblResultat.Text = "";
                }
                lblResultat.Text += Convert.ToString(bNum);
            }
        }
        private int operadorEnInt(String operador)
        {
            int iOperador = 0;
            switch (operador)
            {
                case "+":
                    iOperador = 107;
                    break;
                case "-":
                    iOperador = 109;
                    break;
                case "*":
                    iOperador = 106;
                    break;
                case "/":
                    iOperador = 111;
                    break;
            }
            return iOperador;
        }
    }
}
