int exponentiation(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
        // System.Console.WriteLine(result);


    }
    return result;
}
System.Console.WriteLine(exponentiation(3, 5));
