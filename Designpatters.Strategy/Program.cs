using Designpatters.Strategy.Classes;
using Designpatters.Strategy.Models;

namespace Designpatters.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = 159.5;
            var product = new { Name = "Xbox", Weight = 2.6 };
            var shippingService = new ShippingService();

            var correiosShipping = new Correios();
            var jadlogShipping = new Jadlog();
            var tntShipping = new Tnt();
            var upsShipping = new Ups();

            shippingService.SetCalculateShipping(correiosShipping);
            double correiosShippingPrice = shippingService.Calculate(product.Weight, distance);

            shippingService.SetCalculateShipping(jadlogShipping);
            double jadlogShippingPrice = shippingService.Calculate(product.Weight, distance);

            shippingService.SetCalculateShipping(tntShipping);
            double tntShippingPrice = shippingService.Calculate(product.Weight, distance);

            shippingService.SetCalculateShipping(upsShipping);
            double upsShippingPrice = shippingService.Calculate(product.Weight, distance);

            System.Console.WriteLine($"Correios: {correiosShippingPrice:C2}");
            System.Console.WriteLine($"Jadlog: {jadlogShippingPrice:C2}");
            System.Console.WriteLine($"TNT: {tntShippingPrice:C2}");
            System.Console.WriteLine($"UPS: {upsShippingPrice:C2}");
        }
    }
}
