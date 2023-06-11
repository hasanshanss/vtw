using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.V1.TeamContracts.Requests
{
    public class CreateTeamRequest
    {
        public string TeamName { get; set; }
        public int TeamCategoryId { get; set; }
        public string CreatedBy { get; set; }
        public IFormFile Image { get; set; }
    }
}
