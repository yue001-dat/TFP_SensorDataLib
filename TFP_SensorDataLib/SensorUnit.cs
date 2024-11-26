using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFP_SensorDataLib
{
	public class SensorUnit
	{
		//[Key]
		public int Id {  get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }

		//[InverseProperty("SensorUnit")]
		private List<SensorData> SensorData { get; set; } = new List<SensorData>();	
				
	}
}
