using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            
            // Vejledende løsning:
            Console.Write("Indtast et tal: ");
            string? input = Console.ReadLine();
            
            if (int.TryParse(input, out int tal))
            {
                if (tal > 18)
                {
                    Console.WriteLine($"{tal} er højere end 18");
                }
                else if (tal < 18)
                {
                    Console.WriteLine($"{tal} er lavere end 18");
                }
                else
                {
                    Console.WriteLine($"{tal} er lig med 18");
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et helt tal.");
            }
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            
            // Vejledende løsning:
            Console.Write("Indtast et helt tal: ");
            string? input = Console.ReadLine();
            
            if (int.TryParse(input, out int tal))
            {
                if (tal % 2 == 0)
                {
                    Console.WriteLine($"{tal} er et lige tal");
                }
                else
                {
                    Console.WriteLine($"{tal} er et ulige tal");
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et helt tal.");
            }
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            
            // Vejledende løsning med switch:
            Console.Write("Indtast et helt tal: ");
            string? input = Console.ReadLine();
            
            if (int.TryParse(input, out int tal))
            {
                // Vi bruger modulo operator til at bestemme om tallet er lige eller ulige
                switch (tal % 2)
                {
                    case 0:
                        Console.WriteLine($"{tal} er et lige tal");
                        break;
                    case 1:
                    case -1: // Håndterer negative tal
                        Console.WriteLine($"{tal} er et ulige tal");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et helt tal.");
            }
        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            
            // Vejledende løsning med ternary operator:
            Console.Write("Indtast et helt tal: ");
            string? input = Console.ReadLine();
            
            if (int.TryParse(input, out int tal))
            {
                // Ternary operator: betingelse ? værdi_hvis_sand : værdi_hvis_falsk
                string resultat = (tal % 2 == 0) ? "lige" : "ulige";
                Console.WriteLine($"{tal} er et {resultat} tal");
              
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et helt tal.");
            }
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            
            // Vejledende løsning:
            Console.WriteLine("\n=== QUIZ SPIL ===");
            int point = 0;
            
            // Spørgsmål 1
            Console.WriteLine("\nSpørgsmål 1: Hvad er hovedstaden i Danmark?");
            Console.Write("Dit svar: ");
            string? svar1 = Console.ReadLine()?.ToLower().Trim();
            if (svar1 == "københavn" || svar1 == "copenhagen")
            {
                Console.WriteLine("Korrekt! +1 point");
                point++;
            }
            else
            {
                Console.WriteLine("Forkert. Det rigtige svar er København.");
            }
            
            // Spørgsmål 2
            Console.WriteLine("\nSpørgsmål 2: Hvor mange dage er der i et skudår?");
            Console.Write("Dit svar: ");
            string? svar2 = Console.ReadLine()?.Trim();
            if (svar2 == "366")
            {
                Console.WriteLine("Korrekt! +1 point");
                point++;
            }
            else
            {
                Console.WriteLine("Forkert. Det rigtige svar er 366 dage.");
            }
            
            // Spørgsmål 3
            Console.WriteLine("\nSpørgsmål 3: Hvad er 7 * 8?");
            Console.Write("Dit svar: ");
            string? svar3 = Console.ReadLine()?.Trim();
            if (svar3 == "56")
            {
                Console.WriteLine("Korrekt! +1 point");
                point++;
            }
            else
            {
                Console.WriteLine("Forkert. Det rigtige svar er 56.");
            }
            
            // Resultat
            Console.WriteLine($"\n=== RESULTAT ===");
            Console.WriteLine($"Du fik {point} ud af 3 spørgsmål rigtige!");
            
            if (point == 3)
            {
                Console.WriteLine("Perfekt! Du fik alle spørgsmål rigtige! 🎉");
            }
            else if (point == 2)
            {
                Console.WriteLine("Godt klaret! Du fik 2 ud af 3 rigtige.");
            }
            else if (point == 1)
            {
                Console.WriteLine("Du fik 1 rigtig. Prøv igen! 💪");
            }
            else
            {
                Console.WriteLine("Du fik ingen rigtige. Øv! Prøv igen! 😊");
            }
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            
            // Vejledende løsning:
            Console.WriteLine("\n=== KARAKTER FEEDBACK SYSTEM ===");
            
            // Spørg om hvor mange karakterer brugeren vil indtaste
            Console.Write("Hvor mange karakterer vil du indtaste? ");
            string? antalInput = Console.ReadLine();
            
            if (int.TryParse(antalInput, out int antalKarakterer) && antalKarakterer > 0)
            {
                double sum = 0;
                int gyldigeKarakterer = 0;
                
                for (int i = 1; i <= antalKarakterer; i++)
                {
                    Console.Write($"Indtast karakter {i}: ");
                    string? karakterInput = Console.ReadLine();
                    
                    if (double.TryParse(karakterInput, out double karakter))
                    {
                        // Tjek om karakteren er gyldig (mellem -3 og 12)
                        if (karakter >= -3 && karakter <= 12)
                        {
                            sum += karakter;
                            gyldigeKarakterer++;
                            
                            // Giv feedback for hver karakter
                            string feedback = GetKarakterFeedback(karakter);
                            Console.WriteLine($"Feedback: {feedback}");
                        }
                        else
                        {
                            Console.WriteLine("Ugyldig karakter. Karakteren skal være mellem -3 og 12.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt input. Indtast venligst et tal.");
                    }
                }
                
                // Beregn og vis gennemsnit
                if (gyldigeKarakterer > 0)
                {
                    double gennemsnit = sum / gyldigeKarakterer;
                    Console.WriteLine($"\n=== RESULTAT ===");
                    Console.WriteLine($"Gennemsnit: {gennemsnit:F1}");
                    
                    string gennemsnitFeedback = GetKarakterFeedback(gennemsnit);
                    Console.WriteLine($"Gennemsnit feedback: {gennemsnitFeedback}");
                }
                else
                {
                    Console.WriteLine("Ingen gyldige karakterer blev indtastet.");
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt antal. Indtast venligst et positivt helt tal.");
            }
        }
        
        // Hjælpemetode til at give feedback baseret på karakter
        private static string GetKarakterFeedback(double karakter)
        {
            if (karakter >= 12)
                return "Fantastisk! Du fik topkarakter! 🌟";
            else if (karakter >= 10)
                return "Rigtig flot! Du klarede det rigtig godt! 👏";
            else if (karakter >= 7)
                return "Godt klaret! Du har et solidt niveau. 👍";
            else if (karakter >= 4)
                return "Det er okay, men du kan gøre det bedre. 💪";
            else if (karakter >= 2)
                return "Du skal øve dig mere. Prøv at fokusere på de svage punkter. 📚";
            else if (karakter >= 0)
                return "Det gik ikke så godt denne gang. Prøv igen og giv det et ekstra skud! 🔄";
            else
                return "Det gik ikke godt. Snak med din lærer om hvordan du kan forbedre dig. 🤝";
        }
    }
}
