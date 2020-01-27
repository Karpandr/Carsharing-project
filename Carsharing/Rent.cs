using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
    public partial class Rent : Form
    {
        public Rent(String infocar, String fuel, String id_auto, String id_worker, String pin)
        {
            InitializeComponent();
            label9.Text = infocar;
            label11.Text = fuel;
            this.id_auto = id_auto;
            this.id_worker = id_worker;
            this.pin = pin;
        }
        String id_auto;
        String id_worker;
        String pin;
        int m=0, s=0;
        int flag=0;
        int hours=0, mins=0, seconds=0;
        //DateTime date1 = new DateTime(0, 0, 0);
        private void Rent_Load(object sender, EventArgs e)
        {
            m = 20;//изменить на 20:00
            s = 0;
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == 0 && s == 0)
            {
                MyTimer.Stop();
                flag = 1;
                MyTimer1.Start();
            }

            if(m<10) label2.Text = "0" + Convert.ToString(m);
            else label2.Text = Convert.ToString(m);
            if(s<10) label4.Text = "0" + Convert.ToString(s);
            else label4.Text = Convert.ToString(s);

        }

        private void MyTimer1_Tick(object sender, EventArgs e)
        {
            label5.Visible = true;
            label8.Visible = true;

            seconds = seconds + 1;
            if (seconds == 60)
            {
                mins = mins + 1;
                seconds = 0;
            }
            if (mins == 60)
            {
                hours = hours + 1;
                mins = 0;
            }
            if(hours<10) label7.Text = "0" + Convert.ToString(hours);
            else label7.Text = Convert.ToString(hours);
            if (mins<10) label2.Text = "0" + Convert.ToString(mins);
            else label2.Text = Convert.ToString(mins);
            if (seconds<10) label4.Text = "0" + Convert.ToString(seconds);
            else label4.Text = Convert.ToString(seconds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (flag==1)  sum = 2 * (60 * hours + mins);
            Ride g = new Ride(sum, label9.Text, label11.Text,id_auto, id_worker, pin);
            g.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            flag = 1;
            MyTimer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            if (flag == 0) MessageBox.Show("Ваша поездка была отменена.", "Отмена поездки");
            if (flag == 1)
            {
                double sum = 2 * (60 * hours + mins);
                string sum1 = Convert.ToString(sum);
                MessageBox.Show("За платное ожидание Вами было оплачено " + sum1 + " рублей.", "Оплата поездки");
            }

        }
    }
}
