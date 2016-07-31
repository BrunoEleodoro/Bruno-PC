using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExFuncoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            textBox2.Text = diaSemana(num);
        }
        public string diaSemana(int num)
        {
            string res = "";
            if (num == 1)
            {
                res = "Domingo";
            }
            else if (num == 2)
            {
                res = "Segunda";
            }
            else if (num == 3)
            {
                res = "Terça";
            }
            else if (num == 4)
            {
                res = "Quarta";
            }
            else if (num == 5)
            {
                res = "Quinta";
            }
            else if (num == 6)
            {
                res = "Sexta";
            }
            else if (num == 7)
            {
                res = "Sabado";
            }
            else
            {
                res = "Informe um numero valido";
            }
            return res;
        }
        public string mes(int num)
        {
            string res = "";
            if (num == 1)
            {
                res = "Janeiro";
            }
            else if (num == 2)
            {
                res = "Fevereiro";
            }
            else if (num == 3)
            {
                res = "Março";
            }
            else if (num == 4)
            {
                res = "Abril";
            }
            else if (num == 5)
            {
                res = "Maio";
            }
            else if (num == 6)
            {
                res = "Junho";
            }
            else if (num == 7)
            {
                res = "Julho";
            }
            else if (num == 8)
            {
                res = "Agosto";
            }
            else if (num == 9)
            {
                res = "Setembro";
            }
            else if (num == 10)
            {
                res = "Outubro";
            }
            else if (num == 11)
            {
                res = "Novembro";
            }
            else if (num == 12)
            {
                res = "Dezembro";
            }
            else
            {
                res = "Informe um numero valido";
            }
            return res;
        }
        public string hundred(int num)
        {
            string res = "";
            int i = 0;
            if (num > 100)
            {
                res = "Numero maior que 100";
            }
            else
            {
                while (i <= num)
                {
                    res += i + "-";
                    i++;
                }
            }
            
            return res;
        }
        public string tabuada(int num)
        {
            string res = "";
            int i = 0;
            while (i <= 10)
            {
                res += num + "x" + i + "=" + (num * i) +"\r\n";
                i++;
            }
            return res;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = mes(int.Parse(textBox4.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = hundred(int.Parse(textBox6.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.Text = tabuada(int.Parse(textBox7.Text));
        }
    }
}
