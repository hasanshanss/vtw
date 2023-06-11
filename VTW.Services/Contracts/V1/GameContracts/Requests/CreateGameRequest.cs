using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.V1.GameContracts.Requests
{
    public class CreateGameRequest 
    {
        public string CreatedBy { get; set; }
        public int Team1_Id { get; set; }
        public int Team2_Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
