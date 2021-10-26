using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DTOs;
using TestProject.Steps.BaseSteps;

namespace TestProject.Steps
{
    public class PostRoleSteps : BasePostSteps<List<RoleDTO>>
    {
        public PostRoleSteps(Uri baseUrl, string localToken) : base(baseUrl, localToken, "/roles") { }
    }
}
