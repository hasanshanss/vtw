using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.GameTeamInfoContracts;

namespace VTW.API.Services.Contracts.V1.GameContracts
{
    public class GameDto 
    {
        public GameDto()
        {
            GameTeamInfos = new HashSet<GameTeamInfoDto>();
        }

        public int TeamCategoryId { get; set; }
        public string VoterId { get; set; } = null!;
        public bool IsStarted { get; set; }
        public bool IsFinished { get; set; }

        public IEnumerable<GameTeamInfoDto> GameTeamInfos { get; set; } = null!;
    }
}
