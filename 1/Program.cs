using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            tatic void Main(string[] args)
            {/*
            //Метанит Теория 
            //УМНОЖЕНИЕ КАЖДОГО ИНДЕКСА МАССИВА НА 2.
            int[] max = new[] { 1, 2, 4, 5, 7 }; // одномерный массив.
            for (int i = 0; i < max.Length; i++)
            {
                max[i] = max[i] * 2;
                Console.WriteLine(max[i]);
            }  //постепенно умножение каждого индекса массива на 2;






            //ПОСТРОЕНИЕ МАССИВА В ОБРАТНОМ ПОРЯДКЕ.
            char [] hello = new[] { 'h', 'e', 'l', 'l', 'o' };
            {
                for (int i = hello.Length - 1; i <= hello.Length - 1; i--) //Инверсия массива
                {
                    Console.WriteLine($"{ hello [i]} ") ;
                    Console.ReadLine();                }
                Console.ReadLine();
          


                //ПОСТРОНИЕ
                int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
                int rows = mas.GetUpperBound(0) + 1;
                int columns = mas.Length / rows;
                // или так
                // int columns = mas.GetUpperBound(1) + 1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{mas[i, j]} \t");
                    }
                    Console.WriteLine();}

            





             // ПЕРЕБИРАЕМ МАССИВ МАССИВОВ 
            int[][] value = new int[3][];
            value[0] = new int[] { 1, 2 };
            value[1] = new int[] { 3, 4, 3 };
            value[2] = new int[] { 7, 8, 5, 9 };








            // НАЙДЕМ КОЛИЧЕСТВО ПОЛОЖИТЕЛЬНЫХ ЦИФР В МАССИВЕ
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    result++;
                }
            }
            Console.WriteLine($"Число элементов больше нуля: {result}");







            // НАЙДЕМ КОЛИЧЕСТВО ОТРИЦАТЕЛЬНЫХ ЦИФР В МАССИВЕ
            int[] body = new int [] { 1,2,3,4,5,6,-1,-2,-8 };
            int result01 = 0;
            foreach (int X in body)
            {
                if (X < 0)
                {
                    result01++;
                }          
             }
            Console.WriteLine( $" Число значений меньше нуля:   { result01}" ) ;
            




            //ПЕРЕБИРАЮ ОДНОМЕРНЫЙ МАССИВ
            int[] massiv1 = { 1,2,3,4,5,6,7};
            for (int i=0; i < massiv1.Length; i++)
            { 
                Console.Write($"{massiv1[i]} " );           
            }
           





            //ПЕРЕБИРАЮ ДВУМЕРНЫЙ МАССИВ
            int[,] massiv1 = [ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }];
            for (int i = 0; i < massiv1.GetLength; i++)
            {
                for (int j = 0; j < massiv1.Length ; j++)
                {
                    Console.Write($"{massiv1[i, j]} \t");
                }
                Console.WriteLine();
            }         
            // ВЫВОД МАССИВА С КОНСОЛИ
            Console.Write("Введите число эллементов масива: \t");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\n Введите элемент массива под индексом {i}: \t ");
                array[i] = int.Parse(Console.ReadLine());
            }
                Console.Write($" Вывод массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }




            // ВЫВОд МАссива с консоли в обратном порядке
            Console.Write("Введите число эллементов масива: \t");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\n Введите элемент массива под индексом {i}: \t ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($" Вывод массива: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }

         


            // НАЙТИ СУММУ ЧЕТНЫХ ЧИСЕЛ МАССИВА
            int[] massiv2 = { 1, 2, 3,5,8 };
            int result = 0;
            for (int i = 0; i < massiv2.Length; i++)
            {
                if (massiv2[i] % 2 == 0)
                {
                    result += massiv2[i];
                }
            }
            Console.Write(result);





           // НАЙТИ СУММУ ЧЕТНЫХ ЧИСЕЛ МАССИВА C ИСПОЛЬЗОВАНИЕМ ТЕРМАЛЬНОГО ОПЕРАТОРА.
            int[] massiv2 = { 1, 2, 3, 5, 8 };
            int result = 0;
            for (int i = 0; i < massiv2.Length; i++)
            {
                int x= (massiv2[i] % 2 == 0) ? result += massiv2[i] : 0;
            }
            Console.Write(result);
            
             */
                // Найти наибольший элемент в массиве.

                /// ВОПРОССССС-  Как через ЦИКЛ найти максимальное и минимальное значение массива??
                /*
                int[] myarray = { 1, 0, -2, 9, 6, 4, 0, 3, 1, 15 };

                Console.WriteLine(myarray.Max());
                Console.WriteLine(myarray.Min());
                Console.WriteLine(myarray.Sum());
                int[] result = myarray.Distinct().ToArray();

                Console.WriteLine(Array.Sort(myarray));





                /*Немного теории для себя 
                           Console.WriteLine("One");
                           int [] mix= { 5, 2, 3 };
                           int [,] mix1= new int [4, 5]; //двумерный массив , матрица .
                           int [,,] mix2= new int  [3, 5, 4]; //трехмерный массив, матрица, массив массивов.

                           Console.WriteLine(mix [1]);
                           //Для перебора элементов массива используют специальные операторы- циклы. 
                           Console.WriteLine("Two");

                           int[] array01 = { 2, 7, 6, 9, 4, 6 };

                           for (int f = 0; f < 6; f++)
                           {

                               Console.WriteLine(array01[f]);


                           }

                           Console.WriteLine("Three");
                           int[] array02 = { 2, 7, 6, 9, 4 };

                           for (int l = 0; l < array02.Length ; l++)
                           {

                               Console.WriteLine(array02[l]);


                           }



                           Console.WriteLine("Four");

                           int[][] a = new int[3][];
                           a[0] = new int[8];
                           a[1] = new int[4];
                           a[2] = new int[3];
                           int a00 = a[0][0];

                           a[2][3] = 1;

                           Console.WriteLine(a[0]);






                           Console.WriteLine("Five");


                           int[,] zero = new int[5, 5];
                           zero[2, 2] = 1;

                           for (int i = 0; i < zero.GetLength(0); i++)
                           {

                               for (int j=0; j< zero.GetLength(1); j++) {


                                   Console.Write($"{zero[i,j]}");


                               }
                               System.Console.WriteLine();

                           }

                           int[,] matrix = new int[5, 5];

                           matrix[2, 3] = 1;
                           matrix[2, 4 ] = 1;

                           for (int i = 0; i < matrix.GetLength(0); i++)
                           {
                               for (int j = 0; j < matrix.GetLength(1); j++)
                               {
                                   System.Console.Write($"{matrix[i, j]} ");
                               }
                               System.Console.WriteLine();
                           }



                           while (true)
                           {
                               double input = Convert.ToDouble(Console.ReadLine());


                               {

                                   if (input > 0)
                                   { Console.WriteLine(input); }
                                   else if (input == 0)
                                   { Console.WriteLine("Нуль"); }
                                   break;

                               }

                               /*

                           string password;
                           do
                           {
                               Console.WriteLine("Задайте пароль длиной не менее 5 знаков");
                               password = Console.ReadLine();
                           } while (password.Length < 5);

                           string repeatedPassword;
                           do
                           {
                               Console.WriteLine("Повторите пароль:");
                               repeatedPassword = Console.ReadLine();
                           } while (repeatedPassword != password);

                           Console.WriteLine("Пароль успешно установлен");




                           string[] students =
                                        {
                                           "Иванов",
                                           "Петров",
                                           "Сидоров",
                                           "Петрова",
                                           "Филиппова",
                                           "Егоров",
                                           "Козлова",
                                       };

                           Console.Write("Введите фамилию студента:");
                           string lastName = Console.ReadLine();
                           bool isFound = false;

                           for (int i = 0; i < students.Length; i++)
                           {
                               if (students[i] == lastName)
                               {
                                   Console.WriteLine($"Студент с фамилией {lastName} находится под номером {i + 1}");
                                   isFound = true;
                                   break;
                               }
                           }

                           if (!isFound)
                           {
                               Console.WriteLine("Такого студента нет в списке :(");
                           }




                           ВЫВЕДИ НЕЧЕТНЫЕ ЧИСЛА из 800.

                           for (int a = 0; a < 10; a++) 

                           {
                               if (a%2==0)
                               {
                                   continue;
                               }
                               Console.WriteLine(a);
                           }


                           char[] asd = { 'w', 'o', 'r', 'l', 'd' };

                           for (int i = 0; i < asd.Length; i++)
                           {
                               Console.Write(asd[i]);

                           }

               //tring[] asd01 { "world" };


               char[] asd = { 'w', 'o', 'r', 'l', 'd' };

               for (int i = 0; i < asd.Length; i++)
               {
                   Console.Write(asd[i]);

               }



               // Первое

                   string greetings = "Hello";

                   for (int i = greetings.Length -1  ; i >= 0; i--)
                   {
                       Console.Write(greetings[i]);
                   }

                   Console.Read();


               //Второе

               string [,] directory = new string [,]

               {

               { "Иванов A.A" ,      "+7915872345 / Ivanov@bk.ru" },
               { "Сидоров К.М",      "+7915862457 / Sidorov@mail.ru" },
               { "Быков А.Ю.  ",     "+7919532655 / Bikov@bk.ru" },
               { "Филимонова С.С.",  "+7985696328 / Filimonova@mail.ru" },
               { "Юрченко К.И.",     "+7936152847 / Yurshenko@mail.ru"},


               };

               for (int i = 0; i < directory.GetLength(0); i++)
               {
                   for (int j = 0; j < directory.GetLength(1); j++)
                   {
                       Console.Write(directory[i, j]);
                   }

                   System.Console.ReadLine();

                   */

                /*
                int[,] myArray = new int[,]
                {
                    {2, 45, 12, 51, 51},
                    {6, 7, 8, 3, 1},
                    {1, 5, 65, 78, 13},
                    {6, 3, 151, 5, 65},
                    {64, 43, 15, 5, 37}
                };
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i, i]);
                }



                int[] array = { 1, 2, 3, 4, 5 };
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                }

                */
            }
    }
}
