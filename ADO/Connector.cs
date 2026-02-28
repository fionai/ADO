using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ADO
{
	internal class Connector
	{
		string connection_string;
		SqlConnection connection;
		public Connector(string connection_string)
		{
			this.connection_string = connection_string;
			this.connection = new SqlConnection(connection_string);
		}
		public void Select(string fields, string tables, string condition = "")
		{
			string cmd = $"SELECT {fields} FROM {tables}";
			if (condition != "") cmd += $" WHERE {condition}";
			cmd += ";";
			connection.Open();
			SqlCommand command = new SqlCommand(cmd, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//Console.WriteLine($"{reader[0]}\t{reader[1]} {reader[2]}");
				for (int i = 0; i < reader.FieldCount; i++)
				{
					Console.Write(reader[i].ToString().PadRight(28));
				}
				Console.WriteLine();
			}

			reader.Close();
			connection.Close();
		}
		public void Select(string cmd)
		{
			connection.Open();
			SqlCommand command = new SqlCommand(cmd, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				for (int i = 0; i < reader.FieldCount; i++)
				{
					Console.Write(reader[i].ToString().PadRight(28));
				}
				Console.WriteLine();
			}
			reader.Close();
			connection.Close();

		}
		//public void Insert(string table, string values)
		//{
		//	string cmd = $"INSERT INTO {table} VALUES ({values})";
		//	connection.Open();
		//	SqlCommand command = new SqlCommand (cmd, connection);
		//	command.ExecuteNonQuery();
		//	connection.Close();
		//}
		public void Insert(string table, string values) //автоматизиует вставку ПК
		{
			string cmd = $"SELECT * FROM {table}";
			connection.Open();
			SqlCommand command = new SqlCommand(cmd, connection);
			SqlDataReader reader = command.ExecuteReader();
			int n = 0;
			while (reader.Read())	n++;
			n++;

			reader.Close();
			connection.Close();


			cmd = $"INSERT INTO {table} VALUES ({n},{values})";
			connection.Open();
			command = new SqlCommand (cmd, connection);
			command.ExecuteNonQuery();
			connection.Close();
		}

		//public void Update(string table, int PK_num, string field, string value)
		//{
		//	string cmd = $"SELECT * FROM {table}";
		//	connection.Open();
		//	SqlCommand command = new SqlCommand(cmd, connection);
		//	SqlDataReader reader = command.ExecuteReader();
		//	bool is_finded = false;
		//	int i = 0;
		//	string test = "";
		//	while (reader.Read() && !is_finded)
		//	{
		//		test = reader[i].ToString();
		//		i++;
		//	}
		//reader.Close();
		//connection.Close();
		//}
	}
}
