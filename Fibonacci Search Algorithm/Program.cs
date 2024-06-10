internal class Program
{
    public static int FibonacciSearch(int[] array, int key)
    {
        int n = array.Length;

        if(n == 0)
        {
            return -1;
        } 

        int fib1 = 0, fib2 = 1, fib3 = fib1 + fib2;

        while(fib3 < n)
        {
            fib1 = fib2;
            fib2 = fib3;
            fib3 = fib1 + fib2;
        }

        int offset = -1;
        while (fib3 > 1)
        {
            int index = Math.Min(offset + fib2, n - 1);

            if(array[index] < key)
            {
                fib3 = fib2;
                fib2 = fib1;
                fib1 = fib3 - fib2;
                offset = index;
            } else if(array[index] > key)
            {
                fib3 = fib1;
                fib2 -= fib1;
                fib1 = fib3 - fib2;
            } else 
            {
                return index;
            }
        }

        if (fib2 == 1 && array[offset + 1] == key)
        {
            return offset + 1;
        } else
        {
            return -1;
        }
    }

    private static void Main(string[] args)
    {
        int key = 85;
        int[] array = {10, 22, 35, 40, 45, 50, 80, 82, 85, 90, 100, 235};

        var index = FibonacciSearch(array, key);

        if (index == -1)
        {
            Console.WriteLine($"Key {key} is not found.");
        } else 
        {
            Console.WriteLine($"Key {key} found at index {index}");
        }
    }
}