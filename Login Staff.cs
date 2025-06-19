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
        DataTable com = new DataTable();
        string query;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool cekusername = false;
            bool cekpassword = false;
            //if (com.Rows.Count > 0)
            //{

            //}
            //else
            //{
            //    com.Columns.Add("Computer");
            //    com.Columns.Add("Status");
            //    com.Columns.Add("Username");
            //    com.Columns.Add("Name");
            //    com.Columns.Add("Hour");
            //    for (int i = 1; i <= 20; i++)
            //    {
            //        if(i < 10)
            //        {
            //            com.Rows.Add("K0" + i.ToString(), "Y", "0", "0", "0");
            //        }
            //        else
            //        {
            //            com.Rows.Add("K" + i.ToString(), "Y", "0", "0", "0");
            //        }
            //    }
            //}

            //query = "select username_user, nama_user,id_komputer, hrk.id_penjualan, durasi_sewa, end_time  " +
            //    "from history_rental_komputer hrk, penjualan p, kartu_member km, `user` u " +
            //    "Where hrk.id_penjualan = p.id_penjualan AND p.id_kartu = km.id_kartu AND " +
            //    "km.id_user = u.id_user;";
            


            if (tBox_InputPasswordStaff.Text != "" || tBox_InputEmailStaff.Text != "")
            {
                for (int i = 0; i < dataStaff.Rows.Count; i++)
                {
                    if (tBox_InputEmailStaff.Text == dataStaff.Rows[i][2].ToString())
                    {
                        cekusername = true;
                        if (tBox_InputPasswordStaff.Text == dataStaff.Rows[i][3].ToString())
                        {
                            cekpassword = true;
                            DialogResult DR = MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (DR == DialogResult.OK)
                            {
                                Form1 mainPage = new Form1();
                                mainPage.staffYangLoginSekarang(dataStaff.Rows[i][1].ToString(), dataStaff.Rows[i][0].ToString(), dataStaff.Rows[i][4].ToString(), com);
                                mainPage.Show();
                                this.Hide();
                                break;
                            }
                        }
                    }
                }

                //MessageBox.Show(dtkomputer.Rows[1][2].ToString());

               

                if (cekusername == false)
                {
                    DialogResult DR = MessageBox.Show("Email Invalid", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tBox_InputPasswordStaff.Text = "";
                    tBox_InputEmailStaff.Text = "";
                }
                else if (cekpassword == false)
                {
                    DialogResult DR = MessageBox.Show("Password Invalid", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tBox_InputPasswordStaff.Text = "";
                }
            }
            else
            {
                DialogResult DR = MessageBox.Show("Login Invaid", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataTable dtkomputer = new DataTable();
        private void Login_Staff_Load(object sender, EventArgs e)
        {
            MessageBox.Show("EVELYN");
            timer1.Start();

            if (com.Rows.Count > 0)
            {

            }
            else
            {
                com.Columns.Add("Computer");
                com.Columns.Add("Status");
                com.Columns.Add("Username");
                com.Columns.Add("Name");
                com.Columns.Add("Hour");
                for (int i = 1; i <= 20; i++)
                {
                    if (i < 10)
                    {
                        com.Rows.Add("K0" + i.ToString(), "Y", "0", "0", "0");
                    }
                    else
                    {
                        com.Rows.Add("K" + i.ToString(), "Y", "0", "0", "0");
                    }
                }
            }

            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=Sayacantik44;database=alp_warnet");
            query = "SELECT id_staff, nama_staff, email_staff, password_staff, gender_staff FROM STAFF";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dataStaff);

            query = "select username_user, nama_user,id_komputer, hrk.id_penjualan, durasi_sewa, end_time  " +
                "from history_rental_komputer hrk, penjualan p, kartu_member km, `user` u " +
                "Where hrk.id_penjualan = p.id_penjualan AND p.id_kartu = km.id_kartu AND " +
                "km.id_user = u.id_user;";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dtkomputer);

            for (int i = 0; i < dtkomputer.Rows.Count; i++)
            {
                for (int j = 0; j < com.Rows.Count; j++)
                {
                    if (dtkomputer.Rows[i][2].ToString() == com.Rows[j][0].ToString())
                    {
                        string tanggalskr = DateTime.Now.ToString("ddMMyy");
                        string tglkom = dtkomputer.Rows[i][3].ToString().Substring(1, 6);

                        if (tanggalskr == tglkom)
                        {

                            string jamskr = DateTime.Now.ToString("hhmmss");
                            string jamend = dtkomputer.Rows[i][5].ToString().Substring(0, 2) + dtkomputer.Rows[i][5].ToString().Substring(3, 2) + dtkomputer.Rows[i][5].ToString().Substring(6, 2);

                            int jammain = Convert.ToInt32(dtkomputer.Rows[i][5].ToString().Substring(0, 2)) - Convert.ToInt32(dtkomputer.Rows[i][4].ToString());

                            if (jammain < 0)
                            {
                                jammain = jammain + 12;
                                //jamend = jamend + 12;

                            }
                            string jambarumain = jammain.ToString() + dtkomputer.Rows[i][5].ToString().Substring(3, 2) + dtkomputer.Rows[i][5].ToString().Substring(6, 2);

                            //if(jamskr.Length == jambarumain.Length && jamskr.Length == jamend.Length)
                            //{

                            //}

                            //if  (Convert.ToInt32(jambarumain) > Convert.ToInt32(jamend))
                            //{
                            //    jamend = jamend + 12;
                            //    if (Convert.ToInt32(jamskr) < Convert.ToInt32(jambarumain))
                            //    {
                            //        jamskr = jamskr + 12;
                            //        jambarumain = jambarumain + 12;
                            //    }
                            //}
                            if (Convert.ToInt32(jamskr) < Convert.ToInt32(jambarumain))
                            {
                                
                            }


                            if (Convert.ToInt32(jamskr) > Convert.ToInt32(jambarumain) && Convert.ToInt32(jamskr) < Convert.ToInt32(jamend))
                            {
                                com.Rows[j][1] = "N";
                                com.Rows[j][2] = dtkomputer.Rows[i][0].ToString();
                                com.Rows[j][3] = dtkomputer.Rows[i][1].ToString();
                                com.Rows[j][4] = jamend.ToString();
                            }
                            else
                            {
                                jamskr = (Convert.ToInt32(jamskr) + Convert.ToInt32(dtkomputer.Rows[i][4].ToString()).ToString());
                                
                                if(Convert.ToInt32(jamskr) > 12)
                                {
                                    jamskr = (Convert.ToInt32(jamskr) - 12).ToString();
                                }
                               
                                if(Convert.ToInt32(jamskr) > Convert.ToInt32(jamend))
                                {
                                    com.Rows[j][1] = "N";
                                    com.Rows[j][2] = dtkomputer.Rows[i][0].ToString();
                                    com.Rows[j][3] = dtkomputer.Rows[i][1].ToString();
                                    com.Rows[j][4] = jamend.ToString();
                                }
                            }

                            // 8 - 2
                            // 9 


                        }
                    }
                }
            }
        }

        private void butt_topup_Click(object sender, EventArgs e)
        {
            TopUp_Login topUp_Login = new TopUp_Login();
            topUp_Login.Show();
            this.Hide();
        }
    }
}
