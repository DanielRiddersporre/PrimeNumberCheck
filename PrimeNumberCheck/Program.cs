int range = 100;
Console.WriteLine($"Prime numbers from 1 to {range}:");
PrintPrimeNumbers(range);

void PrintPrimeNumbers(int range)
{
    for (int i = 2; i <= range; i++)
    {
        if (IsPrime(i))
        {
            Console.WriteLine(i);
        }
    }
}

static bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}