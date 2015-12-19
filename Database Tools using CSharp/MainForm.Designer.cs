namespace NSDatabaseTools
{
    class CSupport
    {
        public static uint countBits(ulong data)
        {
            data = intrsct(data, 0x5555555555555555) + (intrsct(srl(data, 1), 0x5555555555555555));
            data = intrsct(data, 0x3333333333333333) + (intrsct(srl(data, 2), 0x3333333333333333));
            data = intrsct(data, 0x0F0F0F0F0F0F0F0F) + (intrsct(srl(data, 4), 0x0F0F0F0F0F0F0F0F));
            data = intrsct(data, 0x00FF00FF00FF00FF) + (intrsct(srl(data, 8), 0x00FF00FF00FF00FF));
            data = intrsct(data, 0x0000FFFF0000FFFF) + (intrsct(srl(data, 16), 0x0000FFFF0000FFFF));
            data = intrsct(data, 0x00000000FFFFFFFF) + (intrsct(srl(data, 32), 0x00000000FFFFFFFF));
            return (uint)data;
        }

        public static ulong powOf2(int n)
        {
            return (ulong)1 << n;
        }

        public static ulong union(ulong a, ulong b)
        {
            return a | b;
        }

        public static ulong intrsct(ulong a, ulong b)
        {
            return a & b;
        }

        public static ulong sll(ulong a, int k)
        {
            return a << k;
        }

        public static ulong srl(ulong a, int k)
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
            this.labelResultListSuperkeysSet = new System.Windows.Forms.Label();
            this.textBoxResultListClosuresSet = new System.Windows.Forms.TextBox();
            this.labelResultListClosuresSet = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelInputFindClosureOf = new System.Windows.Forms.Label();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.generalTabs = new System.Windows.Forms.TabControl();
            this.tabPageCalculate = new System.Windows.Forms.TabPage();
            this.textBoxInputListAttributesSetToFindClosures = new System.Windows.Forms.TextBox();
            this.buttonExecuteCalculate = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSuperkeys = new System.Windows.Forms.TabPage();
            this.richTextBoxResultListSuperkeysSet = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageKeys = new System.Windows.Forms.TabPage();
            this.tabPageClosures = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelResultClosureOfAttributes = new System.Windows.Forms.Label();
            this.textBoxResultClosureOf = new System.Windows.Forms.TextBox();
            this.labelHeaderControl = new System.Windows.Forms.Label();
            this.labelHeaderResult = new System.Windows.Forms.Label();
            this.labelHeaderInput = new System.Windows.Forms.Label();
            this.tabPageConnect = new System.Windows.Forms.TabPage();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.richTextBoxResultFDsSet = new System.Windows.Forms.RichTextBox();
            this.labelResultFDsSet = new System.Windows.Forms.Label();
            this.buttonFindFDs = new System.Windows.Forms.Button();
            this.labelInputPath = new System.Windows.Forms.Label();
            this.textBoxInputPath = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxAbout = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.generalTabs.SuspendLayout();
            this.tabPageCalculate.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSuperkeys.SuspendLayout();
            this.tabPageKeys.SuspendLayout();
            this.tabPageClosures.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            // labelResultListSuperkeysSet
            // 
            resources.ApplyResources(this.labelResultListSuperkeysSet, "labelResultListSuperkeysSet");
            this.labelResultListSuperkeysSet.Name = "labelResultListSuperkeysSet";
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
            // labelLine1
            // 
            this.labelLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelLine1, "labelLine1");
            this.labelLine1.Name = "labelLine1";
            // 
            // labelLine2
            // 
            this.labelLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelLine2, "labelLine2");
            this.labelLine2.Name = "labelLine2";
            // 
            // generalTabs
            // 
            this.generalTabs.Controls.Add(this.tabPageCalculate);
            this.generalTabs.Controls.Add(this.tabPageConnect);
            this.generalTabs.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.generalTabs, "generalTabs");
            this.generalTabs.Name = "generalTabs";
            this.generalTabs.SelectedIndex = 0;
            // 
            // tabPageCalculate
            // 
            this.tabPageCalculate.BackColor = System.Drawing.Color.Transparent;
            this.tabPageCalculate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCalculate.Controls.Add(this.textBoxInputListAttributesSetToFindClosures);
            this.tabPageCalculate.Controls.Add(this.buttonExecuteCalculate);
            this.tabPageCalculate.Controls.Add(this.tabControl);
            this.tabPageCalculate.Controls.Add(this.labelHeaderControl);
            this.tabPageCalculate.Controls.Add(this.labelHeaderResult);
            this.tabPageCalculate.Controls.Add(this.labelHeaderInput);
            this.tabPageCalculate.Controls.Add(this.labelLine2);
            this.tabPageCalculate.Controls.Add(this.labelInputListAllAttributes);
            this.tabPageCalculate.Controls.Add(this.labelLine1);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSuperkeys);
            this.tabControl.Controls.Add(this.tabPageKeys);
            this.tabControl.Controls.Add(this.tabPageClosures);
            this.tabControl.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPageSuperkeys
            // 
            this.tabPageSuperkeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageSuperkeys.Controls.Add(this.richTextBoxResultListSuperkeysSet);
            this.tabPageSuperkeys.Controls.Add(this.label1);
            this.tabPageSuperkeys.Controls.Add(this.labelResultListSuperkeysSet);
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            this.tabPageConnect.Controls.Add(this.buttonBrowse);
            this.tabPageConnect.Controls.Add(this.richTextBoxResultFDsSet);
            this.tabPageConnect.Controls.Add(this.labelResultFDsSet);
            this.tabPageConnect.Controls.Add(this.buttonFindFDs);
            this.tabPageConnect.Controls.Add(this.labelInputPath);
            this.tabPageConnect.Controls.Add(this.textBoxInputPath);
            resources.ApplyResources(this.tabPageConnect, "tabPageConnect");
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            resources.ApplyResources(this.buttonBrowse, "buttonBrowse");
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // richTextBoxResultFDsSet
            // 
            resources.ApplyResources(this.richTextBoxResultFDsSet, "richTextBoxResultFDsSet");
            this.richTextBoxResultFDsSet.Name = "richTextBoxResultFDsSet";
            this.richTextBoxResultFDsSet.ReadOnly = true;
            // 
            // labelResultFDsSet
            // 
            resources.ApplyResources(this.labelResultFDsSet, "labelResultFDsSet");
            this.labelResultFDsSet.Name = "labelResultFDsSet";
            // 
            // buttonFindFDs
            // 
            resources.ApplyResources(this.buttonFindFDs, "buttonFindFDs");
            this.buttonFindFDs.Name = "buttonFindFDs";
            this.buttonFindFDs.UseVisualStyleBackColor = true;
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
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.richTextBoxAbout);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.generalTabs);
            this.Controls.Add(this.labelAuthor);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.generalTabs.ResumeLayout(false);
            this.tabPageCalculate.ResumeLayout(false);
            this.tabPageCalculate.PerformLayout();
            this.tabControl.ResumeLayout(false);
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
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelResultListSuperkeysSet;
        private System.Windows.Forms.Label labelResultListClosuresSet;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelInputFindClosureOf;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.TabControl generalTabs;
        private System.Windows.Forms.TabPage tabPageCalculate;
        private System.Windows.Forms.TabPage tabPageConnect;
        private System.Windows.Forms.Label labelInputPath;
        private System.Windows.Forms.Label labelHeaderInput;
        private System.Windows.Forms.Label labelHeaderResult;
        private System.Windows.Forms.Label labelHeaderControl;
        private System.Windows.Forms.TabPage tabPage3;
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
        public System.Windows.Forms.RichTextBox richTextBoxResultFDsSet;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSuperkeys;
        private System.Windows.Forms.TabPage tabPageKeys;
        private System.Windows.Forms.TabPage tabPageClosures;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelResultClosureOfAttributes;
        public System.Windows.Forms.TextBox textBoxResultClosureOf;
        private System.Windows.Forms.Button buttonExecuteCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputListAttributesSetToFindClosures;
        private System.Windows.Forms.RichTextBox richTextBoxResultListSuperkeysSet;

        class CInProcess
        {
            public void init()
            {
                R = new System.Collections.Generic.List<string>();
                FDClosure = new System.Collections.Generic.List<ulong>();
                SuperkeysSet = new System.Collections.Generic.List<ulong>();
                KeysSet = new System.Collections.Generic.List<ulong>();
                FDsSetLeft = new System.Collections.Generic.List<ulong>();
                FDsSetRight = new System.Collections.Generic.List<ulong>();
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

                for (ulong i = 0; i < CSupport.powOf2(R.Count) - 1; i++)
                {
                    FDClosure.Add(i + 1);
                    ulong old = FDClosure[(int)i];
                    do
                    {
                        old = FDClosure[(int)i];
                        for (int j = 0; j < FDsSetLeft.Count; j++)
                        {
                            if (CSupport.union(FDsSetLeft[j], FDClosure[(int)i]) == FDClosure[(int)i]
                                && CSupport.union(FDsSetRight[j], FDClosure[(int)i]) != FDClosure[(int)i])
                            {
                                FDClosure[(int)i] = CSupport.union(FDClosure[(int)i], FDsSetRight[j]);
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

                ulong valueSuperkey = CSupport.srl((~(ulong)(0)), (64 - R.Count));
                uint minNumDigits = (uint)R.Count;

                for (ulong i = 0; i < CSupport.powOf2(R.Count) - 1; i++)
                {
                    if (FDClosure[(int)i] == valueSuperkey)
                    {
                        SuperkeysSet.Add(i + 1);
                        if (CSupport.countBits(i + 1) > minNumDigits)
                        {
                            continue;
                        }
                        if (CSupport.countBits(i + 1) < minNumDigits)
                        {
                            minNumDigits = CSupport.countBits(i + 1);
                            KeysSet.Clear();
                        }
                        KeysSet.Add(i + 1);
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
                for (ulong i = 0; i < CSupport.powOf2(R.Count) - 1; i++)
                {
                    ulong num = FDClosure[(int)i];
                    ulong k = i + 1;
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

                ulong index = specifiedAttributes;
                string text = "";
                ulong num = FDClosure[(int)index - 1];
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
                    ulong index = SuperkeysSet[i];
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
                    ulong index = (ulong)KeysSet[i];
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
            private System.Collections.Generic.List<ulong> FDClosure;
            private System.Collections.Generic.List<ulong> SuperkeysSet;
            private System.Collections.Generic.List<ulong> KeysSet;
            private System.Collections.Generic.List<ulong> FDsSetLeft;
            private System.Collections.Generic.List<ulong> FDsSetRight;
            private ulong specifiedAttributes;
        };
    }
}


