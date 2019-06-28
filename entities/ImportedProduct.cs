using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace inheritance5_CSharp.entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(double customsFee, string name, double price): base(name,price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            return Name + " $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " Customs fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
