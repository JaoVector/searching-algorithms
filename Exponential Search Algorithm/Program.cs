internal class Program
{

    public static int ExponentialSearch(int[] array, int n, int key)
    {

        if(array[0] == key)
        {
            return 0;
        }

        int i = 1;
        while(i < n && array[i] <= key)
        {
            i *= 2;
        }

        return BinarySearch(array, i/2, Math.Min(i, n-1), key);
    }

    public static int BinarySearch(int[] array, int left, int right, int key)
    {
        if (left <= right)
        {
            int m = left + (right - left) / 2;

            if(array[m] == key)
            {
                return m;
            }

            if(key < array[m])
            {
                return BinarySearch(array, left, m - 1, key);
            }

            if(key > array[m])
            {
                return BinarySearch(array, m + 1, right, key);
            }
        }

        return -1;
    }

    private static void Main(string[] args)
    {
        int key = 235;
        int[] array = {10, 22, 35, 40, 45, 50, 80, 82, 85, 90, 100, 235};

        var index = ExponentialSearch(array, array.Length, key);

        if(index == -1)
        {
            Console.WriteLine($"Key {key} not found");
        } else 
        {
            Console.WriteLine($"Key {key} found at index {index}");
        }
    }
}