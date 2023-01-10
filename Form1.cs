using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            Regex v = new Regex("[,]");
            
            if(!(v.IsMatch(Txt_Altura.Text)))
            {
                MessageBox.Show("Digite a altura com vírgula decimal.");
                Txt_Altura.Clear();
            }
            if(!(v.IsMatch(Txt_Peso.Text)))
            {
                MessageBox.Show("Digite o peso com a vírgula decimal.");
                Txt_Peso.Clear();
            }
            else
            {
                CalculoIMC(Txt_Peso.Text, Txt_Altura.Text);
            }
            
           
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Altura.Clear();
            Txt_Peso.Clear();
        }

        public void CalculoIMC(string p, string a)
        {
           

            try
            {

                double peso = double.Parse(p);
                double altura = double.Parse(a);
                
                double resultado = Math.Round(peso / (Math.Pow(altura, 2)), 2);

                if (resultado < 18.5)
                    {
                    MessageBox.Show("O seu IMC é: " + resultado + ", classificado como magreza!");
                }
                else if(resultado >= 18.5 && resultado <=24.9)
                {
                    MessageBox.Show("O seu IMC é: " + resultado + ", classificado como peso normal.");
                }
                else if(resultado > 24.9 && resultado <= 29.9 )
                {
                    MessageBox.Show("O seu IMC é: " + resultado + ", classificado como sobrepeso.");
                }
                else if(resultado > 29.9 && resultado <= 39.9)
                {
                    MessageBox.Show("O seu IMC é: " + resultado + ", classificado como obesidade");
                }
                else
                {
                    MessageBox.Show("O seu IMC é: " + resultado + ", classificado como obesidade grave");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Valores digitados inválidos, digite novamente.");
            }

        }
    }
}
