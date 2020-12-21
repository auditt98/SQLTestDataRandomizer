namespace SQLTestDataGenerator
{
    partial class DatabaseConnectForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dbms_mssql_button = new Syncfusion.WinForms.Controls.SfButton();
            this.dbms_oracle_button = new Syncfusion.WinForms.Controls.SfButton();
            this.dbms_mysql_button = new Syncfusion.WinForms.Controls.SfButton();
            this.dbms_sqlite_button = new Syncfusion.WinForms.Controls.SfButton();
            this.dbms_postgresql_button = new Syncfusion.WinForms.Controls.SfButton();
            this.databaseconnect_button = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.integratedsecurity_checkbox = new System.Windows.Forms.CheckBox();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.password_textbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.username_textbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.port_textbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.databasename_textbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.servername_textbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.server_textbox_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.database_name_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.port_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.port_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasename_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servername_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.server_textbox_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_name_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.port_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dbms_mssql_button);
            this.splitContainer1.Panel1.Controls.Add(this.dbms_oracle_button);
            this.splitContainer1.Panel1.Controls.Add(this.dbms_mysql_button);
            this.splitContainer1.Panel1.Controls.Add(this.dbms_sqlite_button);
            this.splitContainer1.Panel1.Controls.Add(this.dbms_postgresql_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.databaseconnect_button);
            this.splitContainer1.Panel2.Controls.Add(this.autoLabel6);
            this.splitContainer1.Panel2.Controls.Add(this.integratedsecurity_checkbox);
            this.splitContainer1.Panel2.Controls.Add(this.autoLabel5);
            this.splitContainer1.Panel2.Controls.Add(this.autoLabel4);
            this.splitContainer1.Panel2.Controls.Add(this.autoLabel3);
            this.splitContainer1.Panel2.Controls.Add(this.autoLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.autoLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.password_textbox);
            this.splitContainer1.Panel2.Controls.Add(this.username_textbox);
            this.splitContainer1.Panel2.Controls.Add(this.port_textbox);
            this.splitContainer1.Panel2.Controls.Add(this.databasename_textbox);
            this.splitContainer1.Panel2.Controls.Add(this.servername_textbox);
            this.splitContainer1.Size = new System.Drawing.Size(825, 545);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // dbms_mssql_button
            // 
            this.dbms_mssql_button.AccessibleName = "Button";
            this.dbms_mssql_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.dbms_mssql_button.Location = new System.Drawing.Point(0, 0);
            this.dbms_mssql_button.Name = "dbms_mssql_button";
            this.gridLayout1.SetParticipateInLayout(this.dbms_mssql_button, true);
            this.dbms_mssql_button.Size = new System.Drawing.Size(214, 109);
            this.dbms_mssql_button.TabIndex = 0;
            this.dbms_mssql_button.Text = "MSSQL";
            this.dbms_mssql_button.Click += new System.EventHandler(this.dbms_mssql_button_Click);
            // 
            // dbms_oracle_button
            // 
            this.dbms_oracle_button.AccessibleName = "Button";
            this.dbms_oracle_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.dbms_oracle_button.Location = new System.Drawing.Point(0, 109);
            this.dbms_oracle_button.Name = "dbms_oracle_button";
            this.gridLayout1.SetParticipateInLayout(this.dbms_oracle_button, true);
            this.dbms_oracle_button.Size = new System.Drawing.Size(214, 109);
            this.dbms_oracle_button.TabIndex = 1;
            this.dbms_oracle_button.Text = "Oracle";
            this.dbms_oracle_button.Click += new System.EventHandler(this.dbms_oracle_button_Click);
            // 
            // dbms_mysql_button
            // 
            this.dbms_mysql_button.AccessibleName = "Button";
            this.dbms_mysql_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.dbms_mysql_button.Location = new System.Drawing.Point(0, 218);
            this.dbms_mysql_button.Name = "dbms_mysql_button";
            this.gridLayout1.SetParticipateInLayout(this.dbms_mysql_button, true);
            this.dbms_mysql_button.Size = new System.Drawing.Size(214, 109);
            this.dbms_mysql_button.TabIndex = 2;
            this.dbms_mysql_button.Text = "MySQL";
            this.dbms_mysql_button.Click += new System.EventHandler(this.dbms_mysql_button_Click);
            // 
            // dbms_sqlite_button
            // 
            this.dbms_sqlite_button.AccessibleName = "Button";
            this.dbms_sqlite_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.dbms_sqlite_button.Location = new System.Drawing.Point(0, 327);
            this.dbms_sqlite_button.Name = "dbms_sqlite_button";
            this.gridLayout1.SetParticipateInLayout(this.dbms_sqlite_button, true);
            this.dbms_sqlite_button.Size = new System.Drawing.Size(214, 109);
            this.dbms_sqlite_button.TabIndex = 3;
            this.dbms_sqlite_button.Text = "SQLite";
            this.dbms_sqlite_button.Click += new System.EventHandler(this.dbms_sqlite_button_Click);
            // 
            // dbms_postgresql_button
            // 
            this.dbms_postgresql_button.AccessibleName = "Button";
            this.dbms_postgresql_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.dbms_postgresql_button.Location = new System.Drawing.Point(0, 436);
            this.dbms_postgresql_button.Name = "dbms_postgresql_button";
            this.gridLayout1.SetParticipateInLayout(this.dbms_postgresql_button, true);
            this.dbms_postgresql_button.Size = new System.Drawing.Size(214, 109);
            this.dbms_postgresql_button.TabIndex = 4;
            this.dbms_postgresql_button.Text = "PostgreSql";
            this.dbms_postgresql_button.Click += new System.EventHandler(this.dbms_postgresql_button_Click);
            // 
            // databaseconnect_button
            // 
            this.databaseconnect_button.AccessibleName = "Button";
            this.databaseconnect_button.BackColor = System.Drawing.Color.LightGreen;
            this.databaseconnect_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseconnect_button.Location = new System.Drawing.Point(218, 446);
            this.databaseconnect_button.Name = "databaseconnect_button";
            this.databaseconnect_button.Size = new System.Drawing.Size(154, 50);
            this.databaseconnect_button.Style.BackColor = System.Drawing.Color.LightGreen;
            this.databaseconnect_button.TabIndex = 12;
            this.databaseconnect_button.Text = "Connect";
            this.databaseconnect_button.UseVisualStyleBackColor = false;
            this.databaseconnect_button.Click += new System.EventHandler(this.databaseconnect_button_Click);
            // 
            // autoLabel6
            // 
            this.autoLabel6.DX = -165;
            this.autoLabel6.LabeledControl = this.integratedsecurity_checkbox;
            this.autoLabel6.Location = new System.Drawing.Point(36, 405);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(161, 17);
            this.autoLabel6.TabIndex = 11;
            this.autoLabel6.Text = "Use Intergrated Security";
            // 
            // integratedsecurity_checkbox
            // 
            this.integratedsecurity_checkbox.AutoSize = true;
            this.integratedsecurity_checkbox.Location = new System.Drawing.Point(201, 405);
            this.integratedsecurity_checkbox.Name = "integratedsecurity_checkbox";
            this.integratedsecurity_checkbox.Size = new System.Drawing.Size(18, 17);
            this.integratedsecurity_checkbox.TabIndex = 10;
            this.integratedsecurity_checkbox.UseVisualStyleBackColor = true;
            // 
            // autoLabel5
            // 
            this.autoLabel5.DX = -73;
            this.autoLabel5.DY = 8;
            this.autoLabel5.LabeledControl = this.password_textbox;
            this.autoLabel5.Location = new System.Drawing.Point(128, 344);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(69, 17);
            this.autoLabel5.TabIndex = 9;
            this.autoLabel5.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.BeforeTouchSize = new System.Drawing.Size(338, 34);
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.password_textbox.Location = new System.Drawing.Point(201, 336);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '●';
            this.password_textbox.Size = new System.Drawing.Size(338, 34);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // autoLabel4
            // 
            this.autoLabel4.DX = -77;
            this.autoLabel4.DY = 8;
            this.autoLabel4.LabeledControl = this.username_textbox;
            this.autoLabel4.Location = new System.Drawing.Point(124, 277);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(73, 17);
            this.autoLabel4.TabIndex = 8;
            this.autoLabel4.Text = "Username";
            // 
            // username_textbox
            // 
            this.username_textbox.BeforeTouchSize = new System.Drawing.Size(338, 34);
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.username_textbox.Location = new System.Drawing.Point(201, 269);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(338, 34);
            this.username_textbox.TabIndex = 3;
            // 
            // autoLabel3
            // 
            this.autoLabel3.DX = -38;
            this.autoLabel3.DY = 8;
            this.autoLabel3.LabeledControl = this.port_textbox;
            this.autoLabel3.Location = new System.Drawing.Point(163, 210);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(34, 17);
            this.autoLabel3.TabIndex = 7;
            this.autoLabel3.Text = "Port";
            // 
            // port_textbox
            // 
            this.port_textbox.BeforeTouchSize = new System.Drawing.Size(338, 34);
            this.port_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.port_textbox.Location = new System.Drawing.Point(201, 202);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(338, 34);
            this.port_textbox.TabIndex = 2;
            this.port_textbox.TextChanged += new System.EventHandler(this.port_textbox_TextChanged);
            // 
            // autoLabel2
            // 
            this.autoLabel2.DX = -114;
            this.autoLabel2.DY = 8;
            this.autoLabel2.LabeledControl = this.databasename_textbox;
            this.autoLabel2.Location = new System.Drawing.Point(87, 142);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(110, 17);
            this.autoLabel2.TabIndex = 6;
            this.autoLabel2.Text = "Database Name";
            // 
            // databasename_textbox
            // 
            this.databasename_textbox.BeforeTouchSize = new System.Drawing.Size(338, 34);
            this.databasename_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.databasename_textbox.Location = new System.Drawing.Point(201, 134);
            this.databasename_textbox.Name = "databasename_textbox";
            this.databasename_textbox.Size = new System.Drawing.Size(338, 34);
            this.databasename_textbox.TabIndex = 1;
            this.databasename_textbox.TextChanged += new System.EventHandler(this.databasename_textbox_TextChanged);
            // 
            // autoLabel1
            // 
            this.autoLabel1.DX = -137;
            this.autoLabel1.DY = 8;
            this.autoLabel1.LabeledControl = this.servername_textbox;
            this.autoLabel1.Location = new System.Drawing.Point(64, 76);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(133, 17);
            this.autoLabel1.TabIndex = 5;
            this.autoLabel1.Text = "Server/Data Source";
            // 
            // servername_textbox
            // 
            this.servername_textbox.BeforeTouchSize = new System.Drawing.Size(338, 34);
            this.servername_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.servername_textbox.Location = new System.Drawing.Point(201, 68);
            this.servername_textbox.Name = "servername_textbox";
            this.servername_textbox.Size = new System.Drawing.Size(338, 34);
            this.servername_textbox.TabIndex = 0;
            this.servername_textbox.TextChanged += new System.EventHandler(this.servername_textbox_TextChanged);
            // 
            // gridLayout1
            // 
            this.gridLayout1.Columns = 1;
            this.gridLayout1.ContainerControl = this.splitContainer1.Panel1;
            this.gridLayout1.Rows = 5;
            // 
            // server_textbox_errorProvider
            // 
            this.server_textbox_errorProvider.ContainerControl = this;
            // 
            // database_name_errorProvider
            // 
            this.database_name_errorProvider.ContainerControl = this;
            // 
            // port_ErrorProvider
            // 
            this.port_ErrorProvider.ContainerControl = this;
            // 
            // DatabaseConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 549);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(845, 588);
            this.MinimumSize = new System.Drawing.Size(845, 588);
            this.Name = "DatabaseConnectForm";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "DatabaseConnectForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.password_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.port_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasename_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servername_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.server_textbox_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_name_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.port_ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Syncfusion.WinForms.Controls.SfButton dbms_mssql_button;
        private Syncfusion.WinForms.Controls.SfButton dbms_oracle_button;
        private Syncfusion.WinForms.Controls.SfButton dbms_mysql_button;
        private Syncfusion.WinForms.Controls.SfButton dbms_sqlite_button;
        private Syncfusion.WinForms.Controls.SfButton dbms_postgresql_button;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt password_textbox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt username_textbox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt port_textbox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt databasename_textbox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt servername_textbox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private System.Windows.Forms.CheckBox integratedsecurity_checkbox;
        private Syncfusion.WinForms.Controls.SfButton databaseconnect_button;
        private System.Windows.Forms.ErrorProvider server_textbox_errorProvider;
        private System.Windows.Forms.ErrorProvider database_name_errorProvider;
        private System.Windows.Forms.ErrorProvider port_ErrorProvider;
    }
}