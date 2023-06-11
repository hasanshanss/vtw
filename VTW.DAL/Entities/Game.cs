using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VTW.DAL.Entities
{
    public partial class Game : BaseEntity<int>
    {
        public Game()
        {
            GameTeamInfoNavigations = new HashSet<GameTeamInfo>();
        }
        public bool IsStarted { get; set; }
        public bool IsFinished { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        public virtual ICollection<GameTeamInfo> GameTeamInfoNavigations { get; set; } = null!;
    }
}
