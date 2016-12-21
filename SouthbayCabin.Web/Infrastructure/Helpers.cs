using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SouthbayCabin.Web.Models;
using System.Xml.Linq;

namespace SouthbayCabin.Web.Infrastructure
{
	public static class Helpers
	{
		//public static IEnumerable<Reservation> FetchReservations(string url, int year)
		//{
		//    XDocument doc = XDocument.Load(url);
		//    return from r in doc.Descendants("reservation")
		//                       where r.Attribute("year").Value == year.ToString()
		//                       select new Reservation
		//                       {
		//                           Id = r.Attribute("id").Value,
		//                           Name = r.Attribute("name").Value,
		//                           Start = int.Parse(r.Attribute("start").Value),
		//                           End = int.Parse(r.Attribute("end").Value)
		//                       };
		//}

		public static double GetUNIXTime(DateTime date)
		{
			return (date - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
		}

		public static DateTime GetDateTime(int unix)
		{
			return new DateTime(1970, 1, 1).AddSeconds(unix); 
		}

		public static int GetYear()
		{
			var now = DateTime.Now;
			if (now.Month > 9) { return now.Year + 1;  }
			return now.Year; 
		}
	}
}