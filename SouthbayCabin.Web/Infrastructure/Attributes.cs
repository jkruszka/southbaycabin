using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SouthbayCabin.Web.Infrastructure
{
	public class Attributes
	{
		[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
		public class ValidPhoneNumber : ValidationAttribute
		{
			public override bool IsValid(object value)
			{
				if (value != null) { return Regex.Match(value.ToString(), @"^[2-9]\d{2}-\d{3}-\d{4}$").Success; }
				return true;
			}
		}

		[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
		public class ValidEmail : ValidationAttribute
		{
			public override bool IsValid(object value)
			{
				if (value != null) { return Regex.Match(value.ToString(), @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$").Success; }
				return true;
			}
		}
	}
}