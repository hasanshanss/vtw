using System;
using System.Collections.Generic;

namespace VTW.DAL.Entities
{
    public partial class Team : BaseEntity<int>
    {
        public Team()
        {
            VoteTeamNavigations = new HashSet<Vote>();
        }
        public string TeamName { get; set; } = null!;
        public int TeamCategoryId { get; set; }
        public virtual TeamCategory TeamCategoryNavigation { get; set; } = null!;
        public virtual ICollection<Vote> VoteTeamNavigations { get; set; }
    }
}
