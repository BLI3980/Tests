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
