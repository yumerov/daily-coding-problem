namespace RandUsingAnotherRand;

public static class RandomGenerator
{
    public static int Rand7() => new Random().Next(1, 8);

    public static int Rand5Reroll()
    {
        int result = 6;
        while (result > 5)
        {
            result = Rand7();
        }
        
        return result;
    }

    public static int Rand5Twice()
    {
        const int closestValue = 45;
        int result = closestValue + 1;
        while (result > closestValue)
        {
            result = (Rand7() - 1) * (int)Math.Pow(7, 1);
            result += Rand7();
        }
        
        return (int) Math.Ceiling(result * 5.0 / (closestValue * 1.0));
    }
    
    public static int Rand5X3()
    {
        const int closestValue = 340;
        int result = closestValue + 1;
        while (result > closestValue)
        {
            result = (Rand7() - 1) * (int)Math.Pow(7, 2);
            result += (Rand7() - 1) * (int)Math.Pow(7, 1);
            result += Rand7();
        }
        
        return (int) Math.Ceiling(result * 5.0 / (closestValue * 1.0));
    }
    
    public static int Rand5X4()
    {
        const int closestValue = 2400;
        int result = closestValue + 1;
        while (result > closestValue)
        {
            result = (Rand7() - 1) * (int)Math.Pow(7, 3);
            result += (Rand7() - 1) * (int)Math.Pow(7, 2);
            result += (Rand7() - 1) * (int)Math.Pow(7, 1);
            result += Rand7();
        }
        
        return (int) Math.Ceiling(result * 5.0 / (closestValue * 1.0));
    }
    
    public static int Rand5X5()
    {
        const int closestValue = 16805;
        int result = closestValue + 1;
        while (result > closestValue)
        {
            result = (Rand7() - 1) * (int)Math.Pow(7, 4);
            result += (Rand7() - 1) * (int)Math.Pow(7, 3);
            result += (Rand7() - 1) * (int)Math.Pow(7, 2);
            result += (Rand7() - 1) * (int)Math.Pow(7, 1);
            result += Rand7();
        }
        
        return (int) Math.Ceiling(result * 5.0 / (closestValue * 1.0));
    }
}