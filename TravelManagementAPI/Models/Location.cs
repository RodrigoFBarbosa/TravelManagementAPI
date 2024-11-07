using System.ComponentModel.DataAnnotations;

namespace TravelManagementAPI.Models;

public class Location
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public int TravelId { get; set; }
    public Travel Travel { get; set; }
}