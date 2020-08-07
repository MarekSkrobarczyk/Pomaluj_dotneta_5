using System;
using System.Linq;

namespace Pomaluj_dotneta_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task5();
            //Task6();

            Console.ReadLine();
        }

        public static void Task1()

            /*Zad. 1. Napisz program, w którym:
             * a)utworzysz tablicę o wielkości 50 
             * b)zapełnisz ją kolejnymi liczbami począwszy od 1
             * c)wyświetlisz w konsoli jej zawartość. */
        {
            int[] table = new int[50];

            for (byte i = 0; i + 1 <= 50; i++)
            {
                table[i] = i + 1;
                Console.WriteLine(table[i]);
            }


        }

        public static void Task2()
        {

            /* Zad. 2. Napisz program, w którym:
             * a)utworzysz tablicę o wielkości 20 
             * b)zapełnisz ją wartościami pobranymi z konsoli
             * c)porównasz, czy: 
             * a.element pierwszy jest mniejszy czy większy od ostatniego 
             * b.element drugi jest różny od przedostatniego 
             * d) wypiszesz wszystkie elementy tablicy */

            int[] array = new int[20];

            for (int i = 0; i < 20; i++)
            {

                array[i] = i + 1;
                Console.WriteLine(array[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                if (array[i] > array[19 - i])
                {
                    Console.WriteLine($"{array[i]} is bigger than {array[19 - i]}");
                }
                else
                {
                    Console.WriteLine($"{array[i]} is smaller than {array[19 - i]}");
                }

            }

        }

        public static void Task3()

        /* Zad. 3. Napisz program, w którym:
         * a)utworzysz tablicę o wielkości 10 
         * b)zapełnisz ją losowymi wartościami 
         * c)wypiszesz w konsoli zawartość tej tablicy 
         * d)sprawdzisz, jaka wartość w tablicy jest największa i pod jakim jest indeksem, 
         * po czym wypiszesz obie dane w konsoli 
         * e)sprawdzisz, jaka wartość w tablicy jest najmniejsza i pod jakim jest indeksem, 
         * po czym wypiszesz obie dane w konsoli 

        Zad. 4. Napisz metodę, którą posortujesz tablicę z Zad. 3. Zastosuj algorytm sortowania bąbelkowego.
         */
        {
            int[] array = new int[10];
            var rand = new Random();
            int maxValue = 0;
            int minValue = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine(array[i]);

            }

            Console.WriteLine($" \n\n Smallest value in table is {minValue = array.Min()} ");
            Console.WriteLine($" \n\n Largest value in table is {maxValue = array.Max()} ");

            Console.WriteLine($"\n Index of max value is {Array.IndexOf(array, maxValue)}");
            Console.WriteLine($"\n Index of min value is  {Array.IndexOf(array, minValue)}");

            int n = array.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int a = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = a;
                    }
                }
                n--;
            }
            while (n > 1);

            Console.WriteLine(" I po sortowaniu mamy taki twór ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }



        }

        public static void Task5()

            /* Zad. 5. Napisz program, w którym:
             * a)utworzysz tablicę statyczną o wielkości 20 
             * b)używając funkcji rand() i srand() zapełnisz ją losowymi wartościami 
             * c)wypiszesz w konsoli zawartość tej tablicy 
             * d)napiszesz funkcję, która będzie aktualizowała element tablicy o indeksie podanym przez użytkownika na wartość również przez niego wybraną 
             * e)wypisz w konsoli zaktualizowaną tablicę. 
             * f)Pamiętaj, że użytkownik nie może odwoływać się poza zakres tablicy. */

        {
            int[] array = new int[20];
            var rand = new Random();
            int choice;
            int value;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine(array[i]);

            }


            Console.WriteLine(" You want to change some value in the table, if so, with what index");
            Int32.TryParse(Console.ReadLine(), out choice);

            if (choice >= 0 && choice <= 19)  // I TUTAJ PYTANIE  - Jeżeli dam choice jako typ BYTE lewy warunek nie działa
            {
                Console.WriteLine($" And what value you want ascribe to index {choice} in our table ");
                Int32.TryParse(Console.ReadLine(), out value);
                array[choice] = value;

                Console.WriteLine(array[choice]);
            }

            else
                Console.WriteLine("Nope, we cannot do that, try to contact wuht our support dept.");


        }

        public static void Task6()
        {
            int[,] array = new int[10, 10];

 
            for (int i = 0; i < 10 ; i++)
            {
                
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                    Console.WriteLine(array[i,j]);
                }
            }
        }

        public static void Task7()
        {

        }

        
    }
    

}
