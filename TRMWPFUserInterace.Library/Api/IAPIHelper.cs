using System.Threading.Tasks;
using TRMWPFUserInterace.Library.Models;


namespace TRMWPFUserInterace.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        Task GetLoggedInUserInfo(string token);
    }
}