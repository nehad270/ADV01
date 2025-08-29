using System.Drawing;

namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region qu1
            Point p1 = new Point(10, 3);
            Point p2 = new Point(4, 2);

            Swap.swap<Point>(ref p1, ref p2);
            Console.WriteLine(p1);

            int[] numbers = { 5, 3, 8, 4, 2 };
            Swap.buble(numbers);

            Console.WriteLine("Sorted array:");
            foreach (var num in numbers)
                Console.Write(num + " ");

            #endregion





            #region qu2
            var range = new Range<int>(10, 20);
            Console.WriteLine($"Is 15 in range? {range.IsInRange(15)}");
            Console.WriteLine($"Length: {range.Length()}");

            var doubleRange = new Range<double>(5.5, 10.2);
            Console.WriteLine($"Is 7.1 in range? {doubleRange.IsInRange(7.1)}");
            Console.WriteLine($"Length: {doubleRange.Length()}"); 
            #endregion
        }
    }
}
