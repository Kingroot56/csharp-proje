using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sayilar = new string[2];
       
        public int ekle(string sayi,string islem)
        {
            int sayac = 0;
            sayilar[sayac] = sayi;
            sayac += 1;
            sayilar[sayac] = islem;
            return sayac;
        }
        public int Alan(int x, int y)
        {
            int a = x * y;
            return a;
        }
        public double sonuc()
        {
            double son=0;
            //int son = sayilar[0] + Convert.ToInt32(textBox3.Text);
            if (sayilar[1] == "+")
            {
                double sonuc = Convert.ToDouble(sayilar[0])+ Convert.ToInt32(textBox3.Text);
                //textBox3.Text = sonuc.ToString();
                return sonuc;
            }
            else if(sayilar[1] == "-")
            {
                double sonuc = Convert.ToDouble(sayilar[0]) - Convert.ToInt32(textBox3.Text);
                //textBox3.Text = sonuc.ToString();
                return sonuc;
            }
            else if (sayilar[1] == "/")
            {
                if (textBox3.Text=="0")
                {
                    MessageBox.Show("Bir Sayı 0'a Bölünemez");
                }
                else
                {
                    double sonuc = Convert.ToDouble(sayilar[0]) / Convert.ToInt32(textBox3.Text);
                    textBox3.Text = sonuc.ToString();
                    return sonuc;
                }
                
            }
            else if (sayilar[1] == "x")
            {
                double sonuc = Convert.ToDouble(sayilar[0]) * Convert.ToInt32(textBox3.Text);
                //textBox3.Text = sonuc.ToString();
                return sonuc;
            }
            return son;
        }
       
        
        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text+ "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text+"1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + ".";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string sayi = textBox3.Text;
            ekle(sayi,"+");
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sayi = textBox3.Text;
            ekle(sayi,"-");
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sayi = textBox3.Text;
            ekle(sayi,"x");
            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sayi = textBox3.Text;
            ekle(sayi,"/");
            textBox3.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Text = sonuc().ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "0";
        }
    }
}
