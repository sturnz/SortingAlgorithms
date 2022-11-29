namespace SortingAlgorithms
{
    public static class Program
    {
        public static void Main()
        {
            var unsortedNumbers = new List<int>()
            {
                7, 1, 5, 9, 8, 4, 6, 3
            };

            foreach (var item in unsortedNumbers.GnomeSortDescending())
            {
                Console.WriteLine(item);
            }
        }
    }
}