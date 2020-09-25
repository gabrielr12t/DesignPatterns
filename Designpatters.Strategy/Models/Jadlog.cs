using Designpatters.Strategy.Interfaces;

namespace Designpatters.Strategy.Models
{
    public class Jadlog : ICalculateShipping
    {
        public double WeightPrice { get { return 0.056; } }

        public double Calculate(double weight, double distance)
        {
            return WeightPrice * distance * weight;
        }
    }
}
