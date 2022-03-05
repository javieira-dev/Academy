using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(order);

            //Convertendo para toString
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Convertendo uma string para orderStatus

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}
