using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using TestProject.Helpers;

namespace TestProject.Steps.BaseSteps
{
    public class BaseSteps<T>
    {
        public readonly string basePath;
        public readonly RestClient client;

        public BaseSteps(Uri baseUrl, string localToken, string basePathString)
        {
            basePath = basePathString;
            client = new RestClient(baseUrl);
            client.AddDefaultHeader("Authorisation", localToken);
        }
    }
}
