using System;

namespace itm.csharp.basic
{
    public class Challenger1
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");

            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                
                if (numero >= 0)
                {
                    
                    double resultado = ElevarAlCuadrado(numero);
                    Console.WriteLine($"El cuadrado de {numero} es: {resultado}");
                }
                else
                {
                    Console.WriteLine("El número ingresado no es positivo. No se puede elevar al cuadrado.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
            }
        }

        private double ElevarAlCuadrado(double numero)
        {
            return numero * numero;
        }
    }
}

//Solicita al usuario dos números. Si el primero es mayor, devuelva 
//su doble, de lo contrario devuelva el triple del segundo. 
    public class Challenger2
    {
        public void Run()
        {
            
            Console.Write("Ingrese el primer número: ");
            if (double.TryParse(Console.ReadLine(), out double numero1))
            {
                Console.Write("Ingrese el segundo número: ");
                if (double.TryParse(Console.ReadLine(), out double numero2))
                {
                    double resultado = CompararYCalcular(numero1, numero2);
                    Console.WriteLine($"El resultado es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Ingrese un segundo número válido.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un primer número válido.");
            }
        }

        private double CompararYCalcular(double numero1, double numero2)
        {
            return (numero1 > numero2) ? (2 * numero1) : (3 * numero2);
        }
    }

//Pide al usuario un número. Si es positivo, devuelve su raíz 
//cuadrada, de lo contrario, devuelve su cuadrado. 
public class Challenger3
{
    public void Run()
    {
        
        Console.Write("Ingrese un número: ");

        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            
            double resultado = (numero >= 0) ? CalcularRaizCuadrada(numero) : ElevarAlCuadrado(numero);
            Console.WriteLine($"El resultado es: {resultado}");
        }
        else
        {
            Console.WriteLine("Ingrese un número válido.");
        }
    }

    private double CalcularRaizCuadrada(double numero)
    {
        
        return Math.Sqrt(numero);
    }

    private double ElevarAlCuadrado(double numero)
    {
        
        return numero * numero;
    }
}

public class Challenger4
{
    public void Run()
    {
        
        Console.Write("Ingrese el radio del círculo: ");

        if (double.TryParse(Console.ReadLine(), out double radio) && radio >= 0)
        {
            
            double perimetro = CalcularPerimetroCirculo(radio);
            Console.WriteLine($"El perímetro del círculo con radio {radio} es: {perimetro}");
        }
        else
        {
            Console.WriteLine("Ingrese un radio válido (un número no negativo).");
        }
    }

    private double CalcularPerimetroCirculo(double radio)
    {
        
        return 2 * Math.PI * radio;
    }
}


public class Challenger5
{
    public void Run()
    {
        
        Console.Write("Ingrese un número entre 1 y 7: ");

        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= 7)
        {
            
            string diaSemana = ObtenerDiaSemanaLaborable(numero);
            Console.WriteLine($"El día laborable correspondiente al número {numero} es: {diaSemana}");
        }
        else
        {
            Console.WriteLine("Ingrese un número válido entre 1 y 7.");
        }
    }

    private string ObtenerDiaSemanaLaborable(int numero)
    {
        
        switch (numero)
        {
            case 1: return "Lunes";
            case 2: return "Martes";
            case 3: return "Miércoles";
            case 4: return "Jueves";
            case 5: return "Viernes";
            case 6: return "Número fuera del rango laboral";
            case 7: return "Número fuera del rango laboral";
            default: return "Número no válido";
        }
    }
}

public class Challenger6
{
    public void Run()
    {
        
        Console.Write("Ingrese su salario anual: ");

        if (double.TryParse(Console.ReadLine(), out double salarioAnual) && salarioAnual >= 0)
        {
            
            if (salarioAnual > 12000)
            {
                
                double excedente = salarioAnual - 12000;
                double impuesto = 0.15 * excedente;

                Console.WriteLine($"Su salario excede los 12000. Impuesto a pagar: {impuesto:C}");
            }
            else
            {
                Console.WriteLine("Su salario no excede los 12000. No hay impuesto a pagar.");
            }
        }
        else
        {
            Console.WriteLine("Ingrese un salario anual válido (un número no negativo).");
        }
    }
}

public class Challenger7
{
    public void Run()
    {
        
        Console.Write("Ingrese el primer número: ");

        if (double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.Write("Ingrese el segundo número: ");

            if (double.TryParse(Console.ReadLine(), out double numero2) && numero2 != 0)
            {
                
                double residuo = CalcularResiduo(numero1, numero2);
                Console.WriteLine($"El residuo de {numero1} dividido por {numero2} es: {residuo}");
            }
            else
            {
                Console.WriteLine("Ingrese un segundo número válido (distinto de cero).");
            }
        }
        else
        {
            Console.WriteLine("Ingrese un primer número válido.");
        }
    }

    private double CalcularResiduo(double numero1, double numero2)
    {
        
        return numero1 % numero2;
    }
}


public class Challenger8
{
    public void Run()
    {
        
        int sumaPares = CalcularSumaPares(1, 50);
        Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {sumaPares}");
    }

    private int CalcularSumaPares(int inicio, int fin)
    {
        int suma = 0;

        
        for (int i = inicio; i <= fin; i++)
        {
            
            if (EsPar(i))
            {
                
                suma += i;
            }
        }

        return suma;
    }

    private bool EsPar(int numero)
    {
        
        return numero % 2 == 0;
    }
}

public class Challenger9
{
    public void Run()
    {
        
        Console.Write("Ingrese el numerador de la primera fracción: ");
        if (int.TryParse(Console.ReadLine(), out int numerador1))
        {
            Console.Write("Ingrese el denominador de la primera fracción (distinto de cero): ");
            if (int.TryParse(Console.ReadLine(), out int denominador1) && denominador1 != 0)
            {
                Console.Write("Ingrese el numerador de la segunda fracción: ");
                if (int.TryParse(Console.ReadLine(), out int numerador2))
                {
                    Console.Write("Ingrese el denominador de la segunda fracción (distinto de cero): ");
                    if (int.TryParse(Console.ReadLine(), out int denominador2) && denominador2 != 0)
                    {
                        
                        MostrarDiferenciaFracciones(numerador1, denominador1, numerador2, denominador2);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un denominador válido (distinto de cero) para la segunda fracción.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un numerador válido para la segunda fracción.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un denominador válido (distinto de cero) para la primera fracción.");
            }
        }
        else
        {
            Console.WriteLine("Ingrese un numerador válido para la primera fracción.");
        }
    }

    private void MostrarDiferenciaFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        
        int nuevoDenominador = denominador1 * denominador2;
        int nuevoNumerador1 = numerador1 * denominador2;
        int nuevoNumerador2 = numerador2 * denominador1;
        int diferenciaNumerador = nuevoNumerador1 - nuevoNumerador2;

        Console.WriteLine($"La diferencia entre las fracciones {numerador1}/{denominador1} y {numerador2}/{denominador2} es: {diferenciaNumerador}/{nuevoDenominador}");
    }
}

public class Challenger10
{
    public void Run()
    {
        
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        
        int longitud = CalcularLongitudPalabra(palabra);
        Console.WriteLine($"La longitud de la palabra '{palabra}' es: {longitud}");
    }

    private int CalcularLongitudPalabra(string palabra)
    {
        
        return palabra.Length;
    }
}

public class Challenger11
{
    public void Run()
    {
        
        Console.Write("Ingrese el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Ingrese el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.Write("Ingrese el tercer número: ");
                if (double.TryParse(Console.ReadLine(), out double num3))
                {
                    Console.Write("Ingrese el cuarto número: ");
                    if (double.TryParse(Console.ReadLine(), out double num4))
                    {
                        
                        double promedio = CalcularPromedio(num1, num2, num3, num4);
                        Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un cuarto número válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un tercer número válido.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un segundo número válido.");
            }
        }
        else
        {
            Console.WriteLine("Ingrese un primer número válido.");
        }
    }

    private double CalcularPromedio(double num1, double num2, double num3, double num4)
    {
        
        return (num1 + num2 + num3 + num4) / 4;
    }
}

public class Challenger12
{
    public void Run()
    {
        
        Console.WriteLine("Ingrese cinco números:");

        double[] numeros = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                numeros[i] = numero;
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
                
                return;
            }
        }

        double numeroMasPequeno = EncontrarNumeroMasPequeno(numeros);
        Console.WriteLine($"El número más pequeño es: {numeroMasPequeno}");
    }

    private double EncontrarNumeroMasPequeno(double[] numeros)
    {
        
        double masPequeno = numeros[0];

        
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < masPequeno)
            {
                masPequeno = numeros[i];
            }
        }

        return masPequeno;
    }
}

public class Challenger13
{
    public void Run()
    {
        
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        
        int numeroVocales = ContarVocales(palabra);
        Console.WriteLine($"El número de vocales en la palabra '{palabra}' es: {numeroVocales}");
    }

    private int ContarVocales(string palabra)
    {
        
        int contadorVocales = 0;

        
        foreach (char caracter in palabra.ToLower()) 
        {
            
            if (EsVocal(caracter))
            {
                
                contadorVocales++;
            }
        }

        return contadorVocales;
    }

    private bool EsVocal(char caracter)
    {
        
        return "aeiou".Contains(caracter);
    }
}


public class Challenger14
{
    public void Run()
    {
        
        Console.Write("Ingrese un número para calcular el factorial: ");

        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            
            long factorial = CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
        else
        {
            Console.WriteLine("Ingrese un número entero no negativo válido.");
        }
    }

    private long CalcularFactorial(int numero)
    {
        
        if (numero == 0 || numero == 1)
        {
            return 1;
        }

        long resultado = 1;

        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}

public class Challenger15
{
    public void Run()
    {
        
        Console.Write("Ingrese un número para verificar si está en el rango de 10 a 20: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            
            bool estaEnRango = VerificarRango(numero);

            if (estaEnRango)
            {
                Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
            }
            else
            {
                Console.WriteLine($"El número {numero} NO está en el rango de 10 a 20.");
            }
        }
        else
        {
            Console.WriteLine("Ingrese un número válido.");
        }
    }

    private bool VerificarRango(int numero)
    {
        
        return numero >= 10 && numero <= 20;
    }
}
