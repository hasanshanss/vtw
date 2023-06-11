using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.V1.TeamCategoryContracts.Requests
{
    public class CreateTeamCategoryRequest : BaseDto
    {
        public string TeamCategoryName { get; set; }
        public string CreatedBy { get; set; }
    }
}
