using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Products.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customfee) : base(name, price)
        {
            CustomsFee = customfee;
        }
        public double TotalPrice()
        {
            return base.Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
