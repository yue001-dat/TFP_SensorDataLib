using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFP_SensorDataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TFP_SensorDataLib.Tests
{
	[TestClass()]
	public class SensorRepositoryTests
	{

		private SensorRepository _sensorRepository = new SensorRepository();
		public SensorData testSensorData = new SensorData { Humidity = 45.00, Temperature = 21.50 };


		[TestInitialize]
		public void InitOnce() 
		{
			_sensorRepository.TruncateDb();
		}

		[TestMethod()]
		public void AddTest()
		{
			_sensorRepository.Add(testSensorData);

			Assert.IsTrue(_sensorRepository.GetAll().Count() > 0, "No Rows Returned. Failed to Add.");
		}

		[TestMethod()]
		[DataRow(0)]
		public void GetLatestSensorData(int fetchRows)
		{
			_sensorRepository.GetAll()
			   .OrderByDescending(s => s.Id)
			   .Take(fetchRows)
			   .ToList();

			Assert.IsTrue(_sensorRepository.GetAll().Count() <= fetchRows, "No Rows Returned. Failed to Fetch.");
		}




	}
}