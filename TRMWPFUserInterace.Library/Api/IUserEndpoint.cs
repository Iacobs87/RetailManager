﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TRMWPFUserInterace.Library.Models;

namespace TRMWPFUserInterace.Library.Api
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAll();
        Task<Dictionary<string, string>> GetAllRoles();
        Task AddUserToRole(string userId, string roleName);
        Task RemoveUserFromRole(string userId, string roleName);

    }
}