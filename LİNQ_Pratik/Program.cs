using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();              //Random sayılar üretip bu sayıları bir listeye atadım
                numbers.Add(rnd.Next(-25, 25));
            }
           
            foreach (int i in numbers)
            {
                Console.WriteLine(i); 
            }

            Console.WriteLine("---------------Çift Sayılar-------------------");

            var evenNumber = numbers.Where(n => n % 2 ==0); //Linq den Where yapısını kullanarak çift sayıları

            foreach (int i in evenNumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------Tek Sayılar-------------------------------");

            var oddNumber = numbers.Where(n => n % 2 == 1);  // tek sayıları

            foreach (int i in oddNumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------Negatif Sayılar----------------------------");

            var negativeNumber = numbers.Where(n => n < 0); // negatif sayıları

            foreach (int i in negativeNumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------Pozitif Sayılar-----------------------------------------");

            var positiveNumber = numbers.Where(n => n > 0); // pozitif sayıları

            foreach (int i in positiveNumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------15 den büyük 22 den küçük--------------------------------");

            var rangeNumber = numbers.Where(n => n < 22 && n > 15); // belirli aralıktaki sayıları

            foreach (int i in rangeNumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------Sayıların karesi-----------------------------------------");

            List<int> squareNumbers = numbers.Select(n => n * n).ToList(); //ve listedeki sayıların karesini oluşturup listeledim ve bunun için yeni bir liste oluşturdum

            foreach (int i in squareNumbers)
            {
                Console.WriteLine(i);
            }


        }
    }
}