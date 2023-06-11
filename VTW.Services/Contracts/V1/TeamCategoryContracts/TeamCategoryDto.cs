using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.V1.TeamCategoryContracts
{
    public class TeamCategoryDto  : BaseDto
    {
        public int Id { get; set; }
        public string TeamCategoryName { get; set; }
    }
}
