using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace Warnet
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;

        string namaStaff;
        string idstaff;
        string jk;
        int totalkomputer;
        int totalsnack;
        int jumlahsnack;
        DataTable com = new DataTable();
        DataTable insertconsum = new DataTable();
        string query;
        string jeniskom;
        int jam;
        double minsaldo = 0;
        bool test = false;
        public void nama_dan_id7(string namaStaff, string idstaff, string jk, DataTable com, string username, string idkartu, string nama, int totalkomputer, int totalsnack, string ID_penjualan, int jumlahsnack, string jamskr, string grade, DataTable insertconsum, string jeniskom, int jam)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");

            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
            this.totalkomputer = totalkomputer;
            this.totalsnack = totalsnack;
            this.jumlahsnack = jumlahsnack;
            this.insertconsum = insertconsum;
            this.jeniskom = jeniskom;
            this.jam = jam;

            lb_staff.Text = namaStaff;
            lb_tanggalpembelian.Text = DateTime.Parse(jamskr).ToString("dd-MM-yyyy hh:mm:ss");
            lb_username.Text = username;
            lb_idkartu.Text = idkartu;
            lb_namauser.Text = nama;
            lb_idpenjualan.Text = ID_penjualan;

            double diskon = 0;
            string jamm = "";

            if (totalsnack > 0 && totalkomputer > 0)
            {
                minsaldo = (totalkomputer + totalsnack) - ((totalkomputer + totalsnack) * diskon);
            }
            else if (totalsnack > 0 && totalkomputer == 0)
            {
                minsaldo = (totalsnack) - (totalsnack * diskon);
            }
            else if (totalsnack == 0 && totalkomputer > 0)
            {
                minsaldo = (totalkomputer) - (totalkomputer * diskon);
            }

            query = $"SELECT saldo_kartu FROM kartu_member where id_kartu = '{idkartu}'";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            DataTable kartu = new DataTable();
            sqldataadapter.Fill(kartu);

            double saldoskr = Convert.ToInt32(kartu.Rows[0][0].ToString()) - minsaldo;
            string aaa = "";
            if (saldoskr > 0)
            {
                test = true;
                for (int i = 0; i < com.Rows.Count; i++)
                {
                    if (jeniskom == com.Rows[i][0].ToString())
                    {
                        if (jam.ToString().Length == 5)
                        {
                            int o = Convert.ToInt32(jam.ToString().Substring(0, 1)) + (totalkomputer / 15000);
                            if (o > 12)
                            {
                                o = o - 12;
                            }
                            jamm = o.ToString() + jam.ToString().Substring(1);
                            com.Rows[i][2] = username;
                            com.Rows[i][3] = nama;
                            com.Rows[i][4] = jamm;
                        }
                        else if (jam.ToString().Length == 6)
                        {
                            int o = Convert.ToInt32(jam.ToString().Substring(0, 2)) + (totalkomputer / 15000);
                            if (o > 12)
                            {
                                o = o - 12;
                            }
                            jamm = o.ToString() + jam.ToString().Substring(2);
                            com.Rows[i][2] = username;
                            com.Rows[i][3] = nama;
                            com.Rows[i][4] = jamm;
                        }
                        aaa = com.Rows[i][4].ToString();
                    }
                }

                if(aaa.Length == 5)
                {
                    aaa = "0" + aaa;
                }

                aaa = $"{aaa.Substring(0, 2)}:{aaa.Substring(2, 2)}:{aaa.Substring(4, 2)}";

                if (grade == "Platinum")
                {
                    diskon = 0.07;
                }
                else if (grade == "Silver")
                {
                    diskon = 0.05;
                }
                else if (grade == "Gold")
                {
                    diskon = 0.03;
                }

                if (totalsnack > 0 && totalkomputer > 0)
                {
                    lb_jumlah.Text = "Rp 15.000,00";
                    lb_qty.Text = (totalkomputer / 15000).ToString();
                    lb_amount.Text = "Rp" + totalkomputer.ToString("C2").Remove(0, 1);
                    lb_jumlah2.Text = "";
                    lb_qty2.Text = jumlahsnack.ToString();
                    lb_amount2.Text = "Rp" + totalsnack.ToString("C2").Remove(0, 1);
                    lb_subtotal.Text = "Rp" + (totalkomputer + totalsnack).ToString("C2").Remove(0, 1);
                    lb_diskon.Text = "Rp" + ((totalkomputer + totalsnack) * diskon).ToString("C2").Remove(0, 1);
                    lb_total.Text = "Rp" + ((totalkomputer + totalsnack) - ((totalkomputer + totalsnack) * diskon)).ToString("C2").Remove(0, 1);
                    minsaldo = (totalkomputer + totalsnack) - ((totalkomputer + totalsnack) * diskon);

                    query = $"INSERT INTO PENJUALAN VALUES " +
                        $"('{ID_penjualan}','{idkartu}','{idstaff}','{jamskr}','{(totalkomputer + totalsnack) * diskon}','0');";
                    sqlconnect.Open();
                    sqlcommand = new MySqlCommand(query, sqlconnect);
                    sqlcommand.ExecuteNonQuery();
                    sqlconnect.Close();

                    query = $"INSERT INTO HISTORY_RENTAL_KOMPUTER VALUES " +
                       $"('{jeniskom}','{ID_penjualan}','{lb_qty.Text}'," +
                       $"'{totalkomputer}', '{aaa}', '0');";
                    sqlconnect.Open();
                    sqlcommand = new MySqlCommand(query, sqlconnect);
                    sqlcommand.ExecuteNonQuery();
                    sqlconnect.Close();

                    for (int i = 0; i < insertconsum.Rows.Count; i++)
                    {
                        query = $"INSERT INTO HISTORY_CONSUMABLE VALUES " +
                        $"('{insertconsum.Rows[i][0].ToString()}','{ID_penjualan}','{insertconsum.Rows[i][1].ToString()}'," +
                        $"'{insertconsum.Rows[i][2].ToString()}', '0');";
                        sqlconnect.Open();
                        sqlcommand = new MySqlCommand(query, sqlconnect);
                        sqlcommand.ExecuteNonQuery();
                        sqlconnect.Close();
                    }
                }
                else if (totalsnack > 0 && totalkomputer == 0)
                {
                    lb_nama.Text = "Consumable";
                    lb_nama2.Text = "";
                    lb_jumlah.Text = "";
                    lb_qty.Text = jumlahsnack.ToString();
                    lb_amount.Text = "Rp" + totalsnack.ToString("C2").Remove(0, 1);
                    lb_jumlah2.Text = "";
                    lb_qty2.Text = "";
                    lb_amount2.Text = "";
                    lb_subtotal.Text = "Rp" + totalsnack.ToString("C2").Remove(0, 1);
                    lb_diskon.Text = "Rp" + (totalsnack * diskon).ToString("C2").Remove(0, 1);
                    lb_total.Text = "Rp" + ((totalsnack) - (totalsnack * diskon)).ToString("C2").Remove(0, 1);
                    minsaldo = (totalsnack) - (totalsnack * diskon);

                    query = $"INSERT INTO PENJUALAN VALUES " +
                        $"('{ID_penjualan}','{idkartu}','{idstaff}','{jamskr}','{totalsnack * diskon}','0');";
                    sqlconnect.Open();
                    sqlcommand = new MySqlCommand(query, sqlconnect);
                    sqlcommand.ExecuteNonQuery();
                    sqlconnect.Close();

                    for (int i = 0; i < insertconsum.Rows.Count; i++)
                    {
                        query = $"INSERT INTO HISTORY_CONSUMABLE VALUES " +
                        $"('{insertconsum.Rows[i][0].ToString()}','{ID_penjualan}','{insertconsum.Rows[i][1].ToString()}'," +
                        $"'{insertconsum.Rows[i][2].ToString()}', '0');";
                        sqlconnect.Open();
                        sqlcommand = new MySqlCommand(query, sqlconnect);
                        sqlcommand.ExecuteNonQuery();
                        sqlconnect.Close();
                    }
                }
                else if (totalsnack == 0 && totalkomputer > 0)
                {
                    lb_nama2.Text = "";
                    lb_jumlah.Text = "Rp 15.000,00";
                    lb_qty.Text = (totalkomputer / 15000).ToString();
                    lb_amount.Text = "Rp" + totalkomputer.ToString("C2").Remove(0, 1);
                    lb_jumlah2.Text = "";
                    lb_qty2.Text = "";
                    lb_amount2.Text = "";
                    lb_subtotal.Text = "Rp" + totalkomputer.ToString("C2").Remove(0, 1);
                    lb_diskon.Text = "Rp" + (totalkomputer * diskon).ToString("C2").Remove(0, 1);
                    lb_total.Text = "Rp" + ((totalkomputer) - (totalkomputer * diskon)).ToString("C2").Remove(0, 1);
                    minsaldo = (totalkomputer) - (totalkomputer * diskon);

                    query = $"INSERT INTO PENJUALAN VALUES " +
                        $"('{ID_penjualan}','{idkartu}','{idstaff}','{jamskr}','{totalkomputer * diskon}','0');";
                    sqlconnect.Open();
                    sqlcommand = new MySqlCommand(query, sqlconnect);
                    sqlcommand.ExecuteNonQuery();
                    sqlconnect.Close();

                    query = $"INSERT INTO HISTORY_RENTAL_KOMPUTER VALUES " +
                        $"('{jeniskom}','{ID_penjualan}','{lb_qty.Text}'," +
                        $"'{totalkomputer}', '{aaa}', '0');";
                    sqlconnect.Open();
                    sqlcommand = new MySqlCommand(query, sqlconnect);
                    sqlcommand.ExecuteNonQuery();
                    sqlconnect.Close();
                }

                if (insertconsum.Rows.Count > 0)
                {
                    int quantity = 0;

                    query = "SELECT ID_CONSUMABLE2, QUANTITY_CONSUMABLE FROM CONSUMABLE";
                    sqlcommand = new MySqlCommand(query, sqlconnect);
                    sqldataadapter = new MySqlDataAdapter(sqlcommand);
                    DataTable quantityconsum = new DataTable();
                    sqldataadapter.Fill(quantityconsum);

                    for (int i = 0; i < insertconsum.Rows.Count; i++)
                    {
                        for (int j = 0; j < quantityconsum.Rows.Count; j++)
                        {
                            if (insertconsum.Rows[i][0].ToString() == quantityconsum.Rows[j][0].ToString())
                            {
                                quantity = Convert.ToInt32(quantityconsum.Rows[j][1].ToString()) - Convert.ToInt32(insertconsum.Rows[i][2].ToString());
                                query = $"UPDATE CONSUMABLE SET QUANTITY_CONSUMABLE = '{quantity.ToString()}' WHERE ID_CONSUMABLE2 = '{insertconsum.Rows[i][0].ToString()}';";
                                sqlconnect.Open();
                                sqlcommand = new MySqlCommand(query, sqlconnect);
                                sqlcommand.ExecuteNonQuery();
                                sqlconnect.Close();
                            }
                        }
                    }
                }

                query = $"UPDATE kartu_member set saldo_kartu = saldo_kartu - {minsaldo} where id_kartu = '{idkartu}';\r\n";
                sqlconnect.Open();
                sqlcommand = new MySqlCommand(query, sqlconnect);
                sqlcommand.ExecuteNonQuery();
                sqlconnect.Close();
            }
            else
            {
                test = false;
                for (int i = 0;i < com.Rows.Count;i++)
                {
                    if (com.Rows[i][0].ToString() == jeniskom)
                    {
                        com.Rows[i][1] = "Y";
                    }
                }

                if (totalsnack > 0 && totalkomputer > 0)
                {
                    lb_jumlah.Text = "Rp 15.000,00";
                    lb_qty.Text = (totalkomputer / 15000).ToString();
                    lb_amount.Text = "Rp" + totalkomputer.ToString("C2").Remove(0, 1);
                    lb_jumlah2.Text = "";
                    lb_qty2.Text = jumlahsnack.ToString();
                    lb_amount2.Text = "Rp" + totalsnack.ToString("C2").Remove(0, 1);
                    lb_subtotal.Text = "Rp" + (totalkomputer + totalsnack).ToString("C2").Remove(0, 1);
                    lb_diskon.Text = "Rp" + ((totalkomputer + totalsnack) * diskon).ToString("C2").Remove(0, 1);
                    lb_total.Text = "Rp" + ((totalkomputer + totalsnack) - ((totalkomputer + totalsnack) * diskon)).ToString("C2").Remove(0, 1);
                }
                else if (totalsnack > 0 && totalkomputer == 0)
                {
                    lb_nama.Text = "Consumable";
                    lb_nama2.Text = "";
                    lb_jumlah.Text = "";
                    lb_qty.Text = jumlahsnack.ToString();
                    lb_amount.Text = "Rp" + totalsnack.ToString("C2").Remove(0, 1);
                    lb_jumlah2.Text = "";
                    lb_qty2.Text = "";
                    lb_amount2.Text = "";
                    lb_subtotal.Text = "Rp" + totalsnack.ToString("C2").Remove(0, 1);
                    lb_diskon.Text = "Rp" + (totalsnack * diskon).ToString("C2").Remove(0, 1);
                    lb_total.Text = "Rp" + ((totalsnack) - (totalsnack * diskon)).ToString("C2").Remove(0, 1);
                }
                else if (totalsnack == 0 && totalkomputer > 0)
                {
                    lb_nama2.Text = "";
                    lb_jumlah.Text = "Rp 15.000,00";
                    lb_qty.Text = (totalkomputer / 15000).ToString();
                    lb_amount.Text = "Rp" + totalkomputer.ToString("C2").Remove(0, 1);
                    lb_jumlah2.Text = "";
                    lb_qty2.Text = "";
                    lb_amount2.Text = "";
                    lb_subtotal.Text = "Rp" + totalkomputer.ToString("C2").Remove(0, 1);
                    lb_diskon.Text = "Rp" + (totalkomputer * diskon).ToString("C2").Remove(0, 1);
                    lb_total.Text = "Rp" + ((totalkomputer) - (totalkomputer * diskon)).ToString("C2").Remove(0, 1);
                }
            }
        }

        private void butt_home_Click(object sender, EventArgs e)
        {
            if (test == true)
            {
                DialogResult DR = MessageBox.Show("Payment successful", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DR == DialogResult.OK)
                {
                    Form1 mainPage = new Form1();
                    mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
                    mainPage.Show();
                    this.Hide();
                }
            }
            else if (test == false)
            {
                DialogResult DR = MessageBox.Show("Payment failed, not enough balance", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 mainPage = new Form1();
                mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
                mainPage.Show();
                this.Hide();
            }
        }
    }
}
