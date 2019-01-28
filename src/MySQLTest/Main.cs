using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author:          Nac/Nalal/Host
 * Program Name:    DKPMan
 * License:         GPL-3
 * Init Date:       24/Jan/2019
 * Publish Date:    28/Jan/2019
*/

namespace MySQLTest
{
    public partial class Main : Form
    {
        //Init local datasources
        static DataTable DSource = new DataTable();
        public static DataTable DSend = new DataTable();
        public Main()
        {
            InitializeComponent();
            //Init login page
            LoginC();
        }
        //Check for close request or load DB data
        void LoginC()
        {
            Form log = new Login();
            log.ShowDialog();
            if (Login.loggedin == false)
            {
                Application.Exit();
            }
            else
            {
                LoadDB();
            }
        }
        //Get DB data and push to Datasource
        void LoadDB()
        {
            DSource = DBCall.GetTest();
            DGVTest.DataSource = null;
            DGVTest.DataSource = DSource;
            DGVTest.Columns[0].ReadOnly = true;
        }
        //Reload Datasource
        void RefreshDB()
        {
            DGVTest.DataSource = null;
            DGVTest.DataSource = DSource;
        }
        //Get only changes to database
        DataTable GetChanges()
        {
            DataTable changes = ((DataTable)DGVTest.DataSource).GetChanges();
            return changes;
        }
        //Enable editing of columns
        private void FuncEnable()
        {
            TBDKP.Enabled = true;
            RBAdd.Enabled = true;
            RBEdit.Enabled = true;
            RBSubtract.Enabled = true;
            BSubmit.Enabled = true;
        }
        //Disable editing of columns
        private void FuncDisable()
        {
            TBDKP.Enabled = false;
            RBAdd.Enabled = false;
            RBEdit.Enabled = false;
            RBSubtract.Enabled = false;
            BSubmit.Enabled = false;
        }
        //Reload data if row selection changes
        private void DGVTest_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVTest.SelectedRows.Count > 0)
            {
                FuncEnable();
                TBDKP.Text = DGVTest.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
        //Send data to datasource
        private void BSubmit_Click(object sender, EventArgs e)
        {
            if (TBDKP.Text != null && TBDKP.Text != "" && Err.IsAllDigits(TBDKP.Text))
            {
                int tableval = Convert.ToInt32(DGVTest.SelectedRows[0].Cells[2].Value);
                if (RBAdd.Checked)
                {
                    tableval += Convert.ToInt32(TBDKP.Text);
                    DGVTest.SelectedRows[0].Cells[2].Value = tableval;
                }
                if (RBEdit.Checked)
                {
                    DGVTest.SelectedRows[0].Cells[2].Value = Convert.ToInt32(TBDKP.Text);
                }
                if (RBSubtract.Checked)
                {
                    tableval -= Convert.ToInt32(TBDKP.Text);
                    DGVTest.SelectedRows[0].Cells[2].Value = tableval;
                }
                RefreshDB();
                DSend = GetChanges();
                DBCall.SetData();
                FuncDisable();
            }
            //Verify input value
            else if (!Err.IsAllDigits(TBDKP.Text) && TBDKP.Text != null && TBDKP.Text != "")
            {
                MessageBox.Show("You can only use nubers.","Input Error");
            }
            else if (TBDKP.Text == null || TBDKP.Text == "")
            {
                MessageBox.Show("Input cannot be blank", "Input Error");
            }
        }
        //Pull table data to text box
        private void RBEdit_CheckedChanged(object sender, EventArgs e)
        {
            TBDKP.Text = DGVTest.SelectedRows[0].Cells[2].Value.ToString();
        }
        //Reset text box data
        private void RBAdd_CheckedChanged(object sender, EventArgs e)
        {
            TBDKP.Text = "0";
        }
        //Reset text box data
        private void RBSubtract_CheckedChanged(object sender, EventArgs e)
        {
            TBDKP.Text = "0";
        }
    }
}
