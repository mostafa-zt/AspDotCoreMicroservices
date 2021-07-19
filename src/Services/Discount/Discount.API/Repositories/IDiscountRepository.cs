using System.Threading.Tasks;
using Discount.API.Entities;

namespace Discount.API.Repositories
{
    public interface IDiscountRepository
    {
         Task<Coupon> GetDiscount(string productName);
         Task<Coupon> CreateDisount(Coupon coupon);
         Task<Coupon> UpdateDisount(Coupon coupon);
         Task<Coupon> DeleteDisount(Coupon coupon);

    }
}