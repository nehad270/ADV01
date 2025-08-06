namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 4, 2 };
            Sorter.OptimizedBubbleSort(numbers);

            Console.WriteLine("Sorted array:");
            foreach (var num in numbers)
                Console.Write(num + " ");


            var intRange = new Range<int>(10, 20);
            Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");
            Console.WriteLine($"Length: {intRange.Length()}");

            var doubleRange = new Range<double>(5.5, 10.2);
            Console.WriteLine($"Is 7.1 in range? {doubleRange.IsInRange(7.1)}");
            Console.WriteLine($"Length: {doubleRange.Length()}");
        }
    }
}
