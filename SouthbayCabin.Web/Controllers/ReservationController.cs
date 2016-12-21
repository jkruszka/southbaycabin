using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SouthbayCabin.Web.Infrastructure;
using SouthbayCabin.Web.Data;
using SouthbayCabin.Web.ViewModels.Reservation;
using SouthbayCabin.Web.Models;

namespace SouthbayCabin.Web.Controllers
{
    public class ReservationController : Controller
    {
        //
        // GET: /Availability/

		[Authorize]
        public ActionResult Index()
        {
            return View();
        }

		[Authorize]
		public ActionResult IndexGrid(string sidx, string sord, int page, int rows)
		{
			var reservations = ReservationService.FetchReservations(Helpers.GetYear());
			
			var jsonData = new
			{
				total = (int)Math.Ceiling((double)reservations.Count() / rows),
				page = page,
				records = reservations.Count(),
				rows = reservations.Skip((page - 1) * rows).Take(rows)
			};

			return Json(jsonData, JsonRequestBehavior.AllowGet);
		}

		[Authorize]
		public ActionResult Add()
		{
			var model = new Add();
			return View(model); 
		}

		[Authorize]
		[HttpPost, ValidateInput(false)]
		public ActionResult Add(Add model)
		{
			if (ModelState.IsValid)
			{
				var reservation = new Reservation();
				reservation.Name = model.Name;
				reservation.StartDate = (DateTime)model.StartDate;
				reservation.EndDate = (DateTime)model.EndDate;
				reservation.Phone = model.Phone;
				reservation.Email = model.Email; 
				ReservationService.Insert(reservation);
				return RedirectToAction("Index");
			}
			return View(model); 
		}

		[Authorize]
		public ActionResult Edit(int id)
		{
			var model = new Edit(ReservationService.Get(id));
			return View(model);
		}

		[Authorize]
		[HttpPost, ValidateInput(false)]
		public ActionResult Edit(Edit model)
		{
			if (ModelState.IsValid)
			{
				var reservation = ReservationService.Get(model.Id);
				reservation.Name = model.Name;
				reservation.StartDate = (DateTime)model.StartDate;
				reservation.EndDate = (DateTime)model.EndDate;
				reservation.Phone = model.Phone;
				reservation.Email = model.Email;
				ReservationService.Update(reservation);
				return RedirectToAction("Index");
			}
			return View(model);
		}

		[Authorize]
		[HttpPost]
		public ActionResult Delete(int id)
		{
			var reservation = ReservationService.Get(id);
			if (reservation != null)
			{
				ReservationService.Delete(id); 
				return Json(id);
			}
			return Json("");
		}

    }
}
