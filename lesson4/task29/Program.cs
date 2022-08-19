int[] createArrayAndFill(int lenght, bool rnd, int value)
{
    int[] arr = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        if (rnd)
        {
            arr[i] = random.Next(value);
        }
        else { arr[i] = i + value; }
    }
    return arr;
    int[] arrayOne = createArrayAndFill(50, true, 15){
        Console.WriteLine(printArray(arrayOne));
    }
    void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }




