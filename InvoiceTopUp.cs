using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warnet
{
    public partial class InvoiceTopUp : Form
    {
        public InvoiceTopUp()
        {
            InitializeComponent();
        }
        string namaStaff;
        string idstaff;
        string jk;
        DataTable com = new DataTable();
        DataTable dtHistoryTopUp = new DataTable();

        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;

        public void namastaff(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }
        private void butt_penjualan_Click(object sender, EventArgs e)
        {
            Penjualan jual = new Penjualan();
            jual.nama_dan_id6(namaStaff, idstaff, jk, com);
            jual.Show();
            this.Hide();
        }

        private void butt_home_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
            mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
            mainPage.Show();
            this.Hide();
        }

        private void InvoiceTopUp_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = "SELECT * FROM INVOICE_TOP_UP";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dtHistoryTopUp);
            dgv_topup.DataSource = dtHistoryTopUp;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (tb_search.Text == "")
            {

            }
            else
            {
                dtHistoryTopUp.Rows.Clear();
                sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
                query = $"SELECT * \r\n" +
                $"FROM invoice_top_up WHERE id_transaksi LIKE '%{tb_search.Text}%';";
                sqlcommand = new MySqlCommand(query, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                sqldataadapter.Fill(dtHistoryTopUp);
                dgv_topup.DataSource = dtHistoryTopUp;
            }
        }

        private void butt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            query = "SELECT * FROM INVOICE_TOP_UP";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dtHistoryTopUp);
            dgv_topup.DataSource = dtHistoryTopUp;
        }

        private void dgv_topup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string txt = dgv_topup.CurrentRow.Cells[2].Value.ToString();
            
            query = "select u.username_user,id_transaksi, itu.id_kartu, itu.id_mesin,NONIMAL_TOP_UP, " +
                "DATE_FORMAT(tgl_top_up, '%d %M %Y'),DATE_FORMAT(tgl_top_up, '%h:%m:%s') from " +
                "invoice_top_up itu, `user` u, kartu_member km where km.id_kartu = " +
                "itu.id_kartu AND km.id_user = u.id_user;\r\n";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            DataTable data = new DataTable();
            sqldataadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == txt)
                {
                    string news = $"User dengan username {data.Rows[i][0].ToString()} " +
               $"dan ID Kartu {data.Rows[i][2].ToString()} melakukan top up kartu " +
           $"pada mesin {data.Rows[i][3].ToString()} sebesar {"Rp " + Convert.ToInt32(data.Rows[i][4].ToString()).ToString("C2").Remove(0, 1)} " +
           $"pada tanggal {data.Rows[i][5].ToString()} jam {data.Rows[i][6].ToString()}";

                    DialogResult DR = MessageBox.Show(news, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (DR == DialogResult.OK)
                    {
                        dgv_topup.ClearSelection();
                    }
                    break;
                }
            }

           
        }
    }
}
