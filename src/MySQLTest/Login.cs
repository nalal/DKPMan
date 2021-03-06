﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLTest
{
    public partial class Login : Form
    {
        //Init close var
        public static bool loggedin = false;
        public Login()
        {
            InitializeComponent();
        }
        //Check input and test connection
        private void BLogin_Click(object sender, EventArgs e)
        {
            if (Err.IsAllDigits(TBPort.Text))
            {
                DBCall.InitMySQL(TBIP.Text, Convert.ToUInt32(TBPort.Text), TBUser.Text, TBPass.Text, TBDB.Text);
                if (DBCall.logres)
                {
                    loggedin = true;
                    Close();
                }
            }
        }
        //Pass close var to main and close application
        private void BCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
