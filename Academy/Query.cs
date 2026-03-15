using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Academy
{
	internal class Query
	{
		Query[] queries =
		{
			new Query("Students,Groups,Directions",
				"last_name,first_name,middle_name,group_name,direction_name",
				"[group]=qroup_id AND direction=direction_id"),
			new Query("Groups,Directions",
				"group_name,weekdays,start_time,start_date,direction_name",
				"direction=direction_id"),
			new Query("Directions","*"),
			new Query("Disciplines", "*"),
			new Query("Teachers", "*"),
		};
		public string Tables {  get; set; }
		public string Fields { get; set; }
		public string Condition { get; set; }
		public Query(string tables, string fields, string condition = "") 
		{
			this.Tables = tables;
			this.Fields = fields;
			this.Condition = condition;
		}
		public override string ToString()
		{
			string cmd = $"SELECT {Fields} FROM {Tables}";
			if (Condition != "" && Condition != " ") cmd += $" WHERE {Condition}";
			cmd += ";";
			return cmd ;
		}
	}
}
