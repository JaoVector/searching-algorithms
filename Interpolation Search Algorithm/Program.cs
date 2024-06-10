internal class Program
{
    public static int Interpolation(int[] array, int lo, int hi, int key)
    {
       
        if(lo <= hi && key >= array[lo] && key <= array[hi])
        {

            var pos = lo + ((hi - lo) / (array[hi] - array[lo]) * (key - array[lo]));

            if(array[pos] == key)
            {
                return pos;
            }

            if(array[pos] < key)
            {
                return Interpolation(array, pos + 1, hi, key);
            }

            if(array[pos] > key)
            {
                return Interpolation(array, lo, pos - 1, key);
            }
        }

        return -1;
    }

    private static void Main(string[] args)
    {
       int key = 55;
       int[] array = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610};

       var index = Interpolation(array, 0, array.Length - 1, key);

       if (index == -1)
       {
           Console.WriteLine($"Key {key} not found");
       } else 
       {
           Console.WriteLine($"Key {key} found at index {index}");
       }
    }
}