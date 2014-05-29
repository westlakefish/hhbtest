using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace b
{
    public class Cfg
    {
        public static string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
    }
}