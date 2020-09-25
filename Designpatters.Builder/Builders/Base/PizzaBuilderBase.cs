﻿using Designpatters.Builder.Domain;
using Designpatters.Builder.Processors;

namespace Designpatters.Builder.Builders.Base
{
    public abstract class PizzaBuilderBase
    {
        protected Pizza Pizza = null;
        protected readonly ICalculaValor CalculaValor;

        protected PizzaBuilderBase(ICalculaValor calculaValor)
        {
            CalculaValor = calculaValor;
        }

        public virtual void DefineValor()
        {
            CalculaValor.DefineValor(Pizza);
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }

        protected void Init()
        {
            Pizza = new Pizza();
        }
    }
}
