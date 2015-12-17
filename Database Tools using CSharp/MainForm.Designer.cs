namespace NSDatabaseTools
{
    class CSupport
    {
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
            this.textBoxResultListSuperkeysSet = new System.Windows.Forms.TextBox();
            this.labelResultListSuperkeysSet = new System.Windows.Forms.Label();
            this.textBoxResultListClosuresSet = new System.Windows.Forms.TextBox();
            this.labelResultListClosuresSet = new System.Windows.Forms.Label();
            this.textBoxResultClosureOf = new System.Windows.Forms.TextBox();
            this.labelResultClosureOfAttributes = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxInputListAttributesSetToFindClosures = new System.Windows.Forms.TextBox();
            this.labelInputFindClosureOf = new System.Windows.Forms.Label();
            this.buttonFindClosuresSet = new System.Windows.Forms.Button();
            this.buttonFindSuperkeysSet = new System.Windows.Forms.Button();
            this.buttonFindKeysSet = new System.Windows.Forms.Button();
            this.buttonFindClosureOf = new System.Windows.Forms.Button();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.generalTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelHeaderControl = new System.Windows.Forms.Label();
            this.labelHeaderResult = new System.Windows.Forms.Label();
            this.labelHeaderInput = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // textBoxResultListSuperkeysSet
            // 
            this.textBoxResultListSuperkeysSet.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textBoxResultListSuperkeysSet, "textBoxResultListSuperkeysSet");
            this.textBoxResultListSuperkeysSet.Name = "textBoxResultListSuperkeysSet";
            this.textBoxResultListSuperkeysSet.ReadOnly = true;
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
            // textBoxResultClosureOf
            // 
            this.textBoxResultClosureOf.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textBoxResultClosureOf, "textBoxResultClosureOf");
            this.textBoxResultClosureOf.Name = "textBoxResultClosureOf";
            this.textBoxResultClosureOf.ReadOnly = true;
            // 
            // labelResultClosureOfAttributes
            // 
            resources.ApplyResources(this.labelResultClosureOfAttributes, "labelResultClosureOfAttributes");
            this.labelResultClosureOfAttributes.Name = "labelResultClosureOfAttributes";
            // 
            // labelAuthor
            // 
            resources.ApplyResources(this.labelAuthor, "labelAuthor");
            this.labelAuthor.Name = "labelAuthor";
            // 
            // textBoxInputListAttributesSetToFindClosures
            // 
            resources.ApplyResources(this.textBoxInputListAttributesSetToFindClosures, "textBoxInputListAttributesSetToFindClosures");
            this.textBoxInputListAttributesSetToFindClosures.Name = "textBoxInputListAttributesSetToFindClosures";
            // 
            // labelInputFindClosureOf
            // 
            resources.ApplyResources(this.labelInputFindClosureOf, "labelInputFindClosureOf");
            this.labelInputFindClosureOf.Name = "labelInputFindClosureOf";
            // 
            // buttonFindClosuresSet
            // 
            resources.ApplyResources(this.buttonFindClosuresSet, "buttonFindClosuresSet");
            this.buttonFindClosuresSet.Name = "buttonFindClosuresSet";
            this.buttonFindClosuresSet.UseVisualStyleBackColor = true;
            this.buttonFindClosuresSet.Click += new System.EventHandler(this.buttonFindClosuresSet_Click);
            // 
            // buttonFindSuperkeysSet
            // 
            resources.ApplyResources(this.buttonFindSuperkeysSet, "buttonFindSuperkeysSet");
            this.buttonFindSuperkeysSet.Name = "buttonFindSuperkeysSet";
            this.buttonFindSuperkeysSet.UseVisualStyleBackColor = true;
            this.buttonFindSuperkeysSet.Click += new System.EventHandler(this.buttonFindSuperkeysSet_Click);
            // 
            // buttonFindKeysSet
            // 
            resources.ApplyResources(this.buttonFindKeysSet, "buttonFindKeysSet");
            this.buttonFindKeysSet.Name = "buttonFindKeysSet";
            this.buttonFindKeysSet.UseVisualStyleBackColor = true;
            this.buttonFindKeysSet.Click += new System.EventHandler(this.buttonFindKeysSet_Click);
            // 
            // buttonFindClosureOf
            // 
            resources.ApplyResources(this.buttonFindClosureOf, "buttonFindClosureOf");
            this.buttonFindClosureOf.Name = "buttonFindClosureOf";
            this.buttonFindClosureOf.UseVisualStyleBackColor = true;
            this.buttonFindClosureOf.Click += new System.EventHandler(this.buttonFindClosureOf_Click);
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
            this.generalTabs.Controls.Add(this.tabPage1);
            this.generalTabs.Controls.Add(this.tabPage2);
            this.generalTabs.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.generalTabs, "generalTabs");
            this.generalTabs.Name = "generalTabs";
            this.generalTabs.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelHeaderControl);
            this.tabPage1.Controls.Add(this.labelHeaderResult);
            this.tabPage1.Controls.Add(this.labelHeaderInput);
            this.tabPage1.Controls.Add(this.textBoxResultListSuperkeysSet);
            this.tabPage1.Controls.Add(this.labelLine2);
            this.tabPage1.Controls.Add(this.labelInputListAllAttributes);
            this.tabPage1.Controls.Add(this.labelLine1);
            this.tabPage1.Controls.Add(this.textBoxInputListAttributesSet);
            this.tabPage1.Controls.Add(this.buttonResetAll);
            this.tabPage1.Controls.Add(this.labelInputListFDsSet);
            this.tabPage1.Controls.Add(this.buttonFindClosureOf);
            this.tabPage1.Controls.Add(this.textBoxInputListFDsSet);
            this.tabPage1.Controls.Add(this.buttonFindKeysSet);
            this.tabPage1.Controls.Add(this.labelResultListSuperkeysSet);
            this.tabPage1.Controls.Add(this.buttonFindSuperkeysSet);
            this.tabPage1.Controls.Add(this.labelResultListKeysSet);
            this.tabPage1.Controls.Add(this.buttonFindClosuresSet);
            this.tabPage1.Controls.Add(this.textBoxResultListKeysSet);
            this.tabPage1.Controls.Add(this.textBoxInputListAttributesSetToFindClosures);
            this.tabPage1.Controls.Add(this.labelResultListClosuresSet);
            this.tabPage1.Controls.Add(this.labelInputFindClosureOf);
            this.tabPage1.Controls.Add(this.textBoxResultListClosuresSet);
            this.tabPage1.Controls.Add(this.labelResultClosureOfAttributes);
            this.tabPage1.Controls.Add(this.textBoxResultClosureOf);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonBrowse);
            this.tabPage2.Controls.Add(this.richTextBoxResultFDsSet);
            this.tabPage2.Controls.Add(this.labelResultFDsSet);
            this.tabPage2.Controls.Add(this.buttonFindFDs);
            this.tabPage2.Controls.Add(this.labelInputPath);
            this.tabPage2.Controls.Add(this.textBoxInputPath);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage3.Controls.Add(this.richTextBoxAbout);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAbout
            // 
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label labelResultClosureOfAttributes;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelInputFindClosureOf;
        private System.Windows.Forms.Button buttonFindClosuresSet;
        private System.Windows.Forms.Button buttonFindSuperkeysSet;
        private System.Windows.Forms.Button buttonFindKeysSet;
        private System.Windows.Forms.Button buttonFindClosureOf;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.TabControl generalTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        public System.Windows.Forms.TextBox textBoxResultListSuperkeysSet;
        public System.Windows.Forms.TextBox textBoxResultListClosuresSet;
        public System.Windows.Forms.TextBox textBoxResultClosureOf;
        public System.Windows.Forms.TextBox textBoxInputListAttributesSetToFindClosures;
        public System.Windows.Forms.TextBox textBoxInputPath;
        public System.Windows.Forms.RichTextBox richTextBoxResultFDsSet;

        class CInProcess
        {
            public void init()
            {
                R = new System.Collections.Generic.List<string>();
                FDClosure = new System.Collections.Generic.List<ulong>();
                FDSetLeft = new System.Collections.Generic.List<ulong>();
                FDSetRight = new System.Collections.Generic.List<ulong>();
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
            public void getAttributeNamesFromString()
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
            public void getFDsFromString()
            {
                // set empty FDs
                if (FDSetLeft.Count != 0)
	            {
	            	FDSetLeft.Clear();
            	}
            	if (FDSetRight.Count != 0)
	            {
	            	FDSetRight.Clear();
	            }

                string input = MainForm.getInstance().textBoxInputListFDsSet.Text;
                int check = (int)NSDatabaseTools.CSupport.eCheck.left;
                string tempt = "";

                for (int i = 0; i < input.Length; i++)
	            {
		            if (i == 0 || input[i] == ';')
		            {
			            FDSetLeft.Add(0);
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
                            FDSetLeft[FDSetLeft.Count - 1] = CSupport.union(FDSetLeft[FDSetLeft.Count - 1], CSupport.sll(1, R.IndexOf(tempt)));
			            }
			            else
			            {
				            FDSetRight[FDSetRight.Count - 1] = CSupport.union(FDSetRight[FDSetRight.Count - 1], CSupport.sll(1, R.IndexOf(tempt)));
			            }
                    }

                    if (input[i] == '-')
		            {
		            	FDSetRight.Add(0);
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
                                FDSetRight[FDSetRight.Count - 1] = CSupport.union(FDSetRight[FDSetRight.Count - 1], CSupport.sll(1, R.IndexOf(tempt)));
                            }
				            tempt = tempt.Remove(0);
                            tempt = "";
                        }
                    }   
                }
                //for (int i = 0; i < FDSetLeft.Count; i++)
                //{
                //    string a = "";
                //    ulong j = FDSetLeft[i];
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
                //    j = FDSetRight[i];
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
            public void getSpecifiedAttributesNames()
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
                ulong j = specifiedAttributes;
                string a = "";
                int count = 0;
                while (j != 0)
                {
                    if (CSupport.intrsct((ulong)j, 1) == 1)
                    {
                        a += R[count];
                        a += ", ";
                    }
                    j = j >> 1;
                    count++;
                }
                System.Windows.Forms.MessageBox.Show(a);
            }
            public void findAllClosures()
            {
                if (FDSetLeft.Count != FDSetRight.Count)
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
                
                for (ulong i = 0; i < CSupport.powOf2(R.Count); i++)
                {
                    FDClosure.Add(0);
                    FDClosure[(int)i] = i + 1;
                }
            }

            private CInProcess(){}
            private static CInProcess _instance = null;
            private System.Collections.Generic.List<string> R;
            private System.Collections.Generic.List<ulong> FDClosure;
            private System.Collections.Generic.List<ulong> FDSetLeft;
            private System.Collections.Generic.List<ulong> FDSetRight;
            private ulong specifiedAttributes;
        }
    }
}

