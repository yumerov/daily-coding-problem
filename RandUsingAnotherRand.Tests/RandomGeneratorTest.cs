namespace RandUsingAnotherRand.Tests;

public class RandomGeneratorTest
{
    private const int SampleSize = 100_000;
    private const double DeltaPercentage = 0.05;
    
    [Fact]
    public void Rand7()
    {
        const int size = 7;
        var counts = new int[size];

        for (int index = 0; index < size * SampleSize; index++)
        {
            counts[RandomGenerator.Rand7() - 1]++;
        }

        foreach (var count in counts)
        {
            Assert.InRange(count, SampleSize * (1 - DeltaPercentage), SampleSize * (1 + DeltaPercentage));
        }
    }
    
    [Fact]
    public void Rand5Reroll() => TestRand(RandomGenerator.Rand5Reroll);
    
    [Fact]
    public void Rand5Twice() => TestRand(RandomGenerator.Rand5Twice);
    
    [Fact]
    public void Rand5X3() => TestRand(RandomGenerator.Rand5X3);
    
    [Fact]
    public void Rand5X4() => TestRand(RandomGenerator.Rand5X4);
    
    [Fact]
    public void Rand5X5() => TestRand(RandomGenerator.Rand5X5);

    private static void TestRand(Func<int> rand)
    {
        const int size = 5;
        var counts = new int[size];

        for (int index = 0; index < size * SampleSize; index++)
        {
            counts[rand() - 1]++;
        }

        foreach (var count in counts)
        {
            Assert.InRange(count, SampleSize * (1 - DeltaPercentage), SampleSize * (1 + DeltaPercentage));
        }
    }
}