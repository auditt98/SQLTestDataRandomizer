namespace SQLTestDataGenerator
{
    partial class GenerateDataForm
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
            this.generate_data_button = new System.Windows.Forms.Button();
            this.number_of_rows_checkbox = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.num_of_rows_label = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.is_identity_insert = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_rows_checkbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_identity_insert)).BeginInit();
            this.SuspendLayout();
            // 
            // generate_data_button
            // 
            this.generate_data_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            this.generate_data_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_data_button.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.generate_data_button.ForeColor = System.Drawing.Color.White;
            this.generate_data_button.Location = new System.Drawing.Point(284, 374);
            this.generate_data_button.Name = "generate_data_button";
            this.generate_data_button.Size = new System.Drawing.Size(244, 54);
            this.generate_data_button.TabIndex = 1;
            this.generate_data_button.Text = "Generate Data";
            this.generate_data_button.UseVisualStyleBackColor = false;
            this.generate_data_button.Click += new System.EventHandler(this.generate_data_button_Click);
            // 
            // number_of_rows_checkbox
            // 
            this.number_of_rows_checkbox.BeforeTouchSize = new System.Drawing.Size(338, 34);
            this.number_of_rows_checkbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number_of_rows_checkbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_rows_checkbox.IntegerValue = ((long)(1));
            this.number_of_rows_checkbox.Location = new System.Drawing.Point(284, 146);
            this.number_of_rows_checkbox.Name = "number_of_rows_checkbox";
            this.number_of_rows_checkbox.Size = new System.Drawing.Size(244, 38);
            this.number_of_rows_checkbox.TabIndex = 2;
            this.number_of_rows_checkbox.Text = "1";
            // 
            // num_of_rows_label
            // 
            this.num_of_rows_label.DX = -206;
            this.num_of_rows_label.DY = 3;
            this.num_of_rows_label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_of_rows_label.LabeledControl = this.number_of_rows_checkbox;
            this.num_of_rows_label.Location = new System.Drawing.Point(78, 149);
            this.num_of_rows_label.Name = "num_of_rows_label";
            this.num_of_rows_label.Size = new System.Drawing.Size(202, 32);
            this.num_of_rows_label.TabIndex = 3;
            this.num_of_rows_label.Text = "Number of Rows:";
            // 
            // is_identity_insert
            // 
            this.is_identity_insert.BeforeTouchSize = new System.Drawing.Size(244, 32);
            this.is_identity_insert.Checked = true;
            this.is_identity_insert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_identity_insert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_identity_insert.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.is_identity_insert.Location = new System.Drawing.Point(284, 258);
            this.is_identity_insert.Name = "is_identity_insert";
            this.is_identity_insert.Size = new System.Drawing.Size(244, 32);
            this.is_identity_insert.TabIndex = 4;
            this.is_identity_insert.Text = "Identity Insert ON";
            // 
            // GenerateDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 498);
            this.Controls.Add(this.is_identity_insert);
            this.Controls.Add(this.num_of_rows_label);
            this.Controls.Add(this.number_of_rows_checkbox);
            this.Controls.Add(this.generate_data_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(828, 537);
            this.MinimumSize = new System.Drawing.Size(828, 537);
            this.Name = "GenerateDataForm";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Generate Data";
            ((System.ComponentModel.ISupportInitialize)(this.number_of_rows_checkbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_identity_insert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generate_data_button;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox number_of_rows_checkbox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel num_of_rows_label;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv is_identity_insert;
    }
}