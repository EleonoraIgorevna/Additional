using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //Запрашиваем минимальную погоду за сутки.
            Console.WriteLine("Пожалуйста введи минимальную погоду за сутки.");
            string MinTemperature = Console.ReadLine();
            //Вводим три переменные, где а - манимальная температура, b - максимальная температура за сутки, result - средняя температура за сутки.
            double a, b, result;
            //Конвертируем из строкового значение Минимальной температуры  в числовое значение с плавающей точкой.
            a = Convert.ToByte(MinTemperature);
            //Вывводим результат (минимальная температура) на консоль.
            Console.WriteLine("Минимальная температура " + a + " градусов");
            //Запрашиваем максимальную  погоду за сутки.
            Console.WriteLine("Пожалуйста введи  максимальную погоду за сутки.");
            string MaxTemperature = Console.ReadLine();
            //Конвертируем из строкового значение Максимальной температуры  в числовое значение с плавающей точкой.
            b = Convert.ToByte(MaxTemperature);
            //Вывводим результат (максимальная температура) на консоль.
            Console.WriteLine("Максимальная температура " + b + " градусов");
            //Просчитываем среднее значение минимальной и максимальной температуры за сутки.
            result = ((a + b) / 2);
            //Выводим результат на консоль.
            Console.WriteLine("Средняя температура за сутки  " + result + " градусов");
            */


            /*
             * 
              double Count = 500.34;
            int quantity = 1;



            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ________________________________________");
            Console.WriteLine("|              OOO'Ромашка'              |");
            Console.WriteLine("|             ИНН:  45632455             |");
            Console.WriteLine("|  Россия, г.Москва, ул. Профсоюзная 42  |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|          КАССОВЫЙ ЧЕК/ПРИХОД           |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("| Доставка цветов                 " + quantity + " шт   |");
            Console.WriteLine("| Услуга   " + Count + "                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                      " + DateTime.Now + "|");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|               @}-->--                  |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|_________СПАСИБО ЗА ПОКУПКУ!____________|");











                        //Запрашивает число.
                        Console.WriteLine("Пожалуйста введи любое число. Мы проверим его на четность.");
                        double value = Convert.ToDouble(Console.ReadLine());
                        //Вводим переменную, которая через % будет проверять четность введенного ранее числа. 
                        double result = value % 2;
                        //Прописываем условия четности. 
                        if (result > 0) { Console.WriteLine("Число не четное."); }
                        if (result == 0) { Console.WriteLine("Число четное."); }




            //Запрашиваем число месяца.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Пожалуйста, введите любое число от 1 до 12. Программа выведет на экран название месяца, которое соответствует введенному числу.");
            //Создаем переменную а и присваеваем ей целое значение.
            int a = Convert.ToInt32(Console.ReadLine());
            int MonthOfYear = a;
            string MonthTitle = "";

            //Прописываем номера и их соотвествия месяцам.
            switch (MonthOfYear)
            {
                case 1:
                    MonthTitle = "Январь";
                    break;
                case 2:
                    MonthTitle = "Февраль";
                    break;
                case 3:
                    MonthTitle = "Март";
                    break;
                case 4:
                    MonthTitle = "Апрель";
                    break;
                case 5:
                    MonthTitle = "Май";
                    break;
                case 6:
                    MonthTitle = "Июнь";
                    break;
                case 7:
                    MonthTitle = "Июль";
                    break;
                case 8:
                    MonthTitle = "Август";
                    break;
                case 9:
                    MonthTitle = "Сентябрь";
                    break;
                case 10:
                    MonthTitle = "Октябрь";
                    break;
                case 11:
                    MonthTitle = "Ноябрь";
                    break;
                case 12:
                    MonthTitle = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Введите корректное число.");
                    break;
            }
            Console.WriteLine(MonthTitle);




            //Запрашиваем число месяца.
            Console.WriteLine("Пожалуйста, введите любое число от 1 до 12. Программа выведет на экран название месяца, которое соответствует введенному числу.");
            //Создаем переменную а и присваеваем ей целое значение.
            int a = Convert.ToInt32(Console.ReadLine());
            int MonthOfYear = a;
            string MonthTitle = "";

            //Прописываем номера и их соотвествия месяцам.
            switch (MonthOfYear)
            {
                case 1:
                    MonthTitle = "Январь";
                    Console.WriteLine(MonthTitle);
                    break;
                case 2:
                    MonthTitle = "Февраль";
                    Console.WriteLine(MonthTitle);
                    break;
                case 3:
                    MonthTitle = "Март";
                    Console.WriteLine(MonthTitle);
                    break;
                case 4:
                    MonthTitle = "Апрель";
                    Console.WriteLine(MonthTitle);
                    break;
                case 5:
                    MonthTitle = "Май";
                    Console.WriteLine(MonthTitle);
                    break;
                case 6:
                    MonthTitle = "Июнь";
                    Console.WriteLine(MonthTitle);
                    break;
                case 7:
                    MonthTitle = "Июль";
                    Console.WriteLine(MonthTitle);
                    break;
                case 8:
                    MonthTitle = "Август";
                    Console.WriteLine(MonthTitle);
                    break;
                case 9:
                    MonthTitle = "Сентябрь";
                    Console.WriteLine(MonthTitle);
                    break;
                case 10:
                    MonthTitle = "Октябрь";
                    Console.WriteLine(MonthTitle);
                    break;
                case 11:
                    MonthTitle = "Ноябрь";
                    Console.WriteLine(MonthTitle);
                    break;
                case 12:
                    MonthTitle = "Декабрь";
                    Console.WriteLine(MonthTitle);
                    break;
                default:
                    Console.WriteLine("Введите корректное число.");
                    break;



             public enum Months 
        { 
            January = 1,
            Febuary,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {/* Не получается данный вариант. Хочу понять в чем причина
            int value = Convert.ToInt32(Console.ReadLine((value)));
            Console.WriteLine(value); */
        }


                        */









            ;
        }
}
}
