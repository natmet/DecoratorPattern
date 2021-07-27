using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class IngredientesDecorator : Hamburguesa
    {

        protected Hamburguesa hamburguesa;

        public IngredientesDecorator(Hamburguesa hamburguesa) {
            this.hamburguesa = hamburguesa;
        }
    }
}
