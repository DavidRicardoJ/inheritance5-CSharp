using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace inheritance5_CSharp.entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct(DateTime manufacturedDate, string name, double price) : base(name,price)  
        {
            ManufacturedDate = manufacturedDate;
        }

        public sealed override string PriceTag()
        {
            return Name + " (used) $" + Price.ToString("F2", CultureInfo.InvariantCulture ) + " (Manufacture date: " + ManufacturedDate.ToString("dd/MM/yyyy")+ ")";
        }
    }
}
