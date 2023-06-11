using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.DAL.Entities
{
    public partial class GameTeamInfo : BaseEntity<int>
    {
        public GameTeamInfo()
        {
            VoteNavigations = new HashSet<Vote>();
        }

        public decimal TotalAmount { get; set; }
        public float TotalPercent { get; set; }
        public string FirstVoterId { get; set; } = null!;
        public string MostVoterId { get; set; } = null!;
        public int GameId { get; set; }
        public virtual Game GameNavigation { get; set; } = null!;
        public int TeamId { get; set; }
        public virtual Team TeamNavigation { get; set; } = null!;
        public virtual ICollection<Vote> VoteNavigations { get; set; }

    }
}
