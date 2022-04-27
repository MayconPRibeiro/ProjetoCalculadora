using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    class ModelCalculadora
    {
        public ModelCalculadora()
        {

        }//Fim do construtor

        public double Somar(double num1, double num2)
        {

            return num1 + num2;

        }//Fim somar

        public double Subtrair(double num1, double num2)
        {

            return num1 - num2;

        }//Fim subtrair

        public double Multiplicar(double num1, double num2)
        {

            return num1 * num2;

        }//Fim Multiplicar

        public double Dividir(double num1, double num2)
        {

            if(num2 <= 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }

        }//Fim dividir

        public double Potencia(double bas, double expoente)
        {

            if(expoente == 1)
            {
                return bas;
            }else if(expoente == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(bas, expoente);
            }

        }//Fim Potencia

        public double Raiz(double num1)
        {

            if(num1 <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Sqrt(num1);
            }

        }//Fim Raiz

    }//Fim da Classe
}//Fim Projeto
