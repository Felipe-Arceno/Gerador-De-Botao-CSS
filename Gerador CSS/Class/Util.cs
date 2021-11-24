using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Gerador_CSS.Class
{
    public class Util
    {
        public static string GetParam_Button_Default()
        {

            try
            {
                return ConfigurationManager.AppSettings.Get("Button_Default").ToString();
            }
            catch
            {
            }

            return "";
        }
    }
}