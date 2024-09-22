//The First Problem of Project Euler

namespace Problem_0001;

class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static long SumMultiplesOf3And5(int limit)
    {
        return Enumerable.Range(1, limit -1)
            .Where(n => n % 3 == 0 || n % 5 == 0)
            .Sum();    
    }

    static void RunTests()
    {
        var testCases = new List<TestCase>
        {
            new TestCase { Limit = 10, ExpectedSum = 23 },
            new TestCase { Limit = 20, ExpectedSum = 78 },
            new TestCase { Limit = 50, ExpectedSum = 543 },
            new TestCase { Limit = 100, ExpectedSum = 2318 },
            new TestCase { Limit = 1000, ExpectedSum = 233168 }
        };

        foreach (var testCase in testCases)
        {
            long result = SumMultiplesOf3And5(testCase.Limit);
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