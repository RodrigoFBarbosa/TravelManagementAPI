namespace TravelManagementAPI.Models;

public class Travel
{
    public int id { get; set; }
    public string Destination { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalCost { get; set; }
    public ICollection<Expense> Expenses { get; set; }
    public ICollection<Location> LocationsVisited { get; set; }
}
