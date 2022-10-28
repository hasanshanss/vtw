using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.DAL.Entities
{
    public partial class TeamCategory : BaseEntity<int>
    {
        public TeamCategory()
        {
            TeamNavigations = new HashSet<Team>();
        }

        public string TeamCategoryName { get; set; }
        public virtual ICollection<Team> TeamNavigations{ get; set; }
    }
}
