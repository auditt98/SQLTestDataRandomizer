using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace SQLTestDataGenerator
{
    public partial class DatabaseConnectForm : SfForm
    {
        private MainForm mainForm = null;
        public DatabaseConnectForm()
        {
            SetStyle();
            InitializeComponent();
        }

        public void SetStyle()
        {
            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.Font = this.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            
        }

        public DatabaseConnectForm(MetroForm form)
        {
            mainForm = form as MainForm;
            SetStyle();
            InitializeComponent();
        }

        private void dbms_mssql_button_Click(object sender, EventArgs e)
        {
            mainForm._configs.DBMS = (int)Enums.EnumDBMS.MSSQL;
        }

        private void dbms_oracle_button_Click(object sender, EventArgs e)
        {
            mainForm._configs.DBMS = (int)Enums.EnumDBMS.Oracle;
        }

        private void dbms_mysql_button_Click(object sender, EventArgs e)
        {
            mainForm._configs.DBMS = (int)Enums.EnumDBMS.MySQL;
        }

        private void dbms_sqlite_button_Click(object sender, EventArgs e)
        {
            mainForm._configs.DBMS = (int)Enums.EnumDBMS.SQLite;
        }

        private void dbms_postgresql_button_Click(object sender, EventArgs e)
        {
            mainForm._configs.DBMS = (int)Enums.EnumDBMS.PostgreSql;
        }

        private void databaseconnect_button_Click(object sender, EventArgs e)
        {
            bool isError = false;
            if(servername_textbox.Text.Length == 0)
            {
                server_textbox_errorProvider.SetError(servername_textbox, "This can not be blank.");
                isError = true;
            }
            if(databasename_textbox.Text.Length == 0)
            {
                database_name_errorProvider.SetError(databasename_textbox, "This can not be blank.");
                isError = true;

            }
            if(mainForm._configs.DBMS == 0)
            {
                isError = true;
                MessageBox.Show("Please choose a DBMS to connect to", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (!isError)
            {
                mainForm._configs.databaseName = databasename_textbox.Text;
                mainForm._configs.serverName = servername_textbox.Text;
                if(port_textbox.Text.Length == 0)
                {
                    mainForm._configs.port = 1433;
                }
                else
                {
                    mainForm._configs.port = int.Parse(port_textbox.Text);
                }
                if(username_textbox.Text.Length == 0)
                {
                    mainForm._configs.username = "";

                }
                else
                {
                    mainForm._configs.username = username_textbox.Text;
                }
                if(password_textbox.Text.Length == 0)
                {
                    mainForm._configs.password = "";
                }
                else
                {
                    mainForm._configs.username = password_textbox.Text;
                }
                mainForm._configs.IntegratedSecurity = integratedsecurity_checkbox.Checked;
                var cString = mainForm._configs.ConnectionStringBuilder();

                var _connection = new SqlConnection(cString);
                try
                {
                    _connection.Open();
                    string selectTable = @"
                        SELECT TABLE_NAME FROM information_schema.tables
                        where TABLE_TYPE = 'BASE TABLE';";
                    SqlCommand sqlCommand = new SqlCommand(selectTable, _connection);
                    using (SqlDataReader dr = sqlCommand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var table = new TableModel();
                            table.TABLE_NAME = dr["TABLE_NAME"].ToString();
                            mainForm._tables.Add(table);
                        }
                    }

                    foreach(var table in mainForm._tables)
                    {
                        string selectColumns = $@"
                         select COLUMN_NAME,IS_NULLABLE,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE, (select columnproperty(object_id('{table.TABLE_NAME}'), COLUMN_NAME ,'IsIdentity')) as IS_IDENTITY from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{table.TABLE_NAME}'";
                        sqlCommand = new SqlCommand(selectColumns, _connection);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var column = new ColumnModel();
                                column.COLUMN_NAME = dr["COLUMN_NAME"].ToString();
                                column.DATA_TYPE = dr["DATA_TYPE"].ToString();
                                column.IS_IDENTITY = int.Parse(dr["IS_IDENTITY"].ToString());
                                
                                if(dr["CHARACTER_MAXIMUM_LENGTH"].ToString().Length != 0)
                                {
                                    column.CHARACTER_MAXIMUM_LENGTH = dr["CHARACTER_MAXIMUM_LENGTH"].ToString();
                                }
                                else
                                {
                                    column.CHARACTER_MAXIMUM_LENGTH = "";
                                }
                                if(dr["IS_NULLABLE"].ToString() == "YES")
                                {
                                    column.IS_NULLABLE = true;
                                }
                                else
                                {
                                    column.IS_NULLABLE = false;
                                }
                                
                                if(dr["NUMERIC_PRECISION"].ToString().Length != 0)
                                {
                                    column.NUMERIC_PRECISION = dr["NUMERIC_PRECISION"].ToString();
                                }

                                if (dr["NUMERIC_SCALE"].ToString().Length != 0)
                                {
                                    column.NUMERIC_SCALE = dr["NUMERIC_SCALE"].ToString();
                                }

                                if (column.DATA_TYPE.ToLower() == "varchar" || column.DATA_TYPE.ToLower() == "nvarchar")
                                {
                                    if(column.CHARACTER_MAXIMUM_LENGTH == "-1")
                                    {
                                        column.Parameter = $@"@{column.COLUMN_NAME} {column.DATA_TYPE}(MAX)";
                                    }
                                    else
                                    {
                                        column.Parameter = $@"@{column.COLUMN_NAME} {column.DATA_TYPE}({column.CHARACTER_MAXIMUM_LENGTH})";
                                    }

                                }
                                else if(column.DATA_TYPE.ToLower() == "decimal" || column.DATA_TYPE.ToLower() == "numeric")
                                {
                                    column.Parameter = $@"@{column.COLUMN_NAME} {column.DATA_TYPE}({column.NUMERIC_PRECISION},{column.NUMERIC_SCALE})";
                                }
                                else
                                {
                                    column.Parameter = $@"@{column.COLUMN_NAME} {column.DATA_TYPE}";
                                }
                                column.Variable = $@"@{column.COLUMN_NAME}";
                                
                                table.Columns.Add(column);
                            }
                        }

                    }
                    mainForm.SetConnectionStatus(true);
                    MessageBox.Show("Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _connection.Close();
                    
                }
                catch
                {
                    throw;
                }
                this.Close();
            }
        }

        private void servername_textbox_TextChanged(object sender, EventArgs e)
        {
            server_textbox_errorProvider.Clear();
        }

        private void databasename_textbox_TextChanged(object sender, EventArgs e)
        {
            database_name_errorProvider.Clear();
        }

        private void port_textbox_TextChanged(object sender, EventArgs e)
        {
            port_ErrorProvider.Clear();
        }
    }
}
