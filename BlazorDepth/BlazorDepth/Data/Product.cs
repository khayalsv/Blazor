﻿namespace BlazorDepth.Data
{
    public class Product
    {
        public int Id { get; set; } 
        public string Brand { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public string ImageLink { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
