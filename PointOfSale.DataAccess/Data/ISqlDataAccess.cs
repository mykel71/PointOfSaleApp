using Dapper;

namespace PointOfSale.DataAccess.Data
{
    public interface ISqlDataAccess
    {
        Task SaveData(string storedProcedure, DynamicParameters data, string connectionStringName = "Default");
    }
}