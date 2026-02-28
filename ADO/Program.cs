using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_SPU_411;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connection_string);
			string cmd = "SELECT movie_id, title,year,first_name,last_name  FROM Movies JOIN Directors ON (director=director_id)";
			//string cmd = "SELECT *  FROM Movies JOIN Directors ON (director=director_id)";


			Connector connector = new Connector(connection_string);
			Console.WriteLine("==========Movies==========");
			//connector.Select("title, year, first_name, last_name", "Movies, Directors", "director=director_id");
			connector.Select(cmd);

			Console.WriteLine("\n==========Directors==========");
			//connector.Insert("Directors", "6,N'Tarantino',N'Quentin'");
			//connector.Insert("Directors", "N'Fellini',N'Federico'");
			connector.Select("*", "Directors");
			connector.Update("Directors", 2, "first_name", "new abstract name");
		}
	}
}
