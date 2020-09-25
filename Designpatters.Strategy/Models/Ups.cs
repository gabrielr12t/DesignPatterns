using Designpatters.Strategy.Interfaces;

namespace Designpatters.Strategy.Models
{
    public class Ups : ICalculateShipping
    {
        public double WeightPrice { get { return 0.049; } }

        public double Calculate(double weight, double distance)
        {
            return WeightPrice * distance * weight;
        }
    }
}
