using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace SouthbayCabin.Web.Infrastructure
{
	public class ConnectionFactory
	{
		public static SqlConnection GetConnection(string name)
		{
			return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString);
		}

	}
}