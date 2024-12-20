﻿using System.ComponentModel.DataAnnotations;

namespace TravelManagementAPI.Models;

public class Expense
{
    [Key]
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public int TravelId { get; set; }
    public Travel Travel { get; set; }
}

public enum ExpenseType
{
    Transportation,
    Accommodation,
    Meals,
    Other
}