namespace Problem_0003;

class Program
{
    static void Main(string[] args)
    {
        long number = 600851475143;
        long largestPrimeFactor = FindLargestPrimeFactor(number);
        Console.WriteLine($"The largest prime factor of {number} is {largestPrimeFactor}");
    }

    static long FindLargestPrimeFactor(long n)
    {
        long largestFactor = 1;

        while (n % 2 == 0)
        {
            largestFactor = 2;
            n /= 2;
        }

        for (long i = 3; i * i <= n; i += 2)
        {
            while (n % i == 0)
            {
                largestFactor = i;
                n /= i;
            }
        }

        if (n > 2)
        {
            largestFactor = n;
        }

        return largestFactor;
    }
}
