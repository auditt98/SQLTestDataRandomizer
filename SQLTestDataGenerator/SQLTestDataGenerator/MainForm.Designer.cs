namespace SQLTestDataGenerator
{
    partial class MainForm
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
            this.connect_database_button = new Syncfusion.WinForms.Controls.SfButton();
            this.gen_data_db_button = new Syncfusion.WinForms.Controls.SfButton();
            this.gen_proc_Button = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton5 = new Syncfusion.WinForms.Controls.SfButton();
            this.settings_Button = new Syncfusion.WinForms.Controls.SfButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.connection_status_label = new System.Windows.Forms.Label();
            this.connection_status_autoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dbms_name_autolabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dbms_name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.database_name_autolabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.database_name_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username_label = new System.Windows.Forms.Label();
            this.username_autolabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.gridLayout2 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.connect_database_button);
            this.splitContainer1.Panel1.Controls.Add(this.gen_data_db_button);
            this.splitContainer1.Panel1.Controls.Add(this.gen_proc_Button);
            this.splitContainer1.Panel1.Controls.Add(this.sfButton5);
            this.splitContainer1.Panel1.Controls.Add(this.settings_Button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 571);
            this.splitContainer1.SplitterDistance = 829;
            this.splitContainer1.TabIndex = 0;
            // 
            // connect_database_button
            // 
            this.connect_database_button.AccessibleName = "Button";
            this.connect_database_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(210)))), ((int)(((byte)(202)))));
            this.connect_database_button.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.connect_database_button.ForeColor = System.Drawing.Color.Black;
            this.connect_database_button.Location = new System.Drawing.Point(1, 1);
            this.connect_database_button.Name = "connect_database_button";
            this.gridLayout1.SetParticipateInLayout(this.connect_database_button, true);
            this.connect_database_button.Size = new System.Drawing.Size(276, 285);
            this.connect_database_button.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(210)))), ((int)(((byte)(202)))));
            this.connect_database_button.Style.ForeColor = System.Drawing.Color.Black;
            this.connect_database_button.TabIndex = 0;
            this.connect_database_button.Text = "Connect";
            this.connect_database_button.UseVisualStyleBackColor = false;
            this.connect_database_button.Click += new System.EventHandler(this.connect_database_button_Click);
            // 
            // gen_data_db_button
            // 
            this.gen_data_db_button.AccessibleName = "Button";
            this.gen_data_db_button.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gen_data_db_button.Location = new System.Drawing.Point(277, 1);
            this.gen_data_db_button.Name = "gen_data_db_button";
            this.gridLayout1.SetParticipateInLayout(this.gen_data_db_button, true);
            this.gen_data_db_button.Size = new System.Drawing.Size(276, 285);
            this.gen_data_db_button.TabIndex = 1;
            this.gen_data_db_button.Text = "Generate Data";
            this.gen_data_db_button.Click += new System.EventHandler(this.gen_data_db_button_Click);
            // 
            // gen_proc_Button
            // 
            this.gen_proc_Button.AccessibleName = "Button";
            this.gen_proc_Button.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gen_proc_Button.Location = new System.Drawing.Point(553, 1);
            this.gridLayout1.SetMinimumSize(this.gen_proc_Button, new System.Drawing.Size(276, 285));
            this.gen_proc_Button.Name = "gen_proc_Button";
            this.gridLayout1.SetParticipateInLayout(this.gen_proc_Button, true);
            this.gridLayout1.SetPreferredSize(this.gen_proc_Button, new System.Drawing.Size(276, 285));
            this.gen_proc_Button.Size = new System.Drawing.Size(276, 285);
            this.gen_proc_Button.TabIndex = 2;
            this.gen_proc_Button.Text = "Generate Procedure";
            this.gen_proc_Button.Click += new System.EventHandler(this.gen_proc_Button_Click);
            // 
            // sfButton5
            // 
            this.sfButton5.AccessibleName = "Button";
            this.sfButton5.AllowWrapText = true;
            this.sfButton5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfButton5.Location = new System.Drawing.Point(1, 286);
            this.sfButton5.Name = "sfButton5";
            this.gridLayout1.SetParticipateInLayout(this.sfButton5, true);
            this.sfButton5.Size = new System.Drawing.Size(276, 285);
            this.sfButton5.TabIndex = 4;
            this.sfButton5.Text = "Customizable Data Generation";
            // 
            // settings_Button
            // 
            this.settings_Button.AccessibleName = "Button";
            this.settings_Button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_Button.Location = new System.Drawing.Point(277, 286);
            this.settings_Button.Name = "settings_Button";
            this.gridLayout1.SetParticipateInLayout(this.settings_Button, true);
            this.settings_Button.Size = new System.Drawing.Size(276, 285);
            this.settings_Button.TabIndex = 5;
            this.settings_Button.Text = "Settings";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.connection_status_label);
            this.panel4.Controls.Add(this.connection_status_autoLabel);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.gridLayout2.SetParticipateInLayout(this.panel4, true);
            this.panel4.Size = new System.Drawing.Size(197, 142);
            this.panel4.TabIndex = 3;
            // 
            // connection_status_label
            // 
            this.connection_status_label.AutoEllipsis = true;
            this.connection_status_label.AutoSize = true;
            this.connection_status_label.BackColor = System.Drawing.Color.DodgerBlue;
            this.connection_status_label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_status_label.Location = new System.Drawing.Point(13, 66);
            this.connection_status_label.Name = "connection_status_label";
            this.connection_status_label.Size = new System.Drawing.Size(161, 32);
            this.connection_status_label.TabIndex = 1;
            this.connection_status_label.Text = "Disconnected";
            // 
            // connection_status_autoLabel
            // 
            this.connection_status_autoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_status_autoLabel.Location = new System.Drawing.Point(0, 7);
            this.connection_status_autoLabel.Name = "connection_status_autoLabel";
            this.connection_status_autoLabel.Size = new System.Drawing.Size(88, 32);
            this.connection_status_autoLabel.TabIndex = 0;
            this.connection_status_autoLabel.Text = "Status:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.dbms_name_autolabel);
            this.panel3.Controls.Add(this.dbms_name_label);
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.gridLayout2.SetParticipateInLayout(this.panel3, true);
            this.panel3.Size = new System.Drawing.Size(197, 142);
            this.panel3.TabIndex = 2;
            // 
            // dbms_name_autolabel
            // 
            this.dbms_name_autolabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbms_name_autolabel.ForeColor = System.Drawing.Color.White;
            this.dbms_name_autolabel.Location = new System.Drawing.Point(1, 16);
            this.dbms_name_autolabel.Name = "dbms_name_autolabel";
            this.dbms_name_autolabel.Size = new System.Drawing.Size(88, 32);
            this.dbms_name_autolabel.TabIndex = 1;
            this.dbms_name_autolabel.Text = "DBMS:";
            // 
            // dbms_name_label
            // 
            this.dbms_name_label.AutoEllipsis = true;
            this.dbms_name_label.AutoSize = true;
            this.dbms_name_label.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.dbms_name_label.ForeColor = System.Drawing.Color.White;
            this.dbms_name_label.Location = new System.Drawing.Point(13, 73);
            this.dbms_name_label.Name = "dbms_name_label";
            this.dbms_name_label.Size = new System.Drawing.Size(0, 32);
            this.dbms_name_label.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.database_name_autolabel);
            this.panel2.Controls.Add(this.database_name_label);
            this.panel2.Location = new System.Drawing.Point(0, 286);
            this.panel2.Name = "panel2";
            this.gridLayout2.SetParticipateInLayout(this.panel2, true);
            this.panel2.Size = new System.Drawing.Size(197, 142);
            this.panel2.TabIndex = 1;
            // 
            // database_name_autolabel
            // 
            this.database_name_autolabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_name_autolabel.ForeColor = System.Drawing.Color.White;
            this.database_name_autolabel.Location = new System.Drawing.Point(0, 14);
            this.database_name_autolabel.Name = "database_name_autolabel";
            this.database_name_autolabel.Size = new System.Drawing.Size(123, 32);
            this.database_name_autolabel.TabIndex = 1;
            this.database_name_autolabel.Text = "Database:";
            // 
            // database_name_label
            // 
            this.database_name_label.AutoEllipsis = true;
            this.database_name_label.AutoSize = true;
            this.database_name_label.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_name_label.ForeColor = System.Drawing.Color.White;
            this.database_name_label.Location = new System.Drawing.Point(13, 75);
            this.database_name_label.Name = "database_name_label";
            this.database_name_label.Size = new System.Drawing.Size(0, 19);
            this.database_name_label.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.username_label);
            this.panel1.Controls.Add(this.username_autolabel);
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.gridLayout2.SetParticipateInLayout(this.panel1, true);
            this.panel1.Size = new System.Drawing.Size(197, 142);
            this.panel1.TabIndex = 0;
            // 
            // username_label
            // 
            this.username_label.AutoEllipsis = true;
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(13, 70);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(0, 30);
            this.username_label.TabIndex = 3;
            // 
            // username_autolabel
            // 
            this.username_autolabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_autolabel.ForeColor = System.Drawing.Color.White;
            this.username_autolabel.Location = new System.Drawing.Point(3, 18);
            this.username_autolabel.Name = "username_autolabel";
            this.username_autolabel.Size = new System.Drawing.Size(131, 32);
            this.username_autolabel.TabIndex = 2;
            this.username_autolabel.Text = "Username:";
            // 
            // gridLayout1
            // 
            this.gridLayout1.Columns = 3;
            this.gridLayout1.ContainerControl = this.splitContainer1.Panel1;
            this.gridLayout1.Rows = 2;
            // 
            // gridLayout2
            // 
            this.gridLayout2.Columns = 1;
            this.gridLayout2.ContainerControl = this.splitContainer1.Panel2;
            this.gridLayout2.Rows = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1030, 571);
            this.Controls.Add(this.splitContainer1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1042, 612);
            this.Name = "MainForm";
            this.ShowMaximizeBox = false;
            this.ShowMouseOver = true;
            this.Text = "SQLGenerators";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.WinForms.Controls.SfButton connect_database_button;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Syncfusion.WinForms.Controls.SfButton gen_data_db_button;
        private Syncfusion.WinForms.Controls.SfButton gen_proc_Button;
        private Syncfusion.WinForms.Controls.SfButton sfButton5;
        private Syncfusion.WinForms.Controls.SfButton settings_Button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label connection_status_label;
        private Syncfusion.Windows.Forms.Tools.AutoLabel connection_status_autoLabel;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel dbms_name_autolabel;
        private System.Windows.Forms.Label dbms_name_label;
        private Syncfusion.Windows.Forms.Tools.AutoLabel database_name_autolabel;
        private System.Windows.Forms.Label database_name_label;
        private Syncfusion.Windows.Forms.Tools.AutoLabel username_autolabel;
        private System.Windows.Forms.Label username_label;
    }
}