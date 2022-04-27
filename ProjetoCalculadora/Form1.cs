using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculadora();
        }//Fim construtor

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim da label primeiro numero

        private void Soma_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text); //Coletadno num1
                double num2 = Convert.ToDouble(textBox2.Text); //Coletadno num2 
                double resultado = model.Somar(num1, num2); //Utilizando o metodo somar e salvando na variavel resultado
                label3.Text = "" + resultado; //Mostrando o resultado na label 3
            }catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados\n\n\n" + erro);
            }//Fim try catch

        }//Fim botão soma

        private void label2_Click(object sender, EventArgs e)
        {

        }//Fim da label primeiro numero

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o primeiro numero

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o segundo numero

        private void Subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Subtrair(num1, num2);
                label3.Text = "" + resultado;
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados\n\n\n" + erro);
            }//Fim try catch

        }//Fim botão subtrair

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Multiplicar(num1, num2);
                label3.Text = "" + resultado;
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados\n\n\n" + erro);
            }//Fim try catch

        }//Fim botão multiplicar

        private void Dividir_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Dividir(num1, num2);

                if (resultado == -1)
                {
                    label3.Text = "Impossível dividir :'(";
                }
                else
                {
                    label3.Text = "" + resultado;
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados\n\n\n" + erro);
            }//Fim try catch

        }//Fim botão dividir

        private void Potencia_Click(object sender, EventArgs e)
        {
            try
            {
                double bas = Convert.ToDouble(textBox1.Text);
                double expoente = Convert.ToDouble(textBox2.Text);
                double resultado = model.Potencia(bas, expoente);
                label3.Text = "" + resultado;
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados\n\n\n" + erro);
            }//Fim try catch
        }//Fim botão potencia

        private void Raiz_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double resultado = model.Raiz(num1);
                if (resultado == -1)
                {
                    label3.Text = "Impossível calcular a raíz";
                }
                else
                {
                    label3.Text = "" + resultado;
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados\n\n\n" + erro);
            }//Fim try catch

        }//Fim botão raiz

        private void label3_Click(object sender, EventArgs e)
        {

        }//Fim da label Resultado
    }//Fim da classe
}//Fim do Projeto
