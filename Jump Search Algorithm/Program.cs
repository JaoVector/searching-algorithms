internal class Program
{

    public static int JumpSearch(int[] array, int key)
    {

        int n = array.Length - 1;

        int step = (int)Math.Sqrt(n);

        int prev = 0;
        for (int minStep = Math.Min(step, n); array[minStep] < key; minStep = Math.Min(step, n))
        {
            prev = step;
            step += (int)Math.Sqrt(n);
            if(prev >= n)
            {
                return -1;
            }
        }

        while (array[prev] < key)
        {
            prev++;
            if(prev == Math.Min(step, n))
            {
                return -1;
            }
        }
        
        if(array[prev] == key)
        {
            return prev;
        }

        return -1;
    }

    private static void Main(string[] args)
    {
        int key = 55;
        int[] array = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610};

        int index = JumpSearch(array, key);

        Console.WriteLine($"Key {key} found at index {index}");
    }
}