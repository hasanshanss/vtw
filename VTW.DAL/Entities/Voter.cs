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
            VoteNavigations = new HashSet<Vote>();
        }

        public decimal Balance { get; set; }

        public virtual ICollection<Vote> VoteNavigations { get; set; }
    }
}
