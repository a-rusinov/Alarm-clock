using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FontDialog FD = new FontDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Alarm clock";
            btn_SelectFont.Text = "Выбор Шрифта...";
            btn_Start.Text = "Завести Будильник";
            btn_Stop.Text = "Остановить Будильник";

            this.AutoSize = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            label2.Visible = true;
            label2.Enabled = true;
            label2.Text = "";

            timer1.Interval = 1000;
            timer1.Enabled = true;
            btn_Stop.Enabled = false;
            
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();

        }

        

        SoundPlayer player = new SoundPlayer("Backpacker.wav");

        bool b = false;

        private void Btn_SelectFont_Click(object sender, EventArgs e)
        {
            FD.ShowDialog();
            label1.Font = FD.Font;
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                label2.Text = maskedTextBox1.Text;
                timer1.Start();
                maskedTextBox1.Visible = false;
                btn_Start.Text = "Убрать Будильник";
                b = true;

            }
            else if (b == true)
            {
                label1.Text = "00:00";
                timer1.Stop();
                maskedTextBox1.Visible = true;
                btn_Start.Text = "Завести Будильник";

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            if (label1.Text == label2.Text + ":00")
            {
                btn_Stop.Enabled = true;
                player.Play();
            }
        }




        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            player.Stop();
            btn_Stop.Enabled = false;
            maskedTextBox1.Visible = true;
            btn_Start.Text = "Завести Будильник";
            b = false;

        }
    }
}
