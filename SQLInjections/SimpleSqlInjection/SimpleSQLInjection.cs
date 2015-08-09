using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct SqlConnection
        {
            public string server_address, username, password, database_name, command;
            public MySqlConnection server_connection;
            public MySqlCommand sql_command;
            public MySqlDataReader sql_reader;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cd;
            int i = 0;
            /*////////////////////*/
            /* Set connection parameters */
            /* cd.command is the databse request
            /* cs is the connection string with the user's information*/
            /*////////////////////*/
            cd.command = @"SELECT * FROM'" + database.Text + "'"+" WHERE Username='" + username.Text + "'" + " AND Password='" + password.Text + "'";
            string cs = @"server=" + server_address.Text + ";Username=" + username.Text + ";Password=" + password.Text + ";database=" + database.Text;
            /*////////////////////*/
            /* Create Connection  */
            /*                    */
            /*////////////////////*/
            MessageBox.Show(cd.command);
            cd.server_connection = new MySqlConnection(cs);
            cd.server_connection.Open();
            /*////////////////////*/
            /* Create Command     */
            /* structure          */
            /*                    */
            /*////////////////////*/
            cd.sql_command = new MySqlCommand();
            cd.sql_command.Connection = cd.server_connection;
            cd.sql_command.CommandText = cd.command;
            cd.sql_reader = cd.sql_command.ExecuteReader();
            /*////////////////////*/
            /* Get data back      */
            /*                    */
            /*                    */
            /*////////////////////*/
            while (cd.sql_reader.Read())
            {
                MessageBox.Show("Server Message: "+cd.sql_reader.GetString(i));
            }

            cd.sql_reader.Close();
            cd.server_connection.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
