namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = InputNumber("A");

            var b = InputNumber("B");

            Console.WriteLine("Выберите действие: + или -");
            string action = Console.ReadLine();

            double c = 0;

            string actionName = string.Empty;

            if (action == "+")
            {
                // Тут мы складываем
                c = AddNumbers(a, b);
                actionName = "Сумма";
            }
            else if (action == "-")
            {
                // Тут мы вычитаем
                c = SubtractNumbers(a, b);
                actionName = "Разность";
            }
            else
            {
                Console.WriteLine("Вы ввели некорректную операцию!");
                WaitForExit();
            }

            Console.WriteLine($"{actionName} {a} и {b} равна {c}");

            WaitForExit();
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
        /// Складывает два числа
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">Второе число</param>
        /// <returns>Сумма</returns>
        public static double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Вычитание двух чисел
        /// </summary>
        /// <param name="num1">Уменьшаемое</param>
        /// <param name="num2">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Ввод числа с клавиатуры
        /// </summary>
        /// <returns>Введённое число</returns>
        public static double InputNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}:");

            while(true)
            {
                string enteredNumberAsString = Console.ReadLine();

                double result;
                if (double.TryParse(enteredNumberAsString, out result))
                {
                    return result;
                }

                Console.WriteLine("Вы ввели не число, повторите ввод!");
            }


            //try
            //{
            //    return double.Parse(enteredNumberAsString);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Вы ввели не число, программа завершает свою работу!");
            //    Console.WriteLine($"Произошла ошибка: { ex.Message }");
            //    Console.WriteLine($"Stack trace: { ex.StackTrace }");
            //    WaitForExit();

            //    return double.NaN;
            //}
        }
    }
}