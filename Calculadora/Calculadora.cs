using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        private float operante1;
        private float operante2;
        private float resultado;
        private String operador;
        

       /* public Calculadora( float cOperante1, float cOperante2, String cOperador)
        {
            operante1 = cOperante1;
            operante2 = cOperante2;
            resultado = 0;
            operador = cOperador;
        }
        */

       public float Sumar()
        {
            resultado = operante1 + operante2;

            return resultado;
        }
        public float Restar()
        {
            resultado = operante1 - operante2;

            return resultado;
        }
        public float Multiplicar()
        {
            resultado = operante1 * operante2;

            return resultado;

        }
        public float Dividir()
        {
 
            resultado = operante1 / operante2;
            return resultado;

        }

        public float getOperante1()
        {
            return this.operante1;
        }
        public float getOperante2()
        {
            return this.operante2;
        }
        public float getResultado()
        {
            return this.resultado;
        }
        public String getOperador()
        {
            return this.operador;
        }
        public void setOperante1(float operante1)
        {
            this.operante1 = operante1;
        }
        public void setOperante2(float operante2)
        {
            this.operante2 = operante2;
        }
        public void setResultado(float resultado)
        {
            this.resultado = resultado;
        }
        public void setOperador(String operador)
        {
            this.operador = operador;
        }
    }
}
