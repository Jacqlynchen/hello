using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warnet
{
    public partial class After_TopUp : Form
    {
        public After_TopUp()
        {
            InitializeComponent();
        }
        string idmesin;
        string username;
        double nominal;
        string iduser;
        double saldoKartu;
        string idkartu;
        DataTable terakhirKaliIdTransaksi;

        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;
        string idBaru;

        public void mintaSemuaData(string idmesin, string username, double nominal, string iduser, double saldoKartu, string idkartu)
        {
            this.idkartu = idkartu;
            this.username = username;
            this.iduser = iduser;
            this.saldoKartu = saldoKartu;
            this.idmesin = idmesin;
            this.nominal = nominal;
        }

        private void After_TopUp_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=alp_warnet");
            
            cariKodeTransaksi();
            label_IdTopUp.Text = idBaru;
            label_Tanggal.Text = $"{DateTime.Now.ToString("dd-MM-yy hh:mm:ss")}";
            label_UserID.Text = iduser;
            label_Mesin.Text = idmesin;
            label_CardID.Text = idkartu;
            label_username.Text = username;
            lb_amount.Text = nominal.ToString("C2", CultureInfo.CreateSpecificCulture("id-ID"));
            int sribu = 1000;
            lb_amount2.Text = sribu.ToString("C2", CultureInfo.CreateSpecificCulture("id-ID"));
            lb_subtotal.Text = nominal.ToString("C2", CultureInfo.CreateSpecificCulture("id-ID"));
            lb_total.Text = (nominal + sribu).ToString("C2", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        private void cariKodeTransaksi()
        {
            try
            {
                query = "select concat(substring(id_transaksi, 3, 4), substring(id_transaksi, 1, 2), substring(id_transaksi, 7, 4)), tgl_top_up\r\n from invoice_top_up\r\n order by 1 desc limit 1;";
                sqlcommand = new MySqlCommand(query, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                terakhirKaliIdTransaksi = new DataTable();
                sqldataadapter.Fill(terakhirKaliIdTransaksi);
                string id = terakhirKaliIdTransaksi.Rows[0][0].ToString();
                string tglskr = "";

                if(DateTime.Now.Month < 10)
                {
                    tglskr = "0" + DateTime.Now.Month.ToString();
                }
                else
                {
                    tglskr = DateTime.Now.Month.ToString();
                }

                if (id.Substring(0, 4) == DateTime.Now.Year.ToString() && id.Substring(4,2) == tglskr)
                {
                    int angka = Convert.ToInt32(id.Substring(6, 4));
                    angka += 1;
                    idBaru = id.Substring(4, 2) + id.Substring(0, 4) + string.Format("{0:0000}", angka);
                    
                }
                else
                {
                    int month = DateTime.Now.Month;
                    idBaru =  string.Format("{0:00}", month) + DateTime.Now.Year + string.Format("{0:0000}", 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Keluar_Click(object sender, EventArgs e)
        {
            query = $"insert into invoice_top_up values\r\n('{idmesin}', '{idkartu}', '{idBaru}', '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}', '{nominal + 1000}', '0');";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqlconnect.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnect.Close();

            query = $"update kartu_member \r\n\t\tset saldo_kartu = {nominal + saldoKartu}\r\nwhere id_kartu = '{idkartu}';";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqlconnect.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnect.Close();

            TopUp_Login topUp_Login = new TopUp_Login();
            topUp_Login.Show();
            this.Close();
        }
    }
}
