using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltyBet_Desktop
{
	static class Util
	{
		/// <summary>
		/// Returns a timestamp with the formatting "yyyy-MM-dd HH:mm:ss"
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetTimeStamp(this DateTime value)
		{
			return string.Format("{0} {1}:{2}", value.ToString("yyyy-MM-dd"), value.ToString("HH"), value.ToString("mm"));
		}
	}
}
