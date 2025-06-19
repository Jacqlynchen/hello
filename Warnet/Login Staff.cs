using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warnet
{
    public partial class Login_Staff : Form
    {
        public Login_Staff()
        {
            InitializeComponent();
        }

        DataTable dataStaff = new DataTable();
        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tBox_InputEmailStaff.Text != "" || tBox_InputNamaStaff.Text != "")
            { 
                for (int i = 0; i < dataStaff.Rows.Count; i++)
                {
                    if (tBox_InputNamaStaff.Text == dataStaff.Rows[i][1].ToString())
                    {
                        for (int j = 0; j < dataStaff.Rows.Count; j++)
                        {
                            if (tBox_InputEmailStaff.Text == dataStaff.Rows[j][2].ToString())
                            {
                                Form1 mainPage = new Form1();
                                mainPage.staffYangLoginSekarang(dataStaff.Rows[i][1].ToString());
                                mainPage.Show();
                                this.Hide();
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Login Invalid");
            }
        }

        private void Login_Staff_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=Bernardo1777*;database=ALP_WARNET");
            query = "SELECT * FROM STAFF";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dataStaff);
        }
    }
}
