using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class HamburguesaXL : Hamburguesa
    {

        public override double Precio => 200;

        public override string Ingredientes => "Pan y Carne Grandes";
    }
}
