using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;

namespace ExceptionToText
{
    public class ExceptionToText
    {
        private static String ErrorlineNo, Errormsg, extype, exurl;

        public static void SendErrorToText(Exception ex)
        {
            ErrorlineNo = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
            Errormsg = ex.GetType().Name.ToString();
            extype = ex.GetType().ToString();
            exurl = HttpContext.Current.Request.Url.ToString();
            DateTime Logdate = DateTime.Now;

            string filepath = HttpContext.Current.Server.MapPath("~/ExceptionsFile.txt");
            using (StreamWriter sw = File.AppendText(filepath))
            {
                sw.WriteLine("Log Date:" + Logdate.ToString());
                sw.WriteLine("Error Line No :" + ErrorlineNo);
                sw.WriteLine("Error Message :" + Errormsg);
                sw.WriteLine("Error Type:" + extype);
                sw.WriteLine("Error URL :" + exurl);
                sw.WriteLine("---------------------------------------------------------------------");
                sw.WriteLine("\n");

            }
        }
    }
}

