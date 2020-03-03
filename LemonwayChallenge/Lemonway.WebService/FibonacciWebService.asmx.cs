using System;
using System.Web.Services;
using System.Xml;

namespace Lemonway.WebService
{
    /// <summary>
    /// Summary description for Fibonacci
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FibonacciWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public int Fibonacci(int n)
        {
            try
            {
                if (n < 1 || n > 100)
                    return -1;
                int a = 0;
                int b = 1;
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }

                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
                return json;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
