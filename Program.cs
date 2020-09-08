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
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task10();

            Console.ReadLine();
        }

        public static void Task1()

        /*Zad. 1. Napisz program, w którym:
         * a)utworzysz tablicę o wielkości 50 
         * b)zapełnisz ją kolejnymi liczbami począwszy od 1
         * c)wyświetlisz w konsoli jej zawartość. */
        {
            int[] table = new int[50];

            for (byte i = 0; i < 50; i++)
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


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine(array[i]);

            }

            int maxValue = array[1];
            int minValue = array[1];

            /*                            WERSJA Z LINQ
             * Console.WriteLine($" \n\n Smallest value in table is {minValue = array.Min()} ");
              Console.WriteLine($" \n\n Largest value in table is {maxValue = array.Max()} ");

              Console.WriteLine($"\n Index of max value is {Array.IndexOf(array, maxValue)}");
              Console.WriteLine($"\n Index of min value is  {Array.IndexOf(array, minValue)}");

             */


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];

                }

                if (array[i] > maxValue)

                {
                    maxValue = array[i];

                }


            }



            Console.WriteLine($"\n Index of max value is {maxValue} ");
            Console.WriteLine($"\n Index of min value is  {minValue} ");



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

            if (choice >= 0 && choice <= 19)
            {
                Console.WriteLine($" And what value you want ascribe to index {choice} in our table ");
                Int32.TryParse(Console.ReadLine(), out value);
                array[choice] = value;

                Console.WriteLine(array[choice]);
            }

            else
                Console.WriteLine("Nope, we cannot do that, try to contact wiht our support dept. , but they will probably not help you ");


        }

        public static void Task6()
        {

            /*Napisz program, w którym:
              a)utworzysz tablicę dwuwymiarową o wymiarach 10x10
              b)do każdego elementu tablicy wpiszesz wyniki tabliczki mnożenia od 1 do 10
              c)wypiszesz zawartość tablicy w konsoli tak, żeby każdy wiersz tabeli odpowiadał oddzielnemu wierszowi w konsoli*/


            int[,] array = new int[10, 10];


            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }


        }

        public static void Task7()
        {
            /* Potraktuj tablicę dwuwymiarową jako macierz kwadratową.Napisz program, w którym:
             * a) stworzysz tablicę dwuwymiarową o rozmiarze 3x3 
             * b) wypełnisz jej elementy liczbami z zakresu od 0 do 9
             * c) wypiszesz w konsoli otrzymaną macierz zachowując jej układ  
             * przemnożysz tą macierz przez liczbę podaną przez użytkownika i wpiszesz ją w konsoli
             * */

            Random generator = new Random();

            int[,] array = new int[3, 3];


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = generator.Next(0, 9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" \n\n By what value do we multiply the matrix ?  ");
            int multiplier = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = array[i, j] * multiplier;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static void Task8()
        {
            /* Potraktuj tablicę dwuwymiarową jako macierz kwadratową
             * Napisz program, w którym:
             * a.) stworzysz tablicę dwuwymiarową o rozmiarze 5x5
             * b.) wypełnisz jej elementy liczbami z zakresu od 0 do 9 
             * c.) wypiszesz w konsoli otrzymaną macierz zachowując jej układ 
             * d.) obliczysz ślad otrzymanej macierzy i wypiszesz go w konsoli. 
             */

            Random generator = new Random();

            int[,] array = new int[5, 5];
            int matrixTrace = 0;


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = generator.Next(0, 9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }



            for (int i = 0; i < array.GetLength(0); i++)
            {
                matrixTrace += array[i, i];
            }

            Console.WriteLine($" Matrix trace is equal to {matrixTrace}");



        }

        public static void Task10()
        {
            /* Potraktuj tablicę dwuwymiarową jako macierz kwadratową
             * Napisz program, w którym:
             * a.) stworzysz dwie tablice dwuwymiarowe o rozmiarze 3x3
             * b.) wypełnisz ich elementy liczbami z zakresu od 0 do 9 
             * c.) wypiszesz w konsoli otrzymane macierze, zachowując ich układ 
             * d.) przemnożysz ze sobą macierze pierwszą z drugą i drugą z pierwszą i wypiszesz otrzymane macierze w konsoli.. 
             */

            Random generator = new Random();

            int[,] array = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array12 = new int[3, 3];


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = generator.Next(0, 9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = generator.Next(0, 9);
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\n A x B  \n\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int mulitVal = 0;

                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        mulitVal += (array[i, k] * array2[k, j]);
                    }
                    Console.Write(mulitVal + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n B x A  \n\n");

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    int mulitVal = 0;

                    for (int k = 0; k < array2.GetLength(1); k++)
                    {
                        mulitVal += (array2[i, k] * array[k, j]);
                    }
                    Console.Write(mulitVal + " ");
                }
                Console.WriteLine();
            }



        }

        

    }
}
