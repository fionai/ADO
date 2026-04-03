using DBtools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Academy
{
	public partial class StudentForm : HumanForm
	{
			SqlConnection connection;

		DBtools.Connector connector;

		DataGridView[] tables = null;

		Dictionary<string, int> d_directions = null;
		Dictionary<string, Dictionary<string, int>> d_trees = null;
		public StudentForm()
		{
			InitializeComponent();
			tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
			//AllocConsole();


			string connection_string = ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString;
			Console.WriteLine(connection_string);
			connector = new Connector(connection_string);
			connection = new SqlConnection(connection_string);

			//InitializeComponent();
			rtbLastNAme.Text = "Соколов";
			rtbFirstName.Text = "Михаил";
			rtbMiddleNAme.Text = "Аркадьевич";
			dtpBirthDate.Value = DateTime.Now;
			d_trees = new Dictionary<string, Dictionary<string, int>>();
			d_trees.Add("group_name", d_directions);
			LoadDataToComboBox(cbStudentsGroup);
		}

		void LoadDataToComboBox(ComboBox comboBox)
		{
			//			string table = comboBox.Name.Substring(Array.FindLastIndex<char>(comboBox.Name.ToCharArray(), Char.IsUpper)) + "s";



			string table = "Groups";
			string dictionary_name = $"d_direction".ToLower();
			//Console.WriteLine("==============");
			//Console.WriteLine(table);
			//Console.WriteLine(dictionary_name);

			//d_directions = connector.LoadDictionary(table);
			d_trees[dictionary_name] = connector.LoadDictionary(table);
			foreach (KeyValuePair<string, int> i in d_trees[dictionary_name])
			{
				comboBox.Items.Add(i.Key);
			}



		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			string cmd = $"SELECT group_id FROM Groups WHERE group_name='{cbStudentsGroup.Text.Trim(' ')}'";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			object primary_key = command.ExecuteScalar();

			connection.Close();


			DBtools.Connector connector = new DBtools.Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
			//object primary_key = connector.GetGroup_id(cbStudentsGroup.Text.Trim(' '));
			connector.Insert($"INSERT Students(last_name,first_name,middle_name,birth_date,[group]) " +
				$"VALUES (N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{primary_key})");
				//$"VALUES (N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',N'{cbStudentsGroup.Text.Trim(' ')}')");
				//$"VALUES (N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{1})");
		}

		private void cbStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			//cbStudentsGroup.Items.Clear();


			//DBtools.Connector connector = new DBtools.Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
			//cbStudentsGroup.DataSource = (connector.Select("group_name", "Groups"));
			//.DataSource = connector.Select("group_name", "Groups");

			//toolStripStatusLabel.Text = $"{statusBarSignatures[0]}: {dgvStudents.RowCount - 1}";
			//dgvStudents.DataSource = connector.Select("group_name", "Groups");
			//toolStripStatusLabel.Text = $"{statusBarSignatures[0]}: {dgvStudents.RowCount - 1}";
		}

		private void cbStudentsGroup_Click(object sender, EventArgs e)
		{


		}
	}
}
