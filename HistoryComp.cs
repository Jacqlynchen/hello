using System;
using System.Collections;
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
    public partial class HistoryComp : Form
    {
        public HistoryComp()
        {
            InitializeComponent();
        }

        string namaStaff;
        string idstaff;
        string jk;
        DataTable com = new DataTable();

        DataTable dtHistoryComp = new DataTable();
        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;

        private void butt_computer_Click(object sender, EventArgs e)
        {
            Computer_Page comp = new Computer_Page();
            comp.nama_dan_id(namaStaff, idstaff, jk, com);
            comp.Show();
            this.Hide();
        }

        public void nama_dan_id2(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }

        private void HistoryComp_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = "SELECT * FROM HISTORY_RENTAL_KOMPUTER";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dtHistoryComp);
            dgv_historycomp.DataSource = dtHistoryComp;
        }

        private void butt_home_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
            mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
            mainPage.Show();
            this.Hide();
        }

        private void dgv_historycomp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_historycomp.CurrentRow.Index;
            Penjualan pen = new Penjualan();
            pen.id_penjualan(dtHistoryComp.Rows[index][1].ToString(), 1, namaStaff, idstaff, jk, com);
            pen.Show();
            this.Hide();
        }
    }
}
