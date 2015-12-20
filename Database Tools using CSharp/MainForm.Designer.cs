﻿namespace NSDatabaseTools
{
    class CSupport
    {
        public static uint countBits(uint data)
        {
            data = intrsct(data, 0x55555555) + (intrsct(srl(data, 1), 0x55555555));
            data = intrsct(data, 0x33333333) + (intrsct(srl(data, 2), 0x33333333));
            data = intrsct(data, 0x0F0F0F0F) + (intrsct(srl(data, 4), 0x0F0F0F0F));
            data = intrsct(data, 0x00FF00FF) + (intrsct(srl(data, 8), 0x00FF00FF));
            data = intrsct(data, 0x0000FFFF) + (intrsct(srl(data, 16), 0x0000FFFF));
            return data;
        }

        public static uint powOf2(int n)
        {
            return (uint)1 << n;
        }

        public static uint union(uint a, uint b)
        {
            return a | b;
        }

        public static uint intrsct(uint a, uint b)
        {
            return a & b;
        }

        public static uint sll(uint a, int k)
        {
            return a << k;
        }

        public static uint srl(uint a, int k)
        {
            return a >> k;
        }

        public enum eCheck
        {
            left,
            right,
        }
    }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelInputListAllAttributes = new System.Windows.Forms.Label();
            this.textBoxInputListAttributesSet = new System.Windows.Forms.TextBox();
            this.textBoxInputListFDsSet = new System.Windows.Forms.TextBox();
            this.labelInputListFDsSet = new System.Windows.Forms.Label();
            this.textBoxResultListKeysSet = new System.Windows.Forms.TextBox();
            this.labelResultListKeysSet = new System.Windows.Forms.Label();
            this.textBoxResultListClosuresSet = new System.Windows.Forms.TextBox();
            this.labelResultListClosuresSet = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelInputFindClosureOf = new System.Windows.Forms.Label();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.labelCalculateLine1 = new System.Windows.Forms.Label();
            this.labelCalculateLine2 = new System.Windows.Forms.Label();
            this.Query = new System.Windows.Forms.TabControl();
            this.tabPageCalculate = new System.Windows.Forms.TabPage();
            this.textBoxInputListAttributesSetToFindClosures = new System.Windows.Forms.TextBox();
            this.buttonExecuteCalculate = new System.Windows.Forms.Button();
            this.tabControlCalculate = new System.Windows.Forms.TabControl();
            this.tabPageSuperkeys = new System.Windows.Forms.TabPage();
            this.richTextBoxResultListSuperkeysSet = new System.Windows.Forms.RichTextBox();
            this.labelResultListSuperKeysSet = new System.Windows.Forms.Label();
            this.tabPageKeys = new System.Windows.Forms.TabPage();
            this.tabPageClosures = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelResultClosureOfAttributes = new System.Windows.Forms.Label();
            this.textBoxResultClosureOf = new System.Windows.Forms.TextBox();
            this.labelHeaderControl = new System.Windows.Forms.Label();
            this.labelHeaderResult = new System.Windows.Forms.Label();
            this.labelHeaderInput = new System.Windows.Forms.Label();
            this.tabPageConnect = new System.Windows.Forms.TabPage();
            this.textBoxConnectionStatus = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tabControlConnect = new System.Windows.Forms.TabControl();
            this.tabPageFindFDs = new System.Windows.Forms.TabPage();
            this.comboBoxTableList = new System.Windows.Forms.ComboBox();
            this.labelTableName = new System.Windows.Forms.Label();
            this.labelConnectLine1 = new System.Windows.Forms.Label();
            this.richTextBoxResultAllFDs = new System.Windows.Forms.RichTextBox();
            this.buttonFindFDs = new System.Windows.Forms.Button();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.labelConnectLine2 = new System.Windows.Forms.Label();
            this.buttonExecuteSQLQuery = new System.Windows.Forms.Button();
            this.labelResultQuery = new System.Windows.Forms.Label();
            this.dataGridViewResultQuery = new System.Windows.Forms.DataGridView();
            this.labelQuery = new System.Windows.Forms.Label();
            this.textBoxInputSQLQuery = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelResultFDsSet = new System.Windows.Forms.Label();
            this.labelInputPath = new System.Windows.Forms.Label();
            this.textBoxInputPath = new System.Windows.Forms.TextBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.richTextBoxAbout = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Query.SuspendLayout();
            this.tabPageCalculate.SuspendLayout();
            this.tabControlCalculate.SuspendLayout();
            this.tabPageSuperkeys.SuspendLayout();
            this.tabPageKeys.SuspendLayout();
            this.tabPageClosures.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            this.tabControlConnect.SuspendLayout();
            this.tabPageFindFDs.SuspendLayout();
            this.tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultQuery)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInputListAllAttributes
            // 
            resources.ApplyResources(this.labelInputListAllAttributes, "labelInputListAllAttributes");
            this.labelInputListAllAttributes.Name = "labelInputListAllAttributes";
            // 
            // textBoxInputListAttributesSet
            // 
            resources.ApplyResources(this.textBoxInputListAttributesSet, "textBoxInputListAttributesSet");
            this.textBoxInputListAttributesSet.Name = "textBoxInputListAttributesSet";
            // 
            // textBoxInputListFDsSet
            // 
            resources.ApplyResources(this.textBoxInputListFDsSet, "textBoxInputListFDsSet");
            this.textBoxInputListFDsSet.Name = "textBoxInputListFDsSet";
            // 
            // labelInputListFDsSet
            // 
            resources.ApplyResources(this.labelInputListFDsSet, "labelInputListFDsSet");
            this.labelInputListFDsSet.Name = "labelInputListFDsSet";
            // 
            // textBoxResultListKeysSet
            // 
            this.textBoxResultListKeysSet.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textBoxResultListKeysSet, "textBoxResultListKeysSet");
            this.textBoxResultListKeysSet.Name = "textBoxResultListKeysSet";
            this.textBoxResultListKeysSet.ReadOnly = true;
            // 
            // labelResultListKeysSet
            // 
            resources.ApplyResources(this.labelResultListKeysSet, "labelResultListKeysSet");
            this.labelResultListKeysSet.Name = "labelResultListKeysSet";
            // 
            // textBoxResultListClosuresSet
            // 
            this.textBoxResultListClosuresSet.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textBoxResultListClosuresSet, "textBoxResultListClosuresSet");
            this.textBoxResultListClosuresSet.Name = "textBoxResultListClosuresSet";
            this.textBoxResultListClosuresSet.ReadOnly = true;
            // 
            // labelResultListClosuresSet
            // 
            resources.ApplyResources(this.labelResultListClosuresSet, "labelResultListClosuresSet");
            this.labelResultListClosuresSet.Name = "labelResultListClosuresSet";
            // 
            // labelAuthor
            // 
            resources.ApplyResources(this.labelAuthor, "labelAuthor");
            this.labelAuthor.Name = "labelAuthor";
            // 
            // labelInputFindClosureOf
            // 
            resources.ApplyResources(this.labelInputFindClosureOf, "labelInputFindClosureOf");
            this.labelInputFindClosureOf.Name = "labelInputFindClosureOf";
            // 
            // buttonResetAll
            // 
            resources.ApplyResources(this.buttonResetAll, "buttonResetAll");
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            this.buttonResetAll.Click += new System.EventHandler(this.buttonResetAll_Click);
            // 
            // labelCalculateLine1
            // 
            this.labelCalculateLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelCalculateLine1, "labelCalculateLine1");
            this.labelCalculateLine1.Name = "labelCalculateLine1";
            // 
            // labelCalculateLine2
            // 
            this.labelCalculateLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelCalculateLine2, "labelCalculateLine2");
            this.labelCalculateLine2.Name = "labelCalculateLine2";
            // 
            // Query
            // 
            this.Query.Controls.Add(this.tabPageCalculate);
            this.Query.Controls.Add(this.tabPageConnect);
            this.Query.Controls.Add(this.tabPageAbout);
            resources.ApplyResources(this.Query, "Query");
            this.Query.Name = "Query";
            this.Query.SelectedIndex = 0;
            // 
            // tabPageCalculate
            // 
            this.tabPageCalculate.BackColor = System.Drawing.Color.Transparent;
            this.tabPageCalculate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCalculate.Controls.Add(this.textBoxInputListAttributesSetToFindClosures);
            this.tabPageCalculate.Controls.Add(this.buttonExecuteCalculate);
            this.tabPageCalculate.Controls.Add(this.tabControlCalculate);
            this.tabPageCalculate.Controls.Add(this.labelHeaderControl);
            this.tabPageCalculate.Controls.Add(this.labelHeaderResult);
            this.tabPageCalculate.Controls.Add(this.labelHeaderInput);
            this.tabPageCalculate.Controls.Add(this.labelCalculateLine2);
            this.tabPageCalculate.Controls.Add(this.labelInputListAllAttributes);
            this.tabPageCalculate.Controls.Add(this.labelCalculateLine1);
            this.tabPageCalculate.Controls.Add(this.textBoxInputListAttributesSet);
            this.tabPageCalculate.Controls.Add(this.buttonResetAll);
            this.tabPageCalculate.Controls.Add(this.labelInputListFDsSet);
            this.tabPageCalculate.Controls.Add(this.textBoxInputListFDsSet);
            this.tabPageCalculate.Controls.Add(this.labelInputFindClosureOf);
            this.tabPageCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.tabPageCalculate, "tabPageCalculate");
            this.tabPageCalculate.Name = "tabPageCalculate";
            // 
            // textBoxInputListAttributesSetToFindClosures
            // 
            resources.ApplyResources(this.textBoxInputListAttributesSetToFindClosures, "textBoxInputListAttributesSetToFindClosures");
            this.textBoxInputListAttributesSetToFindClosures.Name = "textBoxInputListAttributesSetToFindClosures";
            // 
            // buttonExecuteCalculate
            // 
            resources.ApplyResources(this.buttonExecuteCalculate, "buttonExecuteCalculate");
            this.buttonExecuteCalculate.Name = "buttonExecuteCalculate";
            this.buttonExecuteCalculate.UseVisualStyleBackColor = true;
            this.buttonExecuteCalculate.Click += new System.EventHandler(this.buttonExecuteCalculate_Click);
            // 
            // tabControlCalculate
            // 
            this.tabControlCalculate.Controls.Add(this.tabPageSuperkeys);
            this.tabControlCalculate.Controls.Add(this.tabPageKeys);
            this.tabControlCalculate.Controls.Add(this.tabPageClosures);
            this.tabControlCalculate.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControlCalculate, "tabControlCalculate");
            this.tabControlCalculate.Name = "tabControlCalculate";
            this.tabControlCalculate.SelectedIndex = 0;
            // 
            // tabPageSuperkeys
            // 
            this.tabPageSuperkeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageSuperkeys.Controls.Add(this.richTextBoxResultListSuperkeysSet);
            this.tabPageSuperkeys.Controls.Add(this.labelResultListSuperKeysSet);
            resources.ApplyResources(this.tabPageSuperkeys, "tabPageSuperkeys");
            this.tabPageSuperkeys.Name = "tabPageSuperkeys";
            this.tabPageSuperkeys.UseVisualStyleBackColor = true;
            // 
            // richTextBoxResultListSuperkeysSet
            // 
            this.richTextBoxResultListSuperkeysSet.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.richTextBoxResultListSuperkeysSet, "richTextBoxResultListSuperkeysSet");
            this.richTextBoxResultListSuperkeysSet.Name = "richTextBoxResultListSuperkeysSet";
            // 
            // labelResultListSuperKeysSet
            // 
            resources.ApplyResources(this.labelResultListSuperKeysSet, "labelResultListSuperKeysSet");
            this.labelResultListSuperKeysSet.Name = "labelResultListSuperKeysSet";
            // 
            // tabPageKeys
            // 
            this.tabPageKeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageKeys.Controls.Add(this.labelResultListKeysSet);
            this.tabPageKeys.Controls.Add(this.textBoxResultListKeysSet);
            resources.ApplyResources(this.tabPageKeys, "tabPageKeys");
            this.tabPageKeys.Name = "tabPageKeys";
            this.tabPageKeys.UseVisualStyleBackColor = true;
            // 
            // tabPageClosures
            // 
            this.tabPageClosures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageClosures.Controls.Add(this.labelResultListClosuresSet);
            this.tabPageClosures.Controls.Add(this.textBoxResultListClosuresSet);
            resources.ApplyResources(this.tabPageClosures, "tabPageClosures");
            this.tabPageClosures.Name = "tabPageClosures";
            this.tabPageClosures.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.labelResultClosureOfAttributes);
            this.tabPage1.Controls.Add(this.textBoxResultClosureOf);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelResultClosureOfAttributes
            // 
            resources.ApplyResources(this.labelResultClosureOfAttributes, "labelResultClosureOfAttributes");
            this.labelResultClosureOfAttributes.Name = "labelResultClosureOfAttributes";
            // 
            // textBoxResultClosureOf
            // 
            this.textBoxResultClosureOf.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textBoxResultClosureOf, "textBoxResultClosureOf");
            this.textBoxResultClosureOf.Name = "textBoxResultClosureOf";
            this.textBoxResultClosureOf.ReadOnly = true;
            // 
            // labelHeaderControl
            // 
            resources.ApplyResources(this.labelHeaderControl, "labelHeaderControl");
            this.labelHeaderControl.Name = "labelHeaderControl";
            // 
            // labelHeaderResult
            // 
            resources.ApplyResources(this.labelHeaderResult, "labelHeaderResult");
            this.labelHeaderResult.Name = "labelHeaderResult";
            // 
            // labelHeaderInput
            // 
            resources.ApplyResources(this.labelHeaderInput, "labelHeaderInput");
            this.labelHeaderInput.Name = "labelHeaderInput";
            // 
            // tabPageConnect
            // 
            this.tabPageConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageConnect.Controls.Add(this.textBoxConnectionStatus);
            this.tabPageConnect.Controls.Add(this.buttonConnect);
            this.tabPageConnect.Controls.Add(this.tabControlConnect);
            this.tabPageConnect.Controls.Add(this.buttonBrowse);
            this.tabPageConnect.Controls.Add(this.labelResultFDsSet);
            this.tabPageConnect.Controls.Add(this.labelInputPath);
            this.tabPageConnect.Controls.Add(this.textBoxInputPath);
            resources.ApplyResources(this.tabPageConnect, "tabPageConnect");
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.UseVisualStyleBackColor = true;
            // 
            // textBoxConnectionStatus
            // 
            this.textBoxConnectionStatus.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxConnectionStatus.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBoxConnectionStatus, "textBoxConnectionStatus");
            this.textBoxConnectionStatus.ForeColor = System.Drawing.Color.Green;
            this.textBoxConnectionStatus.Name = "textBoxConnectionStatus";
            this.textBoxConnectionStatus.ReadOnly = true;
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tabControlConnect
            // 
            this.tabControlConnect.Controls.Add(this.tabPageFindFDs);
            this.tabControlConnect.Controls.Add(this.tabPageQuery);
            resources.ApplyResources(this.tabControlConnect, "tabControlConnect");
            this.tabControlConnect.Name = "tabControlConnect";
            this.tabControlConnect.SelectedIndex = 0;
            // 
            // tabPageFindFDs
            // 
            this.tabPageFindFDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageFindFDs.Controls.Add(this.comboBoxTableList);
            this.tabPageFindFDs.Controls.Add(this.labelTableName);
            this.tabPageFindFDs.Controls.Add(this.labelConnectLine1);
            this.tabPageFindFDs.Controls.Add(this.richTextBoxResultAllFDs);
            this.tabPageFindFDs.Controls.Add(this.buttonFindFDs);
            resources.ApplyResources(this.tabPageFindFDs, "tabPageFindFDs");
            this.tabPageFindFDs.Name = "tabPageFindFDs";
            this.tabPageFindFDs.UseVisualStyleBackColor = true;
            // 
            // comboBoxTableList
            // 
            this.comboBoxTableList.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxTableList, "comboBoxTableList");
            this.comboBoxTableList.Name = "comboBoxTableList";
            // 
            // labelTableName
            // 
            resources.ApplyResources(this.labelTableName, "labelTableName");
            this.labelTableName.Name = "labelTableName";
            // 
            // labelConnectLine1
            // 
            this.labelConnectLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelConnectLine1, "labelConnectLine1");
            this.labelConnectLine1.Name = "labelConnectLine1";
            // 
            // richTextBoxResultAllFDs
            // 
            this.richTextBoxResultAllFDs.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.richTextBoxResultAllFDs, "richTextBoxResultAllFDs");
            this.richTextBoxResultAllFDs.Name = "richTextBoxResultAllFDs";
            this.richTextBoxResultAllFDs.ReadOnly = true;
            // 
            // buttonFindFDs
            // 
            resources.ApplyResources(this.buttonFindFDs, "buttonFindFDs");
            this.buttonFindFDs.Name = "buttonFindFDs";
            this.buttonFindFDs.UseVisualStyleBackColor = true;
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageQuery.Controls.Add(this.labelConnectLine2);
            this.tabPageQuery.Controls.Add(this.buttonExecuteSQLQuery);
            this.tabPageQuery.Controls.Add(this.labelResultQuery);
            this.tabPageQuery.Controls.Add(this.dataGridViewResultQuery);
            this.tabPageQuery.Controls.Add(this.labelQuery);
            this.tabPageQuery.Controls.Add(this.textBoxInputSQLQuery);
            resources.ApplyResources(this.tabPageQuery, "tabPageQuery");
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // labelConnectLine2
            // 
            this.labelConnectLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelConnectLine2, "labelConnectLine2");
            this.labelConnectLine2.Name = "labelConnectLine2";
            // 
            // buttonExecuteSQLQuery
            // 
            resources.ApplyResources(this.buttonExecuteSQLQuery, "buttonExecuteSQLQuery");
            this.buttonExecuteSQLQuery.Name = "buttonExecuteSQLQuery";
            this.buttonExecuteSQLQuery.UseVisualStyleBackColor = true;
            this.buttonExecuteSQLQuery.Click += new System.EventHandler(this.buttonExecuteSQLQuery_Click);
            // 
            // labelResultQuery
            // 
            resources.ApplyResources(this.labelResultQuery, "labelResultQuery");
            this.labelResultQuery.Name = "labelResultQuery";
            // 
            // dataGridViewResultQuery
            // 
            this.dataGridViewResultQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewResultQuery, "dataGridViewResultQuery");
            this.dataGridViewResultQuery.Name = "dataGridViewResultQuery";
            this.dataGridViewResultQuery.ReadOnly = true;
            // 
            // labelQuery
            // 
            resources.ApplyResources(this.labelQuery, "labelQuery");
            this.labelQuery.Name = "labelQuery";
            // 
            // textBoxInputSQLQuery
            // 
            this.textBoxInputSQLQuery.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textBoxInputSQLQuery, "textBoxInputSQLQuery");
            this.textBoxInputSQLQuery.Name = "textBoxInputSQLQuery";
            // 
            // buttonBrowse
            // 
            resources.ApplyResources(this.buttonBrowse, "buttonBrowse");
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelResultFDsSet
            // 
            resources.ApplyResources(this.labelResultFDsSet, "labelResultFDsSet");
            this.labelResultFDsSet.Name = "labelResultFDsSet";
            // 
            // labelInputPath
            // 
            resources.ApplyResources(this.labelInputPath, "labelInputPath");
            this.labelInputPath.Name = "labelInputPath";
            // 
            // textBoxInputPath
            // 
            resources.ApplyResources(this.textBoxInputPath, "textBoxInputPath");
            this.textBoxInputPath.Name = "textBoxInputPath";
            this.textBoxInputPath.TextChanged += new System.EventHandler(this.textBoxInputPath_TextChanged);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAbout.Controls.Add(this.richTextBoxAbout);
            resources.ApplyResources(this.tabPageAbout, "tabPageAbout");
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAbout
            // 
            this.richTextBoxAbout.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.richTextBoxAbout, "richTextBoxAbout");
            this.richTextBoxAbout.Name = "richTextBoxAbout";
            this.richTextBoxAbout.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Query);
            this.Controls.Add(this.labelAuthor);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Query.ResumeLayout(false);
            this.tabPageCalculate.ResumeLayout(false);
            this.tabPageCalculate.PerformLayout();
            this.tabControlCalculate.ResumeLayout(false);
            this.tabPageSuperkeys.ResumeLayout(false);
            this.tabPageSuperkeys.PerformLayout();
            this.tabPageKeys.ResumeLayout(false);
            this.tabPageKeys.PerformLayout();
            this.tabPageClosures.ResumeLayout(false);
            this.tabPageClosures.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageConnect.ResumeLayout(false);
            this.tabPageConnect.PerformLayout();
            this.tabControlConnect.ResumeLayout(false);
            this.tabPageFindFDs.ResumeLayout(false);
            this.tabPageFindFDs.PerformLayout();
            this.tabPageQuery.ResumeLayout(false);
            this.tabPageQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultQuery)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private static MainForm _instance = null;
        public static MainForm getInstance()
        {
            if (_instance == null)
            {
                _instance = new MainForm();
            }
            return _instance;
        }

        private System.Windows.Forms.Label labelInputListAllAttributes;
        private System.Windows.Forms.Label labelInputListFDsSet;
        private System.Windows.Forms.Label labelResultListKeysSet;
        private System.Windows.Forms.Label labelResultListClosuresSet;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelInputFindClosureOf;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.Label labelCalculateLine1;
        private System.Windows.Forms.Label labelCalculateLine2;
        private System.Windows.Forms.TabControl Query;
        private System.Windows.Forms.TabPage tabPageCalculate;
        private System.Windows.Forms.TabPage tabPageConnect;
        private System.Windows.Forms.Label labelInputPath;
        private System.Windows.Forms.Label labelHeaderInput;
        private System.Windows.Forms.Label labelHeaderResult;
        private System.Windows.Forms.Label labelHeaderControl;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label labelResultFDsSet;
        private System.Windows.Forms.Button buttonFindFDs;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox richTextBoxAbout;
        public System.Windows.Forms.TextBox textBoxInputListAttributesSet;
        public System.Windows.Forms.TextBox textBoxInputListFDsSet;
        public System.Windows.Forms.TextBox textBoxResultListKeysSet;
        public System.Windows.Forms.TextBox textBoxResultListClosuresSet;
        public System.Windows.Forms.TextBox textBoxInputPath;
        private System.Windows.Forms.TabControl tabControlCalculate;
        private System.Windows.Forms.TabPage tabPageSuperkeys;
        private System.Windows.Forms.TabPage tabPageKeys;
        private System.Windows.Forms.TabPage tabPageClosures;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelResultClosureOfAttributes;
        public System.Windows.Forms.TextBox textBoxResultClosureOf;
        private System.Windows.Forms.Button buttonExecuteCalculate;
        private System.Windows.Forms.Label labelResultListSuperKeysSet;
        private System.Windows.Forms.TextBox textBoxInputListAttributesSetToFindClosures;
        private System.Windows.Forms.RichTextBox richTextBoxResultListSuperkeysSet;
        private System.Windows.Forms.TabControl tabControlConnect;
        private System.Windows.Forms.TabPage tabPageFindFDs;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.TextBox textBoxInputSQLQuery;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.DataGridView dataGridViewResultQuery;
        private System.Windows.Forms.Label labelResultQuery;
        private System.Windows.Forms.RichTextBox richTextBoxResultAllFDs;
        private System.Windows.Forms.Button buttonExecuteSQLQuery;
        private System.Windows.Forms.Label labelConnectLine1;
        private System.Windows.Forms.TextBox textBoxConnectionStatus;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.ComboBox comboBoxTableList;
        private System.Windows.Forms.Label labelConnectLine2;

        class CInProcess
        {
            public void init()
            {
                R = new System.Collections.Generic.List<string>();
                FDClosure = new System.Collections.Generic.List<uint>();
                SuperkeysSet = new System.Collections.Generic.List<uint>();
                KeysSet = new System.Collections.Generic.List<uint>();
                FDsSetLeft = new System.Collections.Generic.List<uint>();
                FDsSetRight = new System.Collections.Generic.List<uint>();
                specifiedAttributes = 0;
            }

            public static CInProcess getInstance()
            {
                if (_instance == null)
                {
                    _instance = new CInProcess();
                }
                return _instance;
            }
            public void readAttributeNamesFromString()
            {
                if (R.Count != 0)
                {
                    R.Clear();
                }

                string input;
                input = MainForm.getInstance().textBoxInputListAttributesSet.Text;
                input.Trim();
                bool flag_continue_add = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if (!flag_continue_add && input[i] != ',')
                    {
                        string text = "";
                        text += input[i];
                        R.Add(text);
                    }

                    if (flag_continue_add && input[i] != ',')
                    {
                        R[R.Count - 1] += input[i];
                    }

                    if (input[i] != ',')
                    {
                        flag_continue_add = true;
                    }
                    else
                    {
                        flag_continue_add = false;
                    }
                }
                //foreach (string i in R)
                //{
                //    System.Windows.Forms.MessageBox.Show(i + "|");
                //}
            }
            public void readFDsFromString()
            {
                // set empty FDs
                if (FDsSetLeft.Count != 0)
                {
                    FDsSetLeft.Clear();
                }
                if (FDsSetRight.Count != 0)
                {
                    FDsSetRight.Clear();
                }

                string input = MainForm.getInstance().textBoxInputListFDsSet.Text;
                int check = (int)NSDatabaseTools.CSupport.eCheck.left;
                string tempt = "";

                for (int i = 0; i < input.Length; i++)
                {
                    if (i == 0 || input[i] == ';')
                    {
                        FDsSetLeft.Add(0);
                    }

                    if (check != (int)CSupport.eCheck.left && input[i] == '-')
                    {
                        return;
                    }

                    if (input[i] == ',' || input[i] == ';' || input[i] == '-')
                    {
                        if (!R.Exists(x => x == tempt))
                        {
                            return;
                        }

                        if (check == (int)CSupport.eCheck.left)
                        {
                            FDsSetLeft[FDsSetLeft.Count - 1] = CSupport.union(FDsSetLeft[FDsSetLeft.Count - 1], CSupport.sll(1, R.IndexOf(tempt)));
                        }
                        else
                        {
                            FDsSetRight[FDsSetRight.Count - 1] = CSupport.union(FDsSetRight[FDsSetRight.Count - 1], CSupport.sll(1, R.IndexOf(tempt)));
                        }
                    }

                    if (input[i] == '-')
                    {
                        FDsSetRight.Add(0);
                        check = (int)CSupport.eCheck.right;
                    }

                    if (input[i] == ';')
                    {
                        check = (int)CSupport.eCheck.left;
                    }

                    if (input[i] == '-' || input[i] == ';' || input[i] == ',')
                    {
                        tempt = tempt.Remove(0);
                        tempt = "";
                    }
                    else
                    {
                        tempt += input[i];
                        if (check == (int)CSupport.eCheck.right && i == input.Length - 1)
                        {
                            if (R.Exists(x => x == tempt))
                            {
                                FDsSetRight[FDsSetRight.Count - 1] = CSupport.union(FDsSetRight[FDsSetRight.Count - 1], CSupport.sll(1, R.IndexOf(tempt)));
                            }
                            tempt = tempt.Remove(0);
                            tempt = "";
                        }
                    }
                }
                //for (int i = 0; i < FDsSetLeft.Count; i++)
                //{
                //    string a = "";
                //    ulong j = FDsSetLeft[i];
                //    int count = 0;
                //    while (j != 0)
                //    {
                //        if (CSupport.intrsct((ulong)j, 1) == 1)
                //        {
                //            a += R[count];
                //            a += ", ";
                //        }
                //        j = j >> 1;
                //        count++;
                //    }
                //    a += '-';
                //    j = FDsSetRight[i];
                //    count = 0;
                //    while (j != 0)
                //    {
                //        if (CSupport.intrsct((ulong)j, 1) == 1)
                //        {
                //            a += R[count];
                //            a += ", ";
                //        }
                //        j = j >> 1;
                //        count++;
                //    }

                //    System.Windows.Forms.MessageBox.Show(a);
                //}
            }
            public void readSpecifiedAttributesNames()
            {
                if (specifiedAttributes != 0)
                {
                    specifiedAttributes = 0;
                }

                string input = MainForm.getInstance().textBoxInputListAttributesSetToFindClosures.Text;
                input.Trim();

                string text = "";
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ',')
                    {
                        text += input[i];
                    }
                    if (input[i] == ',' || i == input.Length - 1)
                    {
                        if (R.Exists(x => x == text))
                        {
                            specifiedAttributes = CSupport.union(specifiedAttributes, CSupport.sll(1, R.IndexOf(text)));
                        }
                        text.Remove(0);
                        text = "";
                    }
                }
                //ulong j = specifiedAttributes;
                //string a = "";
                //int count = 0;
                //while (j != 0)
                //{
                //    if (CSupport.intrsct((ulong)j, 1) == 1)
                //    {
                //        a += R[count];
                //        a += ", ";
                //    }
                //    j = j >> 1;
                //    count++;
                //}
                //System.Windows.Forms.MessageBox.Show(a);
            }
            public void findAllClosures()
            {
                if (FDsSetLeft.Count != FDsSetRight.Count)
                {
                    return;
                }

                if (R.Count == 0)
                {
                    return;
                }

                if (FDClosure.Count != 0)
                {
                    FDClosure.Clear();
                }

                for (int i = 0; i < CSupport.powOf2(R.Count) - 1; i++)
                {
                    FDClosure.Add((uint)i + 1);
                    ulong old = FDClosure[(int)i];
                    do
                    {
                        old = FDClosure[(int)i];
                        for (int j = 0; j < FDsSetLeft.Count; j++)
                        {
                            if (CSupport.union(FDsSetLeft[j], FDClosure[(int)i]) == FDClosure[(int)i]
                                && CSupport.union(FDsSetRight[j], FDClosure[(int)i]) != FDClosure[(int)i])
                            {
                                FDClosure[i] = CSupport.union(FDClosure[i], FDsSetRight[j]);
                            }
                        }
                    } while (old != FDClosure[(int)i]);
                }
            }
            public void findAllSuperkeysAndKeys()
            {
                if (R.Count == 0)
                {
                    return;
                }

                if (FDClosure.Count == 0)
                {
                    return;
                }

                if (SuperkeysSet.Count != 0)
                {
                    SuperkeysSet.Clear();
                }

                if (SuperkeysSet.Count != 0)
                {
                    KeysSet.Clear();
                }

                ulong valueSuperkey = CSupport.srl(~((uint)0), (64 - R.Count));
                uint minNumDigits = (uint)R.Count;

                for (int i = 0; i < CSupport.powOf2(R.Count) - 1; i++)
                {
                    if (FDClosure[i] == valueSuperkey)
                    {
                        SuperkeysSet.Add((uint)+1);
                        if (CSupport.countBits((uint)i + 1) > minNumDigits)
                        {
                            continue;
                        }
                        if (CSupport.countBits((uint)i + 1) < minNumDigits)
                        {
                            minNumDigits = CSupport.countBits((uint)i + 1);
                            KeysSet.Clear();
                        }
                        KeysSet.Add((uint)i + 1);
                    }
                }
            }
            public void writeResultListAllClosures()
            {
                if (R.Count == 0)
                {
                    return;
                }

                if (FDClosure.Count == 0)
                {
                    return;
                }
                string text = "";
                for (int i = 0; i < CSupport.powOf2(R.Count) - 1; i++)
                {
                    uint num = FDClosure[i];
                    uint k = (uint)i + 1;
                    int count = 0;
                    while (k != 0)
                    {
                        if (CSupport.intrsct(k, 1) == 1)
                        {
                            text += R[count];
                            if (CSupport.srl(k, 1) != 0)
                            {
                                text += ',';
                            }
                        }
                        k = CSupport.srl(k, 1);
                        count++;
                    }
                    text += "+ = {";
                    count = 0;
                    while (num != 0)
                    {
                        if (CSupport.intrsct(num, 1) == 1)
                        {
                            text += R[count];
                            if (CSupport.srl(num, 1) != 0)
                            {
                                text += ',';
                            }
                        }
                        num = CSupport.srl(num, 1);
                        count++;
                    }
                    text += ("};" + System.Environment.NewLine);
                }
                MainForm.getInstance().textBoxResultListClosuresSet.Text = text;
            }
            public void writeResultClosureOfSpecifiedAttributes()
            {
                if (R.Count == 0)
                {
                    return;
                }

                if (FDClosure.Count == 0)
                {
                    return;
                }

                if (specifiedAttributes == 0)
                {
                    return;
                }

                uint index = specifiedAttributes;
                string text = "";
                uint num = FDClosure[(int)index - 1];
                int count = 0;
                while (index != 0)
                {
                    if (CSupport.intrsct(index, 1) == 1)
                    {
                        text += R[count];
                        if (CSupport.srl(index, 1) != 0)
                        {
                            text += ',';
                        }
                    }
                    index = CSupport.srl(index, 1);
                    count++;
                }
                text += "+ = {";
                count = 0;
                while (num != 0)
                {
                    if (CSupport.intrsct(num, 1) == 1)
                    {
                        text += R[count];
                        if (CSupport.srl(num, 1) != 0)
                        {
                            text += ',';
                        }
                    }
                    num = CSupport.srl(num, 1);
                    count++;
                }
                text += ("};" + System.Environment.NewLine);
                MainForm.getInstance().textBoxResultClosureOf.Text = text;
            }
            public void writeResultListAllSuperKeys()
            {
                if (SuperkeysSet.Count == 0)
                {
                    return;
                }
                string text = "";
                for (int i = 0; i < SuperkeysSet.Count; i++)
                {
                    text += "{";
                    uint index = SuperkeysSet[i];
                    int count = 0;
                    while (index != 0)
                    {
                        if (CSupport.intrsct(index, 1) == 1)
                        {
                            text += R[count];
                            if (CSupport.srl(index, 1) != 0)
                            {
                                text += ',';
                            }
                        }
                        index = CSupport.srl(index, 1);
                        count++;
                    }
                    text += ("};" + System.Environment.NewLine);
                }
                MainForm.getInstance().richTextBoxResultListSuperkeysSet.Text = text;
            }
            public void writeResultListAllKeys()
            {
                if (KeysSet.Count == 0)
                {
                    return;
                }
                string text = "";
                for (int i = 0; i < KeysSet.Count; i++)
                {
                    text += "{";
                    uint index = KeysSet[i];
                    int count = 0;
                    while (index != 0)
                    {
                        if (CSupport.intrsct(index, 1) == 1)
                        {
                            text += R[count];
                            if (CSupport.srl(index, 1) != 0)
                            {
                                text += ',';
                            }
                        }
                        index = CSupport.srl(index, 1);
                        count++;
                    }
                    text += ("};" + System.Environment.NewLine);
                }
                MainForm.getInstance().textBoxResultListKeysSet.Text = text;
            }


            private CInProcess() { }
            private static CInProcess _instance = null;
            private System.Collections.Generic.List<string> R;
            private System.Collections.Generic.List<uint> FDClosure;
            private System.Collections.Generic.List<uint> SuperkeysSet;
            private System.Collections.Generic.List<uint> KeysSet;
            private System.Collections.Generic.List<uint> FDsSetLeft;
            private System.Collections.Generic.List<uint> FDsSetRight;
            private uint specifiedAttributes;
        };
        class CADOConnection
        {
            private CADOConnection() { }
            public static CADOConnection getInstance()
            {
                if (_instance == null)
                {
                    _instance = new CADOConnection();
                }
                return _instance;
            }
            public void init()
            {
                R = new System.Collections.Generic.List<string>();
                FDClosure_i = new System.Collections.Generic.List<uint>();
                SuperkeysSet = new System.Collections.Generic.List<uint>();
                KeysSet = new System.Collections.Generic.List<uint>();
                FDsSetLeft = new System.Collections.Generic.List<uint>();
                FDsSetRight = new System.Collections.Generic.List<uint>();
                CANDIDATE_SET = new System.Collections.Generic.List<uint>();
            }
            public void open()
            {
                if (MainForm.getInstance().textBoxInputPath.TextLength == 0)
                {
                    return;
                }
                
                string text = "";

                for (int i = 0; i < MainForm.getInstance().textBoxInputPath.TextLength; i++)
                {
                    text += MainForm.getInstance().textBoxInputPath.Text[i];
                    if (MainForm.getInstance().textBoxInputPath.Text[i] == '\\')
                    {
                        text += '\\';
                    }
                }
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
            + text + ";User Id=admin;Password=;";
                getInstance()._connection = null;
                MainForm.getInstance().textBoxConnectionStatus.Text = "";
                _connection = new System.Data.OleDb.OleDbConnection(connectionString);
                if (_connection != null)
                {
                    MainForm.getInstance().textBoxConnectionStatus.ForeColor = System.Drawing.Color.Green;
                    MainForm.getInstance().textBoxConnectionStatus.Text = "OK";
                }
                else
                {
                    MainForm.getInstance().textBoxConnectionStatus.ForeColor = System.Drawing.Color.Red;
                    MainForm.getInstance().textBoxConnectionStatus.Text = "FAILED";
                }
                loadListOfTables();
            }
            public void executeSQLQuery()
            {
                if (MainForm.getInstance().textBoxInputSQLQuery.TextLength == 0)
                {
                    return;
                }
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(MainForm.getInstance().textBoxInputSQLQuery.Text, getInstance()._connection);
                getInstance()._connection.Open();
                System.Data.OleDb.OleDbDataReader reader = command.ExecuteReader();
                System.Data.OleDb.OleDbDataAdapter dataAdapter = new System.Data.OleDb.OleDbDataAdapter(MainForm.getInstance().textBoxInputSQLQuery.Text, getInstance()._connection);

                //string[] rowData = new string[columnCount];

                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.Fill(ds);
                MainForm.getInstance().dataGridViewResultQuery.DataSource = ds.Tables[0];
                _connection.Close();
            }
            public void prepareToFindFDs()
            {
                
            }
            public void findAllFDs()
            {
                if (CANDIDATE_SET.Count != 0)
                {
                    CANDIDATE_SET.Clear();
                }
                if (FDsSetLeft.Count != 0)
                {
                    FDsSetLeft.Clear();
                }
                if (FDsSetRight.Count != 0)
                {
                    FDsSetLeft.Clear();
                }
                if (FDClosure_i.Count != 0)
                {
                    FDClosure_i.Clear();
                }
                prepareToFindFDs();
                while (CANDIDATE_SET.Count != 0)
                {
                    for (int i = 0; i < CANDIDATE_SET.Count; i++)
                    {
                        ComputeNonTrivialClosure(CANDIDATE_SET[i]);
                        ObtaintFDandKey(CANDIDATE_SET[i]);
                    }
                }
                ObtainEQSet();
                PruneCandidates();
                GenerateNextLevelCandidates();
            }
            public void ComputeNonTrivialClosure(uint xi)
            {
                uint tempt1 = ~((uint)0);
                tempt1 -= (xi + 1);
                uint tempt2 = ~((uint)0);
                tempt2 -= CSupport.intrsct(tempt2, FDClosure_i[(int)xi]);
                uint resultTempt = CSupport.intrsct(tempt1, tempt2);

            }
            public void ObtaintFDandKey(uint xi)
            {
                FDsSetLeft.Add(xi);
                FDsSetRight.Add(FDClosure_i[(int)xi]);

            }
            public void ObtainEQSet()
            {
                for (int i = 0; i < CANDIDATE_SET.Count; i++)
                {

                }
            }
            public void PruneCandidates()
            {
                 for (int i = 0; i < CANDIDATE_SET.Count; i++)
                 {

                 }
            }
            public void GenerateNextLevelCandidates()
            {
                for (int i = 0; i < CANDIDATE_SET.Count; i++)
                {
                    for (int j = 0; j < CANDIDATE_SET.Count; i++)
                    {

                    }
                }
            }
            public void loadListOfTables()
            {
                if (MainForm.getInstance().textBoxConnectionStatus.Text == "OK")
                {
                    if (MainForm.getInstance().comboBoxTableList.Items.Count != 0)
                    {
                        MainForm.getInstance().comboBoxTableList.Items.Clear();
                    }
                    _connection.Open();
                    string[] restrictions = new string[4];
                    restrictions[3] = "Table";
                    System.Data.DataTable schema = _connection.GetSchema("Tables", restrictions);
                    for (int i = 0; i < schema.Rows.Count; i++ )
                    {
                        MainForm.getInstance().comboBoxTableList.Items.Add(schema.Rows[i][2].ToString());
                        R.Add(schema.Rows[i][2].ToString());
                    }
                    _connection.Close();
                }
            }

            private static CADOConnection _instance = null;
            private System.Data.OleDb.OleDbConnection _connection = null;
            private System.Collections.Generic.List<string> R;
            private System.Collections.Generic.List<uint> FDClosure_i;
            private System.Collections.Generic.List<uint> SuperkeysSet;
            private System.Collections.Generic.List<uint> KeysSet;
            private System.Collections.Generic.List<uint> FDsSetLeft;
            private System.Collections.Generic.List<uint> FDsSetRight;
            private System.Collections.Generic.List<uint> CANDIDATE_SET;
        };
    }
}


