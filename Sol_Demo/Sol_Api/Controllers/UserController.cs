using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository = null;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<String> GetNameById(int id)
        {
            return await userRepository?.GetNameById(id);
        }

        public async Task<bool> GetInfo(int id)
        {
            var data = await userRepository?.GetInfo(id);
            return data;
        }
    }
}