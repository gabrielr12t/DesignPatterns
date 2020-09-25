using Designpatters.Builder.Domain.ValueObject;

namespace Designpatters.Builder.Domain
{
    public class Pizza
    {
        public string Sabor { get; set; }
        public Borda Borda { get; set; }
        public double Valor { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public PizzaType PizzaType { get; set; }
        public IngredientesType IngredientesType { get; set; }
        public int TempoFornoMin { get; set; }

        public override string ToString()
        {
            return string.Format($"{Sabor} / {Valor:C} / {TempoFornoMin} min / {PizzaSize}");
        }
    }
}
