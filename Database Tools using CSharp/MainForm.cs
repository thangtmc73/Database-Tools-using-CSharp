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

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm.CInProcess.getInstance().init();
        }

        private void buttonFindSuperkeysSet_Click(object sender, EventArgs e)
        {
            MainForm.CInProcess.getInstance().getAttributeNamesFromString();
            MainForm.CInProcess.getInstance().getFDsFromString();
        }

        private void buttonFindKeysSet_Click(object sender, EventArgs e)
        {

        }

        private void buttonFindClosuresSet_Click(object sender, EventArgs e)
        {

        }

        private void buttonFindClosureOf_Click(object sender, EventArgs e)
        {
            MainForm.CInProcess.getInstance().getAttributeNamesFromString();
            MainForm.CInProcess.getInstance().getSpecifiedAttributesNames();
        }

        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            MainForm.getInstance().textBoxInputListAttributesSet.Text = "";
            MainForm.getInstance().textBoxInputListAttributesSetToFindClosures.Text = "";
            MainForm.getInstance().textBoxInputListFDsSet.Text = "";
            MainForm.getInstance().textBoxInputPath.Text = "";
            MainForm.getInstance().textBoxResultClosureOf.Text = "";
            MainForm.getInstance().textBoxResultListClosuresSet.Text = "";
            MainForm.getInstance().textBoxResultListKeysSet.Text = "";
            MainForm.getInstance().textBoxResultListSuperkeysSet.Text = "";
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                textBoxInputPath.Text = openFileDialog.FileName;
                try
                {
                    string text;
                    text = File.ReadAllText(textBoxInputPath.Text);
                }
                catch (IOException)
                {
                }
            }
        }
    }
}