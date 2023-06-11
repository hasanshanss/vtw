using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.V1.GameTeamInfoContracts
{
    public class GameTeamInfoDto
    {
        public string TeamName { get; set; } = null!;
        public int TeamId { get; set; }
        public decimal TeamAmount { get; set; }
    }
}
