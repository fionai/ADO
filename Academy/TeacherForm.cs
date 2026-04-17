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
	public partial class TeacherForm : HumanForm 
	{
		public TeacherForm()
		{
			InitializeComponent();
		}
		public TeacherForm(int id):this()
		{
			DataTable data = DataBase.Connector.Select("*", "Teachers", $"teacher_id={id}");
			labelID.Text = $"ID: {id}";
			rtbLastNAme.Text = data.Rows[0]["last_name"].ToString();
			rtbFirstName.Text = data.Rows[0]["first_name"].ToString();
			rtbMiddleNAme.Text = data.Rows[0]["middle_name"].ToString();
			dtpBirthDate.Value = Convert.ToDateTime(data.Rows[0]["birth_date"].ToString());
			rtbEmail.Text = data.Rows[0]["email"].ToString();
			rtbPhone.Text = data.Rows[0]["phone"].ToString();
			pictureBoxPhoto.Image = DataBase.Connector.DownloadPhoto(id, "Teachers", "photo");
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			int id = labelID.Text.Split(':').Last() == "" ? 0 : Convert.ToInt32(labelID.Text.Split(':').Last());
			Academy.Models.Teacher teacher = new Models.Teacher
				(
				id,
				rtbLastNAme.Text,
				rtbFirstName.Text,
				rtbMiddleNAme.Text,
				dtpBirthDate.Value.ToString("yyyy-MM-dd"),
				rtbEmail.Text,
				rtbPhone.Text,
				pictureBoxPhoto.Image
				);
			if (teacher.id == 0)
			{
				DataBase.Connector.Insert($"INSERT Teachers({teacher.GetNames()}) VALUES ({teacher})");
				teacher.id = (int)DataBase.Connector.Scalar($"SELECT teacher_id FROM Teachers WHERE {teacher.GetCondition()}");
				DataBase.Connector.UploadPhoto(teacher.SerializePhoto(), teacher.id, "photo", "Teachers");
			}
			else
			{
				DataBase.Connector.Update($"UPDATE Teachers SET {teacher.ToStringUpdate()} WHERE teacher_id={teacher.id}");
			}
			if (teacher.photo != null)
			{
				DataBase.Connector.UploadPhoto(teacher.SerializePhoto(), teacher.id, "photo", "Teachers");
			}
		}
	}
}
