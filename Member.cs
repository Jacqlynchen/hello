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
using MySql.Data.MySqlClient;

namespace Warnet
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        string namaStaff;
        string idstaff;
        string jk;
        string komputer;
        string jamkomputer;
        DataTable cart = new DataTable();
        DataTable com = new DataTable();

        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;

        public void nama_dan_id8(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }

        private void Member_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = "SELECT NAMA_USER, ID_KARTU, USERNAME_USER, u.ID_USER, SALDO_KARTU, GRADE_KARTU\r\nFROM `USER` u, KARTU_MEMBER km\r\nWHERE u.ID_USER = km.ID_USER;";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            DataTable member = new DataTable();
            sqldataadapter.Fill(member);
            dgv_member.DataSource = member;
        }

        private void dgv_member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pemesanan comp = new Pemesanan();
            comp.cellclick(namaStaff, idstaff, jk, com, dgv_member.CurrentRow.Cells[2].Value.ToString(), dgv_member.CurrentRow.Cells[1].Value.ToString(), dgv_member.CurrentRow.Cells[0].Value.ToString(), dgv_member.CurrentRow.Cells[5].Value.ToString());
            comp.Show();
            this.Close();
        }

        private void butt_reset_Click(object sender, EventArgs e)
        {
            query = "SELECT NAMA_USER, ID_KARTU, USERNAME_USER, u.ID_USER, SALDO_KARTU, " +
                "GRADE_KARTU\r\nFROM `USER` u, KARTU_MEMBER km\r\nWHERE u.ID_USER = km.ID_USER;";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            DataTable member = new DataTable();
            sqldataadapter.Fill(member);
            dgv_member.DataSource = member;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (cb_searchby.Text == "ID Kartu")
            {
                query = $"SELECT NAMA_USER, ID_KARTU, USERNAME_USER, u.ID_USER, SALDO_KARTU, GRADE_KARTU\r\n" +
                $"FROM `USER` u, KARTU_MEMBER km\r\nWHERE u.ID_USER = km.ID_USER AND ID_KARTU LIKE '%{tb_search.Text}%';";
            }
            else if (cb_searchby.Text == "ID User")
            {
                query = $"SELECT NAMA_USER, ID_KARTU, USERNAME_USER, u.ID_USER, SALDO_KARTU, GRADE_KARTU\r\n" +
                $"FROM `USER` u, KARTU_MEMBER km\r\nWHERE u.ID_USER = km.ID_USER AND u.ID_USER LIKE '%{tb_search.Text}%';";
            }
            else if (cb_searchby.Text == "Username")
            {
                query = $"SELECT NAMA_USER, ID_KARTU, USERNAME_USER, u.ID_USER, SALDO_KARTU, GRADE_KARTU\r\n" +
                $"FROM `USER` u, KARTU_MEMBER km\r\nWHERE u.ID_USER = km.ID_USER AND USERNAME_USER LIKE '%{tb_search.Text}%';";
            }
            else if (cb_searchby.Text == "Nama User")
            {
                query = $"SELECT NAMA_USER, ID_KARTU, USERNAME_USER, u.ID_USER, SALDO_KARTU, GRADE_KARTU\r\n" +
                $"FROM `USER` u, KARTU_MEMBER km\r\nWHERE u.ID_USER = km.ID_USER AND NAMA_USER LIKE '%{tb_search.Text}%';";
            }

            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            DataTable member = new DataTable();
            sqldataadapter.Fill(member);
            dgv_member.DataSource = member;
        }

        private void cb_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }
    }
}
