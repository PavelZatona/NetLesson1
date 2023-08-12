using System.ComponentModel;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = InputNumber("A");

            var b = InputNumber("B");

            Console.WriteLine("Выберите действие: + - * или /");

            string action = Console.ReadLine();

            double c = 0;

            string actionName =string.Empty;

            if (action == "+")
            {
                // Действие сложения
                c = AddNumbers(a, b);
                actionName = "Сумма";
            }
            else if (action == "-")
            {
                //Действие вычитания
                c = SubtractNumbers(a,b);
                actionName = "Разность";
            }
            else if (action == "*")
            {
                //Действие умножения
                c = MultiplicationNumbers(a,b);
                actionName = "Произведение";
            }
            else if (action == "/")
            {
                //Действие деления
                c = DivisionNumbers(a,b);
                actionName= "Деление";
            }
            else
            {
                Console.WriteLine("Вы ввели не корректную операцию)");
                WaitForExit();
            }

            Console.WriteLine($"{actionName} {a} и {b} равно{c}");

            RequestForNewOperation(); 

            WaitForExit();
        }

        /// <summary>
        /// Предложение пользователю повторно выполнить операцию
        /// </summary>
        public static void RequestForNewOperation()

        {
            Console.WriteLine("Введите y если вы хотите выполнить новую операцию или n для остановки программы.");
            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar.ToString().ToLower() == "y")
                {
                    {
                        var a = InputNumber("A");

                        var b = InputNumber("B");

                        Console.WriteLine("Выберите действие: + - * или /");

                        string action = Console.ReadLine();

                        double c = 0;

                        string actionName = string.Empty;

                        if (action == "+")
                        {
                            // Действие сложения
                            c = AddNumbers(a, b);
                            actionName = "Сумма";
                        }
                        else if (action == "-")
                        {
                            //Действие вычитания
                            c = SubtractNumbers(a, b);
                            actionName = "Разность";
                        }
                        else if (action == "*")
                        {
                            //Действие умножения
                            c = MultiplicationNumbers(a, b);
                            actionName = "Произведение";
                        }
                        else if (action == "/")
                        {
                            //Действие деления
                            c = DivisionNumbers(a, b);
                            actionName = "Деление";
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не корректную операцию)");
                            WaitForExit();
                        }

                        Console.WriteLine($"{actionName} {a} и {b} равно{c}");

                        RequestForNewOperation();

                        WaitForExit();
                    }
                }
                else if (key.KeyChar.ToString().ToLower() == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильную команду");
                }
            }
        }

        /// <summary>
        /// Wait for exit from program
        /// </summary>
        public static void WaitForExit()
        {
            Console.WriteLine("Нажмите q для завершения работы");
            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar.ToString().ToLower() == "q")
                {
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// Ввод числа с клавиатуры
        /// </summary>
        /// <param name="numberName">Число???????????в старой нет этого параметра в коменте</param>
        /// <returns>Введённое пользователем число</returns>
        public static double InputNumber(string numberName)
        {
            Console.WriteLine($"введите число {numberName}: ");
            while (true)
            {
                string EnteredNumberAsString = Console.ReadLine();
                double result;
                if (double.TryParse(EnteredNumberAsString, out result))
                {
                    return result;
                }
                Console.WriteLine("Вы ввели не число, повторите ввод!");
            }
            
            }

        /// <summary>
        /// Сумма двух введённых чисел
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">Второе число</param>
        /// <returns>Сумма</returns>
        public static double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// Разность двух введённых чисел
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">Второе число</param>
        /// <returns>Разность</returns>
        public static double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// Умножение двух введённых чисел
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">Второе число</param>
        /// <returns>Произведение</returns>
        public static double MultiplicationNumbers(double num1, double num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">Второе число</param>
        /// <returns>Частное</returns>
        public static double DivisionNumbers(double num1, double num2)
        {
            return num2 / num1;
        }
    }
}