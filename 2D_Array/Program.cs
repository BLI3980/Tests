/* // OPTION 1. Code without Methods.
int arrSize = new Random().Next(1,10);

int [,] array2D = new int [arrSize, arrSize];

int row = 0, col = 0, m = arrSize, i = 1;
array2D [row, col] = 0;

while ( m > 0 )
{
    for (int counter = 0; counter < m; counter++)
    {
        array2D [row, col] = i;
        //Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
        col++;
        i++;
    }
    row++; col--; m--;
    for (int counter = 0; counter < m; counter++)
    {
        array2D [row, col] = i;
        //Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
        row++;
        i++;
    }
    row--; col--;
    for (int counter = 0; counter < m; counter++)
    {
        array2D [row, col] = i;
        //Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
        col--;
        i++;
    }
    row--; col++; m--;
    for (int counter = 0; counter < m; counter++)
    {
        array2D [row, col] = i;
        //Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
        row--;
        i++;
    }
    row++; col++;
}

row = 0; col = 0;
Console.WriteLine(); //Spacer line
Console.WriteLine("[row, column, array number]");
Console.WriteLine(); //Spacer line

for (col = 0; col < arrSize; col++)
{
Console.Write($"[{row}, {col}: {array2D[row,col]}]   "); // Separate print loop for the first row with increased spacing between array elements
}
Console.WriteLine(); //Spacer line
row++;

while (row < arrSize)
{
    for (col = 0; col < arrSize; col++)
    {
    Console.Write($"[{row}, {col}: {array2D[row,col]}]  ");
    }
    Console.WriteLine();
    row++;
}
Console.WriteLine(); //Spacer line
Console.WriteLine(); //Spacer line
*/

// OPTION 1. Code without Methods.

void FillArray(int[,] array, int size) // Fill 2D array spirally from top left corner until the center of the array
{
    int row = 0, col = 0, m = size, i = 1;
    array [row, col] = 0;
    while ( m > 0 )
    {
        for (int counter = 0; counter < m; counter++)
        {
            array [row, col] = i;
            //Console.Write($"[{row}, {col}: {array[row,col]}]  ");
            col++;
            i++;
        }
        row++; col--; m--;
        for (int counter = 0; counter < m; counter++)
        {
            array [row, col] = i;
            //Console.Write($"[{row}, {col}: {array[row,col]}]  ");
            row++;
            i++;
        }
        row--; col--;
        for (int counter = 0; counter < m; counter++)
        {
            array [row, col] = i;
            //Console.Write($"[{row}, {col}: {array[row,col]}]  ");
            col--;
            i++;
        }
        row--; col++; m--;
        for (int counter = 0; counter < m; counter++)
        {
            array [row, col] = i;
            //Console.Write($"[{row}, {col}: {array[row,col]}]  ");
            row--;
            i++;
        }
        row++; col++;
    }
}

void PrintArray(int [,] array, int size) // Print 2D array in a table with rows and columns equal to entered size
{
    Console.WriteLine(); //Spacer line
    Console.WriteLine("[row, column, array number]");
    Console.WriteLine(); //Spacer line

    int row = 0, col = 0, arrSize = size;

    for (col = 0; col < arrSize; col++)
    {
    Console.Write($"[{row}, {col}: {array[row,col]}]   "); // Separate print loop for the first row with increased spacing between array elements
    }
    Console.WriteLine(); //Spacer line
    row++;

    while (row < arrSize)
    {
        for (col = 0; col < arrSize; col++)
        {
        Console.Write($"[{row}, {col}: {array[row,col]}]  ");
        }
        Console.WriteLine();
        row++;
    }
    Console.WriteLine(); //Spacer line
    Console.WriteLine(); //Spacer line
}

int arrSize = new Random().Next(1,10);
int [,] array2D = new int [arrSize, arrSize];

FillArray(array2D, arrSize);
PrintArray(array2D, arrSize);









