using ShoppingApi.Models.Curbside;
using ShoppingAPI.Domain;
using System.Threading.Tasks;

namespace ShoppingAPI.Controllers
{
    public interface IDoCurbsideQueries
    {
        Task<GetCurbsideOrdersResponse> GetAll();
        Task<CurbsideOrder> GetById(int orderId);
    }
}