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
    public partial class General : Form
    {
        public General()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        private void Vhod_Click(object sender, EventArgs e)
        {
            EnterWin f = new EnterWin();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration b = new Registration();
            b.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Vhod.Visible = true;
            button2.Visible = true;
            Account.Visible = false;
            Exit.Visible = false;
            Rent.Visible = false;
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            Cars f = new Cars();
            f.Show();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный раздел находится в разработке.", "Информация");
        }
    }
}
