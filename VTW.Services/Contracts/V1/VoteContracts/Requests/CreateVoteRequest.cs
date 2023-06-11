using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.DAL.Entities;

namespace VTW.API.Services.Contracts.V1.VoteContracts.Requests
{
    public class CreateVoteRequest
    {
        public int GameId { get; set; }
        public decimal VoteAmount { get; set; }
        public string VoterId { get; set; } = null!;
        public int GameTeamInfoId { get; set; }
    }
}
