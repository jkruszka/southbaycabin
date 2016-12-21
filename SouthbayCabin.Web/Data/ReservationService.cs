using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SouthbayCabin.Web.Models;
using System.Data.SqlClient;
using SouthbayCabin.Web.Infrastructure;
using Dapper;

namespace SouthbayCabin.Web.Data
{
	public static class ReservationService
	{
		class SouthbayDatabase : Database<SouthbayDatabase>
		{
			public Table<Reservation> Reservations { get; set; }
		}

		public static List<Reservation> FetchReservations(int year)
		{
			var cnn = ConnectionFactory.GetConnection("southbay");
			cnn.Open();

			var db = SouthbayDatabase.Init(cnn, commandTimeout: 2);

			var reservations = db.Reservations.All();
			return (from r in reservations where r.StartDate.Year == year select r).OrderBy(x => x.StartDate).ToList();
		}

		public static Reservation Get(int id)
		{
			var cnn = ConnectionFactory.GetConnection("southbay");
			cnn.Open();

			var db = SouthbayDatabase.Init(cnn, commandTimeout: 2);

			return db.Reservations.Get(id);
		}

		public static int? Insert(Reservation reservation)
		{
			var cnn = ConnectionFactory.GetConnection("southbay");
			cnn.Open();

			var db = SouthbayDatabase.Init(cnn, commandTimeout: 2);
			return db.Reservations.Insert(new { Name = reservation.Name, StartDate = reservation.StartDate, EndDate = reservation.EndDate, Phone = reservation.Phone, Email = reservation.Email });

		}

		public static int Update(Reservation reservation)
		{
			var cnn = ConnectionFactory.GetConnection("southbay");
			cnn.Open();

			var db = SouthbayDatabase.Init(cnn, commandTimeout: 2);
			return db.Reservations.Update(reservation.Id, new { Name = reservation.Name, StartDate = reservation.StartDate, EndDate = reservation.EndDate, Phone = reservation.Phone, Email = reservation.Email });
		}

		public static bool Delete(int id)
		{
			var cnn = ConnectionFactory.GetConnection("southbay");
			cnn.Open();

			var db = SouthbayDatabase.Init(cnn, commandTimeout: 2);
			return db.Reservations.Delete(id); 
		}
	}
}