// double max=-10,min=10;

//             Random rand = new Random();
//             for (int i = 0; i < 50; i++)
//             {
// Console.WriteLine("value= " + Math.Round((rand.NextDouble() * (max - min) + min),2));
// }


// for (int i = 0; i < 50; i++)
// {
//     double a = new Random().NextDouble();
//     Console.WriteLine(a);
// }


// void FillPrintDouble(double[] arr) // Randomly fill out the array with doubles and print it to the terminal
// {
//     //Random rand = new Random();
//     double min = -100;
//     double max = 100;
//     double range = max - min;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         double sample = new Random().NextDouble();
//         double scaled = (sample * range) + min;
//         arr[i] = Math.Round(scaled, 2);
//         Console.Write(arr[i] + "   ");

//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }

/*
    double min = 0;
    double max = 0;

    double[] array = new double[] { 1, 8, 3, 5, 2, 4 };

    // FillPrintDouble(array);

    for (int i = 1; i < array.Length; i++)
    {
    if (array[i] > max) max = array[i];
    else min = array[i];
    }

    Console.WriteLine();
    Console.WriteLine("max: " + max);
    Console.WriteLine("min: " + min);
    Console.WriteLine($"Разница между макс и мин значениями: {max - min}");
*/
//=====================================================
/*
    void FOR1(int i)
    {
        if (i > 10) return;
        Console.Write($"{i} ");
        FOR1(i + 1);
    }

    void FOR2(int i)
    {
        if (i > 10) return;
        FOR2(i + 1);
        Console.Write($"{i} ");
    }

    FOR1(1);
    Console.WriteLine();
    FOR2(1);
    // Почему FOR1(1); покажет
    // 1 2 3 4 5 6 7 8 9 10


    // а FOR2(1);
    // покажет
    // 10 9 8 7 6 5 4 3 2 1
*/
//=====================================================
// Console.WriteLine("Enter a number: ");
// string? name = Console.ReadLine();
// int a = int.Parse(name!);
// Console.WriteLine(name + 1);

//=====================================================
// Console.WriteLine("Enter a number: ");
// int name = int.Parse(Console.ReadLine()!);

// Console.WriteLine(name + 1);

//=====================================================



// Fill 3D Array Non-Repeat
// =========================================================================================================================

// int[,,] array = new int[3, 3, 3]; // The size of array is chosen 4 x 11 x 4 in order to 
//                                   // accommodate as much of two-digit positive and negative integers as possible


// void Fill3DArrNonRepeat(int[,,] arr)
// {
//     for (int k = 0; k < arr.GetLength(2); k++)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//             Repeat:
//                 int check = new Random().Next(10, 100) * (new Random().Next(0, 2) * 2 - 1);
//                 // Console.WriteLine($"1. {i} {j} {k}: {check}");
//                 // Console.ReadKey();
//                 int k1, i1, j1;
//                 for (k1 = 0; k1 < arr.GetLength(2); k1++)
//                 {
//                     // Console.Write($"k1:{k1} ");
//                     for (i1 = 0; i1 < arr.GetLength(0); i1++)
//                     {
//                         // Console.Write($"i1:{i1} ");
//                         for (j1 = 0; j1 < arr.GetLength(1); j1++)
//                         {
//                             // Console.Write($"j1:{j1} ");
//                             // Console.WriteLine();
//                             // Console.WriteLine($"  2. {i1} {j1} {k1}: {arr[i1, j1, k1]}");
//                             // Console.ReadKey();
//                             if (arr[i1, j1, k1] == check)
//                             {
//                                 goto Repeat;
//                             }
//                             // Console.WriteLine($"   2a. {i} {j} {k} | {i1} {j1} {k1}");
//                             // Console.ReadKey();
//                             if ((i1 == i) && (j1 == j) && (k1 == k))
//                             {
//                                 arr[i, j, k] = check;
//                                 // Console.WriteLine($"3. {i} {j} {k}: {arr[i, j, k]}");
//                                 // Console.ReadKey();
//                                 break;
//                             }
//                         }
//                         // Console.WriteLine();
//                         if (arr[i, j, k] == check) break;
//                     }
//                     if (arr[i, j, k] == check) break;
//                 }
//             }
//             // Console.WriteLine();
//         }
//     }
// }





// void Print3DArray(int[,,] arr)
// {
//     for (int k = 0; k < arr.GetLength(2); k++)
//     {
//         // Console.WriteLine($"Block {k}");
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write("{0,4}", arr[i, j, k]);
//             }
//             Console.WriteLine();
//         }
//         // Console.WriteLine("---------");
//     }
// }

// Fill3DArrNonRepeat(array);
// Print3DArray(array);
// =========================================================================================================================

// 3D array of max size one of its dimensions equal or less to 100.
// How many or such arrays exists which can accommodate as much of positive and negative
// two-digit integers?

// for (int i = 0; i < 100; i++)
// {
//     for (int j = 0; j < 100; j++)
//     {
//         for (int k = 0; k < 100; k++)
//         {
//             if ((i * j * k) < 178 && (i * j * k) > 174) Console.WriteLine($"{i} {j} {k} {i * j * k}");
//         }
//     }
// }

Console.WriteLine(Console.WindowHeight);
Console.WriteLine(Console.WindowWidth);
