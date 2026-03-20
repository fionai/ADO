using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBtools;
using System.Runtime.InteropServices;

namespace Academy
{
	public partial class MainForm : Form
	{
	
		DataGridView[] tables = null;
		Query[] queries =
		{
			new Query("Students,Groups,Directions",
				"last_name,first_name,middle_name,group_name,direction_name",
				"[group]=group_id AND direction=direction_id"),
			new Query("Groups,Directions",
				"group_name,weekdays,start_time,start_date,direction_name",
				"direction=direction_id"),
			new Query("Directions","*"),
			new Query("Disciplines", "*"),
			new Query("Teachers", "*"),
		};
		string[] statusBarSignatures =
		{
			"Количество студентов",
			"Количество групп",
			"Количество направлений",
			"Количество дисциплин",
			"Количество преподавателей",
		};
		
		DBtools.Connector connector;
		DBtools.Connector movies_connector;
		public MainForm()
		{

			InitializeComponent();
			tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
			AllocConsole();
			connector = new DBtools.Connector("Data Source=PROBOOK\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
			tabControl_SelectedIndexChanged(tabControl, null);
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			tables[i].DataSource = connector.Select(queries[i].ToString());
			toolStripStatusLabel.Text = $"{statusBarSignatures[i]}: {tables[i].RowCount - 1}";
		}

		private void tbStudentsGroupF_MouseDown(object sender, MouseEventArgs e)
	{
			if (tbStudentsGroupF.Text == "Group filter")
			{
				tbStudentsGroupF.ForeColor = Color.Black;
				tbStudentsGroupF.Text = "";
			}
		}

		private void tbStudentsDirectionF_MouseDown(object sender, MouseEventArgs e)
		{
			if (tbStudentsDirectionF.Text == "Direction filter")
			{
				tbStudentsDirectionF.ForeColor = System.Drawing.Color.Black;
				tbStudentsDirectionF.Text = "";
			}
		}

		private void tbStudentsGroupF_DragEnter(object sender, DragEventArgs e) // не то
		{
			
		}

		private void tbStudentsGroupF_Enter(object sender, EventArgs e) // не то
		{
			
		}

		private void tbStudentsGroupF_KeyUp(object sender, KeyEventArgs e)
		{

			if (e.KeyData.ToString() == Keys.Enter.ToString() && tbStudentsGroupF.Text != "" && tbStudentsGroupF.Text != "Group filter")
			{
				tbStudentsGroupF.ForeColor = Color.Black;
				Query studentsFilteredByGroup = new Query("Students,Groups,Directions",
				"last_name,first_name,middle_name,group_name,direction_name",
				$"[group]=group_id AND direction=direction_id AND Groups.group_name LIKE ('{tbStudentsGroupF.Text}%')");
				tables[0].DataSource = connector.Select(studentsFilteredByGroup.ToString());
			}
			else if (e.KeyData.ToString() == Keys.Enter.ToString() && (tbStudentsGroupF.Text == "" || tbStudentsGroupF.Text != "Group filter"))
			{
				tables[0].DataSource = connector.Select(queries[0].ToString());
				tbStudentsGroupF.Text = "Group filter";
				tbStudentsGroupF.ForeColor = System.Drawing.Color.Gray;
			}
		}

		private void tbStudentsDirectionF_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData.ToString() == Keys.Enter.ToString() && tbStudentsDirectionF.Text != "" && tbStudentsDirectionF.Text != "Direction filter")
			{
				tbStudentsDirectionF.ForeColor = Color.Black;
				Query studentsFilteredByDirection = new Query("Students,Groups,Directions",
				"last_name,first_name,middle_name,group_name,direction_name",
				$"[group]=group_id AND direction=direction_id AND direction_name LIKE ('{tbStudentsDirectionF.Text}%')");
				tables[0].DataSource = connector.Select(studentsFilteredByDirection.ToString());
			}
			else if (e.KeyData.ToString() == Keys.Enter.ToString() && (tbStudentsDirectionF.Text == "" || tbStudentsDirectionF.Text != "Direction filter"))
			{
				tables[0].DataSource = connector.Select(queries[0].ToString());
				tbStudentsDirectionF.Text = "Direction filter";
				tbStudentsDirectionF.ForeColor = System.Drawing.Color.Gray;
			}
		}

		private void tbTeachersF_MouseDown(object sender, MouseEventArgs e)
		{
			if (tbTeachersF.Text == "Фамилия")
			{
				tbTeachersF.ForeColor = System.Drawing.Color.Black;
				tbTeachersF.Text = "";
			}
		}

		private void tbTeachersF_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData.ToString() == Keys.Enter.ToString() && tbTeachersF.Text != "" && tbTeachersF.Text != "Фамилия")
			{
				tbTeachersF.ForeColor = Color.Black;
				Query disciplinesViewedByTeacher = new Query("Disciplines, TeachersDisciplinesRelation, Teachers", 
				"discipline_name",
				$" teacher_id = teacher AND discipline_id = discipline  AND last_name LIKE ('{tbTeachersF.Text}%')");
				tables[4].DataSource = connector.Select(disciplinesViewedByTeacher.ToString());
			}
			else if (e.KeyData.ToString() == Keys.Enter.ToString() && (tbTeachersF.Text == "" || tbTeachersF.Text != "Фамилия"))
			{
				tables[4].DataSource = connector.Select(queries[4].ToString());
				tbStudentsDirectionF.Text = "Фамилия";
				tbStudentsDirectionF.ForeColor = System.Drawing.Color.Gray;
			}
		}
	}
}
