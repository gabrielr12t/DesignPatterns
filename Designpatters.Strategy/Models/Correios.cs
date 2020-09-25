using Designpatters.Strategy.Interfaces;

namespace Designpatters.Strategy.Models
{
    public class Correios : ICalculateShipping
    {
        public double WeightPrice { get { return 0.07; } }

        public double Calculate(double weight, double distance)
        {
            return WeightPrice * distance * weight;
        }
    }
}
