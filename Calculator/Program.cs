namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator app");
            Console.Write("Please enter first number: ");
            bool isParsed01 = int.TryParse(Console.ReadLine(), out int number_1);
            Console.Write("Please enter second number: ");
            bool isParsed02 = int.TryParse(Console.ReadLine(), out int number_2);
            Console.WriteLine("Plese choose you operation");
            Console.WriteLine("choose 1 ==> + ");
            Console.WriteLine("choose 2 ==> - ");
            Console.WriteLine("choose 3 ==> 3 ");
            Console.WriteLine("choose 4 ==> / ");
            Console.Write("Your choice: ");
            bool isParsed03 = int.TryParse(Console.ReadLine(), out int op);
            if (isParsed01 && isParsed02 && isParsed03)
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine($"{number_1} + {number_2} = {number_1 + number_2}");
                        break;
                    case 2:
                        Console.WriteLine($"{number_1} - {number_2} = {number_1 - number_2}");
                        break;
                    case 3:
                        Console.WriteLine($"{number_1} * {number_2} = {number_1 * number_2}");
                        break;
                    case 4:
                        Console.WriteLine($"{number_1} / {number_2} = {number_1 / number_2}");
                        break;
                    default:
                        Console.WriteLine($"Invalid input");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }
        }
    }
}
