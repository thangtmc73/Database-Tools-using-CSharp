using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NSDatabaseTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void resetResult()
        {
            // reset
            MainForm.getInstance().textBoxResultClosureOf.Text = "";
            MainForm.getInstance().textBoxResultListClosuresSet.Text = "";
            MainForm.getInstance().richTextBoxResultListKeysSet.Text = "";
            MainForm.getInstance().richTextBoxResultListSuperkeysSet.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CInProcess.getInstance().init();
        }
       
        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            MainForm.getInstance().textBoxInputListAttributesSet.Text = "";
            MainForm.getInstance().textBoxInputListAttributesSetToFindClosures.Text = "";
            MainForm.getInstance().textBoxInputListFDsSet.Text = "";
            MainForm.getInstance().textBoxInputPath.Text = "";
            MainForm.getInstance().textBoxResultClosureOf.Text = "";
            MainForm.getInstance().textBoxResultListClosuresSet.Text = "";
            MainForm.getInstance().richTextBoxResultListKeysSet.Text = "";
            MainForm.getInstance().richTextBoxResultListSuperkeysSet.Text = "";
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                textBoxInputPath.Text = openFileDialog.FileName;
            }
        }

        private void buttonExecuteCalculate_Click(object sender, EventArgs e)
        {
            CInProcess.getInstance().readAttributeNamesFromString();
            CInProcess.getInstance().readFDsFromString();
            CInProcess.getInstance().readSpecifiedAttributesNames();
            CInProcess.getInstance().findAllClosures();
            CInProcess.getInstance().findAllSuperkeysAndKeys();
            CInProcess.getInstance().writeResultListAllSuperKeys();
            CInProcess.getInstance().writeResultListAllClosures();
            CInProcess.getInstance().writeResultClosureOfSpecifiedAttributes();
            CInProcess.getInstance().writeResultListAllKeys();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            CADOConnection.getInstance().open();
        }

        private void buttonExecuteSQLQuery_Click(object sender, EventArgs e)
        {
            CADOConnection.getInstance().executeSQLQuery();
        }

        private void textBoxInputPath_TextChanged(object sender, EventArgs e)
        {
            MainForm.getInstance().textBoxConnectionStatus.Text = "";
        }
    }
}