using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class TomateDecorator : IngredientesDecorator
    {

        public TomateDecorator(Hamburguesa hamburguesa) : base(hamburguesa) { }

        public override double Precio => hamburguesa.Precio + 35;

        public override string Ingredientes => string.Format($"{hamburguesa.Ingredientes}, Tomate");
    }
}
