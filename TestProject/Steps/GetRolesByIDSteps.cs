using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DTOs;
using TestProject.Steps.BaseSteps;

namespace TestProject.Steps.BaseSteps
{
    public class GetRolesByIDSteps : BaseGetSteps<List<RoleDTO>>
    {
        public GetRolesByIDSteps(Uri baseUrl, string localToken) : base(baseUrl, localToken, "/roles") { }
    }
}
