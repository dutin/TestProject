using Newtonsoft.Json;
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
        private readonly RestClient _client;
        private readonly RestRequest _request;


        public RequestOperationsHelper(RestClient client)
        {
            _client = client;
            _request = new RestRequest();
        }

        private void SetRequestProperties(RestRequest request, Method method, string basePath,
            Dictionary<string, string> pathParams, Dictionary<string, string> queryParams)
        {
            request.Resource = basePath;
            request.Method = method; 
            request.RequestFormat = DataFormat.Json;
            foreach (var param in pathParams)
            {
                request.AddUrlSegment(param.Key, param.Value);
            }
            foreach (var param in queryParams)
            {
                request.AddQueryParameter(param.Key, param.Value);
            }
        }       
               

        private void AddBodyToRequest(RestRequest request, object body)
        {
            var jsonBody = new Parameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
            request.AddJsonBody(jsonBody);

        }

        //for GET
        public IRestResponse SendGetRequest(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams)
        {
            SetRequestProperties(_request, Method.GET, basePath, pathParams, queryParams);
            IRestResponse response = _client.Execute(_request);
            return response;
        } 
        public T SendGetRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams)
        {
            var response = SendGetRequest(basePath, pathParams, queryParams).Content.ToString();
            return JsonConvert.DeserializeObject<T>(response);
        }
        
        //for DELETE
        public IRestResponse SendDeleteRequest(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams)
        {
            SetRequestProperties(_request, Method.DELETE, basePath, pathParams, queryParams);
            IRestResponse response = _client.Execute(_request);
            return response;
        }
        public T SendDeleteRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams)
        {
            var response = SendDeleteRequest(basePath, pathParams,queryParams).Content.ToString();
            return JsonConvert.DeserializeObject<T>(response);
        }

        //for POST
        public IRestResponse SendPostRequest(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {
            SetRequestProperties(_request, Method.POST, basePath, pathParams, queryParams);
            AddBodyToRequest(_request, body);
            IRestResponse response = _client.Execute(_request);
            return response;
        }
        public T SendPostRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {            
            var response = SendPostRequest(basePath, pathParams, queryParams, body).Content.ToString();            
            return JsonConvert.DeserializeObject<T>(response);
        }

        //for PUT
        public IRestResponse SendPutRequest(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {
            SetRequestProperties(_request, Method.PUT, basePath, pathParams, queryParams);
            AddBodyToRequest(_request, body);
            IRestResponse response = _client.Execute(_request);
            return response;
        }
        public T SendPutRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {
            var response = SendPutRequest(basePath, pathParams, queryParams, body).Content.ToString();
            return JsonConvert.DeserializeObject<T>(response);
        }

        //for PATCH
        public IRestResponse SendPatchRequest(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {
            SetRequestProperties(_request, Method.PATCH, basePath, pathParams, queryParams);
            AddBodyToRequest(_request, body);
            IRestResponse response = _client.Execute(_request);
            return response;
        }
        public T SendPatchRequestAsObject<T>(string basePath, Dictionary<string, string> pathParams, Dictionary<string, string> queryParams, object body)
        {
            var response = SendPatchRequest(basePath, pathParams, queryParams, body).Content.ToString();
            return JsonConvert.DeserializeObject<T>(response);
        }
    }
}
