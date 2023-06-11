using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.V1.TeamContracts
{
    public class TeamDto 
    {
        public int Id { get; set; }
        public int TeamCategoryId { get; set; }
        public int TeamName { get; set; }
    }
}
