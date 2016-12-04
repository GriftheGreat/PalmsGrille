using System;
namespace WebApplication1
{
   public partial class Default : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         this.me.Text = "Jacob" + DataProvider.mytext;
      }
   }
}

//https://msdn.microsoft.com/en-us/library/ms164642(v=vs.80).aspx
//
// and WebApplication1 !!! :)
//
//<pages>
//   <namespaces>
//      <add namespace="System" />
//      <add namespace="System.Collections" />
//      <add namespace="System.Collections.Specialized" />
//      <add namespace="System.Configuration" />
//      <add namespace="System.Text" />
//      <add namespace="System.Text.RegularExpressions" />
//      <add namespace="System.Web" />
//      <add namespace="System.Web.Caching" />
//      <add namespace="System.Web.SessionState" />
//      <add namespace="System.Web.Security" />
//      <add namespace="System.Web.Profile" />
//      <add namespace="System.Web.UI" />
//      <add namespace="System.Web.UI.WebControls" />
//      <add namespace="System.Web.UI.WebControls.WebParts" />
//      <add namespace="System.Web.UI.HtmlControls" />
//   </namespaces>
//   <!-- Other elements -->
//</pages>