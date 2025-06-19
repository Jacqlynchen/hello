namespace Warnet
{
    partial class Pemesanan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_totalsnack = new System.Windows.Forms.Label();
            this.dgv_cartsnack = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_bulantahun = new System.Windows.Forms.Label();
            this.label_jam = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_hari = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_komputer = new System.Windows.Forms.ComboBox();
            this.cb_jam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butt_member = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_idkartu = new System.Windows.Forms.TextBox();
            this.tb_namaorang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butt_back = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_totalsnack = new System.Windows.Forms.TextBox();
            this.butt_delsnack = new System.Windows.Forms.Button();
            this.add_snack = new System.Windows.Forms.Button();
            this.butt_nota = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.cb_consum = new System.Windows.Forms.ComboBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartsnack)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lb_total);
            this.panel2.Controls.Add(this.lb_totalsnack);
            this.panel2.Controls.Add(this.dgv_cartsnack);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label_bulantahun);
            this.panel2.Controls.Add(this.label_jam);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.butt_back);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tb_totalsnack);
            this.panel2.Controls.Add(this.butt_delsnack);
            this.panel2.Controls.Add(this.add_snack);
            this.panel2.Controls.Add(this.butt_nota);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.qty);
            this.panel2.Controls.Add(this.cb_consum);
            this.panel2.Controls.Add(this.tb_total);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 647);
            this.panel2.TabIndex = 7;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.lb_total.Location = new System.Drawing.Point(943, 506);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(52, 16);
            this.lb_total.TabIndex = 48;
            this.lb_total.Text = "Rp 0.00";
            // 
            // lb_totalsnack
            // 
            this.lb_totalsnack.AutoSize = true;
            this.lb_totalsnack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.lb_totalsnack.Location = new System.Drawing.Point(943, 465);
            this.lb_totalsnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_totalsnack.Name = "lb_totalsnack";
            this.lb_totalsnack.Size = new System.Drawing.Size(52, 16);
            this.lb_totalsnack.TabIndex = 47;
            this.lb_totalsnack.Text = "Rp 0.00";
            // 
            // dgv_cartsnack
            // 
            this.dgv_cartsnack.AllowUserToAddRows = false;
            this.dgv_cartsnack.AllowUserToDeleteRows = false;
            this.dgv_cartsnack.AllowUserToResizeColumns = false;
            this.dgv_cartsnack.AllowUserToResizeRows = false;
            this.dgv_cartsnack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cartsnack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cartsnack.Location = new System.Drawing.Point(601, 276);
            this.dgv_cartsnack.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_cartsnack.Name = "dgv_cartsnack";
            this.dgv_cartsnack.ReadOnly = true;
            this.dgv_cartsnack.RowHeadersVisible = false;
            this.dgv_cartsnack.RowHeadersWidth = 82;
            this.dgv_cartsnack.RowTemplate.Height = 33;
            this.dgv_cartsnack.Size = new System.Drawing.Size(559, 163);
            this.dgv_cartsnack.TabIndex = 46;
            this.dgv_cartsnack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cartsnack_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(799, 458);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "T O T A L";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BackgroundImage = global::Warnet.Properties.Resources.Screenshot_2024_06_07_230848;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(593, 458);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 161);
            this.panel6.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BackgroundImage = global::Warnet.Properties.Resources.Screenshot_2024_06_07_224845;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(434, 17);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(429, 51);
            this.panel5.TabIndex = 44;
            // 
            // label_bulantahun
            // 
            this.label_bulantahun.AutoSize = true;
            this.label_bulantahun.BackColor = System.Drawing.Color.Transparent;
            this.label_bulantahun.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bulantahun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(16)))), ((int)(((byte)(55)))));
            this.label_bulantahun.Location = new System.Drawing.Point(1048, 105);
            this.label_bulantahun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bulantahun.Name = "label_bulantahun";
            this.label_bulantahun.Size = new System.Drawing.Size(85, 23);
            this.label_bulantahun.TabIndex = 7;
            this.label_bulantahun.Text = "Mei 2024";
            // 
            // label_jam
            // 
            this.label_jam.AutoSize = true;
            this.label_jam.BackColor = System.Drawing.Color.White;
            this.label_jam.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(16)))), ((int)(((byte)(55)))));
            this.label_jam.Location = new System.Drawing.Point(1055, 242);
            this.label_jam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_jam.Name = "label_jam";
            this.label_jam.Size = new System.Drawing.Size(80, 23);
            this.label_jam.TabIndex = 27;
            this.label_jam.Text = "10:10:10";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BackgroundImage = global::Warnet.Properties.Resources.Screenshot_2024_06_07_222220;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label_hari);
            this.panel4.Controls.Add(this.label_day);
            this.panel4.Location = new System.Drawing.Point(1051, 131);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(88, 109);
            this.panel4.TabIndex = 44;
            // 
            // label_hari
            // 
            this.label_hari.AutoSize = true;
            this.label_hari.BackColor = System.Drawing.Color.Transparent;
            this.label_hari.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(16)))), ((int)(((byte)(55)))));
            this.label_hari.Location = new System.Drawing.Point(18, 19);
            this.label_hari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hari.Name = "label_hari";
            this.label_hari.Size = new System.Drawing.Size(46, 23);
            this.label_hari.TabIndex = 33;
            this.label_hari.Text = "Mon";
            this.label_hari.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.BackColor = System.Drawing.Color.Transparent;
            this.label_day.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(16)))), ((int)(((byte)(55)))));
            this.label_day.Location = new System.Drawing.Point(27, 60);
            this.label_day.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(30, 23);
            this.label_day.TabIndex = 32;
            this.label_day.Text = "00";
            this.label_day.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BackgroundImage = global::Warnet.Properties.Resources.Screenshot_2024_06_07_214912;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.cb_komputer);
            this.panel3.Controls.Add(this.cb_jam);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(111, 360);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 181);
            this.panel3.TabIndex = 44;
            // 
            // cb_komputer
            // 
            this.cb_komputer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_komputer.FormattingEnabled = true;
            this.cb_komputer.Location = new System.Drawing.Point(132, 80);
            this.cb_komputer.Margin = new System.Windows.Forms.Padding(2);
            this.cb_komputer.Name = "cb_komputer";
            this.cb_komputer.Size = new System.Drawing.Size(237, 25);
            this.cb_komputer.TabIndex = 1;
            this.cb_komputer.SelectedIndexChanged += new System.EventHandler(this.cb_komputer_SelectedIndexChanged);
            // 
            // cb_jam
            // 
            this.cb_jam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_jam.FormattingEnabled = true;
            this.cb_jam.Items.AddRange(new object[] {
            "1 jam",
            "2 jam",
            "3 jam",
            "4 jam",
            "5 jam",
            "6 jam",
            "7 jam",
            "8 jam"});
            this.cb_jam.Location = new System.Drawing.Point(132, 127);
            this.cb_jam.Margin = new System.Windows.Forms.Padding(2);
            this.cb_jam.Name = "cb_jam";
            this.cb_jam.Size = new System.Drawing.Size(237, 25);
            this.cb_jam.TabIndex = 2;
            this.cb_jam.SelectedIndexChanged += new System.EventHandler(this.cb_jam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(33, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 27);
            this.label10.TabIndex = 44;
            this.label10.Text = "Computer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = global::Warnet.Properties.Resources.Screenshot_2024_06_07_214912;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.butt_member);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.tb_idkartu);
            this.panel1.Controls.Add(this.tb_namaorang);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(111, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 236);
            this.panel1.TabIndex = 35;
            // 
            // butt_member
            // 
            this.butt_member.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butt_member.BackgroundImage = global::Warnet.Properties.Resources.Screenshot_2024_06_07_213541;
            this.butt_member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butt_member.Location = new System.Drawing.Point(153, 19);
            this.butt_member.Margin = new System.Windows.Forms.Padding(2);
            this.butt_member.Name = "butt_member";
            this.butt_member.Size = new System.Drawing.Size(38, 32);
            this.butt_member.TabIndex = 32;
            this.butt_member.UseVisualStyleBackColor = false;
            this.butt_member.Click += new System.EventHandler(this.butt_member_Click);
            // 
            // tb_username
            // 
            this.tb_username.Enabled = false;
            this.tb_username.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(127, 118);
            this.tb_username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(255, 28);
            this.tb_username.TabIndex = 33;
            // 
            // tb_idkartu
            // 
            this.tb_idkartu.Enabled = false;
            this.tb_idkartu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idkartu.Location = new System.Drawing.Point(127, 168);
            this.tb_idkartu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_idkartu.Multiline = true;
            this.tb_idkartu.Name = "tb_idkartu";
            this.tb_idkartu.Size = new System.Drawing.Size(255, 29);
            this.tb_idkartu.TabIndex = 34;
            // 
            // tb_namaorang
            // 
            this.tb_namaorang.Enabled = false;
            this.tb_namaorang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namaorang.Location = new System.Drawing.Point(127, 71);
            this.tb_namaorang.Margin = new System.Windows.Forms.Padding(2);
            this.tb_namaorang.Multiline = true;
            this.tb_namaorang.Name = "tb_namaorang";
            this.tb_namaorang.Size = new System.Drawing.Size(253, 25);
            this.tb_namaorang.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(29, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Search Member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(29, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(31, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "ID Kartu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(31, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nama User";
            // 
            // butt_back
            // 
            this.butt_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.butt_back.Location = new System.Drawing.Point(114, 558);
            this.butt_back.Margin = new System.Windows.Forms.Padding(2);
            this.butt_back.Name = "butt_back";
            this.butt_back.Size = new System.Drawing.Size(99, 35);
            this.butt_back.TabIndex = 0;
            this.butt_back.Text = "B A C K";
            this.butt_back.UseVisualStyleBackColor = false;
            this.butt_back.Click += new System.EventHandler(this.butt_back_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(16)))), ((int)(((byte)(55)))));
            this.label11.Location = new System.Drawing.Point(623, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 27);
            this.label11.TabIndex = 45;
            this.label11.Text = "Consume";
            // 
            // tb_totalsnack
            // 
            this.tb_totalsnack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.tb_totalsnack.Enabled = false;
            this.tb_totalsnack.ForeColor = System.Drawing.Color.White;
            this.tb_totalsnack.Location = new System.Drawing.Point(934, 458);
            this.tb_totalsnack.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalsnack.Multiline = true;
            this.tb_totalsnack.Name = "tb_totalsnack";
            this.tb_totalsnack.Size = new System.Drawing.Size(227, 35);
            this.tb_totalsnack.TabIndex = 39;
            // 
            // butt_delsnack
            // 
            this.butt_delsnack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.butt_delsnack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_delsnack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butt_delsnack.Location = new System.Drawing.Point(840, 228);
            this.butt_delsnack.Margin = new System.Windows.Forms.Padding(2);
            this.butt_delsnack.Name = "butt_delsnack";
            this.butt_delsnack.Size = new System.Drawing.Size(131, 29);
            this.butt_delsnack.TabIndex = 38;
            this.butt_delsnack.Text = "Delete Snack";
            this.butt_delsnack.UseVisualStyleBackColor = false;
            this.butt_delsnack.Click += new System.EventHandler(this.butt_delsnack_Click);
            // 
            // add_snack
            // 
            this.add_snack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.add_snack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_snack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_snack.Location = new System.Drawing.Point(708, 228);
            this.add_snack.Margin = new System.Windows.Forms.Padding(2);
            this.add_snack.Name = "add_snack";
            this.add_snack.Size = new System.Drawing.Size(128, 29);
            this.add_snack.TabIndex = 36;
            this.add_snack.Text = "Add Snack";
            this.add_snack.UseVisualStyleBackColor = false;
            this.add_snack.Click += new System.EventHandler(this.add_snack_Click);
            // 
            // butt_nota
            // 
            this.butt_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.butt_nota.ForeColor = System.Drawing.Color.White;
            this.butt_nota.Location = new System.Drawing.Point(992, 544);
            this.butt_nota.Margin = new System.Windows.Forms.Padding(2);
            this.butt_nota.Name = "butt_nota";
            this.butt_nota.Size = new System.Drawing.Size(105, 28);
            this.butt_nota.TabIndex = 31;
            this.butt_nota.Text = "Order";
            this.butt_nota.UseVisualStyleBackColor = false;
            this.butt_nota.Click += new System.EventHandler(this.butt_nota_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(16)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(630, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(16)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(630, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Consum";
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.qty.ForeColor = System.Drawing.Color.White;
            this.qty.Location = new System.Drawing.Point(708, 195);
            this.qty.Margin = new System.Windows.Forms.Padding(2);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(264, 22);
            this.qty.TabIndex = 10;
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_KeyPress);
            // 
            // cb_consum
            // 
            this.cb_consum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_consum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_consum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.cb_consum.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_consum.FormattingEnabled = true;
            this.cb_consum.Location = new System.Drawing.Point(708, 145);
            this.cb_consum.Margin = new System.Windows.Forms.Padding(2);
            this.cb_consum.Name = "cb_consum";
            this.cb_consum.Size = new System.Drawing.Size(264, 24);
            this.cb_consum.TabIndex = 9;
            // 
            // tb_total
            // 
            this.tb_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(46)))));
            this.tb_total.Enabled = false;
            this.tb_total.ForeColor = System.Drawing.Color.White;
            this.tb_total.Location = new System.Drawing.Point(934, 497);
            this.tb_total.Margin = new System.Windows.Forms.Padding(2);
            this.tb_total.Multiline = true;
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(227, 37);
            this.tb_total.TabIndex = 6;
            // 
            // Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1263, 646);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pemesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Pemesanan";
            this.Load += new System.EventHandler(this.Pemesanan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartsnack)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_back;
        private System.Windows.Forms.ComboBox cb_komputer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_jam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.ComboBox cb_consum;
        private System.Windows.Forms.Label label_bulantahun;
        private System.Windows.Forms.Label label_hari;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button butt_nota;
        private System.Windows.Forms.Button butt_member;
        private System.Windows.Forms.TextBox tb_namaorang;
        private System.Windows.Forms.TextBox tb_idkartu;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button add_snack;
        private System.Windows.Forms.Button butt_delsnack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_jam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv_cartsnack;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_totalsnack;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_totalsnack;
    }
}