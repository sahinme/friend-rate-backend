using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Nnn.ApplicationCore.Services.ReplyService.Dto;
using Microsoft.Nnn.ApplicationCore.Services.VoteService;
using Microsoft.Nnn.ApplicationCore.Services.VoteService.Dto;

namespace Microsoft.Nnn.Web.Controllers.Api
{
    public class VoteController:BaseApiController
       {
           private readonly IVoteAppService _voteAppService;
   
           public VoteController(IVoteAppService voteAppService)
           {
               _voteAppService = voteAppService;
           }
   
           [HttpPost]
           public async  Task<IActionResult> CreateVote(CreateVoteDto input)
           {
               var result = await _voteAppService.CreateVote(input);
               return Ok( new {success=true,result} );
           }
           
           [HttpGet]
           public async  Task<IActionResult> GetUserVotes(long id)
           {
               var result = await _voteAppService.GetUserVotes(id);
               return Ok( new {success=true,result,message="List successfuly fetched"} );
           }
       }
}