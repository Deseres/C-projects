
//Console.WriteLine(string.Join(",", flattenedList));

public static class ArrayUtils
{
    public static void Reverse1(int[] Array) => System.Array.Reverse(Array);

    public static int[] Reverse2 (int[] Array)
    {
        int length = Array.Length;
        int[] reversedArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            reversedArray[i] = Array[length - 1 - i];
        }
        return reversedArray;
    }

    public static int[] PickPositive(int[] Array)
    {
        var positiveList = new List<int>(Array);
        positiveList.RemoveAll(i => i < 0);
        return positiveList.ToArray();
    }

    public static double[] Round(double[] Array)
    {
        return Array.Select(d => Math.Round(d, 0)).ToArray();
    }

    public static int[] PickAboveTreshold(int[] Array, int treshold)
    {
        var aboveTresholdList = new List<int>(Array);
        foreach (var item in Array)
        {
            if (item < treshold)
            {
                aboveTresholdList.Remove(item);
            }
        }
        return aboveTresholdList.ToArray();
    }

    public static int[] Acumulate(int[] Array)
    {
        int[] acumulateArray = new int[Array.Length];
        int sum = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            sum += Array[i];
            acumulateArray[i] = sum;
        }
        return acumulateArray;
    }

    public static int[] Zip(int[] Array1, int[] Array2)
    {
        int[] zippedArray = new int[Array1.Length];
        for (int i = 0; i < Array2.Length; i++)
        {
            zippedArray[i] = Array1[i] + Array2[i];

        }
        return zippedArray;
    }
    public static int[] Diagonal1(int[,] grid)
    {

        var diagonalList = new List<int>();
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            diagonalList.Add(grid[i, i]);
        }
        return diagonalList.ToArray();
    }
    public static int[] Diagonal2(int[,] grid)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int limit = Math.Min(rows, cols);
        var diagonalList = new List<int>(limit);
        for (int i = 0; i < limit; i++)
        {
            diagonalList.Add(grid[i, i]);
        }
        return diagonalList.ToArray();
    }

    public static void Triangularize(int[,] grid2)
    {
        int rows = grid2.GetLength(0);
        int cols = grid2.GetLength(1);
        Sides sides = Sides.above;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (sides == Sides.above && j > i)
                {
                    grid2[i, j] = 0;
                }
                if (sides == Sides.under && i > j)
                {
                    grid2[i, j] = 0;
                }
            }
        }
        Console.WriteLine();
    }
    public static void PrintGrid(int[,] grid)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public enum Sides
    {
        under,
        above
    }
    public static int[] Flatten(int[,] grid)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        Order order = Order.columnWise;
        var flattenedList = new List<int>(rows * cols);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (order == Order.columnWise)
                {
                    flattenedList.Add(grid[j, i]);
                    continue;
                }
                if (order == Order.rowWise)
                {
                    flattenedList.Add(grid[i, j]);
                }
            }
        }
        return flattenedList.ToArray();
    }

    public enum Order
    {
        rowWise,
        columnWise
    }

}

