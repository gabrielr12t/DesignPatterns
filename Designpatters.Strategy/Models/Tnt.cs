using Designpatters.Strategy.Interfaces;

namespace Designpatters.Strategy.Models
{
    public class Tnt : ICalculateShipping
    {
        public double WeightPrice { get { return 0.065; } }

        public double Calculate(double weight, double distance)
        {
            return WeightPrice * distance * weight;
        }
    }
}
