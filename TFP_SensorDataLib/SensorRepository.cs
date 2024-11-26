using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFP_SensorDataLib
{
	public class SensorRepository
	{
		private EnviromentSecrets enviromentSecrets = new EnviromentSecrets();
		private SensorDbContext _context;
	
		public SensorRepository()
		{
			var optionsBuilder = new DbContextOptionsBuilder<SensorDbContext>();
			optionsBuilder.UseSqlServer(enviromentSecrets.getDbConnectionString());

			_context = new SensorDbContext(optionsBuilder.Options);
		}

		public void TruncateDb()
		{
			_context.Database.ExecuteSqlRaw("TRUNCATE TABLE SensorData");
		}

		public SensorData Add(SensorData sensorData)
		{
			_context.SensorData.Add(sensorData);
			_context.SaveChanges();

			return sensorData;
		}

		public IEnumerable<SensorData> GetAll()
		{
			return _context.SensorData.ToList();
		}



		


	}
}
