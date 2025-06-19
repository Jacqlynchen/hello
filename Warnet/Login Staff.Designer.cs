namespace Warnet
{
    partial class Login_Staff
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
            this.label_NamaLogin = new System.Windows.Forms.Label();
            this.label_EmailLogin = new System.Windows.Forms.Label();
            this.tBox_InputNamaStaff = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label_MenujuTopUp = new System.Windows.Forms.Label();
            this.tBox_InputEmailStaff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_NamaLogin
            // 
            this.label_NamaLogin.AutoSize = true;
            this.label_NamaLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_NamaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NamaLogin.Location = new System.Drawing.Point(1019, 421);
            this.label_NamaLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NamaLogin.Name = "label_NamaLogin";
            this.label_NamaLogin.Size = new System.Drawing.Size(102, 32);
            this.label_NamaLogin.TabIndex = 1;
            this.label_NamaLogin.Text = "Nama:";
            // 
            // label_EmailLogin
            // 
            this.label_EmailLogin.AutoSize = true;
            this.label_EmailLogin.BackColor = System.Drawing.Color.Transparent;
            this.label_EmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmailLogin.Location = new System.Drawing.Point(1019, 527);
            this.label_EmailLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_EmailLogin.Name = "label_EmailLogin";
            this.label_EmailLogin.Size = new System.Drawing.Size(108, 32);
            this.label_EmailLogin.TabIndex = 2;
            this.label_EmailLogin.Text = "Email: ";
            // 
            // tBox_InputNamaStaff
            // 
            this.tBox_InputNamaStaff.Location = new System.Drawing.Point(1193, 410);
            this.tBox_InputNamaStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_InputNamaStaff.Multiline = true;
            this.tBox_InputNamaStaff.Name = "tBox_InputNamaStaff";
            this.tBox_InputNamaStaff.Size = new System.Drawing.Size(292, 59);
            this.tBox_InputNamaStaff.TabIndex = 3;
            this.tBox_InputNamaStaff.Text = "BOBBY SANTOSO";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Login.Location = new System.Drawing.Point(1292, 626);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(150, 55);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label_MenujuTopUp
            // 
            this.label_MenujuTopUp.AutoSize = true;
            this.label_MenujuTopUp.BackColor = System.Drawing.Color.Transparent;
            this.label_MenujuTopUp.Font = new System.Drawing.Font("Georgia", 10F);
            this.label_MenujuTopUp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_MenujuTopUp.Location = new System.Drawing.Point(1556, 1015);
            this.label_MenujuTopUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MenujuTopUp.Name = "label_MenujuTopUp";
            this.label_MenujuTopUp.Size = new System.Drawing.Size(176, 31);
            this.label_MenujuTopUp.TabIndex = 6;
            this.label_MenujuTopUp.Text = "Go to Top Up";
            // 
            // tBox_InputEmailStaff
            // 
            this.tBox_InputEmailStaff.Location = new System.Drawing.Point(1193, 509);
            this.tBox_InputEmailStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_InputEmailStaff.Multiline = true;
            this.tBox_InputEmailStaff.Name = "tBox_InputEmailStaff";
            this.tBox_InputEmailStaff.Size = new System.Drawing.Size(292, 59);
            this.tBox_InputEmailStaff.TabIndex = 8;
            this.tBox_InputEmailStaff.Text = "bsantoso@gmail.com";
            // 
            // Login_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::Warnet.Properties.Resources.Welcome_Back_Nama_Email_Login_Go_to_Top_up_Machine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.tBox_InputEmailStaff);
            this.Controls.Add(this.label_MenujuTopUp);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tBox_InputNamaStaff);
            this.Controls.Add(this.label_EmailLogin);
            this.Controls.Add(this.label_NamaLogin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login_Staff";
            this.Load += new System.EventHandler(this.Login_Staff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_NamaLogin;
        private System.Windows.Forms.Label label_EmailLogin;
        private System.Windows.Forms.TextBox tBox_InputNamaStaff;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label_MenujuTopUp;
        private System.Windows.Forms.TextBox tBox_InputEmailStaff;
    }
}