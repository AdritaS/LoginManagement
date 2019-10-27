using System;
using System.Collections.Generic;
using System.Text;
using LoginManagement.Data;
using LoginManagementRepository.Interfaces;

namespace LoginManagementRepository.Implementations
{
    public class RoleRepository :  GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(LoginManagementDbContext context) : base(context)
        {

        }
    }
}
