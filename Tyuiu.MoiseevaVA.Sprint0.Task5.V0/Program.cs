using Tyuiu.MoiseevaVA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A+B=" + DataServise.Addition(1, 5));
            Console.WriteLine("A-B=" + DataServise.Subtraction(1, 5));
            Console.WriteLine("A*B=" + DataServise.Multiplication(1, 5));
            Console.WriteLine("A/B=" + DataServise.Division(5,1));
            Console.ReadKey();
        }
    }
}
