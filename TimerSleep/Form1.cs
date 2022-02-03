using System;
using System.Threading;
using System.Windows.Forms;

namespace TimerSleep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int timeLeft;
        private void button1_Click(object sender, EventArgs e)
        {
            Processo P = new Processo(600);
            timeLeft = 600;
            label4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Processo a = new Processo();
            timeLeft = 0;
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Processo P = new Processo(1200);
            timeLeft = 1200;
            label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Processo P = new Processo(1800);
            timeLeft = 1800;
            label4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Processo P = new Processo(2400);
            timeLeft = 2400;
            label4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Processo P = new Processo(3000);
            timeLeft = 3000;
            label4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Processo P = new Processo(3600);
            timeLeft = 3600;
            label4.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button8.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true; 

            }
            else
            {
                button8.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label3.Visible = false;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Entrada Invalida");
                
            }
            else
            {
                int conv = 0, convH = 0;
                if (textBox2.Text == "")
                    convH = 0;
                else
                    convH = int.Parse(textBox2.Text);
                if (textBox1.Text == "")
                    textBox1.Text = "0";
                
                conv = int.Parse(textBox1.Text);
                convH = convH * 3600;
                conv = convH + (conv * 60);

                Processo P = new Processo(conv);
                timeLeft = conv;
                label4.Visible = true;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (timeLeft > 0)
            {
                int hora = timeLeft /3600;
                if (hora < 1)
                    hora = 0;

                int minutos = CaclHora(timeLeft, hora);
                int minutos2 = CalcSegundos(timeLeft);
                int segundos = CalcMinutos(timeLeft, minutos2);
                

                label4.Text = hora.ToString() +" Horas"+minutos.ToString()+"minutos"+segundos + " Segundos";
                timeLeft--;

                if (minutos == 9 && segundos == 59 ||  minutos == 1 && segundos == 59)
                {
                    finalizarNotificacao();
                }

            }

        }
        static int CalcSegundos (int c) // metodos na propria classe do programa
        {
            return c / 60;
        }
        static int CalcMinutos (int a, int b)
        {
            return a - (b *60);
        }
        static int CaclHora (int a, int b)
        {
            return (a / 60 - (b * 60));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public void finalizarNotificacao()
        {
            System.Diagnostics.Process.Start("CMD.exe", @"/C " + "taskkill /im wlrmdr.exe").WaitForExit();

        }
    }
}
