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
    public partial class Form1 : Form
    {
        string namaStaff;

        public Form1()
        {
            InitializeComponent();
        }
        public void staffYangLoginSekarang(string namaStaff)
        {
            this.namaStaff = namaStaff;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label_NamaStaffBerjaga.Text = $"Hello, {namaStaff}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
