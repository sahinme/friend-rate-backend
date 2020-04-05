using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Nnn.ApplicationCore.Entities.Users;
using Microsoft.Nnn.ApplicationCore.Entities.Votes;
using Microsoft.Nnn.ApplicationCore.Interfaces;
using Microsoft.Nnn.ApplicationCore.Services.VoteService.Dto;

namespace Microsoft.Nnn.ApplicationCore.Services.VoteService
{
    public class VoteAppService:IVoteAppService
    {
        private readonly IAsyncRepository<Vote> _voteRepository;
        private readonly IAsyncRepository<User> _userRepository;

        public VoteAppService(IAsyncRepository<Vote> voteRepository,IAsyncRepository<User> userRepository)
        {
            _voteRepository = voteRepository;
            _userRepository = userRepository;
        }
        
        public async Task<Vote> CreateVote(CreateVoteDto input)
        {
            var vote = new Vote
            {
                UserId = input.UserId,
                VoterName = input.VoterName,
                Survivor = input.Survivor,
                CarModel = input.CarModel,
                Football = input.Football,
                Netflix = input.Netflix,
                Instrument = input.Instrument,
                YesilCam = input.YesilCam,
                Series = input.Series,
                Singer = input.Singer,
                Startup = input.Startup,
                MusicType = input.MusicType
            };
            await _voteRepository.AddAsync(vote);
            return vote;
        }

        public async Task<List<VoteDto>> GetUserVotes(string username)
        {
            var user = await _userRepository.GetAll().Where(x => x.Username == username).FirstOrDefaultAsync();
            var result = await _voteRepository.GetAll().Where(x => x.UserId == user.Id).Include(x => x.User)
                .Select(x => new VoteDto
                {
                    Id = x.Id,
                    User = x.User.Username,
                    VoterName = x.VoterName,
                    CreatedDateTime = x.CreatedDate,
                    Survivor = x.Survivor,
                    CarModel = x.CarModel,
                    Football = x.Football,
                    Netflix = x.Netflix,
                    Instrument = x.Instrument,
                    YesilCam = x.YesilCam,
                    Series = x.Series,
                    Singer = x.Singer,
                    Startup = x.Startup,
                    MusicType = x.MusicType
                }).ToListAsync();
            return result;
        }
    }
}