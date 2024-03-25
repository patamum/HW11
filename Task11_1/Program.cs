namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уравнение: 0 = k*x + b");
            Console.WriteLine("Введите коэффициент k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            double b = Convert.ToDouble(Console.ReadLine());

            Linear linear = new Linear(k, b);
            Console.WriteLine(linear.Root());


        }
    }
}