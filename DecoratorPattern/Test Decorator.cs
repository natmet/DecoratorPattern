using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Test_Decorator
    {

        static void Main(string[] args) {


            //Hamburguesa sin decorar
            Hamburguesa hamburguesa = new HamburguesaBase();

            

            Console.WriteLine("Bienvenido a Burger King");

            int opcionMenu =0;

            do {
                Console.WriteLine("Seleccione el ingrediente que desea:");
                Console.WriteLine("1.Queso");
                Console.WriteLine("2.Lechuga");
                Console.WriteLine("3.Tomate");
                Console.WriteLine("0.Terminar Orden");
                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu) {

                    case 0:
                        break;

                    case 1:
                        hamburguesa = new QuesoDecorador(hamburguesa);
                        break;

                    case 2:
                        hamburguesa = new LechugaDecorador(hamburguesa);
                        break;

                    case 3:
                        hamburguesa = new TomateDecorator(hamburguesa);
                        break;

                    default:
                        Console.WriteLine("Digite una opcion valida");
                        break;
                }

            } while (opcionMenu!=0);
            Console.WriteLine("");
            Console.WriteLine("Su hamburguesa esta lista, Gracias por su compra.");
            Console.WriteLine("Los ingredientes son: "+ hamburguesa.Ingredientes);
            Console.WriteLine("El precio de su hamburguesa: "+ hamburguesa.Precio);
        }

    }
}
