using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Nnn.ApplicationCore.Entities.Votes;
using Microsoft.Nnn.ApplicationCore.Services.VoteService.Dto;

namespace Microsoft.Nnn.ApplicationCore.Services.VoteService
{
    public interface IVoteAppService
    {
        Task<Vote> CreateVote(CreateVoteDto input);
        Task<List<VoteDto>> GetUserVotes(long userId);
    }
}