using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] numeros = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "" };

        //public void inicializar()
        //{
        //    button1.Text = numeros[0];
        //    button2.Text = numeros[1];
        //    button3.Text = numeros[2];
        //    button4.Text = numeros[3];
        //    button5.Text = numeros[4];
        //    button6.Text = numeros[5];
        //    button7.Text = numeros[6];
        //    button8.Text = numeros[7];
        //    button9.Text = numeros[8];
        //    button10.Text = numeros[9];
        //    button11.Text = numeros[10];
        //    button12.Text = numeros[11];
        //    button13.Text = numeros[12];
        //    button14.Text = numeros[13];
        //    button15.Text = numeros[14];
        //    button16.Text = numeros[15];
        //}                 

        private void vari_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var Nums = Enumerable.Range(1, 15).OrderBy(x => rand.Next()).ToList();
            var numerosTS = Nums.Select(x => x.ToString()).ToList();
            
            button1.Text = numerosTS[0].ToString();
            button2.Text = numerosTS[1].ToString();
            button3.Text = numerosTS[2].ToString();
            button4.Text = numerosTS[3].ToString();
            button5.Text = numerosTS[4].ToString();
            button6.Text = numerosTS[5].ToString();
            button7.Text = numerosTS[6].ToString();
            button8.Text = numerosTS[7].ToString();
            button9.Text = numerosTS[8].ToString();
            button10.Text = numerosTS[9].ToString();
            button11.Text = numerosTS[10].ToString();
            button12.Text = numerosTS[11].ToString();
            button13.Text = numerosTS[12].ToString();
            button14.Text = numerosTS[13].ToString();
            button15.Text = numerosTS[14].ToString();
            button16.Text = "";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (button12.Text == "")
            {
                button12.Text = button16.Text;
                button16.Text = "";
            }
            if (button15.Text == "")
            {
                button15.Text = button16.Text;
                button16.Text = "";
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (button11.Text == "")
            {
                button11.Text = button15.Text;
                button15.Text = "";
            }
            if (button14.Text == "")
            {
                button14.Text = button15.Text;
                button15.Text = "";
            }
            if (button16.Text == "")
            {
                button16.Text = button15.Text;
                button15.Text = "";
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (button10.Text == "")
            {
                button10.Text = button14.Text;
                button14.Text = "";
            }
            if (button13.Text == "")
            {
                button13.Text = button14.Text;
                button14.Text = "";
            }
            if (button15.Text == "")
            {
                button15.Text = button14.Text;
                button14.Text = "";
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = button13.Text;
                button13.Text = "";
            }
            if (button14.Text == "")
            {
                button14.Text = button13.Text;
                button13.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = button12.Text;
                button12.Text = "";
            }
            if (button11.Text == "")
            {
                button11.Text = button12.Text;
                button12.Text = "";
            }
            if (button16.Text == "")
            {
                button16.Text = button12.Text;
                button12.Text = "";
            }

        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = button11.Text;
                button11.Text = "";
            }
            if (button10.Text == "")
            {
                button10.Text = button11.Text;
                button11.Text = "";
            }
            if (button12.Text == "")
            {
                button12.Text = button11.Text;
                button11.Text = "";
            }
            if (button15.Text == "")
            {
                button15.Text = button11.Text;
                button11.Text = "";
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button10.Text;
                button10.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button10.Text;
                button10.Text = "";
            }
            if (button11.Text == "")
            {
                button11.Text = button10.Text;
                button10.Text = "";
            }
            if (button14.Text == "")
            {
                button14.Text = button10.Text;
                button10.Text = "";
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button9.Text;
                button9.Text = "";
            }
            if (button10.Text == "")
            {
                button10.Text = button9.Text;
                button9.Text = "";
            }
            if (button13.Text == "")
            {
                button13.Text = button9.Text;
                button9.Text = "";
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button8.Text;
                button8.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }
            if (button12.Text == "")
            {
                button12.Text = button8.Text;
                button8.Text = "";
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button7.Text;
                button7.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button7.Text;
                button7.Text = "";
            }
            if (button11.Text == "")
            {
                button11.Text = button7.Text;
                button7.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button6.Text;
                button6.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button6.Text;
                button6.Text = "";
            }
            if (button10.Text == "")
            {
                button10.Text = button6.Text;
                button6.Text = "";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button5.Text;
                button5.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button5.Text;
                button5.Text = "";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button4.Text;
                button4.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button4.Text;
                button4.Text = "";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button3.Text;
                button3.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button3.Text;
                button3.Text = "";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button2.Text;
                button2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button1.Text;
                button1.Text = "";
            }

        }
    }
}
