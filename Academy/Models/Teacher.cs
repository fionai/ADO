using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Academy.Models
{
	internal class Teacher : Human
	{
		string start_date;
		public Teacher
			(
				int id, string last_name, string first_name, string middle_name, string birth_date,
			string email, string phone, Image photo,
			string start_date
			) : base(id, last_name, first_name, middle_name, birth_date, email, phone, photo)
		{
			this.start_date = start_date;

		}
		public override string GetNames()
		{
			return base.GetNames() + ",work_since";
		}
		public override string ToString()
		{
			return base.ToString() + $",{start_date}";
		}
		public string GetCondition()
		{
			return $"last_name=N'{last_name}' AND first_name=N'{first_name}' AND middle_name=N'{middle_name}' AND birth_date=N'{birth_date}'";
		}
		public override string ToStringUpdate()
		{
			return base.ToStringUpdate() + $",work_since={start_date}";
		}

	}
}
