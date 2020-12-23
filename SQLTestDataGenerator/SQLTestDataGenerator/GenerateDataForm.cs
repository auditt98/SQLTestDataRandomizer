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
    public partial class GenerateDataForm : SfForm
    {
        private MainForm mainForm = null;
        private List<TableModel> insertedTables = null;
        public GenerateDataForm()
        {
            SetStyle();
            //this.
            InitializeComponent();

        }

        public GenerateDataForm(MetroForm form)
        {
            this.mainForm = form as MainForm;
            InitializeComponent();
            SetStyle();
            this.insertedTables = mainForm._tables;
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
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;

            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.generate_data_button.BackColor = Color.FromArgb(112, 175, 133);
        }

        private void generate_data_button_Click(object sender, EventArgs e)
        {
            while(insertedTables.Count > 0)
            {
                string cnString = mainForm._configs.ConnectionStringBuilder();
                SqlConnection connection = new SqlConnection(cnString);

            }
        }
    }
}
