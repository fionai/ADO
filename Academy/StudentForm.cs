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
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			DBtools.Connector connector = new DBtools.Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
			//connector.Insert("Students", $"N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',N'',N'',N'',{1}");
			connector.Insert($"INSERT Students(last_name,first_name,middle_name,birth_date,[group]) " +
				$"VALUES (N'{rtbLastNAme.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleNAme.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{1})");
		}
	}
}
