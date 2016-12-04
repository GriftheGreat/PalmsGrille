using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

public partial class DataProvider
{
   public static string mytext = "bugs!";
   
   public string status
   {
      get { return "good"; }
      set { status = value; }
   }
}