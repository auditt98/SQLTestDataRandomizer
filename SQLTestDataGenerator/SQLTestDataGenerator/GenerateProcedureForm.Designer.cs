namespace SQLTestDataGenerator
{
    partial class GenerateProcedureForm
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.sql_save_dialog = new System.Windows.Forms.SaveFileDialog();
            this.generate_proc_button = new System.Windows.Forms.Button();
            this.export_to_sql_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewAdv1
            // 
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(497, 472);
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.FullRowSelect = true;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.HelpTextControl.Name = "";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(392, 112);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Visible = true;
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.Location = new System.Drawing.Point(-1, 5);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv1.Size = new System.Drawing.Size(497, 472);
            this.treeViewAdv1.TabIndex = 2;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.treeViewAdv1.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.ToolTipControl.Name = "";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(392, 112);
            this.treeViewAdv1.ToolTipControl.TabIndex = 0;
            this.treeViewAdv1.ToolTipControl.Visible = true;
            // 
            // generate_proc_button
            // 
            this.generate_proc_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            this.generate_proc_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_proc_button.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.generate_proc_button.ForeColor = System.Drawing.Color.White;
            this.generate_proc_button.Location = new System.Drawing.Point(514, 174);
            this.generate_proc_button.Name = "generate_proc_button";
            this.generate_proc_button.Size = new System.Drawing.Size(244, 54);
            this.generate_proc_button.TabIndex = 3;
            this.generate_proc_button.Text = "Generate Procedure";
            this.generate_proc_button.UseVisualStyleBackColor = false;
            this.generate_proc_button.Click += new System.EventHandler(this.generate_proc_button_Click);
            // 
            // export_to_sql_btn
            // 
            this.export_to_sql_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(170)))), ((int)(((byte)(168)))));
            this.export_to_sql_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_to_sql_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.export_to_sql_btn.ForeColor = System.Drawing.Color.White;
            this.export_to_sql_btn.Location = new System.Drawing.Point(514, 291);
            this.export_to_sql_btn.Name = "export_to_sql_btn";
            this.export_to_sql_btn.Size = new System.Drawing.Size(244, 54);
            this.export_to_sql_btn.TabIndex = 4;
            this.export_to_sql_btn.Text = "Export To SQL File";
            this.export_to_sql_btn.UseVisualStyleBackColor = false;
            this.export_to_sql_btn.Click += new System.EventHandler(this.export_to_sql_btn_Click);
            // 
            // GenerateProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 482);
            this.Controls.Add(this.export_to_sql_btn);
            this.Controls.Add(this.generate_proc_button);
            this.Controls.Add(this.treeViewAdv1);
            this.MaximumSize = new System.Drawing.Size(824, 521);
            this.MinimumSize = new System.Drawing.Size(824, 521);
            this.Name = "GenerateProcedureForm";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Generate Procedure";
            this.Load += new System.EventHandler(this.GenerateProcedureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private System.Windows.Forms.SaveFileDialog sql_save_dialog;
        private System.Windows.Forms.Button generate_proc_button;
        private System.Windows.Forms.Button export_to_sql_btn;
    }
}