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
    public partial class Consumable_Page : Form
    {
        public Consumable_Page()
        {
            InitializeComponent();
        }

        DataTable stock = new DataTable();
        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;

        string namaStaff;
        string idstaff;
        string jk;
        DataTable com = new DataTable();
        public void nama_dan_id3(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }

        private void butt_home_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
            mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
            mainPage.Show();
            this.Hide();
        }

        private void butt_historyconsum_Click(object sender, EventArgs e)
        {
            HistoryConsum consum = new HistoryConsum();
            consum.nama_dan_id4(namaStaff, idstaff, jk, com);
            consum.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Consumable_Page_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = "Select nama_consumable, quantity_consumable from consumable";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(stock);
            dgv_stock.DataSource = stock;
        }
    }
}
