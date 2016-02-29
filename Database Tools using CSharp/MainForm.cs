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
		private MainForm()
		{
			InitializeComponent();
		}

		class Calculate
		{
			private static Calculate _instance = null;

			private Calculate() { }

			public static Calculate Instance
			{
				get
				{
					if (_instance == null)
					{
						_instance = new Calculate();
					}
					return _instance;
				}
			}

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

			public void readAttributeNamesFromString()
			{
				if (R.Count != 0)
				{
					R.Clear();
				}

				string input;
				input = MainForm.Instance.textBoxInputListAttributesSet.Text;
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
				//System.Windows.Forms.MessageBox.Show(i + "|");
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

				string input = MainForm.Instance.textBoxInputListFDsSet.Text;
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
				//string a = "";
				//ulong j = FDsSetLeft[i];
				//int count = 0;
				//while (j != 0)
				//{
				//if (CSupport.intrsct((ulong)j, 1) == 1)
				//{
				//a += R[count];
				//a += ", ";
				//}
				//j = j >> 1;
				//count++;
				//}
				//a += '-';
				//j = FDsSetRight[i];
				//count = 0;
				//while (j != 0)
				//{
				//if (CSupport.intrsct((ulong)j, 1) == 1)
				//{
				//a += R[count];
				//a += ", ";
				//}
				//j = j >> 1;
				//count++;
				//}

				//System.Windows.Forms.MessageBox.Show(a);
				//}
			}
			public void readSpecifiedAttributesNames()
			{
				if (specifiedAttributes != 0)
				{
					specifiedAttributes = 0;
				}

				string input = MainForm.Instance.textBoxInputListAttributesSetToFindClosures.Text;
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
				//if (CSupport.intrsct((ulong)j, 1) == 1)
				//{
				//a += R[count];
				//a += ", ";
				//}
				//j = j >> 1;
				//count++;
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

				if (KeysSet.Count != 0)
				{
					KeysSet.Clear();
				}

				uint valueSuperkey = CSupport.srl(~((uint)0), (32 - R.Count));

				for (int i = 0; i < CSupport.powOf2(R.Count) - 1; i++)
				{
					if (FDClosure[i] == valueSuperkey)
					{
						SuperkeysSet.Add((uint)i + 1);
						bool flag = false;
						if (KeysSet.Count != 0)
						{
							for (int j = 0; j < KeysSet.Count; j++)
							{
								if (CSupport.union(KeysSet[j], (uint)(i + 1)) == (uint)(i + 1))
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							KeysSet.Add((uint)(i + 1));
						}
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
				MainForm.Instance.textBoxResultListClosuresSet.Text = text;
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
				MainForm.Instance.textBoxResultClosureOf.Text = text;
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
				MainForm.Instance.richTextBoxResultListSuperkeysSet.Text = text;
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
				MainForm.Instance.richTextBoxResultListKeysSet.Text = text;
			}

			private System.Collections.Generic.List<string> R;
			private System.Collections.Generic.List<uint> FDClosure;
			private System.Collections.Generic.List<uint> SuperkeysSet;
			private System.Collections.Generic.List<uint> KeysSet;
			private System.Collections.Generic.List<uint> FDsSetLeft;
			private System.Collections.Generic.List<uint> FDsSetRight;
			private uint specifiedAttributes;
		};
		class ADOConnection
		{
			private static ADOConnection _instance = null;

			private ADOConnection() { }

			public static ADOConnection Instance
			{
				get
				{
					if (_instance == null)
					{
						_instance = new ADOConnection();
					}
					return _instance;
				}
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
			public bool open()
			{
				if (MainForm.Instance.textBoxInputPath.TextLength == 0)
				{
					return false;
				}

				string text = "";

				for (int i = 0; i < MainForm.Instance.textBoxInputPath.TextLength; i++)
				{
					text += MainForm.Instance.textBoxInputPath.Text[i];
					if (MainForm.Instance.textBoxInputPath.Text[i] == '\\')
					{
						text += '\\';
					}
				}

				string extFile = System.IO.Path.GetExtension(MainForm.Instance.textBoxInputPath.Text);

				string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
+ text + ";User Id=admin;Password=;";
				Instance._connection = new System.Data.OleDb.OleDbConnection(connectionString);
				if (Instance._connection == null)
				{
					return false;
				}
				return true;
			}
			public void executeSQLQuery()
			{
				if (MainForm.Instance.textBoxInputSQLQuery.TextLength == 0)
				{
					return;
				}
				System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(MainForm.Instance.textBoxInputSQLQuery.Text, Instance._connection);
				Instance._connection.Open();
				System.Data.OleDb.OleDbDataReader reader = command.ExecuteReader();
				System.Data.OleDb.OleDbDataAdapter dataAdapter = new System.Data.OleDb.OleDbDataAdapter(MainForm.Instance.textBoxInputSQLQuery.Text, Instance._connection);

				//string[] rowData = new string[columnCount];

				System.Data.DataSet ds = new System.Data.DataSet();
				dataAdapter.Fill(ds);
				MainForm.Instance.dataGridViewResultQuery.DataSource = ds.Tables[0];
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
				if (MainForm.Instance.comboBoxTableList.Items.Count != 0)
				{
					MainForm.Instance.comboBoxTableList.Items.Clear();
				}
				_connection.Open();
				string[] restrictions = new string[4];
				restrictions[3] = "Table";
				System.Data.DataTable schema = _connection.GetSchema("Tables", restrictions);
				for (int i = 0; i < schema.Rows.Count; i++)
				{
					MainForm.Instance.comboBoxTableList.Items.Add(schema.Rows[i][2].ToString());
					R.Add(schema.Rows[i][2].ToString());
				}
				_connection.Close();
			}
			private System.Data.OleDb.OleDbConnection _connection = null;
			private System.Collections.Generic.List<string> R;
			private System.Collections.Generic.List<uint> FDClosure_i;
			private System.Collections.Generic.List<uint> SuperkeysSet;
			private System.Collections.Generic.List<uint> KeysSet;
			private System.Collections.Generic.List<uint> FDsSetLeft;
			private System.Collections.Generic.List<uint> FDsSetRight;
			private System.Collections.Generic.List<uint> CANDIDATE_SET;
		};


		private void resetResult()
		{
			// reset
			textBoxResultClosureOf.Text = "";
			textBoxResultListClosuresSet.Text = "";
			richTextBoxResultListKeysSet.Text = "";
			richTextBoxResultListSuperkeysSet.Text = "";
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Calculate.Instance.init();
			ADOConnection.Instance.init();
		}

		private void buttonResetAll_Click(object sender, EventArgs e)
		{
			textBoxInputListAttributesSet.Text = "";
			textBoxInputListAttributesSetToFindClosures.Text = "";
			textBoxInputListFDsSet.Text = "";
			textBoxInputPath.Text = "";
			textBoxResultClosureOf.Text = "";
			textBoxResultListClosuresSet.Text = "";
			richTextBoxResultListKeysSet.Text = "";
			richTextBoxResultListSuperkeysSet.Text = "";
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
			Calculate.Instance.readAttributeNamesFromString();
			Calculate.Instance.readFDsFromString();
			Calculate.Instance.readSpecifiedAttributesNames();
			Calculate.Instance.findAllClosures();
			Calculate.Instance.findAllSuperkeysAndKeys();
			Calculate.Instance.writeResultListAllSuperKeys();
			Calculate.Instance.writeResultListAllClosures();
			Calculate.Instance.writeResultClosureOfSpecifiedAttributes();
			Calculate.Instance.writeResultListAllKeys();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			if (ADOConnection.Instance.open())
			{
				ADOConnection.Instance.loadListOfTables();
			}
		}

		private void buttonExecuteSQLQuery_Click(object sender, EventArgs e)
		{
			ADOConnection.Instance.executeSQLQuery();
		}
	}
}