using ShoppingAPI.Domain;
using ShoppingAPI.Models.Curbside;
using System.Threading.Tasks;

namespace ShoppingAPI.Controllers
{
    public interface IDoCurbsideCommands
    {
        Task<CurbsideOrder> AddOrder(PostCurbsideOrderRequest orderToPlace);
    }
}