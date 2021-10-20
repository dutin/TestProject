using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Helpers;

namespace TestProject.Steps.BaseSteps
{
    public class BaseDeleteSteps<T>: BaseSteps<T>
    {
        public BaseDeleteSteps(Uri baseUrl, string localToken, string basePathString) : base(baseUrl, localToken, basePathString) { }
        public T SendDeleteWithNoParams(object body)
        {
            var pathParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            return new RequestOperationsHelper(client).SendDeleteRequestAsObject<T>(basePath, pathParams, queryParams);
        }
    }
}
