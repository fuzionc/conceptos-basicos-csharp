using System; // Agregamos la declaración para usar la clase Console

namespace itm.csharp.basic
{
    public static class menu
    {
        // Método para mostrar el menú
        public static void MostrarMenu()
        {
            // Opciones del menú con descripciones
            Console.WriteLine("1. Elevar número al cuadrado."); // Eleva un número al cuadrado
            Console.WriteLine("2. Doble o triple."); // Calcula el doble o triple de un número
            Console.WriteLine("3. Raíz o cuadrado."); // Calcula la raíz cuadrada o el cuadrado de un número
            Console.WriteLine("4. Perímetro de un círculo. "); // Calcula el perímetro de un círculo
            Console.WriteLine("5. Días de la semana "); // Imprime los días de la semana
            Console.WriteLine("6. Calculador de impuestos "); // Calcula impuestos
            Console.WriteLine("7. Mostrar residuo "); // Muestra el residuo de una operación
            Console.WriteLine("8. Suma de pares"); // Calcula la suma de números pares
            Console.WriteLine("9. Diferencia de fracciones"); // Calcula la diferencia entre dos fracciones
            Console.WriteLine("10. Longitud de una palabra"); // Calcula la longitud de una palabra
            Console.WriteLine("11. Promedio de 4 números"); // Calcula el promedio de cuatro números
            Console.WriteLine("12. Número más pequeño de 5 números "); // Encuentra el número más pequeño entre cinco números
            Console.WriteLine("13. Número de vocales"); // Cuenta el número de vocales en una palabra
            Console.WriteLine("14. Factorial de ese número"); // Calcula el factorial de un número
            Console.WriteLine("15. Rango 1 al 20"); // Imprime el rango del 1 al 20
        }
    }
}
