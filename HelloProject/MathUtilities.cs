//M&BA 
//double a = double.Parse(Console.ReadLine());
//double b = double.Parse(Console.ReadLine());
//double result = MathUtilities.Equation(a, b);
//Console.WriteLine(result);
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int bigger = MathUtilities.BiggerNumber(num1, num2);
//Console.WriteLine(bigger);
//int GCD = MathUtilities.GreatestCommonDivisor(num1, num2);
//Console.WriteLine(GCD);
//int number = int.Parse(Console.ReadLine());
//bool isPrime = MathUtilities.IsPrime(number);
//Console.WriteLine(isPrime);
//bool areCoprime = MathUtilities.ISCoprime(num1, num2);
//Console.WriteLine(areCoprime);
//(double, double) sqrt = MathUtilities.RootsOfQuadraticEquation(1, -6, 5);
//Console.WriteLine(sqrt);
//int int1 = int.Parse(Console.ReadLine());
//int int2 = int.Parse(Console.ReadLine());
//(int, int) switched = MathUtilities.IntegerSwitch(int1, int2);
//Console.WriteLine(switched);
// (int, int) gcdLcm = MathUtilities.GCDAndLCM(num1, num2);
//MathUtilities.GCDAndLCM(num1, num2, out int gcd, out int lcm);
//Console.WriteLine(gcd);
//Console.WriteLine(lcm);
//int NUMBER = 24;
//int[] divisors = MathUtilities.GetDivisors(NUMBER);
//Console.WriteLine(string.Join(",", divisors));
public static class MathUtilities
{
    public static double Equation(double a, double b)
    {
        if (a == 0)
        {
            throw new ArgumentException("Coefficient 'a' cannot be zero.");
        }

        return -b / a;
    }

    public static int BiggerNumber(int num1, int num2)
    {
        if (num1 == num2)
        {
            return num1;
        }
        return Math.Max(num1, num2);
    }
    public static int GreatestCommonDivisor(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }
    public static bool IsPrime(int number)
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

    public static bool ISCoprime(int num1, int num2)
    {
        if (GreatestCommonDivisor(num1, num2) == 1)
        {
            return true;
        }
        return false;
    }

    public static (double, double) RootsOfQuadraticEquation(double A, double B, double C)
    {
        double discriminant = B * B - 4 * A * C;
        if (discriminant < 0)
        {
            throw new ArgumentException("The equation has no real roots.");
        }
        else
        {
            double root1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
            double root2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
            return (root1, root2);
        }
    }

    public static (int, int) IntegerSwitch(int int1, int int2)
    {
        int temp = int1;
        int1 = int2;
        int2 = temp;
        return (int1, int2);
    }

    public static void GCDAndLCM(int num1, int num2, out int gcd, out int lcm)
    {
        gcd = GreatestCommonDivisor(num1, num2);
        lcm = (num1 * num2) / gcd;

    }

    public static int[] GetDivisors(int number)
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
            }
        }
        return divisors.ToArray();
    }

}
