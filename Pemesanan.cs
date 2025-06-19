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
using System.Text.RegularExpressions;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace Warnet
{
    public partial class Pemesanan : Form
    {
        public Pemesanan()
        {
            InitializeComponent();
        }

        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;
        DataTable consum = new DataTable();

        string namaStaff;
        string idstaff;
        string jk;
        string username;
        string idkartu;
        string nama;
        int totalkomputer = 0;
        int totalsnack = 0;
        string jamskr;
        string grade;
        int jumlahsnack = 0;
        string jeniskom;
        int jam = 0;

        DataTable com = new DataTable();
        List<int> hargasnack = new List<int>();
        DataTable cart = new DataTable();
        DataTable allconsum = new DataTable();
        bool tes = false;
        public void nama_dan_id5(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
            mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
            mainPage.Show();
            this.Hide();
        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (tb_idkartu.Text == "")
            {
                cb_komputer.Enabled = false;
                cb_jam.Enabled = false;
                cb_consum.Enabled = false;
                qty.Enabled = false;
                add_snack.Enabled = false;
                butt_delsnack.Enabled = false;
            }
            else
            {
                cb_komputer.Enabled = true;
                cb_jam.Enabled = true;
                cb_consum.Enabled = true;
                qty.Enabled = true;
                add_snack.Enabled = true;
                butt_delsnack.Enabled = true;
            }
            cart.Columns.Clear();
            cart.Columns.Add("Nama Snack");
            cart.Columns.Add("Quantity");
            dgv_cartsnack.DataSource = cart;

            cb_consum.Text = "";
            cb_komputer.Items.Clear();
            for (int i = 0; i < com.Rows.Count; i++)
            {
                if (com.Rows[i][1].ToString() == "Y")
                {
                    cb_komputer.Items.Add(com.Rows[i][0].ToString());
                }
            }

            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = "SELECT * FROM CONSUMABLE";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(consum);
            sqldataadapter.Fill(allconsum);
            cb_consum.DataSource = consum;
            cb_consum.DisplayMember = "NAMA_CONSUMABLE";
            cb_consum.ValueMember = "HARGA_CONSUMABLE";

            dgv_cartsnack.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void cb_jam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_komputer.Text != "")
            {
                int jam = Convert.ToInt32(cb_jam.Text.Substring(0, 1));
                lb_total.Text = "  Rp" + (jam * 15000).ToString("C2").Remove(0, 1);
                totalkomputer = jam * 15000;
            }
        }

        private void cb_komputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_jam.Text != "")
            {
                int jam = Convert.ToInt32(cb_jam.Text.Substring(0, 1));
                lb_total.Text = "  Rp" + (jam * 15000).ToString("C2").Remove(0, 1);
                totalkomputer = jam * 15000;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_jam.Text = DateTime.Now.ToString("hh:mm:ss");
            label_bulantahun.Text = DateTime.Now.ToString("MMMM yyyy");
            label_day.Text = DateTime.Now.ToString("dd");
            label_hari.Text = DateTime.Now.ToString("ddd");
        }

        private void butt_nota_Click(object sender, EventArgs e)
        {
            DataTable insertconsum = new DataTable();
            insertconsum.Columns.Add("id_consum");
            insertconsum.Columns.Add("harga_penjualan");
            insertconsum.Columns.Add("quantity");

            string tanggal = DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd");
            string date = DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy");
            if (tb_idkartu.Text != "" && tb_namaorang.Text != "" && tb_username.Text != "")
            {
                query = "SELECT MAX(CONCAT(SUBSTRING(ID_PENJUALAN, 6, 2), SUBSTRING(ID_PENJUALAN, 4, 2), " +
                    "SUBSTRING(ID_PENJUALAN, 2, 2))), MAX(SUBSTRING(ID_PENJUALAN, 8)) FROM penjualan;";
                sqlcommand = new MySqlCommand(query, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                DataTable max = new DataTable();
                sqldataadapter.Fill(max);
                string maxi = max.Rows[0][0].ToString().Substring(4, 2) + max.Rows[0][0].ToString().Substring(2, 2) + max.Rows[0][0].ToString().Substring(0, 2);
                string ID_penjualan = "";
                int id = 1;
                query = "SELECT MAX(haha.`max`), MAX(haha.`max1`) FROM(SELECT MAX(CONCAT(SUBSTRING(ID_PENJUALAN, 6, 2), " +
                    "SUBSTRING(ID_PENJUALAN, 4, 2), SUBSTRING(ID_PENJUALAN, 2, 2))) as `max`, " +
                    "MAX(SUBSTRING(ID_PENJUALAN, 8)) as `max1` FROM penjualan WHERE ID_PENJUALAN " +
                    $"LIKE '%{maxi}%' group by ID_PENJUALAN order by 1 desc) as haha, penjualan " +
                    $"WHERE ID_PENJUALAN LIKE '%{maxi}%' group by ID_PENJUALAN order by 1 desc;";
                sqlcommand = new MySqlCommand(query, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                DataTable ID = new DataTable();
                sqldataadapter.Fill(ID);
                ID_penjualan = ID.Rows[0][0].ToString();
                if (ID_penjualan == tanggal)
                {
                    if (Convert.ToInt32(ID.Rows[0][1].ToString()) + 1 < 10)
                    {
                        ID_penjualan = "P" + date + "000" + (Convert.ToInt32(ID.Rows[0][1].ToString()) + 1).ToString();
                    }
                    else if (Convert.ToInt32(ID.Rows[0][1].ToString()) < 100)
                    {
                        ID_penjualan = "P" + date + "00" + (Convert.ToInt32(ID.Rows[0][1].ToString()) + 1).ToString();
                    }
                    else if (Convert.ToInt32(ID.Rows[0][1].ToString()) < 1000)
                    {
                        ID_penjualan = "P" + date + "0" + (Convert.ToInt32(ID.Rows[0][1].ToString()) + 1).ToString();
                    }
                    else if (Convert.ToInt32(ID.Rows[0][1].ToString()) < 10000)
                    {
                        ID_penjualan = "P" + date + (Convert.ToInt32(ID.Rows[0][1].ToString()) + 1).ToString();
                    }
                }
                else if (Convert.ToInt32(ID.Rows[0][0].ToString()) < Convert.ToInt32(tanggal))
                {
                    ID_penjualan = "P" + date + "0001";
                }
                jamskr = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                if (cb_komputer.Text != "" && cb_jam.Text != "")
                {
                    jam = Convert.ToInt32(DateTime.Now.ToString("hhmmss"));
                    jeniskom = cb_komputer.Text;
                    for (int i = 0; i < com.Rows.Count; i++)
                    {
                        if (cb_komputer.Text == com.Rows[i][0].ToString())
                        {
                            com.Rows[i][1] = "N";
                            break;
                        }
                    }

                    if (cart.Rows.Count != 0)
                    {
                        for (int k = 0; k < cart.Rows.Count; k++)
                        {
                            jumlahsnack = jumlahsnack + Convert.ToInt32(cart.Rows[k][1].ToString());
                        }

                        for (int o = 0; o < cart.Rows.Count; o++)
                        {
                            for (int k = 0; k < allconsum.Rows.Count; k++)
                            {
                                if (cart.Rows[o][0].ToString() == allconsum.Rows[k][1].ToString())
                                {
                                    insertconsum.Rows.Add(allconsum.Rows[k][0].ToString(), (hargasnack[o] * Convert.ToInt32(cart.Rows[o][1].ToString())).ToString(), cart.Rows[o][1].ToString());
                                    break;
                                }
                            }
                        }
                        Invoice nota = new Invoice();
                        nota.nama_dan_id7(namaStaff, idstaff, jk, com, username, idkartu, nama, totalkomputer, totalsnack, ID_penjualan, jumlahsnack, jamskr, grade, insertconsum, jeniskom, jam);
                        nota.Show();
                        this.Close();
                    }
                    else
                    {
                        Invoice nota = new Invoice();
                        nota.nama_dan_id7(namaStaff, idstaff, jk, com, username, idkartu, nama, totalkomputer, totalsnack, ID_penjualan, jumlahsnack, jamskr, grade, insertconsum, jeniskom, jam);
                        nota.Show();
                        this.Close();
                    }
                }
                else if (cart.Rows.Count != 0)
                {
                    for (int k = 0; k < cart.Rows.Count; k++)
                    {
                        jumlahsnack = jumlahsnack + Convert.ToInt32(cart.Rows[k][1].ToString());
                    }

                    for (int o = 0; o < cart.Rows.Count; o++)
                    {
                        for (int k = 0; k < allconsum.Rows.Count; k++)
                        {
                            if (cart.Rows[o][0].ToString() == allconsum.Rows[k][1].ToString())
                            {
                                insertconsum.Rows.Add(allconsum.Rows[k][0].ToString(), (hargasnack[o] * Convert.ToInt32(cart.Rows[o][1].ToString())).ToString(), cart.Rows[o][1].ToString());
                                break;
                            }
                        }
                    }
                    Invoice nota = new Invoice();
                    nota.nama_dan_id7(namaStaff, idstaff, jk, com, username, idkartu, nama, totalkomputer, totalsnack, ID_penjualan, jumlahsnack, jamskr, grade, insertconsum, jeniskom, jam); ;
                    nota.Show();
                    this.Close();
                }
                else
                {
                    DialogResult DR = MessageBox.Show("Please, choose your order first!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult DR = MessageBox.Show("Please, choose who orders first!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void butt_member_Click(object sender, EventArgs e)
        {
            Member memb = new Member();
            memb.nama_dan_id8(namaStaff, idstaff, jk, com);
            memb.Show();
            this.Close();
        }

        public void cellclick(string namaStaff, string idstaff, string jk, DataTable com, string username, string idkartu, string nama, string grade)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
            this.username = username;
            this.idkartu = idkartu;
            this.nama = nama;
            this.grade = grade;
            tb_username.Text = username;
            tb_idkartu.Text = idkartu;
            tb_namaorang.Text = nama;
        }

        private void add_snack_Click(object sender, EventArgs e)
        {
            string cekk = "";
            if (cb_consum.Text != "" && qty.Text != "")
            {
                query = "SELECT * FROM CONSUMABLE";
                sqlcommand = new MySqlCommand(query, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                DataTable snack = new DataTable();
                sqldataadapter.Fill(snack);

                bool cek = false;
                for (int i = 0; i < cart.Rows.Count; i++)
                {
                    if (cb_consum.Text == cart.Rows[i][0].ToString())
                    {
                        int quantity = Convert.ToInt32(cart.Rows[i][1].ToString());
                        int quntitytextbox = Convert.ToInt32(qty.Text);
                        int totqty = quantity + quntitytextbox;

                        bool ha = false;
                        for (int j = 0; j < snack.Rows.Count; j++)
                        {
                            if (cb_consum.Text == snack.Rows[j][1].ToString())
                            {
                                cekk = snack.Rows[j][4].ToString();
                                if (totqty <= Convert.ToInt32(snack.Rows[j][4].ToString()))
                                {
                                    ha = true;
                                    break;
                                }
                            }
                        }
                        if (ha == false)
                        {
                            string news = "Kurang Stock! Stock" + cb_consum.Text + " hanya berjumlah " + cekk;
                            DialogResult DR = MessageBox.Show(news, "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ha == true)
                        {
                            cart.Rows[i][1] = totqty.ToString();
                        }
                        cek = true;
                        break;
                    }
                }

                if (cek == false)
                {
                    bool ha = false;
                    for (int j = 0; j < snack.Rows.Count; j++)
                    {
                        if (cb_consum.Text == snack.Rows[j][1].ToString())
                        {
                            cekk = snack.Rows[j][4].ToString();
                            if (Convert.ToInt32(qty.Text) <= Convert.ToInt32(snack.Rows[j][4].ToString()))
                            {
                                ha = true;
                                break;
                            }
                        }
                    }
                    if (ha == false)
                    {
                        string news = "Kurang Stock! Stock" + cb_consum.Text + " hanya berjumlah " + cekk;
                        DialogResult DR = MessageBox.Show(news, "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ha == true)
                    {
                        cart.Rows.Add(cb_consum.Text, qty.Text);
                        hargasnack.Add(Convert.ToInt32(cb_consum.SelectedValue));
                    }
                }

                int a = 0;
                for (int i = 0; i < cart.Rows.Count; i++)
                {
                    a = a + (Convert.ToInt32(cart.Rows[i][1].ToString()) * hargasnack[i]);
                }
                totalsnack = a;
                lb_totalsnack.Text = "  Rp " + a.ToString("C2").Remove(0, 1);
            }
            else
            {
                DialogResult DR = MessageBox.Show("Enter the quantity first!", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_cartsnack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tes = true;
        }

        private void butt_delsnack_Click(object sender, EventArgs e)
        {
            if (tes == true)
            {
                int index = dgv_cartsnack.CurrentRow.Index;
                dgv_cartsnack.Rows.RemoveAt(index);
                hargasnack.RemoveAt(index);
                tes = false;
                dgv_cartsnack.ClearSelection();

                int a = 0;
                for (int i = 0; i < cart.Rows.Count; i++)
                {
                    a = a + (Convert.ToInt32(cart.Rows[i][1].ToString()) * hargasnack[i]);
                }
                lb_totalsnack.Text = "Rp" + a.ToString("C2").Remove(0, 1);

            }
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (qty.Text.Length >= 7 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
