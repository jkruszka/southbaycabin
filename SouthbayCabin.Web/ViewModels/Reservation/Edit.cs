using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SouthbayCabin.Web.ViewModels.Reservation
{
	public class Edit : Base
	{
		public int Id { get; set; }

		public Edit()
		{

		}

		public Edit(SouthbayCabin.Web.Models.Reservation reservation)
		{
			this.Id = reservation.Id;
			this.Name = reservation.Name;
			this.StartDate = reservation.StartDate;
			this.EndDate = reservation.EndDate;
			this.Phone = reservation.Phone;
			this.Email = reservation.Email; 			
		}
	}
}