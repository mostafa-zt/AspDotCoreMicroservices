using System.Threading.Tasks;
using Dapper;
using Discount.API.Entities;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Discount.API.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly IConfiguration _configuration;
        public DiscountRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public Task<Coupon> CreateDisount(Coupon coupon)
        {
            throw new System.NotImplementedException();
        }

        public Task<Coupon> DeleteDisount(Coupon coupon)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            using var connection = new NpgsqlConnection(_configuration.GetValue<string>(""));
            var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>("SELECT * FROM COUPON WHERE ProductName = @ProductName", new { ProductName = productName });
            // using (var conn = My.ConnectionFactory())
            // {
            //     var invoices = conn.Query<Invoice>(sql);
            // }
            throw new System.NotImplementedException();
        }

        public Task<Coupon> UpdateDisount(Coupon coupon)
        {
            throw new System.NotImplementedException();
        }
    }
}