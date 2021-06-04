using Api.Errors;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            var users =  _userRepository.getUsers();

            return Ok(users);
        }


        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _userRepository.getUserById(id);
            if (user == null)
            {
                return NotFound(new CodeErrorResponse(404));
            }
            return user;
        }
    }
}
