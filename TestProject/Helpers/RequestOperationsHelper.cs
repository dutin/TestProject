using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Helpers
{
    public class RequestOperationsHelper
    {
        private readonly RestClient client;

        public RequestOperationsHelper(RestClient client)
        {
            this.client = client;
        }

        internal T SendGetRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams)
        {
            throw new NotImplementedException();
        }

        internal T SendGetRequestAsObject<T>(string basePath, Dictionary<string, string> param)
        {
            throw new NotImplementedException();
        }

        internal T SendDeleteRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {
            throw new NotImplementedException();
        }

        internal T SendPutRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {
            throw new NotImplementedException();
        }

        internal T SendPostRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {
            throw new NotImplementedException();
        }
    }
}
