namespace MySQLTest
{
    partial class Login
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
            this.TBIP = new System.Windows.Forms.TextBox();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPort = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBDB = new System.Windows.Forms.TextBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TBIP
            // 
            this.TBIP.Location = new System.Drawing.Point(90, 12);
            this.TBIP.Name = "TBIP";
            this.TBIP.Size = new System.Drawing.Size(100, 20);
            this.TBIP.TabIndex = 0;
            this.TBIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(90, 64);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(100, 20);
            this.TBUser.TabIndex = 1;
            this.TBUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBPort
            // 
            this.TBPort.Location = new System.Drawing.Point(90, 38);
            this.TBPort.Name = "TBPort";
            this.TBPort.Size = new System.Drawing.Size(100, 20);
            this.TBPort.TabIndex = 1;
            this.TBPort.Text = "3306";
            this.TBPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(90, 90);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(100, 20);
            this.TBPass.TabIndex = 2;
            this.TBPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // TBDB
            // 
            this.TBDB.Location = new System.Drawing.Point(90, 116);
            this.TBDB.Name = "TBDB";
            this.TBDB.Size = new System.Drawing.Size(100, 20);
            this.TBDB.TabIndex = 3;
            this.TBDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(90, 142);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(100, 23);
            this.BLogin.TabIndex = 4;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database:";
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(90, 171);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(100, 23);
            this.BCancel.TabIndex = 10;
            this.BCancel.Text = "Exit";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(222, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 186);
            this.listBox1.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 203);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.TBDB);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBPort);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.TBIP);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBIP;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox TBPort;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBDB;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.ListBox listBox1;
    }
}