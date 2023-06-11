
using VTW.DAL.Entities;

namespace VTW.API.Services.Contracts.V1.VoteContracts
{
    public class VoteDto 
    {
        public string VoterId { get; set; } = null!;
        public Voter VoterNavigation { get; set; } = null!;
        public long GameTeamInfoId { get; set; }
        public GameTeamInfo GameTeamInfoNavigation { get; set; } = null!;
        public decimal VoteAmount { get; set; }
        public DateTime VotedAt { get; set; }
    }
}
