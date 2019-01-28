using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MySQLTest
{
    class DBCall
    {
        public static bool logres = true;
        static MySqlConnectionStringBuilder mysqlcon = new MySqlConnectionStringBuilder();
        //Test connection
        public static void InitMySQL(string IP, uint port, string user, string pass, string DB)
        {
            mysqlcon.Server = IP;
            mysqlcon.Port = port;
            mysqlcon.UserID = user;
            mysqlcon.Password = pass;
            mysqlcon.Database = DB;
            using (MySqlConnection conn = new MySqlConnection(mysqlcon.ConnectionString))
            {
                try
                {
                    conn.Open();
                    conn.Close();
                    logres = true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            logres = false;
                            MessageBox.Show("Cannot connect to server. Contact administrator");
                            break;
                        case 1045:
                            logres = false;
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                        default:
                            logres = false;
                            MessageBox.Show(ex.Message);
                            break;
                    }
                }
            }
        }
        //Load data from DB
        public static DataTable GetTest()
        {
            DataTable DT = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(mysqlcon.ConnectionString))
            {
                try 
{
                    string query = "SELECT * FROM testTB";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(DT);
                    conn.Close();
                    da.Dispose();
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                    }
                }
            }
            return DT;
        }
        //Push only changes to the DB if there are any
        public static void SetData()
        {
            DataTable changes = Main.DSend;
            if (changes != null)
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon.ConnectionString))
                {
                    MySqlDataAdapter ms = new MySqlDataAdapter("select * from testTB", conn);
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(ms);
                    ms.UpdateCommand = mcb.GetUpdateCommand();
                    ms.Update(changes);
                    ((DataTable)changes).AcceptChanges();
                }
            }
        }
    }
}
