using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warnet
{
    public partial class Form1 : Form
    {
        string namaStaff;
        string idstaff;
        string jk;
        DataTable com = new DataTable();

        DataTable profit = new DataTable();
        MySqlDataAdapter sqldataadapter;
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        string query;

        public Form1()
        {
            InitializeComponent();
        }
        public void staffYangLoginSekarang(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(label_nama.Top.ToString() + "  " + label_nama.Left.ToString() + "  " + pb_profile.Left.ToString());
            butt_home.Text = "Home";
            timer1.Start();
            string[]nama = namaStaff.Split(' ');
            string namapanjang = "";
            string namapendek = nama[0].Substring(0, 1) + nama[0].Substring(1).ToLower();
            for (int i = 0; i < nama.Length; i++)
            {
                string a = nama[i].Substring(0, 1) + nama[i].Substring(1).ToLower();
                namapanjang = namapanjang + " " + a;
            }
            label_nama.Text = $"Hi, {namapanjang}";
            label_ID.Text = $"ID {idstaff}";
            lb_welcome.Text = $"Welcome Back, {namapendek}";

            if(jk == "M")
            {
                pb_profile.Image = Properties.Resources.male2;
            }
            else if(jk == "F")
            {
                pb_profile.Image = Properties.Resources.female1;
            }

            int aa = 0;
            for (int i = 0; i < com.Rows.Count; i++)
            {
                if (com.Rows[i][1].ToString() == "N")
                {
                    aa++;
                }
            }
            label_player.Text = aa.ToString();


            string date = DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy");
            int al = 0;
            sqlconnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=ALP_WARNET");
            query = "Select IF((kom.`hkom` + pen.`hpen` - diskon.`diskon`) is null, '0',(kom.`hkom` + pen.`hpen` - diskon.`diskon`)) " +
                "FROM(select IF(SUM(harga_sewa) is null, '0', SUM(harga_sewa)) as " +
                $"`hkom`from history_rental_komputer hrk WHERE hrk.id_penjualan LIKE'%{date}%') as kom," +
                "( select IF(SUM(harga_penjualan) is null, '0', SUM(harga_penjualan)) as `hpen` from history_consumable hc " +
                $"WHERE hc.id_penjualan LIKE'%{date}%') as pen, (select SUM(diskon_penjualan) as `diskon` " +
                $"from penjualan p where p.id_penjualan LIKE '%{date}%') as diskon;";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(profit);

            label_profit.Text = "Rp " + Convert.ToInt32(profit.Rows[0][0].ToString()).ToString("C2").Remove(0, 1);

            query = "select IF(SUM(NONIMAL_TOP_UP) is null, '0', SUM(NONIMAL_TOP_UP)) from invoice_top_up " +
                $"where MONTH(tgl_top_up) = '{DateTime.Now.ToString("MM")}' AND YEAR(tgl_top_up) = '{DateTime.Now.ToString("yyyy")}';";
            sqlcommand = new MySqlCommand(query, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            DataTable profittopup = new DataTable();
            sqldataadapter.Fill(profittopup);

            lb_profittopup.Text = "Rp " + Convert.ToInt32(profittopup.Rows[0][0].ToString()).ToString("C2").Remove(0,1);
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DR == DialogResult.Yes)
            {
                Login_Staff loginStaff = new Login_Staff();
                loginStaff.Show();
                this.Hide();
            }
        }

        private void butt_computer_Click(object sender, EventArgs e)
        {
            Computer_Page comp = new Computer_Page();
            comp.nama_dan_id(namaStaff, idstaff, jk, com);
            comp.Show();
            this.Hide();
        }

        private void butt_consum_Click(object sender, EventArgs e)
        {
            Consumable_Page consum = new Consumable_Page();
            consum.nama_dan_id3(namaStaff, idstaff, jk, com);
            consum.Show();
            this.Hide();
        }

        private void butt_penjualan_Click(object sender, EventArgs e)
        {
            Penjualan jual = new Penjualan();
            jual.nama_dan_id6(namaStaff, idstaff, jk, com);
            jual.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_jam.Text = DateTime.Now.ToString("hh:mm:ss");
            label_bulantahun.Text = DateTime.Now.ToString("MMMM yyyy");
            label_day.Text = DateTime.Now.ToString("dd");
            label_hari.Text = DateTime.Now.ToString("ddd");
            label3.Text = DateTime.Now.ToString("dd-MM-yy hh:mm:ss");
        }

        private void butt_pesan_Click(object sender, EventArgs e)
        {
            Pemesanan comp = new Pemesanan();
            comp.nama_dan_id5(namaStaff, idstaff, jk, com);
            comp.Show();
            this.Hide();
        }

        private void butt_member_Click(object sender, EventArgs e)
        {
            DataMember DM = new DataMember();
            DM.nama_dan_id3(namaStaff, idstaff, jk, com);
            DM.Show();
            this.Hide();
        }
    }
}
