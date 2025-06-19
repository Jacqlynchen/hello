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
    public partial class Penjualan : Form
    {
        public Penjualan()
        {
            InitializeComponent();
        }

        string namaStaff;
        string idstaff;
        string jk;
        DataTable com = new DataTable();
        DataTable dtHistoryPenjualan = new DataTable();

        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;
        string id;
        int cek = 0;

        public void nama_dan_id6(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            if (cek == 0)
            {
                query = "SELECT * FROM PENJUALAN";
                sqlcommand = new MySqlCommand(query, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                sqldataadapter.Fill(dtHistoryPenjualan);
                dgv_jual.DataSource = dtHistoryPenjualan;
            }
            cek = 0;

        }

        private void butt_home_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
            mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
            mainPage.Show();
            this.Hide();
        }

        private void dgv_jual_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_jual.CurrentRow.Index;
            query = "select u.USERNAME_USER, id_komputer, durasi_sewa from " +
                "history_rental_komputer hrk, kartu_member km, `user` u, " +
                $"penjualan p Where hrk.id_penjualan = '{dtHistoryPenjualan.Rows[index][0].ToString()}' AND " +
                $"p.id_penjualan = '{dtHistoryPenjualan.Rows[index][0].ToString()}' " +
                "AND p.ID_KARTU = km.ID_KARTU AND u.ID_USER = km.ID_USER;";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            DataTable dataakom = new DataTable();
            sqldataadapter.Fill(dataakom);

            query = "select nama_consumable as `nm`, quantity_penjualan, username_user " +
                "as `qp` from history_consumable hc, consumable c, penjualan p, " +
                $"`user` u, kartu_member km Where hc.id_penjualan = '{dtHistoryPenjualan.Rows[index][0].ToString()}' " +
                $"AND hc.id_consumable2 = c.id_consumable2  AND p.id_penjualan = '{dtHistoryPenjualan.Rows[index][0].ToString()}'  " +
                $"AND p.ID_KARTU = km.ID_KARTU AND u.ID_USER = km.ID_USER; ";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            DataTable dataaconsum = new DataTable();
            sqldataadapter.Fill(dataaconsum);

            if(dataakom.Rows.Count > 0)
            {
                string news = $"User dengan username {dataakom.Rows[0][0]} menyewa komputer {dataakom.Rows[0][1]} selama {dataakom.Rows[0][2]} jam ";
                if (dataaconsum.Rows.Count > 1)
                {
                    string makan = "";
                    for (int i = 0; i < dataaconsum.Rows.Count; i++)
                    {
                        if (i == dataaconsum.Rows.Count - 1)
                        {
                            makan = $"dan {dataaconsum.Rows[i][0].ToString()} sebanyak {dataaconsum.Rows[i][1].ToString()}.";
                        }
                        else
                        {
                            if (i == 0)
                            {
                                makan = $"dan consume yaitu {dataaconsum.Rows[i][0].ToString()} sebanyak {dataaconsum.Rows[i][1].ToString()}, ";
                            }
                            else
                            {
                                makan = $"{dataaconsum.Rows[i][0].ToString()} sebanyak {dataaconsum.Rows[i][1].ToString()}, ";
                            }

                        }
                        news = news + makan;
                    }
                }
                else if (dataaconsum.Rows.Count == 1)
                {
                    news = news + $"dan consume yaitu {dataaconsum.Rows[0][0].ToString()} sebanyak {dataaconsum.Rows[0][1].ToString()}.";
                }
                DialogResult DR = MessageBox.Show(news, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DR == DialogResult.OK)
                {
                    dgv_jual.ClearSelection();
                }
            }
            else
            {
                string news = $"User dengan username {dataaconsum.Rows[0][2]} membeli ";
                if (dataaconsum.Rows.Count > 1)
                {
                    string makan = "";
                    for (int i = 0; i < dataaconsum.Rows.Count; i++)
                    {
                        if (i == dataaconsum.Rows.Count - 1)
                        {
                            makan = $"dan {dataaconsum.Rows[i][0].ToString()} sebanyak {dataaconsum.Rows[i][1].ToString()}.";
                        }
                        else
                        {
                            if (i == 0)
                            {
                                makan = $"consume yaitu {dataaconsum.Rows[i][0].ToString()} sebanyak {dataaconsum.Rows[i][1].ToString()}, ";
                            }
                            else
                            {
                                makan = $"{dataaconsum.Rows[i][0].ToString()} sebanyak {dataaconsum.Rows[i][1].ToString()}, ";
                            }

                        }
                        news = news + makan;
                    }
                }
                else if (dataaconsum.Rows.Count == 1)
                {
                    news = news + $" consume yaitu {dataaconsum.Rows[0][0].ToString()} sebanyak {dataaconsum.Rows[0][1].ToString()}.";
                }
                DialogResult DR = MessageBox.Show(news, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DR == DialogResult.OK)
                {
                    dgv_jual.ClearSelection();
                }
            }
        }

        public void id_penjualan (string id, int cek, string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.cek = cek;
            this.id = id;
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
            tb_search.Text = id;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (tb_search.Text == "")
            {
                
            }
            else
            {
                dtHistoryPenjualan.Rows.Clear();
                sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
                query = $"SELECT * \r\n" +
                $"FROM penjualan WHERE id_penjualan LIKE '%{tb_search.Text}%';";
                sqlcommand = new MySqlCommand(query, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                sqldataadapter.Fill(dtHistoryPenjualan);
                dgv_jual.DataSource = dtHistoryPenjualan;
            }
        }

        private void butt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            dtHistoryPenjualan.Rows.Clear();
            query = "SELECT * FROM PENJUALAN";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dtHistoryPenjualan);
            dgv_jual.DataSource = dtHistoryPenjualan;
        }

        private void butt_topup_Click(object sender, EventArgs e)
        {
            InvoiceTopUp TU = new InvoiceTopUp();
            TU.namastaff(namaStaff, idstaff, jk, com);
            TU.Show();
            this.Hide();
        }
    }
}
