using System;
using System.Collections.Generic;
using System.Text;
using LoginManagement.Data;
using LoginManagementRepository.Interfaces;

namespace LoginManagementRepository.Implementations
{
    public class UserRepository :  GenericRepository<User>, IUserRepository
    {
        public UserRepository(LoginManagementDbContext context) : base(context)
        {

        }
    }
}
