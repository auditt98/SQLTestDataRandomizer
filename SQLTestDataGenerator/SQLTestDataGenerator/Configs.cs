using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTestDataGenerator
{
    public partial class Configs
    {
        public string username { get; set; }
        public string password { get; set; }
        public string serverName { get; set; }
        public string databaseName { get; set; }
        public int port { get; set; }
        public bool arithAbort { get; set; }
        public bool encrypt { get; set; }
        public bool IntegratedSecurity { get; set; }
        public int DBMS { get; set; }

        public Configs()
        {

        }

        /// <summary>
        /// Build a config object to connect to the database when needed, this object will be passed between forms.
        /// </summary>
        /// <param name="dbms">Type of Database to connect to, specified in Enums/DBMS</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <param name="servername">Name of the server</param>
        /// <param name="databasename">Name of the database</param>
        /// <param name="port">Port</param>
        /// <param name="IntegratedSecurity">Specify whether the connection is trusted or not. If set to true, username and password will be ignored</param>
        /// <param name="arithabort"></param>
        /// <param name="encrypt"></param>

        public Configs(int dbms, string username, string password, string servername, string databasename, int port, bool IntegratedSecurity = false , bool arithabort = true, bool encrypt = false)
        {
            this.DBMS = dbms;
            this.username = username;
            this.password = password;
            this.serverName = servername;
            this.databaseName = databasename;
            this.port = port;
            this.arithAbort = arithabort;
            this.encrypt = encrypt;
            this.IntegratedSecurity = IntegratedSecurity;
        }

        public string ConnectionStringBuilder()
        {
            var cnString = "";
            if (DBMS == (int)Enums.EnumDBMS.MSSQL)
            {
                cnString = $"Server={this.serverName};Database={this.databaseName};User Id={this.username};Password={this.password}; Trusted_Connection= { this.IntegratedSecurity}";
            }
            else if (DBMS == (int)Enums.EnumDBMS.MySQL)
            {
                

            }
            else if (DBMS == (int)Enums.EnumDBMS.Oracle)
            {
            

            }
            else if (DBMS == (int)Enums.EnumDBMS.PostgreSql)
            {
            

            }
            else if (DBMS == (int)Enums.EnumDBMS.SQLite)
            {
            

            }
            else
            {
            
            }
            return cnString;
        }

        public bool TestConnection(string connectionString)
        {
            if (DBMS == (int)Enums.EnumDBMS.MSSQL)
            {
                SqlConnection _connection = new SqlConnection(connectionString);
                try
                {
                    _connection.Open();
                    MessageBox.Show("Connected");
                    _connection.Close();
                    return true;
                }
                catch
                {
                    throw;
                }
            }
            else if (DBMS == (int)Enums.EnumDBMS.MySQL)
            {


            }
            else if (DBMS == (int)Enums.EnumDBMS.Oracle)
            {


            }
            else if (DBMS == (int)Enums.EnumDBMS.PostgreSql)
            {


            }
            else if (DBMS == (int)Enums.EnumDBMS.SQLite)
            {


            }
            else
            {

            }
            return false;

        }
    }
}
