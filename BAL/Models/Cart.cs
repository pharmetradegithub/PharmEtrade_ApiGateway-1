﻿using BAL.RequestModels;

namespace BAL.Models
{
    public class Cart
    {
        public string? CartId { get; set; }
        public CustomerBasicDetails Customer { get; set; }
        public ProductBasicDetails Product { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
