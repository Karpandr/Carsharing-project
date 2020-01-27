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
    public partial class EnterWin : Form
    {
        public EnterWin()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        int getidclient;
        private void Next_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (Error1())
                {
                    string connStringAcc = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:/Андрей new/3 курс/Проектирование/Курсовая/Carsharing/Carsharing/Carsharing.accdb";
                    con = new OleDbConnection(connStringAcc);
 
                    OleDbCommand command = con.CreateCommand();
                    command.CommandText = "SELECT SurnameNameC FROM [Client] WHERE [PhoneC]='" + textBoxNumb.Text + "' AND [Password]='" + textBoxPass.Text+"'";
                    OleDbCommand check = new OleDbCommand(command.CommandText, con);
                    con.Open();
                    
                    

                    if (check.ExecuteScalar() != null)
                    {
                        string getusername = (string)command.ExecuteScalar();
                        OleDbCommand command1 = con.CreateCommand();
                        command1.CommandText = "SELECT id_client FROM [Client] WHERE [PhoneC]='" + textBoxNumb.Text + "' AND [Password]='" + textBoxPass.Text + "'";
                        //OleDbCommand check1 = new OleDbCommand(command1.CommandText, con);
                        getidclient = (Int32)command1.ExecuteScalar();
                        //MessageBox.Show("Вы зашли в свой аккаунт.");
                        con.Close();
                        Program.f1.label3.Text = Convert.ToString(getidclient);
                        Program.f1.Rent.Visible = true;
                        Program.f1.Vhod.Visible = false;
                        Program.f1.button2.Visible = false;
                        Program.f1.Account.Visible = true;
                        Program.f1.Account.Text = getusername;
                        Program.f1.Exit.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        con.Close();
                    }
                }
            //}
            //catch(Exception ex)
            //{
               //MessageBox.Show("Ошибка! Некорректные данные");
            //}
        }
        private bool Error1() //проверка на заполненность всех полей
        {
            if (textBoxNumb.Text != "" && textBoxPass.Text != "")
                return true;
            else
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
        }
    }
}
