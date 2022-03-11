
using System;
namespace tydz2zad4
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Zad1");
            string FirstName = "Jan";
            string LastName = "Kowalski";
            byte Age = 18;
            char Gender = 'm';
            string PESEL = "434324324";
            string EmployeeNumber = "2509324094";
            Console.WriteLine($"FirstName: {FirstName},\r\nLastName: {LastName},\r\nAge: {Age},\r\nGender: {Gender}, \r\nFirstName: {FirstName},\r\nPESEL: {PESEL},\r\nEmployeeNumber: {EmployeeNumber} ");

            Console.WriteLine("\r\nZad2");
            char v1 = 'a';
            char v2 = 'b';
            char v3 = 'c';
            Console.WriteLine($"v3:{v3}, v2:{v2}, v1:{v1}");

            Console.WriteLine("\r\nZad3");
            Console.WriteLine("Podaj szerokość prostokąta");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość prostokąta");
            double length = double.Parse(Console.ReadLine());
            double DiagonalLength = Math.Sqrt(Math.Pow(width,2) + Math.Pow(length, 2));
            Console.WriteLine($" Długość przekątnej wynosi: {DiagonalLength} ");

            Console.WriteLine("\r\nZad4");
            int a;
            string b;
            double c;
            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;
            Console.WriteLine($"a. {a},\r\nb. {b},\r\nc. {c}");

            Console.WriteLine("\r\nZad5");
            Console.WriteLine("Podaj swoję imię");
            string Name = Console.ReadLine();
            Console.WriteLine("Podaj swój wiek");
            Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój e-mail");
            string Email=Console.ReadLine();
            Console.WriteLine("Podaj swój adres");
            string Adress = (Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost");
            byte Height = byte.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoją datę urodzenia");
            DateTime myDate = DateTime.Now;
            string longDateString = myDate.ToString("d");
            Console.WriteLine($"\r\nPodane dane \r\nImię: {Name},\r\nWiek: {Age},\r\nEmail: {Email},\r\nAdres: {Adress},\r\nWzrost: {Height } \r\nDane na dzień {longDateString} ");
        }

    }
}
