using System;
using System.Collections.Generic;
using System.Text;

namespace ExercPolimorfismo.Entities
{
    class ImporteProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImporteProduct()
        {

        }

        public ImporteProduct(string name, double price, double customsFee): base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price  + CustomsFee;
        }


        public override string PriceTag()
        {
            return base.PriceTag() + TotalPrice() + "(Customs fee: $ )" + CustomsFee ;
        }

    }
}
