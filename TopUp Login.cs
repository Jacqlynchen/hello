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
    public partial class TopUp_Login : Form
    {
        public TopUp_Login()
        {
            InitializeComponent();
        }

        DataTable dataSemuaUser;
        DataTable mesin;
        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;

        private void btn_MenujuStaff_Click(object sender, EventArgs e)
        {
            Login_Staff login_Staff = new Login_Staff();
            login_Staff.Show();
            this.Close();
        }

        private void TopUp_Login_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = $"select kartu.id_kartu, kartu.id_user, u.username_user, kartu.saldo_kartu " +
                $"from kartu_member kartu, `user` u where kartu.id_user = u.id_user;";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            dataSemuaUser = new DataTable();
            sqldataadapter.Fill(dataSemuaUser);

            query = "select id_mesin as 'ID Mesin',  concat('Mesin ' , row_number() OVER (  ORDER BY id_mesin  )) as 'Nama Mesin' from mesin_top_up;";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            mesin = new DataTable();
            sqldataadapter.Fill(mesin);
            cbox_Mesin.DataSource = mesin;
            cbox_Mesin.ValueMember = "ID Mesin";
            cbox_Mesin.DisplayMember = "Nama Mesin";
        }

        private void btn_LoginUser_Click(object sender, EventArgs e)
        {
            bool tes = false;
            for (int i = 0; i < dataSemuaUser.Rows.Count; i++)
            {
                if (dataSemuaUser.Rows[i][0].ToString() == tBox_InputCardIDUser.Text && dataSemuaUser.Rows[i][1].ToString() == tBox_InputUserIDUser.Text && cbox_Mesin.SelectedValue != null)
                {
                    DialogResult DR = MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (DR == DialogResult.OK)
                    {
                        tes = true;
                        TopUp_Interface goToTopUp = new TopUp_Interface();
                        goToTopUp.dataUser(dataSemuaUser.Rows[i][1].ToString(), dataSemuaUser.Rows[i][2].ToString(), dataSemuaUser.Rows[i][0].ToString(), Convert.ToInt32(dataSemuaUser.Rows[i][3].ToString()), cbox_Mesin.SelectedValue.ToString());
                        goToTopUp.Show();
                        this.Close();
                        break;
                    }
                }
            }

            if(tes == false)
            {
                MessageBox.Show("Unable To Login");
            }
        }
    }
}
