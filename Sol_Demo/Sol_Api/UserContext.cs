using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Api
{
    public interface IUserContext
    {
        Task<bool> GetInfo(int id);
    }

    public class UserContext : IUserContext
    {
        private readonly IUserRepository userRepository = null;
        private readonly IUserDbContextMock userDbContextMock = null;

        public UserContext(IUserRepository userRepository, IUserDbContextMock userDbContextMock)
        {
            this.userRepository = userRepository;
            this.userDbContextMock = userDbContextMock;
        }

        async Task<bool> IUserContext.GetInfo(int id)
        {
            var data1 = await userDbContextMock?.GetInfo(id);

            var data = await userRepository?.GetInfo(id);
            return data;
        }
    }
}