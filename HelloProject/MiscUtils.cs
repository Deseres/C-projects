public static class MiscUtils
{
    public static void GcdLcm(int num1, int num2, out int gcd, out int lcm)
    {
        int num2ForLcm = num2;
        int num1ForLcm = num1;
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        gcd = num1;
        lcm = (num1ForLcm * num2ForLcm) / gcd;
    }
    public static int GcdForMany(int[] numbers)
    {
        int tempGCD = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            while (numbers[i] != 0)
            {
                int temp = numbers[i];
                numbers[i] = tempGCD % numbers[i];
                tempGCD = temp;
            }
        }
        return tempGCD;
    }
}