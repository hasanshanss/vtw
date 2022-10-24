using System;
using System.Collections.Generic;

namespace VTW.DAL.Entities
{
    public partial class Vote : BaseEntity<long>
    {
        public bool IsCompleted { get; set; }
        public long Team1 { get; set; }
        public long Team2 { get; set; }

        public virtual Team Team1Navigation { get; set; } = null!;
        public virtual Team Team2Navigation { get; set; } = null!;
    }
}
