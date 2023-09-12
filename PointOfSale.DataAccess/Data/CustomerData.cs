﻿using Dapper;
using PointOfSale.DataAccess.Models;
using System.Data;

namespace PointOfSale.DataAccess.Data;

public class CustomerData
{
    private readonly ISqlDataAccess _sql;
    public CustomerData(ISqlDataAccess sql)
    {
        _sql = sql;
    }

    public async Task InsertPurchase(CustomerPurchaseModel data)
    {
        DynamicParameters p = new();
        p.Add("@CustomerId", dbType: DbType.Int32, direction: ParameterDirection.Output);
        p.Add("@FirstName", data.FirstName);
        p.Add("@LastName", data.LastName);
        p.Add("@Email", data.Email);

        await _sql.SaveData("dbo.spCustomer_Upsert", p);

        int customerId = p.Get<int>("@CustomerId");

        p = new();
        p.Add("@Item", data.Item);
        p.Add("Cost", data.Cost);
        p.Add("@CustomerId", customerId);

        await _sql.SaveData("dbo.spPurchase_Insert", p);
    }
}
