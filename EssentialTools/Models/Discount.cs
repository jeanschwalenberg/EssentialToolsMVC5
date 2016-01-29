﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models {

    public interface IDiscountHelper {
        decimal ApplyDiscount(decimal TotalParam);
    }

    public class DefaultDiscountHelper : IDiscountHelper {
        public decimal discountSize { get; set; }

    public DefaultDiscountHelper(decimal discountParam) {
            discountSize = discountParam;
        }

    public decimal ApplyDiscount(decimal totalParam) {
        return (totalParam - discountSize / 100m * totalParam);
    }

    }
}