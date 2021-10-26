using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DTOs;

namespace TestProject.Steps.BaseSteps
{
    public class GetRolesSteps : BaseGetSteps<List<RoleDTO>>
    {
        public GetRolesSteps(Uri baseUrl, string localToken) : base(baseUrl, localToken, "/roles") { }
    }
}
