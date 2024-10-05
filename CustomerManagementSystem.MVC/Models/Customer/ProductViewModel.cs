﻿namespace CustomerManagementSystem.MVC.Models.Customer
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
    }
}