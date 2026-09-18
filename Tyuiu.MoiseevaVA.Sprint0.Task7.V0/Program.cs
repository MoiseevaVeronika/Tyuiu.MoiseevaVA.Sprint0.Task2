using Tyuiu.MoiseevaVA.Sprint0.Task7.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5};
            Console.WriteLine("Значение элемента массива #1");
            for (int i =0; i< arrayNums1.Length; i++)
            {
                Console.WriteLine(arrayNums1[i] + ",");
            }

            Console.WriteLine();
            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5};
            Console.WriteLine("Значение элемента массива #2");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.WriteLine(arrayNums1[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ");
            Console.WriteLine("*********************************************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("Сумма элементов массива равна");
                for (int i=0; i< resultArray.Length; i++)
                {
                    Console.WriteLine(resultArray[i]+",");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исхожные массивы имеют разное кол-во элементов ");
            }
            Console.ReadKey();
        }
    }
}
