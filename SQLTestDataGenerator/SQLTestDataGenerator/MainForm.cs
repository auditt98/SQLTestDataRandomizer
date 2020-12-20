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

        public MainForm()
        {
            Syncfusion.Windows.Forms.CaptionLabel captionLabel1 = new Syncfusion.Windows.Forms.CaptionLabel();
            this.CaptionBarHeight = 40;
            this.CaptionBarHeightMode = Syncfusion.Windows.Forms.Enums.CaptionBarHeightMode.SameAlwaysOnMaximize;
            this.CaptionAlign = HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            //NameGenerator _nameGenerator = new NameGenerator();
            //textBoxExt1.Text = _nameGenerator.GenerateLastName();
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.WriteLine("heleloo");
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            DatabaseConnectForm databaseConnectForm = new DatabaseConnectForm();
            databaseConnectForm.ShowDialog();

        }
    }
}
