using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Test_Decorator
    {

        static void Main(string[] args) {


            //Hamburguesa sin decorar
            Hamburguesa hamburguesa = new HamburguesaSmall();

            //Decorando hamburguesa con ingredientes
            hamburguesa = new QuesoDecorador(hamburguesa);
            hamburguesa = new LechugaDecorador(hamburguesa);

            Console.WriteLine("Los ingredientes que pidio son: " + hamburguesa.Ingredientes);
            Console.WriteLine("Y el precio seria: " + hamburguesa.Precio);

            Console.ReadKey();



        }

    }
}
