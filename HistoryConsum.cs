using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warnet
{
    public partial class HistoryConsum : Form
    {
        DataTable dtHistoryConsum = new DataTable();
        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;
        public HistoryConsum()
        {
            InitializeComponent();
        }

        string namaStaff;
        string idstaff;
        string jk;
        DataTable com = new DataTable();
        public void nama_dan_id4(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }

        private void butt_consum_Click(object sender, EventArgs e)
        {
            Consumable_Page consum = new Consumable_Page();
            consum.nama_dan_id3(namaStaff, idstaff, jk, com);
            consum.Show();
            this.Hide();
        }

        private void butt_home_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
            mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
            mainPage.Show();
            this.Hide();
        }

        private void HistoryConsum_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = "SELECT * FROM HISTORY_CONSUMABLE";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dtHistoryConsum);
            dgv_historyconsum.DataSource = dtHistoryConsum;
        }

        private void dgv_historyconsum_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_historyconsum.CurrentRow.Index;
            Penjualan pen = new Penjualan();
            pen.id_penjualan(dtHistoryConsum.Rows[index][1].ToString(), 1, namaStaff, idstaff, jk, com);
            pen.Show();
            this.Hide();
        }
    }
}
