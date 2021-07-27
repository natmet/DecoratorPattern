using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class HamburguesaSmall : Hamburguesa
    {

        public override double Precio => 125;

        public override string Ingredientes => "Pan y Carne";
    }
}
