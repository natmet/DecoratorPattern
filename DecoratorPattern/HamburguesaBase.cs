using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class HamburguesaBase : Hamburguesa
    {

        public override double Precio => 100;

        public override string Ingredientes => "Pan y Carne ";
    }
}
