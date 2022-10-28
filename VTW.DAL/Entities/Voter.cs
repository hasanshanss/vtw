using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.DAL.Entities
{
    public partial class Voter : IdentityUser
    {
        public Voter()
        {
            BetNavigations = new HashSet<Bet>();
        }

        public virtual ICollection<Bet> BetNavigations { get; set; }
    }
}
