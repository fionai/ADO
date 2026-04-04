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
			//rtbLastNAme.Text = "Соловьев";
			//rtbFirstName.Text = "Дмитрий";
			//rtbMiddleNAme.Text = "Владимирович";
			//dtpBirthDate.Value = DateTime.Now;

			cbStudentsGroup.DataSource = DataBase.Connector.Select("*", "Groups");
			cbStudentsGroup.DisplayMember = "group_name";
			cbStudentsGroup.ValueMember = "group_id";
		}
		public StudentForm(int id):this()
		{
			DataTable data = DataBase.Connector.Select("*", "Students", $"stud_id={id}");
			labelID.Text = $"ID: {id}";
			rtbLastNAme.Text = data.Rows[0]["last_name"].ToString();
			rtbFirstName.Text = data.Rows[0]["first_name"].ToString();
			rtbMiddleNAme.Text = data.Rows[0]["middle_name"].ToString();
			dtpBirthDate.Value = Convert.ToDateTime(data.Rows[0]["birth_date"].ToString());
			rtbEmail.Text = data.Rows[0]["email"].ToString() ;
			rtbPhone.Text = data.Rows[0]["phone"].ToString() ;
			cbStudentsGroup.SelectedValue = Convert.ToInt32(data.Rows[0]["group"].ToString());
			pictureBoxPhoto.Image = DataBase.Connector.DownloadPhoto(id, "Students", "photo");

		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			int id = labelID.Text.Split(':').Last() == "" ? 0 :Convert.ToInt32(labelID.Text.Split(':').Last());
			Academy.Models.Student student = new Models.Student
				(
				id,
				rtbLastNAme.Text,
				rtbFirstName.Text,
				rtbMiddleNAme.Text,
				dtpBirthDate.Value.ToString("yyyy-MM-dd"),
				rtbEmail.Text,
				rtbPhone.Text,
				pictureBoxPhoto.Image,
				Convert.ToInt32(cbStudentsGroup.SelectedValue)
				);
			if (student.id == 0)
			{
				DataBase.Connector.Insert($"INSERT Students({student.GetNames()}) VALUES ({student})");
				student.id = (int)DataBase.Connector.Scalar($"SELECT stud_id FROM Students WHERE {student.GetCondition()}");
				DataBase.Connector.UploadPhoto(student.SerializePhoto(), student.id, "photo", "Students");
			}
			else
			{
				DataBase.Connector.Update($"UPDATE Students SET {student.ToStringUpdate()} WHERE stud_id={student.id}");
			}
			if (student.photo != null)
			{
				DataBase.Connector.UploadPhoto(student.SerializePhoto(), student.id, "photo", "Students");
			}
			//DBtools.Connector connector = new DBtools.Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
			//connector.Insert("Students", $"N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',N'',N'',N'',{1}");
			//DataBase.Connector.Insert($"INSERT Students(last_name,first_name,middle_name,birth_date,[group]) " +
			//	$"VALUES (N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{cbStudentsGroup.SelectedValue})");
		}
	}
}
