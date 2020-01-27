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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            String infocar = carsGridView.CurrentRow.Cells[9].Value.ToString() + " " + carsGridView.CurrentRow.Cells[2].Value.ToString() + " " +carsGridView.CurrentRow.Cells[3].Value.ToString()+
                " " + carsGridView.CurrentRow.Cells[1].Value.ToString();
            String fuel = carsGridView.CurrentRow.Cells[13].Value.ToString();
            String id_auto = carsGridView.CurrentRow.Cells[0].Value.ToString();
            String id_worker = carsGridView.CurrentRow.Cells[14].Value.ToString();
            String pin = carsGridView.CurrentRow.Cells[11].Value.ToString();
            //MessageBox.Show(infocar+fuel);
            this.Close();
            Rent f = new Rent(infocar,fuel, id_auto, id_worker, pin);
            f.Show();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carsharingDataSet.Auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.carsharingDataSet.Auto);

        }
    }
}
