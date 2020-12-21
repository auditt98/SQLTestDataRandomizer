using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLTestDataGenerator.Generators.Complex;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace SQLTestDataGenerator
{
    public partial class MainForm : MetroForm
    {
        public Configs _configs { get; set; }
        public MainForm()
        {

            SetStyle();
            InitializeComponent();

        }

        public void SetStyle()
        {
            this.CaptionBarHeight = 40;
            this.CaptionBarHeightMode = Syncfusion.Windows.Forms.Enums.CaptionBarHeightMode.SameAlwaysOnMaximize;
            this.CaptionAlign = HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this._configs = new Configs();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            //Enables appearance settings
            //this.gridLayout1.DpiAware = true;
            //NameGenerator _nameGenerator = new NameGenerator();
            //textBoxExt1.Text = _nameGenerator.GenerateLastName();
        }

        private void connect_database_button_Click(object sender, EventArgs e)
        {
            DatabaseConnectForm databaseConnectForm = new DatabaseConnectForm(this);
            databaseConnectForm.ShowDialog();
        }

        public void SetConnectionStatus(bool status)
        {
            if (status)
            {
                connection_status_label.Text = "Connected";
                database_name_label.Text = _configs.databaseName;
                username_label.Text = _configs.username;
                dbms_name_label.Text = _configs.serverName;
            }
            else
            {
                connection_status_label.Text = "Disconnected";
            }
        }

        private void gen_data_db_button_Click(object sender, EventArgs e)
        {
            GenerateDataForm generateDataForm = new GenerateDataForm(this);
            generateDataForm.ShowDialog();
            
        }

        private void gen_proc_Button_Click(object sender, EventArgs e)
        {
            GenerateProcedureForm generateProcedureForm= new GenerateProcedureForm(this);
            generateProcedureForm.ShowDialog();
        }
    }
}
