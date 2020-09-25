using Designpatters.Builder.Domain;
using Designpatters.Builder.Domain.ValueObject;

namespace Designpatters.Builder.Builders.Base
{
    public interface IPizzaBuilder
    {
        void PrepraraBorda(Borda borda);

        void PreparaMassa(PizzaSize pizzaSize);

        void InsereIngradientes();

        void DefineValor();

        void TempoForno();

        Pizza GetPizza();
    }
}
