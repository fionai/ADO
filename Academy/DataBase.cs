using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Academy
{
	static internal class DataBase
	{
		public static DBtools.Connector Connector { get; set; } = new DBtools.Connector
			(
				ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString
			);

	}
}
