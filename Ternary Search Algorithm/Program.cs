internal class Program
{

    public static int TernarySearch(int[]array, int left, int right, int key)
    {
        if(right >= left)
        {
           int m1 = left + (right - left) / 3;
           int m2 = right - (right - left) / 3;

            if(array[m1] == key)
            {
                return m1;
            }

            if(array[m2] == key)
            {
                return m2;
            }

            if(key < array[m1])
            {
                return TernarySearch(array, left, m1 - 1, key);
            } else if(key > array[m2])
            {
                return TernarySearch(array, m2 + 1, right, key);
            } else 
            {
                return TernarySearch(array, m1 + 1, m2 - 1, key);
            }
        }

        return -1;
    }

    private static void Main(string[] args)
    {
        int[] array = {2, 5, 8, 12, 16, 23, 38, 56, 72, 91};
        int key = 56;

        var result = TernarySearch(array, 0, array.Length - 1, key);
        
        if(result == -1)
        {
            Console.WriteLine($"Key {key} doesn't exists in the array");
        } else 
        {
            Console.WriteLine($"Key {key} found at index {result}");
        }
    }
}