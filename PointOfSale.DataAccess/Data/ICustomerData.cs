using PointOfSale.DataAccess.Models;

namespace PointOfSale.DataAccess.Data
{
    public interface ICustomerData
    {
        Task InsertPurchaseAsync(CustomerPurchaseModel data);
    }
}