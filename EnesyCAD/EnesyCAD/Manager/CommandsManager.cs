﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Specialized;

using EnesyCAD.Runtime;
using Autodesk.AutoCAD.Runtime;

namespace EnesyCAD.Manager
{
    public partial class CommandsManagerDialog : EnesyCAD.Forms.Form
    {
        /// <summary>
        /// Datatable for restore, filter commands
        /// This is source of viewer (dataGridView) and somne control (searchBox, helpLink,..)
        /// </summary>
        private System.Data.DataTable m_commandsData = new System.Data.DataTable();

        /// <summary>
        /// Constructor
        /// </summary>
        public CommandsManagerDialog()
        {
            InitializeComponent();
            this.Help = CommandsHelp.CommandsManager;

            // Init dataSource
            this.m_commandsData.Columns.Add("Commands", typeof(string));
            this.m_commandsData.Columns.Add("Tag", typeof(string));
            this.m_commandsData.Columns.Add("Description", typeof(string));
            this.m_commandsData.Columns.Add("Author", typeof(string));
            this.m_commandsData.Columns.Add("Email", typeof(string));
            this.m_commandsData.Columns.Add("Help", typeof(string));

            // Init info for viewer
            this.dgrvCommands.DataSource = m_commandsData;
            this.searchBox.DataSource = m_commandsData;
            this.searchBox.Enabled = true;
            this.ListCommandsFromThisAssembly();

            // Description richTextBox
            this.txtDescription.DataSource = this.m_commandsData;
            this.txtDescription.DisplayMember = "Description";
            this.txtDescription.Regen();

            // Link label
            lblWebLink.DataSource = this.m_commandsData;
            lblWebLink.DisplayMember = "Help";
            lblWebLink.Regen();
        }

        #region Get information of commands from EnesyCadCommand attribute
        /// <summary>
        /// Get information of commands from [EnesyCADCommandMethod] attribute
        /// </summary>
        /// <param name="asm">Assembly that contains .NET function</param>
        /// <param name="markedOnly"></param>
        /// <returns></returns>
        private static List<CommandInfo> GetCommands(Assembly asm, bool markedOnly)
        {
            {
                //StringCollection sc = new StringCollection();
                List<CommandInfo> cmdInfo = new List<CommandInfo>();
                object[] objs = asm.GetCustomAttributes(typeof(EnesyCADCommandMethod), true);
                Type[] tps;
                int numTypes = objs.Length;
                if (numTypes > 0)
                {
                    tps = new Type[numTypes];
                    for (int i = 0; i < numTypes; i++)
                    {
                        CommandClassAttribute cca = objs[i] as CommandClassAttribute;
                        if (cca != null)
                        {
                            tps[i] = cca.Type;
                        }
                    }
                }
                else
                {
                    // If we're only looking for specifically
                    // marked CommandClasses, then use an
                    // empty list
                    if (markedOnly)
                        tps = new Type[0];
                    else
                        tps = asm.GetExportedTypes();
                }

                foreach (Type tp in tps)
                {
                    MethodInfo[] meths = tp.GetMethods();
                    foreach (MethodInfo meth in meths)
                    {
                        objs = meth.GetCustomAttributes(typeof(EnesyCADCommandMethod), true);
                        foreach (object obj in objs)
                        {
                            EnesyCADCommandMethod attb = (EnesyCADCommandMethod)obj;
                            if (!attb.IsTest)
                            {
                                cmdInfo.Add(new CommandInfo(attb.GlobalName,
                                                            attb.Tag,
                                                            attb.Description,
                                                            attb.Author,
                                                            attb.Email,
                                                            attb.WebLink
                                                            )
                                );
                            }
                        }
                    }
                }
                return cmdInfo;
            }
        }

        /// <summary>
        /// List Commands in current Assembly
        /// </summary>
        public void ListCommandsFromThisAssembly()
        {
            if (m_commandsData != null) m_commandsData.Rows.Clear();

            // Just get the commands for this assembly
            Assembly asm = Assembly.GetExecutingAssembly();
            List<CommandInfo> cmds = GetCommands(asm, false);

            // Send info to dataSource (datatable)
            foreach (CommandInfo cmd in cmds)
            {
                System.Data.DataRow dr = m_commandsData.NewRow();

                dr[0] = cmd.GlobalName;
                dr[1] = cmd.Tag;
                dr[2] = cmd.Description;
                dr[3] = cmd.Author;
                dr[4] = cmd.Email;
                dr[5] = cmd.WebLink;

                m_commandsData.Rows.Add(dr);
            }
        }
        #endregion

        /// <summary>
        /// Override OnFormClosing of this form
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            this.Hide();
            e.Cancel = true;
        }

        /// <summary>
        /// Calling command when row/cell is double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgrvCommands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            Autodesk.AutoCAD.ApplicationServices.Document doc =
                Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            string s = dgrvCommands.Rows[e.RowIndex].Cells[0].Value.ToString();
            doc.SendStringToExecute(s + " ", false, false, true);
        }

        private void dgrvCommands_MouseHover(object sender, EventArgs e)
        {
            this.lblStatus.Text = "Double click to calling command";
        }

        private void searchBox_MouseHover(object sender, EventArgs e)
        {
            if (searchBox.DisplayMember == "")
            {
                this.lblStatus.Text = "Select search column...";
            }
            else
            {
                this.lblStatus.Text = "Search " + searchBox.DisplayMember;
            }
        }
    }
}