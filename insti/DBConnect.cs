using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace insti
{
    class DBConnect
    {
        private MySqlConnection con;
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataSet ds;
        private String server, database, uid, password;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = Settings1.Default.server;
            database = Settings1.Default.database;
            uid = Settings1.Default.user;
            password = Settings1.Default.password;
            String connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";
            this.con = new MySqlConnection(connectionString);
        }

        private bool connectionOpen()
        {
            try
            {
                this.con.Open();
                return true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private bool connectionClose()
        {
            try
            {
                this.con.Close();
                return true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public DataSet Login(String username, String password)
        {
            String sql = "SELECT * FROM tblusers WHERE uname='" + username + "' and upassword='" + password + "';";
            ds = new DataSet();
            if(this.connectionOpen() == true)
            {
                adapter = new MySqlDataAdapter(sql, con);
                builder = new MySqlCommandBuilder(adapter);
                adapter.Fill(ds);
                this.connectionClose();
                return ds;
            }
            else
            {
                return ds;
            }
        }
    }
}
