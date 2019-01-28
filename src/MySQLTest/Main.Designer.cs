namespace MySQLTest
{
    partial class Main
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
            this.DGVTest = new System.Windows.Forms.DataGridView();
            this.BSubmit = new System.Windows.Forms.Button();
            this.TBDKP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBEdit = new System.Windows.Forms.RadioButton();
            this.RBAdd = new System.Windows.Forms.RadioButton();
            this.RBSubtract = new System.Windows.Forms.RadioButton();
            this.BLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTest)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTest
            // 
            this.DGVTest.AllowUserToAddRows = false;
            this.DGVTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVTest.Location = new System.Drawing.Point(0, 0);
            this.DGVTest.MultiSelect = false;
            this.DGVTest.Name = "DGVTest";
            this.DGVTest.Size = new System.Drawing.Size(421, 258);
            this.DGVTest.TabIndex = 0;
            this.DGVTest.SelectionChanged += new System.EventHandler(this.DGVTest_SelectionChanged);
            // 
            // BSubmit
            // 
            this.BSubmit.Enabled = false;
            this.BSubmit.Location = new System.Drawing.Point(15, 302);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(100, 23);
            this.BSubmit.TabIndex = 1;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // TBDKP
            // 
            this.TBDKP.Enabled = false;
            this.TBDKP.Location = new System.Drawing.Point(15, 276);
            this.TBDKP.Name = "TBDKP";
            this.TBDKP.Size = new System.Drawing.Size(100, 20);
            this.TBDKP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DKP:";
            // 
            // RBEdit
            // 
            this.RBEdit.AutoSize = true;
            this.RBEdit.Checked = true;
            this.RBEdit.Enabled = false;
            this.RBEdit.Location = new System.Drawing.Point(121, 277);
            this.RBEdit.Name = "RBEdit";
            this.RBEdit.Size = new System.Drawing.Size(43, 17);
            this.RBEdit.TabIndex = 4;
            this.RBEdit.TabStop = true;
            this.RBEdit.Text = "Edit";
            this.RBEdit.UseVisualStyleBackColor = true;
            this.RBEdit.CheckedChanged += new System.EventHandler(this.RBEdit_CheckedChanged);
            // 
            // RBAdd
            // 
            this.RBAdd.AutoSize = true;
            this.RBAdd.Enabled = false;
            this.RBAdd.Location = new System.Drawing.Point(121, 300);
            this.RBAdd.Name = "RBAdd";
            this.RBAdd.Size = new System.Drawing.Size(44, 17);
            this.RBAdd.TabIndex = 5;
            this.RBAdd.TabStop = true;
            this.RBAdd.Text = "Add";
            this.RBAdd.UseVisualStyleBackColor = true;
            this.RBAdd.CheckedChanged += new System.EventHandler(this.RBAdd_CheckedChanged);
            // 
            // RBSubtract
            // 
            this.RBSubtract.AutoSize = true;
            this.RBSubtract.Enabled = false;
            this.RBSubtract.Location = new System.Drawing.Point(121, 323);
            this.RBSubtract.Name = "RBSubtract";
            this.RBSubtract.Size = new System.Drawing.Size(65, 17);
            this.RBSubtract.TabIndex = 6;
            this.RBSubtract.TabStop = true;
            this.RBSubtract.Text = "Subtract";
            this.RBSubtract.UseVisualStyleBackColor = true;
            this.RBSubtract.CheckedChanged += new System.EventHandler(this.RBSubtract_CheckedChanged);
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(15, 357);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(100, 23);
            this.BLogin.TabIndex = 7;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 392);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.RBSubtract);
            this.Controls.Add(this.RBAdd);
            this.Controls.Add(this.RBEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDKP);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.DGVTest);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTest;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.TextBox TBDKP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBEdit;
        private System.Windows.Forms.RadioButton RBAdd;
        private System.Windows.Forms.RadioButton RBSubtract;
        private System.Windows.Forms.Button BLogin;
    }
}

