using System.Collections.Generic;
using System.Threading.Tasks;
using TRMWPFUserInterace.Library.Models;

namespace TRMWPFUserInterace.Library.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}