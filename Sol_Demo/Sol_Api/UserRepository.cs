using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Api
{
    public interface IUserRepository
    {
        Task<String> GetNameById(int id);

        Task<bool> GetInfo(int id);
    }

    public class UserRepository : IUserRepository
    {
        Task<bool> IUserRepository.GetInfo(int id)
        {
            //return Task.Run(() => (id == 1) ? true : false);
            throw new NotImplementedException();
        }

        Task<string> IUserRepository.GetNameById(int id)
        {
            return Task.Run(() =>
            {
                string name;
                if (id == 1)
                {
                    name = "Kishor";
                }
                else if (id == 2)
                {
                    name = "Eshaan";
                }
                else
                {
                    name = "Not Found";
                }
                return name;
            });
        }
    }
}