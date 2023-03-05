using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arayüzlü_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlencekmi;
        private int _ilkSayı;


        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            _ekranTemizlencekmi = true;
            int _ilkSayı = Convert.ToInt32(ekranlabel.Text);
            _islem = '-';
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlencekmi == true)
            {
                ekranlabel.Text = "";
                _ekranTemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            _ekranTemizlencekmi = true;
            int _ilkSayı = Convert.ToInt32(ekranlabel.Text);
            _islem = '/';

        }

        private void button10_Click(object sender, EventArgs e)
        {

            _ekranTemizlencekmi = true;
            _ilkSayı = Convert.ToInt32(ekranlabel.Text);
            _islem = '*';

        }

        private void button11_Click(object sender, EventArgs e)
        {
            _ekranTemizlencekmi = true;
            _ilkSayı = Convert.ToInt32(ekranlabel.Text);
            _islem = '+';
        }

        private void button14_Click(object sender, EventArgs e)// eşittir (=) equal
        {
            int sonuc;
            int ikincisayi = Convert.ToInt32(ekranlabel.Text);
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayı + ikincisayi;
                    break;

                    case '-':
                    sonuc = _ilkSayı - ikincisayi;
                    break;

                    case '*':
                    sonuc = _ilkSayı * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilkSayı / ikincisayi;
                    break;

                default:
                sonuc = 0;
                break; 
                        
            }
            ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button16_Click_1(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
