using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DTOs;
using TestProject.Steps.BaseSteps;

namespace TestProject.Steps
{
    class PutRoleSteps : BasePutSteps<List<RoleDTO>>
    {
        public PutRoleSteps(Uri baseUrl, string localToken) : base(baseUrl, localToken, "/roles") { }
    }
}
