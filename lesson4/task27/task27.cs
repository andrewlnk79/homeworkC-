int sumOfDigits(int num)
{
    num = 325;
    int result = 0;

    if (num > 0)
    {
        while (num > 0)
        {
            int newNum = num % 10;
            result = result + newNum;
            num = num / 10;

        }

    }
    return result;


}



Console.WriteLine(sumOfDigits(325));
