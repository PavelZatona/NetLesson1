namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 10.0;

            var b = 15.0;

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
    }
}