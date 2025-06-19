namespace Warnet
{
    partial class Member
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
            this.dgv_member = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.butt_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_searchby = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pb_profile = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_member
            // 
            this.dgv_member.AllowUserToAddRows = false;
            this.dgv_member.AllowUserToDeleteRows = false;
            this.dgv_member.AllowUserToResizeColumns = false;
            this.dgv_member.AllowUserToResizeRows = false;
            this.dgv_member.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_member.Location = new System.Drawing.Point(357, 63);
            this.dgv_member.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_member.Name = "dgv_member";
            this.dgv_member.ReadOnly = true;
            this.dgv_member.RowHeadersVisible = false;
            this.dgv_member.RowHeadersWidth = 82;
            this.dgv_member.RowTemplate.Height = 33;
            this.dgv_member.Size = new System.Drawing.Size(858, 556);
            this.dgv_member.TabIndex = 0;
            this.dgv_member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_member_CellClick);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Warnet.Properties.Resources.Screenshot_2024_06_07_235025;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.butt_reset);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.cb_searchby);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.tb_search);
            this.panel6.Location = new System.Drawing.Point(41, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 415);
            this.panel6.TabIndex = 77;
            // 
            // butt_reset
            // 
            this.butt_reset.BackColor = System.Drawing.Color.DarkOrchid;
            this.butt_reset.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butt_reset.Location = new System.Drawing.Point(95, 344);
            this.butt_reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butt_reset.Name = "butt_reset";
            this.butt_reset.Size = new System.Drawing.Size(75, 34);
            this.butt_reset.TabIndex = 76;
            this.butt_reset.Text = "Reset";
            this.butt_reset.UseVisualStyleBackColor = false;
            this.butt_reset.Click += new System.EventHandler(this.butt_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 111;
            this.label1.Text = "Search By";
            // 
            // cb_searchby
            // 
            this.cb_searchby.AutoCompleteCustomSource.AddRange(new string[] {
            "ID Kartu",
            "ID User",
            "Username",
            "Nama User"});
            this.cb_searchby.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_searchby.ForeColor = System.Drawing.Color.White;
            this.cb_searchby.FormattingEnabled = true;
            this.cb_searchby.Items.AddRange(new object[] {
            "ID Kartu",
            "ID User",
            "Username",
            "Nama User"});
            this.cb_searchby.Location = new System.Drawing.Point(49, 169);
            this.cb_searchby.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_searchby.Name = "cb_searchby";
            this.cb_searchby.Size = new System.Drawing.Size(157, 24);
            this.cb_searchby.TabIndex = 75;
            this.cb_searchby.SelectedIndexChanged += new System.EventHandler(this.cb_searchby_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.125F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 110;
            this.label3.Text = "S E A R C H";
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tb_search.ForeColor = System.Drawing.Color.White;
            this.tb_search.Location = new System.Drawing.Point(31, 74);
            this.tb_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(195, 26);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // pb_profile
            // 
            this.pb_profile.BackColor = System.Drawing.Color.White;
            this.pb_profile.Image = global::Warnet.Properties.Resources.Screenshot_2024_06_07_235918;
            this.pb_profile.Location = new System.Drawing.Point(63, 482);
            this.pb_profile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pb_profile.Name = "pb_profile";
            this.pb_profile.Size = new System.Drawing.Size(219, 125);
            this.pb_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_profile.TabIndex = 78;
            this.pb_profile.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Warnet.Properties.Resources.Screenshot_2024_06_07_142611;
            this.pictureBox10.Location = new System.Drawing.Point(-23, -32);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(1077, 651);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 73;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1170, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1263, 646);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pb_profile);
            this.Controls.Add(this.dgv_member);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_member;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ComboBox cb_searchby;
        private System.Windows.Forms.Button butt_reset;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_profile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}