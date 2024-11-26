﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFP_SensorDataLib
{
	public class SensorData
	{
		//[Key]
		public int Id { get; set; } 

		public DateTime CreatedAt { get; set; }

		public double? Temperature { get; set; }
		public double? Humidity { get; set; }

		//[ForeignKey("SensorUnit")]
		public int? SensorUnitId { get; set; }
		public SensorUnit ?SensorUnit = new SensorUnit();	

	}
}
