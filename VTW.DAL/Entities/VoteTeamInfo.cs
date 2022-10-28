using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.DAL.Entities
{
    public partial class VoteTeamInfo : BaseEntity<long>
    {
        public VoteTeamInfo()
        {
            BetNavigations = new HashSet<Bet>();
        }

        public decimal TotalAmount { get; set; }
        public float TotalPercent { get; set; }
        public long VoteId { get; set; }
        public virtual Vote VoteNavigation { get; set; } = null!;
        public long TeamId { get; set; }
        public virtual Team TeamNavigation { get; set; } = null!;
        public virtual ICollection<Bet> BetNavigations { get; set; }

    }
}
