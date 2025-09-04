using System;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.Write("Indtast en streng: ");
            string? input = Console.ReadLine();
            Console.WriteLine("Du indtastede: " + input);
        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            Console.Write("Indtast et tal: ");
            string? input = Console.ReadLine();
            int tal = int.Parse(input ?? "0");
            Console.WriteLine("Du indtastede: " + tal);
        }

        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            Console.Write("Indtast et decimaltal: ");
            string? input = Console.ReadLine();
            double decimaltal = double.Parse(input ?? "0");
            Console.WriteLine("Du indtastede: " + decimaltal);
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.Write("Indtast en sandhedsværdi (sandt/falsk): ");
            string? input = Console.ReadLine();
            bool sandhedsværdi = bool.Parse(input ?? "false");
            Console.WriteLine("Du indtastede: " + sandhedsværdi);
        }

        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            
            Console.WriteLine("Indtast dit navn: ");
            string? navn = Console.ReadLine();
            
            Console.WriteLine("Indtast din alder: ");
            string? alderInput = Console.ReadLine();
            int alder = int.Parse(alderInput ?? "0");
            
            Console.WriteLine("Indtast din hjemby: ");
            string? hjemby = Console.ReadLine();
            
            Console.WriteLine($"Hej, jeg hedder {navn}, er {alder} år gammel og kommer fra {hjemby}!");
        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde))."
            );
            
            Console.Write("Indtast din vægt i kg: ");
            string? vægtInput = Console.ReadLine();
            double vægt = double.Parse(vægtInput ?? "0");
            
            Console.Write("Indtast din højde i meter: ");
            string? højdeInput = Console.ReadLine();
            double højde = double.Parse(højdeInput ?? "0");
            
            double bmi = vægt / (højde * højde);
            Console.WriteLine($"Din BMI er: {bmi:F2}");
        }
    }
}
