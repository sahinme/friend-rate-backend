using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Nnn.ApplicationCore.Entities.Users;
using Microsoft.Nnn.ApplicationCore.Interfaces;
using Nnn.ApplicationCore.Services.UserService.Dto;

namespace Microsoft.Nnn.Web.Controllers.Api
{
    public class UserController:BaseApiController
    {
        private readonly IUserService _userService;
        private readonly IEmailSender _emailSender;

        public UserController(IUserService userService,
                IEmailSender emailSender
            )
        {
            _userService = userService;
            _emailSender = emailSender;
        }

        [HttpGet("by-id")]
        public async Task<IActionResult> GetUser(int id)
        {
            var result = await _userService.GetUserById(id);
            return Ok(result);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetUserByName(string username)
        {
            var result = await _userService.GetUserByName(username);
            return result == null ? Ok(new {success = false, status=404}) : Ok(new {succes = true, result});
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromForm]  CreateUserDto input)
        {
           var user = await _userService.CreateUser(input);
           return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserDto input)
        {
            await _userService.UpdateUser(input);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(long id)
        {
            await _userService.DeleteUser(id);
            return Ok();
        }

        [HttpPost]
        public async Task EmailSend(string email, string subject, string message)
        {
            await _emailSender.SendEmailAsync(email, subject, message);
        }
    }
}