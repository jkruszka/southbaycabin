using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SouthbayCabin.Web.Models
{
	public class Reservation
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Start
		{
			get
			{
				return StartDate.ToString("MM/dd/yyyy"); 
			}
		}
		public string End
		{
			get
			{
				return EndDate.ToString("MM/dd/yyyy");
			}
		}
	}
}