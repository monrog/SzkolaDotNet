
using System;
namespace tydz2zad7
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///ZADANIE 1
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Podaj pierwszą liczbę");
            Int32 a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            Int32 b = Int32.Parse(Console.ReadLine());
            string text = (a == b) ? ($"{a} i { b} są równe") : ($"{a} i {b} są różne");
            Console.WriteLine($"{text}");

            ///ZADANIE 2
            Console.WriteLine("\r\nZadanie 2");
            Console.WriteLine("Podaj liczbę");
            Int32 Oddeven = Int32.Parse(Console.ReadLine());
            text = (Oddeven% 2 == 0) ? ($"{Oddeven} jest liczbą parzystą") : ($"{Oddeven} jest liczbą nieparzystą");
            Console.WriteLine($"{text}");

            ///ZADANIE 3
            Console.WriteLine("\r\nZadanie 3");
            Console.WriteLine("Podaj liczbę");
            Int32 NP = Int32.Parse(Console.ReadLine());
            switch (NP)
            {
                case > 0:
                Console.WriteLine($"{NP} jest liczbą dodatnią");
                    break;
                case < 0:
                Console.WriteLine($"{NP} jest liczbą ujemną");
                    break;
                case 0:
                Console.WriteLine($"{NP} jest równe zero");
                    break;
            }

            ///ZADANIE 4
            Console.WriteLine("\r\nZadanie 4");
            Console.WriteLine("Podaj rok");
            Int32 Year = Int32.Parse(Console.ReadLine());
            text = (Year % 4 == 0) ? ($"{Year} jest rokiem przestępnym") : ($"{Year} nie jest rokiem przestępnym");
            Console.WriteLine($"{text}");

            ///ZADANIE 5
            Console.WriteLine("\r\nZadanie 5");
            Console.WriteLine("Podaj wiek");
            Int32 Age = Int32.Parse(Console.ReadLine());
            text = Age switch
            {
                < 21 => "Nie możesz zostać ani posłem, ani senatrem, ani premierem",
                (>= 21 and < 30) => "Możesz zostać posłem",
                (>= 30 and < 35)=> "Możesz zostać posłem lub sentaorem",
                >= 35 => "Możesz zostać posłem,senatrem lub premierem",
            };
            Console.WriteLine($"{text}");

            ///ZADANIE 6
            Console.WriteLine("\r\nZadanie 6");
            Console.WriteLine("Podaj wzrost");
            byte Height = byte.Parse(Console.ReadLine());
            text = Height switch
            {
                <= 140 => "Jesteś krasnoludem",
                (> 140 and < 160) => "Jesteś niski",
                (>= 160 and < 190) => "Jesteś średniego wzrostu",
                >= 190 => "Jesteś bardzo wysoki",

            };
            Console.WriteLine($"{text}");

            ///ZADANIE 7
            Console.WriteLine("\r\nZadanie 7");
            Console.WriteLine("Podaj 3 liczby: ");
            Int32 N1 = Int32.Parse(Console.ReadLine());
            Int32 N2 = Int32.Parse(Console.ReadLine());
            Int32 N3 = Int32.Parse(Console.ReadLine());
            Int32 BiggestN = Math.Max(Math.Max(N1, N2), N3);
            Console.WriteLine($"{BiggestN} jest największa z podanych");

            ///ZADANIE 8  
            Console.WriteLine("\r\nZadanie 8");
            Console.WriteLine("Podaj wynik z matematyki: ");
            Int32 Mathem = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z fizyki: ");
            Int32 Physics = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z chemii: ");
            Int32 Chem = Int32.Parse(Console.ReadLine());
            if ((Mathem > 70 && Physics > 55 && Chem > 45 && Mathem+Physics+Chem >180 ) || ( (Mathem + Physics  > 150 ) || (Mathem + Chem > 150)))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");

            }
            ///ZADANIE 9   
            Console.WriteLine("\r\nZadanie 9");
            Console.WriteLine("Podaj temperaturę: ");
            Int32 Temp = Int32.Parse(Console.ReadLine());
            text = Temp switch
            {
                < 0 => "cholernie piździ",
                (>= 0 and < 10) => "zimno",
                (>= 10 and 20) => "chłodno",
                (>= 20 and 30) => "w sam raz",
                (>= 30 and 40) => "zaczyna być słabo, bo gorąco",
                >= 40 => "a weź wyprowadzam się na Alaskę.",
              _ => "Nieprawidłowa wartość",
            };
            Console.WriteLine($"{text}");

            ///ZADANIE 10
            Console.WriteLine("\r\nZadanie 10");
            Console.WriteLine("Podaj długości trójkąta od najmniejszej do największej");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            Int32 c = Int32.Parse(Console.ReadLine());

            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
            else
            { 
              Console.WriteLine("Można zbudować trójkąt");
            }

            ///ZADANIE 11
            Console.WriteLine("\r\nZadanie 11");
            Console.WriteLine("Podaj ocenę ");
            Int32 Grade = Int32.Parse(Console.ReadLine());
            text = Grade switch
                {
                    6 => "Celujący",
                    5 => "Bardzo dobry",
                    4 => "Dobry",
                    3 => "Dostateczny",
                    2 => "Dopuszczający",
                    1 => "Niedostateczny",
                    _ => "Nieprawidłowa wartość",
                };
            Console.WriteLine($"{text}");

            ///ZADANIE 12
            Console.WriteLine("\r\nZadanie 12");
            Console.WriteLine("Podaj numer dnia tygodnia ");
            Int32 Day = Int32.Parse(Console.ReadLine());
            text = Day switch
            {
                7 => "Niedziela",
                6 => "Sobota",
                5 => "Piątek",
                4 => "Czwartek",
                3 => "Środa",
                2 => "Wtorek",
                1 => "Poniedziałek",
                _ => "Nieprawidłowa wartość",
            };
            Console.WriteLine($"{text}");

            ///ZADANIE 13   
            Console.WriteLine("\r\nZadanie 13");
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer operacji do wykonania: \r\n1. Dodawanie \r\n2. Odejmowanie \r\n3. Mnożenie \r\n4. Dzielenie");
            Int32 Operation = Int32.Parse(Console.ReadLine());
            switch (Operation)
            {
                case 1:
                    Console.WriteLine($"Twój wynik to: {a+b}");
                    break;
                case 2:
                    Console.WriteLine($"Twój wynik to: {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Twój wynik to: {a * b}");
                    break;
                case 4:
                    if (b !=0 )
                    {
                        Console.WriteLine($"Twój wynik to: {a / b}");
                    }
                    else
                    {
                        Console.WriteLine($"Nie można dzielić przez 0");
                    }
                    break;
                default:
                    Console.WriteLine("Wybrano nieprawidłowy numer działania");
                    break;
            }

        }        
    }
}
