using PointOfSale.DataAccess.Data;
using PointOfSale.DataAccess.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<ICustomerData, CustomerData>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/purchase", async (ICustomerData db, CustomerPurchaseModel data) =>
{
    await db.InsertPurchaseAsync(data);
});

app.Run();
