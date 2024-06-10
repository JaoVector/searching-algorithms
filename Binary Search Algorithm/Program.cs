internal class Program
{

    public static int BinarySearch(int[] array, int key, int left, int right)
    {
        int middle = left + (right - left) / 2;

        if(array[middle] == key)
        {
            return middle;
        }

        if(array[middle] < key)
        {
            return BinarySearch(array, key, middle + 1, right);
        } else if(array[middle] > key)
        {
            return BinarySearch(array, key, left, middle - 1);
        } else 
        {
            return -1;
        }

    }

    private static void Main(string[] args)
    {
        int key = 8;
        int[] array = {2, 5, 8, 12, 16, 23, 38, 56, 72, 91};

        var resp = BinarySearch(array, key, 0, array.Length - 1);

        if (resp == -1)
        {
            Console.WriteLine("Nada Encontrado");
        } else 
        {
            Console.WriteLine($"Chave {key} achada no Index {resp}");
        }
    }
}

/*
int left = 0, right = array.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (array[middle] == key)
            {
                return middle;
            }

            if(array[middle] < key)
            {
                left = middle + 1;
            } else 
            {
                right = middle - 1;
            }
        }

        return -1;
*/