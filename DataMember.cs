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
    public partial class DataMember : Form
    {
        public DataMember()
        {
            InitializeComponent();
        }
        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        
        string query;
        string namaStaff;
        string idstaff;
        string jk;
        
        DataTable com = new DataTable();
        DataTable member = new DataTable();
        public void nama_dan_id3(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }
        private void DataMember_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = "Select * from kartu_member";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(member);
            dgv_memberdata.DataSource = member;
        }

        private void butt_home_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
            mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
            mainPage.Show();
            this.Hide();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            member.Rows.Clear();
            query = $"Select * from kartu_member where id_kartu LIKE '%{tb_search.Text}%'";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(member);
            dgv_memberdata.DataSource = member;
        }

        private void butt_reset_Click(object sender, EventArgs e)
        {
            member.Rows.Clear();
            tb_search.Text = "";
            query = "Select * from kartu_member";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(member);
            dgv_memberdata.DataSource = member;
        }
    }
}
