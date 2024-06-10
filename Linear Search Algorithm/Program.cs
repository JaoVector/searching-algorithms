internal class Program
{

    public static int LinearSearch(int[] array, int key, int index)
    {

        if(index < array.Length - 1)
        {
            if(array[index] == key)
            {
                return index;
            } else 
            {
                return LinearSearch(array, key, index + 1);
            }
        }

        return -1;
    }

    private static void Main(string[] args)
    {
        int key = 72;
        int[] array = {2, 5, 8, 12, 16, 23, 38, 56, 72, 91};

        var item = LinearSearch(array, key, 0);

        if(item == -1)
        {
            Console.WriteLine("Key not Found");
        } else 
        {
            Console.WriteLine($"Key {key} found at index {item}");
        }
    }
}