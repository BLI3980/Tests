//Task: Create 2D array, which have numbers spirally coiling up from its upper left corner clockwise until the center of the array.
//Example:
// 1    2   3   4   5
// 16   17  18  19  6
// 15   24  25  20  7
// 14   23  22  21  8
// 13   12  11  10  9

Console.Clear();
Console.WriteLine("This is a spirally coiled array, which starts from its upper left corner");
Console.WriteLine("and coils clockwise until the center of the array.");
Console.WriteLine(); //Spacer line

void FillArray(int[,] array, int size) // Fill 2D array spirally from top left corner until the center of the array
{
    for (int i = 0, j = 0, temp = 1; temp <= array.GetLength(0) * array.GetLength(1);)
    {
        array[i, j] = temp;
        temp++;
        if ((i <= j + 1) && (i + j < array.GetLength(1) - 1))
            j++;
        else if ((i < j) && (i + j >= array.GetLength(0) - 1))
            i++;
        else if ((i >= j) && (i + j > array.GetLength(1) - 1))
            j--;
        else
            i--;
    }
}

void PrintArray(int[,] array, int size) // Print 2D array in a table with rows and columns equal to entered size
{
    Console.WriteLine(); //Spacer line

    int row = 0, col = 0, arrSize = size;

    while (row < arrSize)
    {
        for (col = 0; col < arrSize; col++)
        {
            Console.Write($"{array[row, col]}{"\t"}");
        }
        Console.WriteLine();
        Console.WriteLine();
        row++;
    }
    Console.WriteLine(); //Spacer line
}

int arrSize = new Random().Next(3, 10); // Randomly select the size of square array from 3 to 10
int[,] array2D = new int[arrSize, arrSize]; // Declare new empty square array

Console.WriteLine("Array size is randomly chosen from the range 3 to 10.");
Console.WriteLine($"The size of this random array is {arrSize} x {arrSize}.");

FillArray(array2D, arrSize);
PrintArray(array2D, arrSize);
