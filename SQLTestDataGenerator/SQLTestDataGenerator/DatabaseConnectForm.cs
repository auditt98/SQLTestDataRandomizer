using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Configs _configs = null;
        public DatabaseConnectForm()
        {
            InitializeComponent();

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
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        }

        public DatabaseConnectForm(MetroForm form)
        {
            mainForm = form as MainForm;
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
    }
}
