
namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Список разрешённых операций
        /// </summary>
        public static readonly IReadOnlyCollection<string> AllowedOperations = new List<string>() { "+", "-", "*", "/" };

        static void Main(string[] args)
        {
            do
            {
                // Тут мы будем делать вычисления
                DoCalculation();
            }
            while (IsNewOperationRequested());

            WaitForExit();
        }

        /// <summary>
        /// Возвращает true, если пользователь хочет ещё операцию
        /// </summary>
        /// <returns></returns>
        public static bool IsNewOperationRequested()
        {
            while (true)
            {
                Console.WriteLine("Введите y если вы хотите выполнить новую операцию или n для остановки программы.");

                var userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "y")
                {
                    return true;
                }
                else if (userAnswer == "n")
                {
                    return false;
                }

                // Некорректный ввод
                Console.WriteLine("Некорректный ответ!");
            }
        }

        /// <summary>
        /// Принимает введённую с клавиатуры операцию и проверяет, допустима-ли она
        /// </summary>
        public static bool IsOperationCorrect(string operation)
        {
            return AllowedOperations.Any(collectionItem => collectionItem == operation);
        }


        public static string EnterOperation()
        {
            while (true)
            {
                Console.WriteLine($"Выберите действие: {string.Join(", ", AllowedOperations)}");
                string action = Console.ReadLine();

                if (IsOperationCorrect(action))
                {
                    return action;
                }

                Console.WriteLine("Операция некорректна, повторите ввод!");
            }
        }

        /// <summary>
        /// Метод выполняет одну операцию
        /// </summary>
        public static void DoCalculation()
        {
            var a = InputNumber("A");

            var b = InputNumber("B");

            string action = EnterOperation();

            double c;
            string actionName;

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
                throw new Exception("В программе баг, неожиданная операция!");
            }

            Console.WriteLine($"{actionName} {a} и {b} равно {c}");
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
        /// <param name="numberName">Имя числа, которое пользователь будет вводить</param>
        /// <returns>Введённое пользователем число</returns>
        public static double InputNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}:");

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