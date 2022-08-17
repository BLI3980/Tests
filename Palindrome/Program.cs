// Task: A number that is input from console, needs to be checked to see if it's a palindrome.
// Example: 12345 - No, 1234321 - Yes

Console.WriteLine("Enter your number: ");
int inputNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

//1. find out the number of digits in the number
//2. create an empty array
//3. fill out the array with numbers
//4. find out if number is palindrome - compare digits 1 to n, 2 to n-1 until the middle of the array
//5. print out result

//1. find out the number of digits in the number
int numDigits = 0;
int count = 0;

for (numDigits = inputNumber; numDigits > 0; count++) {numDigits = numDigits / 10;}

//2. create an empty array
int[] array = new int [count];
int arrayLastIdx = count - 1;
Console.WriteLine("array length = " + array.Length);
Console.WriteLine("array last index = " + arrayLastIdx);

//3. fill out the array with numbers
count = count-1;
for (numDigits = inputNumber; numDigits > 0; count--)
{
    array[count] = numDigits % 10;
    numDigits = numDigits / 10;
    Console.WriteLine($"array{count}: {array[count]}");
}

// Find out if number is a palindrome
bool palindrome = false;
for (int j = 0; j <= array.Length/2 - 1; j++) 
{
    if (array[j] != array[array.Length - (j+1)])
    {
        palindrome = false;
        Console.WriteLine($"1.{j}: {palindrome}");
        break;
    }
    else
    {
        palindrome = true;
        Console.WriteLine($"2.{j}: {palindrome}");
    }
}

//Printout the result
if (palindrome == true) 
{
    Console.WriteLine("The number is a palindrome");
}
else
{
    Console.WriteLine("The number is not a palindrome");
}

