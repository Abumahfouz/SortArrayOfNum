namespace SortArrayOfNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newNumbers = new int[] {21,7,5,12,11,16,4,10,20,9,7,15};
            int dummy;

            for (int i = 0; i < newNumbers.Length; i++)
            {
                for (int sort = i+1; sort < newNumbers.Length; sort++)
                {
                    if (newNumbers[i] < newNumbers[sort])
                    {
                        dummy = newNumbers[i];
                        newNumbers[i] = newNumbers[sort];
                        newNumbers[sort] = dummy;
                    }
                }
            }
            foreach (int values in newNumbers)
            {
                Console.WriteLine(values + " ");
            }

        }
    }
}