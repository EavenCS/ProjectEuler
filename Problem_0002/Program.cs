namespace Problem_0002;

class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static long SumEvenFibonacciNumbers(int limit)
    {
        int one = 1;
        int two = 2;
        long sumEvenFibonacci = 0;

        while (one <= limit)
        {
            if (one % 2 == 0)
            {
                sumEvenFibonacci += one;
            }

            int next = one + two;
            one = two;
            two = next;
        }

        return sumEvenFibonacci;
    }

    static void RunTests()
    {
        var testCases = new List<TestCase>
        {
            new TestCase { Limit = 10, ExpectedSum = 10 },
            new TestCase { Limit = 20, ExpectedSum = 10 },
            new TestCase { Limit = 100, ExpectedSum = 44 },
            new TestCase { Limit = 1000, ExpectedSum = 798 },
            new TestCase { Limit = 4000000, ExpectedSum = 4613732 }
        };

        foreach (var testCase in testCases)
        {
            long result = SumEvenFibonacciNumbers(testCase.Limit);
            bool passed = result == testCase.ExpectedSum;

            Console.WriteLine($"Test for Limit {testCase.Limit}: " +
                              $"{(passed ? "Passed" : "Failed")}");
            Console.WriteLine($"Expected: {testCase.ExpectedSum}, Received: {result}\n");
        }
    }
}

class TestCase
{
    public int Limit { get; set; }
    public long ExpectedSum { get; set; }
}
