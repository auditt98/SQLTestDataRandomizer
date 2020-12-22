﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using Syncfusion.WinForms.Controls;

namespace SQLTestDataGenerator
{
    public partial class GenerateProcedureForm : SfForm
    {
        private MainForm mainForm = null;
        public GenerateProcedureForm()
        {
            InitializeComponent();
            SetStyle();
        }

        public GenerateProcedureForm(MetroForm form)
        {
            this.mainForm = form as MainForm;
            InitializeComponent();
            SetStyle();
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
        }

        private void GenerateProcedureForm_Load(object sender, EventArgs e)
        {

            //connect
            List<TableModel> tableModels = new List<TableModel>();
            var connectionString = mainForm._configs.ConnectionStringBuilder();
            foreach(var table in mainForm._tables)
            {
                var treeNode_child_insert = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv("Insert");
                treeNode_child_insert.Name = table.TABLE_NAME + "_insert";
                var treeNode_child_update = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv("Update");
                treeNode_child_update.Name = table.TABLE_NAME + "_update";
                var treeNode_child_delete = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv("Delete");
                treeNode_child_delete.Name = table.TABLE_NAME + "_delete";

                var treeNode_child_getbyid = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv("GetByID");
                treeNode_child_getbyid.Name = table.TABLE_NAME + "_getbyid";

                var treeNode_parent = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv(table.TABLE_NAME, new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] { treeNode_child_insert, treeNode_child_update, treeNode_child_delete, treeNode_child_getbyid });
                treeNode_parent.Text = table.TABLE_NAME;
                treeNode_parent.Name = table.TABLE_NAME;
                treeViewAdv1.Nodes.Add(treeNode_parent);
                treeNode_parent.Checked = true;
                treeNode_child_insert.Checked = true;
                treeNode_child_update.Checked = true;
                treeNode_child_getbyid.Checked = true;
                treeNode_child_delete.Checked = true;
                treeViewAdv1.ShowCheckBoxes = true;
            }
            #region Check db type
            if (mainForm._configs.DBMS == (int)Enums.EnumDBMS.MSSQL)
            {
                
            }
            else if (mainForm._configs.DBMS == (int)Enums.EnumDBMS.MySQL)
            {


            }
            else if (mainForm._configs.DBMS == (int)Enums.EnumDBMS.Oracle)
            {


            }
            else if (mainForm._configs.DBMS == (int)Enums.EnumDBMS.PostgreSql)
            {


            }
            else if (mainForm._configs.DBMS == (int)Enums.EnumDBMS.SQLite)
            {


            }
            else
            {

            }
            #endregion 
        }

        private void generate_proc_button_Click(object sender, EventArgs e)
        {
            var generatedProcs = new List<string>();
            //check for clicked treenodes
            
            //do actual work 
            foreach(var table in mainForm._tables)
            {
                //insert
                var colString = "";
                var paramString = "";
                var varString = "";
                for(int i = 0; i < table.Columns.Count; i++)
                {
                    //check if last column
                    if(i != table.Columns.Count - 1)
                    {
                        if(table.Columns[i].IS_IDENTITY != 1)
                        {
                            colString = colString + table.Columns[i].COLUMN_NAME + ", ";
                            paramString = paramString + table.Columns[i].Parameter + ", ";
                            varString = varString + table.Columns[i].Variable + ", ";
                        }
                    }
                    else
                    {
                        if (table.Columns[i].IS_IDENTITY != 1)
                        {
                            colString = colString + table.Columns[i].COLUMN_NAME;
                            paramString = paramString + table.Columns[i].Parameter;
                            varString = varString + table.Columns[i].Variable;
                        }
                    }
                }

                //foreach(var col in table.Columns)
                //{
                //    colString = colString + col.COLUMN_NAME + ", ";
                //    paramString = paramString + col.Parameter + ", ";
                //}
                var insertProc =
                    $@"CREATE PROCEDURE sp_INSERT_{table.TABLE_NAME} {paramString} as begin INSERT INTO {table.TABLE_NAME}({colString}) values ({varString}) end;";
                generatedProcs.Add(insertProc);

                paramString = "";
                colString = "";
                varString = "";
                //update
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    //check if last column
                    if (i != table.Columns.Count - 1)
                    {
                        paramString = paramString + table.Columns[i].Parameter + ", ";
                    }
                    else
                    {
                        paramString = paramString + table.Columns[i].Parameter;
                    }
                }

                if (table.Columns.Select(c => c.COLUMN_NAME == "ID" || c.COLUMN_NAME == "id").Any())
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        //if its not the last column
                        if (i != table.Columns.Count - 1)
                        {
                            if(table.Columns[i].COLUMN_NAME.ToLower() != "id")
                            {
                                varString = varString + $@"{table.Columns[i].COLUMN_NAME} = @{table.Columns[i].COLUMN_NAME}, ";
                            }

                        }
                        else //if it is
                        {
                            if (table.Columns[i].COLUMN_NAME.ToLower() != "id")
                            {
                                varString = varString + $@"{table.Columns[i].COLUMN_NAME} = @{table.Columns[i].COLUMN_NAME}";
                            }
                        }
                    }
                    var updateProc =
                    $@"CREATE PROCEDURE sp_UPDATE_{table.TABLE_NAME} {paramString} as begin UPDATE {table.TABLE_NAME} set {varString} where ID = @ID end;";
                    generatedProcs.Add(updateProc);
                }
                //delete
                var deleteProc = $@"CREATE PROCEDURE sp_DELETE_{table.TABLE_NAME} @ID int as begin delete from {table.TABLE_NAME} where ID = @ID end;";
                generatedProcs.Add(deleteProc);
                //getbyid
                var getByIDProc = $@"CREATE PROCEDURE sp_GETBYID_{table.TABLE_NAME} @ID int as begin select * from {table.TABLE_NAME} where ID = @ID end;";
                generatedProcs.Add(getByIDProc);
                //get all 
                var getAllProc = $@"CREATE PROCEDURE sp_GETALL_{table.TABLE_NAME} as begin select * from {table.TABLE_NAME} end;";
                generatedProcs.Add(getAllProc);

            }

        }

        private void export_to_sql_btn_Click(object sender, EventArgs e)
        {
            var generatedProcs = new List<string>();
            //check for clicked treenodes

            //do actual work 
            foreach (var table in mainForm._tables)
            {
                //insert
                var colString = "";
                var paramString = "";
                var varString = "";
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    //check if last column
                    if (i != table.Columns.Count - 1)
                    {
                        if (table.Columns[i].IS_IDENTITY != 1)
                        {
                            colString = colString + table.Columns[i].COLUMN_NAME + ", ";
                            paramString = paramString + table.Columns[i].Parameter + ", ";
                            varString = varString + table.Columns[i].Variable + ", ";
                        }
                    }
                    else
                    {
                        if (table.Columns[i].IS_IDENTITY != 1)
                        {
                            colString = colString + table.Columns[i].COLUMN_NAME;
                            paramString = paramString + table.Columns[i].Parameter;
                            varString = varString + table.Columns[i].Variable;
                        }
                    }
                }

                //foreach(var col in table.Columns)
                //{
                //    colString = colString + col.COLUMN_NAME + ", ";
                //    paramString = paramString + col.Parameter + ", ";
                //}
                var insertProc =
                    $@"CREATE PROCEDURE sp_INSERT_{table.TABLE_NAME} {paramString} as begin INSERT INTO {table.TABLE_NAME}({colString}) values ({varString}) end;";
                generatedProcs.Add(insertProc);

                paramString = "";
                colString = "";
                varString = "";
                //update
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    //check if last column
                    if (i != table.Columns.Count - 1)
                    {
                        paramString = paramString + table.Columns[i].Parameter + ", ";
                    }
                    else
                    {
                        paramString = paramString + table.Columns[i].Parameter;
                    }
                }

                if (table.Columns.Select(c => c.COLUMN_NAME == "ID" || c.COLUMN_NAME == "id").Any())
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        //if its not the last column
                        if (i != table.Columns.Count - 1)
                        {
                            if (table.Columns[i].COLUMN_NAME.ToLower() != "id")
                            {
                                varString = varString + $@"{table.Columns[i].COLUMN_NAME} = @{table.Columns[i].COLUMN_NAME}, ";
                            }

                        }
                        else //if it is
                        {
                            if (table.Columns[i].COLUMN_NAME.ToLower() != "id")
                            {
                                varString = varString + $@"{table.Columns[i].COLUMN_NAME} = @{table.Columns[i].COLUMN_NAME}";
                            }
                        }
                    }
                    var updateProc =
                    $@"CREATE PROCEDURE sp_UPDATE_{table.TABLE_NAME} {paramString} as begin UPDATE {table.TABLE_NAME} set {varString} where ID = @ID end;";
                    generatedProcs.Add(updateProc);
                }
                //delete
                var deleteProc = $@"CREATE PROCEDURE sp_DELETE_{table.TABLE_NAME} @ID int as begin delete from {table.TABLE_NAME} where ID = @ID end;";
                generatedProcs.Add(deleteProc);
                //getbyid
                var getByIDProc = $@"CREATE PROCEDURE sp_GETBYID_{table.TABLE_NAME} @ID int as begin select * from {table.TABLE_NAME} where ID = @ID end;";
                generatedProcs.Add(getByIDProc);
                //get all 
                var getAllProc = $@"CREATE PROCEDURE sp_GETALL_{table.TABLE_NAME} as begin select * from {table.TABLE_NAME} end;";
                generatedProcs.Add(getAllProc);

            }
        
            
        }
    }
}
