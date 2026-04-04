using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Academy
{
	public partial class StudentForm : HumanForm
	{
		public StudentForm()
		{
			InitializeComponent();
			rtbLastNAme.Text = "Соловьев";
			rtbFirstName.Text = "Дмитрий";
			rtbMiddleNAme.Text = "Владимирович";
			dtpBirthDate.Value = DateTime.Now;

			cbStudentsGroup.DataSource = DataBase.Connector.Select("*", "Groups");
			cbStudentsGroup.DisplayMember = "group_name";
			cbStudentsGroup.ValueMember = "group_id";
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			Academy.Models.Student student = new Models.Student
				(
				0,
				rtbLastNAme.Text,
				rtbFirstName.Text,
				rtbMiddleNAme.Text,
				dtpBirthDate.Value.ToString("yyyy-MM-dd"),
				rtbEmail.Text,
				rtbPhone.Text,
				pictureBoxPhoto.Image,
				Convert.ToInt32(cbStudentsGroup.SelectedValue)
				);
			DataBase.Connector.Insert($"INSERT Students({student.GetNames()}) VALUES ({student})");
			student.id = (int)DataBase.Connector.Scalar($"SELECT stud_id FROM Students WHERE {student.GetCondition()}");
			DataBase.Connector.UploadPhoto(student.SerializePhoto(), student.id, "photo", "Students");

			//DBtools.Connector connector = new DBtools.Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
			//connector.Insert("Students", $"N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',N'',N'',N'',{1}");
			//DataBase.Connector.Insert($"INSERT Students(last_name,first_name,middle_name,birth_date,[group]) " +
			//	$"VALUES (N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{cbStudentsGroup.SelectedValue})");
		}
	}
}
