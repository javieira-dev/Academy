using System;
using System.Collections.Generic;
using System.Text;

namespace ExercPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManudatureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate): base(name, price)
        {
            ManudatureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + "$(Manufacture date: ManudatureDate)";
        }
    }
}
