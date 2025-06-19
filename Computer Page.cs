using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Warnet
{
    public partial class Computer_Page : Form
    {
        public Computer_Page()
        {
            InitializeComponent();
        }
        string namaStaff;
        string idstaff;
        string jk;
        DataTable com = new DataTable();
        string tanggalmain = "";
        public void nama_dan_id(string namaStaff, string idstaff, string jk, DataTable com)
        {
            this.namaStaff = namaStaff;
            this.idstaff = idstaff;
            this.jk = jk;
            this.com = com;
        }
        List<Button> computer = new List<Button>();
        List<Panel> panel = new List<Panel>();
        private void Computer_Page_Load(object sender, EventArgs e)
        {
            timer1.Start();
            computer.Clear();
            computer.Add(button1);
            computer.Add(button2);
            computer.Add(button3);
            computer.Add(button4);
            computer.Add(button5);
            computer.Add(button6);
            computer.Add(button7);
            computer.Add(button8);
            computer.Add(button9);
            computer.Add(button10);
            computer.Add(button11);
            computer.Add(button12);
            computer.Add(button13);
            computer.Add(button14);
            computer.Add(button15);
            computer.Add(button16);
            computer.Add(button17);
            computer.Add(button18);
            computer.Add(button19);
            computer.Add(button20);

            panel.Add(panel1);
            panel.Add(panel2);
            panel.Add(panel3);
            panel.Add(panel4);
            panel.Add(panel5);
            panel.Add(panel6);
            panel.Add(panel7);
            panel.Add(panel8);
            panel.Add(panel9);
            panel.Add(panel10);
            panel.Add(panel11);
            panel.Add(panel12);
            panel.Add(panel13);
            panel.Add(panel14);
            panel.Add(panel15);
            panel.Add(panel16);
            panel.Add(panel17);
            panel.Add(panel18);
            panel.Add(panel19);
            panel.Add(panel20);

            for (int i = 0; i < computer.Count; i++)
            {
                (computer[i]).Click += new EventHandler(buttonClicksEvent);
                (computer[i]).Tag = i;
            }

            int a = Convert.ToInt32(DateTime.Now.ToString("hhmmss"));
            //MessageBox.Show(a.ToString() + "   " + com.Rows[2][4].ToString());

            for (int i = 0; i < com.Rows.Count; i++)
            {
                if (com.Rows[i][1].ToString() == "N")
                {
                    if (Convert.ToInt32(DateTime.Now.ToString("hhmmss")).ToString().Length == Convert.ToInt32(com.Rows[i][4].ToString()).ToString().Length)
                    {
                        if (Convert.ToInt32(DateTime.Now.ToString("hhmmss")) > Convert.ToInt32(com.Rows[i][4].ToString()))
                        {
                            com.Rows[i][1] = "Y";
                            computer[i].ForeColor = Color.LightGreen;
                            com.Rows[i][2] = "0";
                            com.Rows[i][3] = "0";
                            com.Rows[i][4] = "0";
                        }
                    }
                }
            }

            for (int i = 0; i < computer.Count; i++)
            {
                if (com.Rows[i][1].ToString() == "N")
                {
                    computer[i].BackColor = Color.Red;
                    computer[i].Enabled = true;
                    panel[i].Visible = true;
                }
                else
                {
                    computer[i].BackColor = Color.LightGreen;
                    computer[i].Enabled = false;
                    panel[i].Visible = false;
                }

            }
            //dataGridView1.DataSource = com;
        }

        public void buttonClicksEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int a = Convert.ToInt32(btn.Tag);
            if (com.Rows[a][4].ToString().Length == 5)
            {
                tanggalmain = "0" + com.Rows[a][4].ToString().Substring(0, 1) + ":" + com.Rows[a][4].ToString().Substring(1, 2) + ":" + com.Rows[a][4].ToString().Substring(3, 2);
            }
            else if (com.Rows[a][4].ToString().Length == 6)
            {
                tanggalmain = com.Rows[a][4].ToString().Substring(0, 2) + ":" + com.Rows[a][4].ToString().Substring(2, 2) + ":" + com.Rows[a][4].ToString().Substring(4, 2);
            }
            MessageBox.Show($"Player with username {com.Rows[a][2].ToString()} playing until {tanggalmain}");
        }

        private void butt_home_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
            mainPage.staffYangLoginSekarang(namaStaff, idstaff, jk, com);
            mainPage.Show();
            this.Hide();
        }

        private void butt_historycomp_Click(object sender, EventArgs e)
        {
            HistoryComp history = new HistoryComp();
            history.nama_dan_id2(namaStaff, idstaff, jk, com);
            history.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
