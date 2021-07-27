using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class QuesoDecorador : IngredientesDecorator
    {
        public QuesoDecorador(Hamburguesa hamburguesa) : base(hamburguesa) { }

        public override double Precio => hamburguesa.Precio + 50;

        public override string Ingredientes => string.Format($"{hamburguesa.Ingredientes}, Queso");

    }
}
