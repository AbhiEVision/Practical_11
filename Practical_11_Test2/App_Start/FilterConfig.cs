﻿using System.Web;
using System.Web.Mvc;

namespace Practical_11_Test2
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
