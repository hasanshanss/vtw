using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.DAL.Entities
{
    public partial class Vote : BaseEntity<long>
    {
        public string VoterId { get; set; } = null!;
        public Voter VoterNavigation { get; set; } = null!;
        public int GameTeamInfoId { get; set; }
        public GameTeamInfo GameTeamInfoNavigation { get; set; } = null!;
        public decimal VoteAmount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime VotedDate { get; set; }
    }
}
