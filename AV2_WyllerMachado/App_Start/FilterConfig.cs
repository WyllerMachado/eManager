﻿using System.Web;
using System.Web.Mvc;

namespace AV2_WyllerMachado
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
