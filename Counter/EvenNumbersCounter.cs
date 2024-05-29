namespace Counter
{
    public class EvenNumbersCounter
    {
        public static int CountEvenNumbers(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
