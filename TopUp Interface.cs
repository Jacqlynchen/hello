using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Warnet
{
    public partial class TopUp_Interface : Form
    {
        public TopUp_Interface()
        {
            InitializeComponent();
        }

        string iduser;
        string username;
        string idkartu;
        string idmesin;
        int saldoKartu;
        double biayaTopUp;

        private void TopUp_Interface_Load(object sender, EventArgs e)
        {
            lb_welcome.Text = $"Welcome Back, {username}";
            label_saldoUser.Text = "Rp" + saldoKartu.ToString("C2").Remove(0,1);
        }
        public void dataUser(string iduser, string username, string idkartu, int saldoKartu, string idmesin)
        {
            this.idkartu = idkartu;
            this.username = username;
            this.iduser = iduser;
            this.saldoKartu = saldoKartu;
            this.idmesin = idmesin;
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            TopUp_Login topUp_Login = new TopUp_Login();
            topUp_Login.Show();
            this.Close();
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            biayaTopUp = 50000;
            tbox_NominalTopUp.Text = biayaTopUp.ToString();
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            biayaTopUp = 100000;
            tbox_NominalTopUp.Text = biayaTopUp.ToString();
        }

        private void btn_150_Click(object sender, EventArgs e)
        {
            biayaTopUp = 150000;
            tbox_NominalTopUp.Text = biayaTopUp.ToString();
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            biayaTopUp = 200000;
            tbox_NominalTopUp.Text = biayaTopUp.ToString();
        }

        private void btn_TopUpNow_Click(object sender, EventArgs e)
        {
            int nominal = Convert.ToInt32(tbox_NominalTopUp.Text);
            if (tbox_NominalTopUp.Text != "" && nominal > 19999)
            {
                if((saldoKartu + nominal) > 9999999)
                {
                    DialogResult DR = MessageBox.Show("Saldo Kartu Tidak Boleh Melebihi Rp 9.999.999,00", "Nominal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    biayaTopUp = Convert.ToDouble(tbox_NominalTopUp.Text);
                    After_TopUp after_TopUp = new After_TopUp();
                    after_TopUp.mintaSemuaData(idmesin, username, biayaTopUp, iduser, saldoKartu, idkartu);
                    after_TopUp.Show();
                    this.Close();
                }
            }
            else
            {
                DialogResult DR = MessageBox.Show("Minimal Top Up Rp 20.000,00", "Nominal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbox_NominalTopUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbox_NominalTopUp.Text.Length >= 7 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
