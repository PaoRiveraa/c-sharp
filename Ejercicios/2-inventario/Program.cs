using System;

namespace inventario
{

    
    class Program
    {

        static void Main(string[] args)
        {
            int opcion = 0;

            while (true)
            {
                Console.Clear();
                Console.WhiteLine("Sistema de Inventario");
                Console.WhiteLine("*********************");
                Console.WhiteLine("");
                Console.WhiteLine("1 - Productos");
                Console.WhiteLine("2 - Ingreso de Inventario");
                Console.WhiteLine("3 - Salida de Inventario");
                Console.WhiteLine("0 - Salir");
                opcion = Console.Read();

                switch (opcion)
                {
                    case 1:
                    Console.WhiteLine("Productos!");
                    Console.ReadLine();
                    break;
                    default:
                    break; 
                    
                }

                if(opcion == 0){
                    break;
                }


            }
            
        }
    }
}
