using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Nnn.ApplicationCore.Entities.Votes;
using Microsoft.Nnn.ApplicationCore.Interfaces;
using Microsoft.Nnn.ApplicationCore.Services.VoteService.Dto;

namespace Microsoft.Nnn.ApplicationCore.Services.VoteService
{
    public class VoteAppService:IVoteAppService
    {
        private readonly IAsyncRepository<Vote> _voteRepository;

        public VoteAppService(IAsyncRepository<Vote> voteRepository)
        {
            _voteRepository = voteRepository;
        }
        
        public async Task<Vote> CreateVote(CreateVoteDto input)
        {
            var vote = new Vote
            {
                UserId = input.UserId,
                VoterName = input.VoterName,
                Honest = input.Honest,
                Reliable = input.Reliable,
                Handsome = input.Handsome,
                Beautiful = input.Beautiful,
                Clever = input.Clever,
                Impressive = input.Impressive,
                Sympathetic = input.Sympathetic,
                ClothingStyle = input.ClothingStyle,
                MakeUp = input.MakeUp,
                Funny = input.Funny,
                HairStyle = input.HairStyle,
                TalkingStyle = input.TalkingStyle
            };
            await _voteRepository.AddAsync(vote);
            return vote;
        }

        public async Task<List<VoteDto>> GetUserVotes(long userId)
        {
            var result = await _voteRepository.GetAll().Where(x => x.UserId == userId).Include(x => x.User)
                .Select(x => new VoteDto
                {
                    Id = x.Id,
                    User = x.User.Username,
                    VoterName = x.VoterName,
                    Honest = x.Honest,
                    Reliable = x.Reliable,
                    Handsome = x.Handsome,
                    Beautiful = x.Beautiful,
                    Clever = x.Clever,
                    Impressive = x.Impressive,
                    Sympathetic = x.Sympathetic,
                    ClothingStyle = x.ClothingStyle,
                    MakeUp = x.MakeUp,
                    Funny = x.Funny,
                    HairStyle = x.HairStyle,
                    TalkingStyle = x.TalkingStyle
                }).ToListAsync();
            return result;
        }
    }
}