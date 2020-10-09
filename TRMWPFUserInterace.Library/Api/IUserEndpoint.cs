using System.Collections.Generic;
using System.Threading.Tasks;
using TRMWPFUserInterace.Library.Models;

namespace TRMWPFUserInterace.Library.Api
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAll();
    }
}