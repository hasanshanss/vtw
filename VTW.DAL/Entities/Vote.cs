using System;
using System.Collections.Generic;

namespace VTW.DAL.Entities
{
    public partial class Vote : BaseEntity<long>
    {
        public Vote()
        {
            VoteTeamInfoNavigations = new HashSet<VoteTeamInfo>();
        }
        public bool IsStarted { get; set; }
        public bool IsFinished { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<VoteTeamInfo> VoteTeamInfoNavigations { get; set; } = null!;
    }
}
