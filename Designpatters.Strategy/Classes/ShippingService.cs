using Designpatters.Strategy.Interfaces;

namespace Designpatters.Strategy.Classes
{
    public class ShippingService
    {
        private ICalculateShipping _calculateShipping;

        public ShippingService(ICalculateShipping calculateShipping)
        {
            _calculateShipping = calculateShipping;
        }

        public ShippingService() { }

        public void SetCalculateShipping(ICalculateShipping calculateShipping)
        {
            _calculateShipping = calculateShipping;
        }

        public double Calculate(double weight, double distance)
        {
            return _calculateShipping.Calculate(weight, distance);
        }
    }
}
