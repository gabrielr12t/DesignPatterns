using Designpatters.Builder.Builders;
using Designpatters.Builder.Builders.Base;
using Designpatters.Builder.Director;
using Designpatters.Builder.Domain;
using Designpatters.Builder.Domain.ValueObject;
using Designpatters.Builder.Processors;
using System;

namespace Designpatters.Builder
{
    class Program
    {
        private static void Main(string[] args)
        {
            var calcValor = new CalculaValor();

            IPizzaBuilder pizzaCalabresaBuilder = new PizzaCalabresa(calcValor);
            IPizzaBuilder pizzaModaCasaBuilder = new PizzaModaCasa(calcValor);

            var cardapioService = new CardapioServices();

            #region Pizza 1

            cardapioService.PrepararPizzaComBorda(pizzaCalabresaBuilder, PizzaSize.Grande, new Borda { BordaType = BordaType.Catupiry, BordaSize = BordaSize.Normal });

            var pizzacalabresa1 = pizzaCalabresaBuilder.GetPizza();

            #endregion Pizza 1

            #region Pizza 2

            cardapioService.PrepararPizzaSemBorda(pizzaCalabresaBuilder, PizzaSize.Grande);
            var pizzacalabresa2 = pizzaCalabresaBuilder.GetPizza();

            #endregion Pizza 2

            #region Pizza 3

            cardapioService.PrepararPizzaComBorda(pizzaModaCasaBuilder, PizzaSize.Grande, new Borda { BordaType = BordaType.Chedder, BordaSize = BordaSize.Normal });
            var pizzaModaCasa1 = pizzaModaCasaBuilder.GetPizza();

            #endregion Pizza 3

            View("Pizza 1: ", pizzacalabresa1);
            View("Pizza 2: ", pizzacalabresa2);
            View("Pizza 3: ", pizzaModaCasa1);
        }

        public static void View(string msg, Pizza pizza)
        {
            Console.WriteLine(pizza);
        }
    }
}
