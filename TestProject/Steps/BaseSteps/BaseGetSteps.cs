using System;
using System.Collections.Generic;
using TestProject.Helpers;

namespace TestProject.Steps.BaseSteps
{
    public class BaseGetSteps<T> : BaseSteps<T>
    {
        public BaseGetSteps(Uri baseUrl, string localToken, string basePathString) : base(baseUrl, localToken, basePathString) { }

        public T SendGetRequestNoParams()
        {
            var pathParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            return new RequestOperationsHelper(client).SendGetRequestAsObject<T>(basePath, pathParams, queryParams);
        }

        public T SendGetWithOneQueryParam(string queryParamName, string queryParamValue)
        {
            var parameter = new Dictionary<string, string>()
            {
                {queryParamName, queryParamValue }
            };

            return new RequestOperationsHelper(client).SendGetRequestAsObject<T>(basePath, parameter);
        }

        public T SendGetWithOnePathParamAndOneQueryParam(string firstPathName, string firstPathValue, string queryParamName, string queryParamValue)
        {
            var pathParams = new Dictionary<string, string>
            {
                { firstPathName, firstPathValue }
            };
            var queryParams = new Dictionary<string, string>
            {
                { queryParamName, queryParamValue }
            };

            return new RequestOperationsHelper(client).SendGetRequestAsObject<T>(basePath, pathParams, queryParams);
        }

        public T SendGetWithOnePathParamsAndTwoQueryParams
            (
                string firstPathName, 
                string firstPathValue,
                string firstQueryParamName, 
                string firstQueryParamValue,
                string secondQueryParamName,
                string secondQueryParamValue
            )
        {
            var pathParams = new Dictionary<string, string>
            {
                { firstPathName, firstPathValue },
            };
            var queryParams = new Dictionary<string, string>
            {
                { firstQueryParamName, firstQueryParamValue },
                { secondQueryParamName, secondQueryParamValue }
            };

            return new RequestOperationsHelper(client).SendGetRequestAsObject<T>(basePath, pathParams, queryParams);
        }

        public T SendGetWithThreePathParams
            (
                string firstPathName, 
                string firstPathValue, 
                string secondPathName, 
                string secondPathValue, 
                string thirdPathName, 
                string thirdPathValue
            )
        {
            var pathParams = new Dictionary<string, string>
            {
                { firstPathName, firstPathValue },
                { secondPathName, secondPathValue },
                { thirdPathName, thirdPathValue }
            };

            return new RequestOperationsHelper(client).SendGetRequestAsObject<T>(basePath, pathParams);
        }
    }
}
