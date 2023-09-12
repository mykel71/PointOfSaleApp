namespace PointOfSale.DataAccess.Models;

public class CustomerPurchaseModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Item { get; set; }
    public decimal Cost { get; set; }
}
