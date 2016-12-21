using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SouthbayCabin.Web.ViewModels.Reservation
{
	public class Base
	{
		[Display(Name = "Name")]
		[Required(ErrorMessage = "Name is required.")]
		public string Name { get; set; }

		[Display(Name = "Start Date")]
		[Required(ErrorMessage = "Start Date is required.")]
		//[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime? StartDate { get; set; }

		[Display(Name = "End Date")]
		[Required(ErrorMessage = "End Date is required.")]
		//[DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
		public DateTime? EndDate { get; set; }

		[Display(Name = "Phone Number")]
		[StringLength(12)]
		[DataType(DataType.PhoneNumber)]
		[Required(ErrorMessage = "Phone Number is required.")]
		[SouthbayCabin.Web.Infrastructure.Attributes.ValidPhoneNumber(ErrorMessage = "Invalid Phone Number.  Format: ###-###-####")]
		public string Phone { get; set; }

		[Display(Name = "Email")]
		[SouthbayCabin.Web.Infrastructure.Attributes.ValidEmail(ErrorMessage = "Invalid Email.")]
		[StringLength(200)]
		public string Email { get; set; }
	}
}