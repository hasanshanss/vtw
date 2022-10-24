using System;
using System.Collections.Generic;

namespace VTW.DAL.Entities
{
    public partial class Team : BaseEntity<long>
    {
        public Team()
        {
            VoteTeam1Navigations = new HashSet<Vote>();
            VoteTeam2Navigations = new HashSet<Vote>();
        }

        public string TeamName { get; set; } = null!;
        public int TeamCategoryId { get; set; }
        public virtual TeamCategory TeamCategoryNavigation { get; set; } = null!;
        public virtual ICollection<Vote> VoteTeam1Navigations { get; set; }
        public virtual ICollection<Vote> VoteTeam2Navigations { get; set; }
    }
}
