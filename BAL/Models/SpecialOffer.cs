﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class SpecialOffer
    {
        //public string DiscountText { get; set; }
        //public string ProductCategoryName { get; set; }
        //public string OfferImageUrl { get; set; }

        public int Discount { get; set; }
        public string SpecificationName { get; set; }
        public int CategorySpecificationId { get; set; }
    }
}
