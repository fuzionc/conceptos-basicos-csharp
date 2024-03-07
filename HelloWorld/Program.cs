namespace itm.csharp.basic
{
    class Program {
        static void Main(String[] arg)
        {
            Console.WriteLine("Ingrese su nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre} por favor, elige un ejercicio del siguiente menú");
            menu.MostrarMenu();
            while(true)
            {
                string entrada = Console.ReadLine().ToLower();
                
                if(entrada == "x" || entrada == "exit")
                {
                    break; // salir del bucle
                }

                if(int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15)
                {
                    switch (eleccion)
            {
                case 1:
                    var Challenger1 = new Challenger1();
                    Challenger1.Run();
                    break;
                case 2:
                    var Challenge2 = new Challenger2();
                    Challenge2.Run();
                    break;
                case 3:
                    var Challenger3 = new Challenger3();
                    Challenger3.Run();
                    break;
                case 4:
                    var Challenger4 = new Challenger4();
                    Challenger4.Run();
                    break;
                case 5:
                    var Challenger5 = new Challenger5();
                    Challenger5.Run();
                    break;
                case 6:
                var Challenger6 = new Challenger6();
                    Challenger6.Run();
                    break;
                case 7:
                    var Challenger7 = new Challenger7();
                    Challenger7.Run();
                    break;
                case 8:
                    var Challenger8 = new Challenger8();
                    Challenger8.Run();
                    break;
                case 9:
                    var Challenger9 = new Challenger9();
                    Challenger9.Run();
                    break;
                case 10:
                    var Challenger10 = new Challenger10();
                    Challenger10.Run();
                    break;
                case 11:
                    var Challenger11 = new Challenger11();
                    Challenger11.Run();
                    break;
                case 12:
                    var Challenger12 = new Challenger12();
                    Challenger12.Run();
                    break;
                case 13:
                    var Challenger13 = new Challenger13();
                    Challenger13.Run();
                    break;
                case 14:
                    var Challenger14 = new Challenger14();
                    Challenger14.Run();
                    break;
                case 15:
                    var Challenger15 = new Challenger15();
                    Challenger15.Run();
                    break;
                default:
                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    menu.MostrarMenu();
                    break;
            }
                    
                }
                else
                {
                    Console.WriteLine("Opcione no valida. por favor, ingrese un numero entre 1 y 15, (x) o (exit)");
                }
            }
            Console.WriteLine("Hasta luego");
        }
    }
}

