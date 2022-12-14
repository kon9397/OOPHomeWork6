namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите арифметический знак: + - * /");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(Calculator.Plus(a, b));
                    break;
                case "-":
                    Console.WriteLine(Calculator.Minus(a, b));
                    break;
                case "*":
                    Console.WriteLine(Calculator.Multiply(a, b));
                    break;
                case "/":
                    Console.WriteLine(Calculator.Divide(a, b));
                    break;
                default:
                    Console.WriteLine("Неизвестный знак, попробуйте снова");
                    break;
            }

            Console.ReadKey();
        }
    }
}