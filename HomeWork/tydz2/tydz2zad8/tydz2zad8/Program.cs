using System;

namespace tydz2zad8
{
    class Program
    {
        public static void Main(string[] args)
        {
           //Zad1
            Console.Write("\r\nZadanie 1 \r\n");
            Console.WriteLine("Liczby pierwsze od 0 do 100 : ");
            int sum = 0;
            for (int i = 2; i <= 100; i++)
            {

                int temp = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if ((i % j) == 0)
                    {
                        temp++;

                    }
                }
                if (temp == 0 )
                {
                    Console.Write(i + " ");
                    sum++;
                }
            }
            Console.WriteLine($"\r\nLiczb pierwszych w zakresie od 0 do 100 jest : {sum}");

            //Zad2
            Console.Write("\r\nZadanie 2 \r\n");
            Console.WriteLine("Liczby parzyste do 100");
            int even = 1;
            do
            {
                if (even % 2 == 0)
                {
                    Console.WriteLine(even);
                }
                even++;
            }
            while (even < 100);

            //Zad3
            Console.WriteLine("\r\nZadanie 3 ciąg Fibonacciego");
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
           
            //Zad4
            Console.Write("\r\nZadanie 4");
            Console.Write("\r\nPodaj liczbę całkowitą : ");
            int lastNum = int.Parse(Console.ReadLine());
            int num = 1;
            for (int row = 1; row <=lastNum; row++)
            {
                for (int col=1; col <=row ;col++)
                {
                    Console.Write($"{num} ");
                    num++;
                    if (num > lastNum) break;
                    
                }
                Console.WriteLine();
                if (num > lastNum)
                {
                    break;
                }
            }
        
            //Zad5
            Console.Write("\r\nZadanie 5");
            Console.Write("\r\n");
            int numPow = 20;
            double p =0;
            for (double i = 1; i <= numPow; i++)
            {
                p = Math.Pow(i, 3);
                Console.Write($"Potęga 3 liczby {i} to : {p}");
                Console.Write("\r\n");
            }

            //Zad6
            Console.Write("\r\nZadanie 6");
            int numEnd = 20;
            double s = 0.0;

            for (double i = 1; i <= numEnd; i++)
            {
                s += 1 / i;
            }
            Console.Write($"\r\nSuma dla liczb od 0 do 20 to: {Math.Round((decimal) s, 2)}");
         
            //Zad7
            Console.Write("\r\nZadanie 7");
            Console.Write("\r\nPodaj najkrótszą przekątną diamentu:  \r\n");
            int level = int.Parse(Console.ReadLine());
            for (int j = level / 2; j >= 0; j--)
            {
                for (int k = 0; k < j; k++) Console.Write(" ");
                for (int k = level; k > j * 2; k--) Console.Write("*");
                Console.WriteLine();
            }
            for (int j = 1; j <= level / 2; j++) 
            {
                 for (int k = 1; k <= j; k++) Console.Write(" ");
                for (int k = level; k > j * 2; k--) Console.Write("*");
                Console.WriteLine();
            }
            Console.Write("\r\n");
            
            //Zad8
            Console.Write("\r\nZadanie 8");
            Console.Write("\r\nPodaj ciąg znaków : ");
            string str1 = Console.ReadLine();
            string str2 = " ";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str2 += str1[i];
            }
            Console.Write($"Odwrócony ciąg znaków : {str2}");
            Console.ReadLine();

            //Zad9
            Console.Write("\r\nZadanie 9");
            Console.Write("\r\nPodaj liczbę dziesiętną: ");
            int value = int.Parse(Console.ReadLine());
            int rest = 0;
            string valueB = "";

            for  (int i=value; value > 0;i++)
            {
                rest = value % 2;
                value = value / 2;
                valueB = rest + valueB;
            }
            Console.WriteLine($"Liczba binarna to: {valueB}");

            /*
             Widziałam też taki sposób ale sama na to nie wpadłam więc nie podaję :)
              string valueB = Convert.ToString(value, 2);
            */
            
            //Zad10
            Console.Write("\r\nZadanie 10");
            Console.Write("\r\nPodaj pierwszą liczbę : ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę  : ");
            int value2 = int.Parse(Console.ReadLine());
            int nww = 0;
            int x1 = value1;
            int x2 = value2;
          
                        for (int i = value1; value1 != value2; i++)
                        {
                            var conditions = (value1 > value2);
                            int check =   conditions ? (value1 = value1 - value2) : (value2 = value2 - value1);
                        }
                        nww = (x1 * x2) / value1;
          
            Console.Write($"\r\nNajmniejszy wspólny dzielnik dla podanych liczb to : {nww}\r\n"); 
            
        }
    }

    }

    
