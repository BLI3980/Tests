//Task: Create a 2D array of m x n size, filled it with random real numbers.

Console.Clear();
Console.WriteLine("Enter the size of the dimensions of 2D array: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,] array = new int[m, n];

// Format 1. Tab and | separated. With +--+ spacer rows. Double numbers. =================================================
// void FillPrint2DArray(double[,] arr, int rangeMin, int rangeMax) // Randomly fill out 2D array with integers and print it to the terminal
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write("+-------");
//     }
//     Console.Write("+");
//     Console.WriteLine();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = Math.Round(new Random().NextDouble() * (rangeMax - rangeMin) + rangeMin, 2);
//             if (arr[i, j] < 0) Console.Write(arr[i, j] + "\t" + "| ");
//             else Console.Write(" " + arr[i, j] + "\t" + "| ");
//         }
//         Console.WriteLine();
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write("+-------");
//         }
//         Console.Write("+");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Format 2. Tab and | separated. With +--+ spacer rows. Integer numbers.  =================================================
void FillPrint2DArray(int[,] arr, int rangeMin, int rangeMax) // Randomly fill out 2D array with integers and print it to the terminal
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write("+-------");
    }
    Console.Write("+");
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(rangeMin, rangeMax);
            if (arr[i, j] < 0) Console.Write(arr[i, j] + "\t" + "| ");
            else Console.Write(" " + arr[i, j] + "\t" + "| ");
        }
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("+-------");
        }
        Console.Write("+");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Format 3. Tabs only as column separators. Empty lines as row separators. =================================================
// void FillPrint2DArray(int[,] arr, int rangeMin, int rangeMax) // Randomly fill out 2D array with integers and print it to the terminal
// {
//     Console.WriteLine();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(rangeMin, rangeMax);
//             if (arr[i, j] < 0) Console.Write(arr[i, j] + "\t");
//             else Console.Write(" " + arr[i, j] + "\t");
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

FillPrint2DArray(array, -10, 100);
Console.WriteLine();
