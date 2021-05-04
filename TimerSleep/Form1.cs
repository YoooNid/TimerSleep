using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string Min10 = @"/C " + "shutdown -s -t 600";
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
            timeLeft = 600;
            label4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Min10 = @"/C " + "shutdown/a";
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
            timeLeft = 0;
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Min10 = @"/C " + "shutdown -s -t 1200";
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
            timeLeft = 1200;
            label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Min10 = @"/C " + "shutdown -s -t 1800";
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
            timeLeft = 1800;
            label4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Min10 = @"/C " + "shutdown -s -t 2400";
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
            timeLeft = 2400;
            label4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Min10 = @"/C " + "shutdown -s -t 3000";
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
            timeLeft = 3000;
            label4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Min10 = @"/C " + "shutdown -s -t 3600";
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
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
            int conv = 0, convH = 0;
            if (textBox2.Text == "")
                convH = 0;
            else
            convH = int.Parse(textBox2.Text);
            
            conv = int.Parse(textBox1.Text);
            convH = convH * 3600;
            conv = convH + (conv * 60);

            string Min10 = @"/C " + "shutdown -s -t "+conv.ToString();
            System.Diagnostics.Process.Start("CMD.exe", Min10).WaitForExit();
            timeLeft = conv;
            label4.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (timeLeft > 0)
            {
                int hora = timeLeft /3600;
                if (hora < 1)
                    hora = 0;
                
                int minutos = (timeLeft / 60);
                int segundos = timeLeft - (minutos * 60);

                label4.Text = hora.ToString() +" Horas"+minutos.ToString()+"minutos"+segundos + " seconds";
                timeLeft--;
              
            }
           
        }
        
    }
}
