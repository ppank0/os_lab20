using Counter;
namespace test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, 3, 4 };
            Console.WriteLine("Массив:");
            numbers.ToList().ForEach(num => Console.Write(num+"\t"));
            Console.WriteLine("\nКоличество чётных чисел - "+EvenNumbersCounter.CountEvenNumbers(numbers));
        }
    }
}
