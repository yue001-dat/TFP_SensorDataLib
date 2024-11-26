using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFP_SensorDataLib
{
	public class EnviromentSecrets
	{
		private string dbConnectionString = "Server=(localdb)\\mssqllocaldb;Database=TFE;Trusted_Connection=True;MultipleActiveResultSets=true";

		public string getDbConnectionString()
		{
			return dbConnectionString;
		}


	}
}
