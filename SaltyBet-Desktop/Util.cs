using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltyBet_Desktop
{
	class Util
	{
		/// <summary>
		/// Returns a string of the current date and time in the format: 
		/// YYYY/MM/DD-HH:MM:SS
		/// </summary>
		/// <returns></returns>
		public string getLongDate()
		{
			return
				DateTime.Now.Year	+ "/" +
				DateTime.Now.Month	+ "/" +
				DateTime.Now.Day	+ "-" +
				DateTime.Now.Hour	+ ":" +
				DateTime.Now.Minute
			;
		}
	}
}
