using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class Product
    {
        public string Code;
        public string Name;
        public double Price;
        public double DiscountPrice;
        public ProductType Type;

        public Product(ProductType productType, double price)
        {
            Code = $"{productType.ToString()[0]}";
            Price = price;
            if (productType == ProductType.Bakery)
            {
                DiscountPrice = (Price * 0.9);
            }
            //switch (productType)
            //{
            //    case ProductType.Bakery:
            //        Code += "B";
            //        DiscountPrice = (Price * 0.9);
            //        break;
            //    case ProductType.Drink:
            //        Code += "D";
            //        break;
            //    case ProductType.Meat:
            //        Code += "M";
            //        break;
            //    case ProductType.Fish:
            //        Code += "F";
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
