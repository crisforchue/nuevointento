using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un numero entero de dos digitos: ");
        string input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number) && number >= 10 && number <= 99)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            int sum = firstDigit + secondDigit;

            Console.WriteLine($"La suma de los digitos de {number} es {sum}.");
        }
        else
        {
            Console.WriteLine("El numero ingresado no es un mumero entero de dos digitos.");
        }
    }
}
