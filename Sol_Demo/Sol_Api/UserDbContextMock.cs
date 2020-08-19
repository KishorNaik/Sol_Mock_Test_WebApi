using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Api
{
    public interface IUserDbContextMock
    {
        Task<bool> GetInfo(int id);
    }

    public class UserDbContextMock : IUserDbContextMock
    {
        Task<bool> IUserDbContextMock.GetInfo(int id)
        {
            return Task.Run(() => (id == 1) ? true : false);
        }
    }
}