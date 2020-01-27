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
    public partial class End : Form
    {
        public End(double movesum, double waitsum, double gensum)
        {
            InitializeComponent();
            this.movesum = movesum;
            this.waitsum = waitsum;
            this.gensum = gensum;
        }
        double movesum, waitsum, gensum;

        private void End_Load(object sender, EventArgs e)
        {
            string gensum1 = Convert.ToString(gensum);
            string movesum1 = Convert.ToString(movesum);
            string waitsum1 = Convert.ToString(waitsum);
            label4.Text = Convert.ToString(gensum1)+" р";
            label5.Text = Convert.ToString(movesum1)+ " р";
            label6.Text = Convert.ToString(waitsum1) + " р";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
