using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.TeamContracts;

namespace VTW.API.Services.Contracts.V1.VoteContracts.Responses
{
    public class CreateVoteResponse
    {
        public CreateVoteResponse(VoteDto firstVoteDto, VoteDto biggestVoteDto)
        {
            FirstVoteDto = firstVoteDto;
            BiggestVoteDto = biggestVoteDto;
        }

        public VoteDto FirstVoteDto { get; set; }
        public VoteDto BiggestVoteDto { get; set; }
    }
}
