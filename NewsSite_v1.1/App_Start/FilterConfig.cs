﻿using System.Web;
using System.Web.Mvc;

namespace NewsSite_v1._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
