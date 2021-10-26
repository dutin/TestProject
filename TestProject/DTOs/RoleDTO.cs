using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.DTOs
{
    public class RoleDTO
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        public IList<PermissionsDTO> Permissions { get; set; }
        public IList<string> EmployeeIds { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        [JsonProperty("__v")]
        public int Version { get; set; }
    }
}
