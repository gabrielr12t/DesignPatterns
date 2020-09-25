using Designpatters.Builder.Builders.Base;
using Designpatters.Builder.Domain;
using Designpatters.Builder.Domain.ValueObject;

namespace Designpatters.Builder.Director
{
    public class CardapioServices
    {
        public void PrepararPizzaSemBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize)
        {
            pizzaBuilder.PreparaMassa(pizzaSize);
            pizzaBuilder.InsereIngradientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }

        public void PrepararPizzaComBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize, Borda borda)
        {
            pizzaBuilder.PreparaMassa(pizzaSize);
            pizzaBuilder.PrepraraBorda(borda);
            pizzaBuilder.InsereIngradientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }
    }
}
