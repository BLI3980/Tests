// Task: A sorted array and a separate number k are given. Find the first pair of two elements of the array, 
// sum of which gives the number k as the result.
// Example [-3, 0, 1, 3, 4], k = 5. Result [1, 4]

/*// OPTION 1: Using two loops for going through each element. Time Complexity is O(n^2), memory is O(1)
int m = Convert.ToInt32(new Random().Next(4, 11));
int k = Convert.ToInt32(new Random().Next(8, 20));
int[] array = new int[m];

void FillArray(int[] arr) // Randomly fill out 1D array with integers
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine();
}

int[] SortArray(int[] arr) // Sort array in ascending order
{
    int[] arr1 = new int[m];
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr1;
}

void PrintArray(int[] arr) // Method to print out 1D array
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,4}", arr[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] SumOfTwo(int[] arr, int k)
{
    int notFound = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] + arr[j] == k)
            {
                notFound = 0;
                return new int[] { arr[i], arr[j] };
            }
        }
    }
    if (notFound == 1)
    {
        Console.WriteLine($"no pair, which make a sum equal to {k}, in this array.");
    }
    return new int[0];
}


Console.WriteLine($"k = {k}");
FillArray(array);
SortArray(array);
PrintArray(array);
PrintArray(SumOfTwo(array, k));
*/

/*// OPTION 2: Using HashSet.Time Complexity is O(n), memory is O(n)
int m = Convert.ToInt32(new Random().Next(4, 11));
int k = Convert.ToInt32(new Random().Next(8, 20));
int[] array = new int[m];

void FillArray(int[] arr) // Randomly fill out 1D array with integers
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine();
}

int[] SortArray(int[] arr) // Sort array in ascending order
{
    int[] arr1 = new int[m];
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr1;
}

void PrintArray(int[] arr) // Method to print out 1D array
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,4}", arr[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] SumOfTwo(int[] arr, int k)
{
    HashSet<int> set = new HashSet<int>();
    int notFound = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        int numberToFind = k - arr[i];
        if (set.Contains(numberToFind))
        {
            notFound = 0;
            return new int[] { numberToFind, arr[i] };
        }
        set.Add(arr[i]);

    }
    if (notFound == 1)
    {
        Console.WriteLine($"no pair, which make a sum equal to {k}, in this array.");
    }
    return new int[0];
}


Console.WriteLine($"k = {k}");
FillArray(array);
SortArray(array);
PrintArray(array);
PrintArray(SumOfTwo(array, k));
*/

/*// OPTION 3: Using binary search. Time Complexity is O(n log n), memory is O(1)
int m = Convert.ToInt32(new Random().Next(4, 11));
int k = Convert.ToInt32(new Random().Next(8, 20));
int[] array = new int[m];

void FillArray(int[] arr) // Randomly fill out 1D array with integers
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine();
}

int[] SortArray(int[] arr) // Sort array in ascending order
{
    int[] arr1 = new int[m];
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr1;
}

void PrintArray(int[] arr) // Method to print out 1D array
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,4}", arr[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] SumOfTwo(int[] arr, int k)
{
    int notFound = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        int numberToFind = k - arr[i];
        int left = i + 1, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == numberToFind)
            {
                notFound = 0;
                return new int[] { arr[i], arr[mid] };
            }
            if (arr[mid] > numberToFind) right = mid - 1;
            else left = mid + 1;
        }
    }
    if (notFound == 1)
    {
        Console.WriteLine($"no pair, which make a sum equal to {k}, in this array.");
    }
    return new int[0];
}


Console.WriteLine($"k = {k}");
FillArray(array);
SortArray(array);
PrintArray(array);
PrintArray(SumOfTwo(array, k));
*/

//OPTION 3: Using two reference number from both ends of the array. Time Complexity is O(n), memory is O(1)
int m = Convert.ToInt32(new Random().Next(4, 11));
int k = Convert.ToInt32(new Random().Next(8, 20));
int[] array = new int[m];

void FillArray(int[] arr) // Randomly fill out 1D array with integers
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine();
}

int[] SortArray(int[] arr) // Sort array in ascending order
{
    int[] arr1 = new int[m];
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr1;
}

void PrintArray(int[] arr) // Method to print out 1D array
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,4}", arr[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] SumOfTwo(int[] arr, int k)
{
    bool notFound = true;
    int left = 0, right = arr.Length - 1;

    while (left < right)
    {
        int sum = arr[left] + arr[right];
        if (sum == k)
        {
            notFound = false;
            return new int[] { arr[left], arr[right] };
        }
        if (sum < k) left++;
        else right--;
    }
    if (notFound == true)
    {
        Console.WriteLine($"no pair, which make a sum equal to {k}, in this array.");
    }
    return new int[0];
}


Console.WriteLine($"k = {k}");
FillArray(array);
SortArray(array);
PrintArray(array);
PrintArray(SumOfTwo(array, k));