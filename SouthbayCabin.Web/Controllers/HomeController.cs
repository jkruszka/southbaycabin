using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using SouthbayCabin.Web.Models;
using SouthbayCabin.Web.Infrastructure;
using SouthbayCabin.Web.Data;

namespace SouthbayCabin.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Welcome";
			return View();
		}

		public ActionResult Amenities()
		{
			return View();
		}

		public ActionResult Photos()
		{
			return View();
		}

		public ActionResult Availability()
		{
			return View();
		}

		public ActionResult Rates()
		{
			return View();
		}

		public ActionResult PageNotFound()
		{
			return View();
		}

		[HttpPost]
		public JsonResult GetBooked()
		{
			var reservations = ReservationService.FetchReservations(Helpers.GetYear());
			var events = new List<Event>();
			foreach (var r in reservations)
			{
				events.Add(new Event() { Title = "Reserved", Start = Helpers.GetUNIXTime(r.StartDate), End = Helpers.GetUNIXTime(r.EndDate) });
			}
					
			return Json(events, JsonRequestBehavior.AllowGet);
		}

		#region private members
		private double GetUNIXTime(DateTime date)
		{
			return (date - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
		}

		#endregion

	}
}
