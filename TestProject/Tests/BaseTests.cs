using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Configuration;

namespace TestProject.Tests
{
    class BaseTests
    {
        public static Uri BaseUrl = new Uri(ConfigurationManager.AppSettings["baseUrl"]);
        public RestClient Client = new RestClient();
        public string BasePath;

        public IEnumerable<Parameter> Headers;
        public IEnumerable<Parameter> QueryParams;
        public IEnumerable<Parameter> PathParams;

        public BaseTests()
        {
            
        }

        [STAThread]
        static void Main()
        {
        }

    }
}
