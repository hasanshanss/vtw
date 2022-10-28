using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.DAL.Entities
{
    public partial class Bet : BaseEntity<long>
    {
        public string VoterId { get; set; }
        public Voter VoterNavigation { get; set; } = null!;
        public long VoteTeamInfoId { get; set; }
        public VoteTeamInfo VoteTeamInfoNavigation { get; set; } = null!;
        public decimal BetAmount { get; set; }
        public DateTime BetPlacedAt { get; set; }
        public BetType BetType { get; set; }
    }

    public enum BetType : byte
    {
        First,
        Ordinary,
        Most
    }
}
