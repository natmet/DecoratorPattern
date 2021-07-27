using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class LechugaDecorador : IngredientesDecorator
    {

        public LechugaDecorador(Hamburguesa hamburguesa) : base(hamburguesa) { }

        public override double Precio => hamburguesa.Precio + 35;

        public override string Ingredientes => string.Format($"{hamburguesa.Ingredientes}, Lechuga");

    }
}
