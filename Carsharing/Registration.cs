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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Error1()&&Error2())
                {
                    string connStringAcc = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:/Андрей new/3 курс/Проектирование/Курсовая/Carsharing/Carsharing/Carsharing.accdb";
                    con = new OleDbConnection(connStringAcc);
                    OleDbCommand myOleDbCommand = con.CreateCommand();
                    myOleDbCommand.CommandText = "INSERT INTO [Client] ([SurnameNameC], [PhoneC], [SeriesC], [PasspNumC], [DriveLic], [Password]) VALUES " +
                        "('" + textBox1.Text + " " + textBox2.Text + "', '" + textBox6.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox7.Text + "')";
                    con.Open();
                    //myOleDbCommand.CommandText = "INSERT INTO [Client] ([SurnameNameC], [PhoneC], [SeriesC], [PasspNumC], [DriveLic], [Password]) VALUES ('Karpiuk', '+7908', '9212', '405668', '123123', 'qqq')";
                    myOleDbCommand.ExecuteNonQuery();
                    con.Close();
                MessageBox.Show("Вы были успешно зарегистрированы в нашей системе!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Некорректный ввод");
            }
        }
        private bool Error1() //проверка на заполненность всех полей
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "" &&
                textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                return true;
            else
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
        }
        private bool Error2() //проверка на совпадение паролей
        {
            if (textBox7.Text == textBox8.Text)
                return true;
            else
            {
                MessageBox.Show("Пароли не совпадают!");
                return false;
            }
        }

    }
}
