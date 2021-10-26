using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.DTOs
{
    public class PermissionsDTO
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Endpoint { get; set; }
        public string Method { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        [JsonProperty("__v")]
        public int Version { get; set; }
    }
}
