using System;

namespace Opgaver
{
    public class Indputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Variabler!");
            String1();
            Int1();
            Double1();
            Bool1();
        }

        public static void String1()
        {
            Console.WriteLine("Lav et program som gemmer et input som en string og skriver strengen ud i konsollen");

            Console.WriteLine("Indtast en streng: ");
        }

        public static void Int1()
        {
            Console.WriteLine("Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen");

            Console.WriteLine("Indtast et tal: ");
        }

        public static void Double1()
        {
            Console.WriteLine("Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen");

            Console.WriteLine("Indtast et decimaltal: ");
        }

        public static void Bool1()
        {
            Console.WriteLine("Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen");

            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk): ");
        }
    }
}