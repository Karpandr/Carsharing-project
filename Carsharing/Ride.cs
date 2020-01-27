using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Carsharing
{
    public partial class Ride : Form
    {
        public Ride(double sum, String infocar, String fuellevel, String id_auto, String id_worker, String pin)
        {
            InitializeComponent();
            sum2=sum;
            label19.Text = infocar;
            label21.Text = fuellevel;
            this.id_auto = id_auto;
            this.id_worker = id_worker;
            this.pin = pin;
        }
        String id_auto;
        String id_worker;
        String pin;
        OleDbConnection con;
        int hours = 0, mins = 0, seconds = 0;
        int Roadhours = 0, Roadmins = 0, Roadseconds = 0;
        int Waithours = 0, Waitmins = 0, Waitseconds = 0;
        double movesum=0, waitsum=0, gensum = 0, sum2 = 0;
        private void Gasbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пин-код Вашей топливной карты " + pin, "Пополнение топливного бака");
        }

        private void Endbutton_Click(object sender, EventArgs e)
        {
            movesum = 8 * (60 * Roadhours + Roadmins);
            waitsum = 2 * (60 * Waithours + Waitmins) + sum2;
            gensum = movesum + waitsum;
            string connStringAcc = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:/Андрей new/3 курс/Проектирование/Курсовая/Carsharing/Carsharing/Carsharing.accdb";
            con = new OleDbConnection(connStringAcc);
            OleDbCommand myOleDbCommand = con.CreateCommand();
            myOleDbCommand.CommandText = "INSERT INTO [Ride] ([Duration], [Ride_rate], [Wait_rate], [WayToPay], [DateP], [Ride_time], [Wait_time], [Sum], [id_client]) VALUES " +
                "('" + Convert.ToString(hours) + " час " + Convert.ToString(mins) + " мин', '8 руб/мин','2 руб/мин','Bank card','" +
                DateTime.Now + "', '" + Convert.ToString(Roadhours) + " час " + Convert.ToString(mins) + " мин', '" + 
                Convert.ToString(Waithours) + " час " + Convert.ToString(Waitmins) + " мин', '" + Convert.ToString(gensum) + " р', '" + Convert.ToInt32(Program.f1.label3.Text) + "')";
            con.Open();
            //myOleDbCommand.CommandText = "INSERT INTO [Client] ([SurnameNameC], [PhoneC], [SeriesC], [PasspNumC], [DriveLic], [Password]) VALUES ('Karpiuk', '+7908', '9212', '405668', '123123', 'qqq')";
            myOleDbCommand.ExecuteNonQuery();

            OleDbCommand myOleDbCommand1 = con.CreateCommand();
            myOleDbCommand1.CommandText = "INSERT INTO [Carsharing] ([id_client], [id_auto], [id_worker]) VALUES " +
                "('" + Convert.ToInt32(Program.f1.label3.Text) + "', '" + Convert.ToInt32(id_auto) + "', '" + Convert.ToInt32(id_worker) + "')";
            
            myOleDbCommand1.ExecuteNonQuery();
            con.Close();
            End a = new End(movesum, waitsum, gensum);
            a.Show();
            this.Close();
        }

        private void Ride_Load(object sender, EventArgs e)
        {
            GeneralTimer.Start();
            RoadTimer.Start();
        }

        private void Waitbutton_Click(object sender, EventArgs e)
        {
            RoadTimer.Enabled = false;
            GeneralTimer.Enabled=false;
            GeneralTimer.Start();
            WaitTimer.Start();
            Contbutton.Enabled = true;
            Waitbutton.Enabled = false;
        }

        private void Contbutton_Click(object sender, EventArgs e)
        {
            GeneralTimer.Enabled = false;
            GeneralTimer.Start();
            RoadTimer.Start();
            WaitTimer.Enabled = false;
            Contbutton.Enabled = false;
            Waitbutton.Enabled = true;
        }

        private void RoadTimer_Tick(object sender, EventArgs e)
        {
            Roadseconds = Roadseconds + 1;
            if (Roadseconds == 60)
            {
                Roadmins = Roadmins + 1;
                Roadseconds = 0;
            }
            if (Roadmins == 60)
            {
                Roadhours = Roadhours + 1;
                Roadmins = 0;
            }
            if (Roadhours < 10) label14.Text = "0" + Convert.ToString(Roadhours);
            else label14.Text = Convert.ToString(Roadhours);
            if (Roadmins < 10) label16.Text = "0" + Convert.ToString(Roadmins);
            else label16.Text = Convert.ToString(Roadmins);
            if (Roadseconds < 10) label18.Text = "0" + Convert.ToString(Roadseconds);
            else label18.Text = Convert.ToString(Roadseconds);
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            Waitseconds = Waitseconds + 1;
            if (Waitseconds == 60)
            {
                Waitmins = Waitmins + 1;
                Waitseconds = 0;
            }
            if (Waitmins == 60)
            {
                Waithours = Waithours + 1;
                Waitmins = 0;
            }
            if (Waithours < 10) label9.Text = "0" + Convert.ToString(Waithours);
            else label9.Text = Convert.ToString(Waithours);
            if (Waitmins < 10) label11.Text = "0" + Convert.ToString(Waitmins);
            else label11.Text = Convert.ToString(Waitmins);
            if (Waitseconds<10) label13.Text = "0" + Convert.ToString(Waitseconds);
            else label13.Text = Convert.ToString(Waitseconds);
        }

        private void GeneralTimer_Tick(object sender, EventArgs e)
        {
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
            if(hours<10)label2.Text = "0" + Convert.ToString(hours);
            else label2.Text = Convert.ToString(hours);
            if(mins<10)label4.Text = "0" + Convert.ToString(mins);
            else label4.Text = Convert.ToString(mins);
            if(seconds<10)label6.Text = "0" + Convert.ToString(seconds);
            else label6.Text = Convert.ToString(seconds);
        }
    }
}
