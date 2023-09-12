using Dapper;

namespace PointOfSale.DataAccess.Data
{
    public interface ISqlDataAccess
    {
        Task SaveDataAsync(string storedProcedure, DynamicParameters data, string connectionStringName = "Default");
    }
}