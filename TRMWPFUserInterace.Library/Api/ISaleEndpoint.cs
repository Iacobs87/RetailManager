using System.Threading.Tasks;
using TRMWPFUserInterace.Library.Models;

namespace TRMWPFUserInterace.Library.Api
{
    public interface ISaleEndpoint
    {
        Task PostSale(SaleModel sale);
    }
}