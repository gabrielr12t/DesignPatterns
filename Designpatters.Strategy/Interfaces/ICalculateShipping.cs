namespace Designpatters.Strategy.Interfaces
{
    public interface ICalculateShipping
    {
        double WeightPrice { get; }

        double Calculate(double weight, double distance);
    }
}
