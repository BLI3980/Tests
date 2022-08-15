int RomanToInt(string s) 
{
    //int I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000;
    
    //Run a loop to compare each string character with 7 options. Make a list of figures out of it
    //Sum up the list to get a number, taking into account exceptions - I, X, C before V, L, D
    
    //Run through code on test value III
    
    int strSize = s.Length - 1; //2
    int[] array = new int[s.Length]; //3
    int arrSize = array.Length-1; //2
    int num = 0; //result initial value

    //Fillup int array from input string.
    for (int i = strSize; i >= 0; i--) 
    {
        if (s[i] == 'I') array[i] = 1; 
        if (s[i] == 'V') array[i] = 5;
        if (s[i] == 'X') array[i] = 10;
        if (s[i] == 'L') array[i] = 50;
        if (s[i] == 'C') array[i] = 100;
        if (s[i] == 'D') array[i] = 500;
        if (s[i] == 'M') array[i] = 1000;
        //Console.WriteLine($"{i}: {array[i]}");
    }
    
    //Add up or subtract the last two digits.
    // if (arrSize >= 1)
    // {
    //     if (((array[arrSize-1] == 1) && (array[arrSize] == 5)) || ((array[arrSize-1] == 1) && (array[arrSize] == 10))) 
    //     {
    //         num = array[arrSize] - array[arrSize-1];
    //         //Console.WriteLine("1." + num);
        
    //         if (((array[arrSize-1] == 10) && (array[arrSize] == 50)) || ((array[arrSize-1] == 10) && (array[arrSize] == 100))) 
    //         {
    //             num = array[arrSize] - array[arrSize-1];
    //             //Console.WriteLine("2." + num);
    //         }
    //             if (((array[arrSize-1] == 100) && (array[arrSize] == 500)) || ((array[arrSize-1] == 100) && (array[arrSize] == 1000))) 
    //             {
    //                 num = array[arrSize] - array[arrSize-1];
    //                 //Console.WriteLine("3." + num);
    //             }
    //     }
    //     else 
    //     {
    //         num = array[arrSize] + array[arrSize-1];
    //         //Console.WriteLine("4." + num);
    //     }   
    // }
    
    //Add up the rest of the digits
    // if (arrSize >= 2)
    // {
    //     for (int i = arrSize-2; i >= 0; i--)
    //     {
    //         num = num + array[i];
    //     }
    // }   

    //Sum up all the digits taking into account exceptions like IV, IX; XL, XC; CD, CM.
    int j = 0;
    bool except1 = false;
    bool except2 = false;
    Console.WriteLine($"0. {j}, {arrSize}, {num}");

    while (j <= arrSize)
    {   
        if (j + 1 <= arrSize) //compare j and j + 1
        {
            except1 = false;
            if (((array[j] == 1) && (array[j + 1] == 5 || array[j + 1] == 10)) ||
            ((array[j] == 10) && (array[j + 1] == 50 || array[j + 1] == 100)) ||
            ((array[j] == 100) && (array[j + 1] == 500 || array[j + 1] == 1000))) except1 = true; Console.WriteLine("Except1: "+ except1);
        }
        if (j + 2 <= arrSize) //compare j + 1 and j + 2
        {
            except2 = false;
            if (((array[j + 1] == 1) && (array[j + 2] == 5 || array[j + 2] == 10)) ||
            ((array[j + 1] == 10) && (array[j + 2] == 50 || array[j + 2] == 100)) ||
            ((array[j + 1] == 100) && (array[j + 2] == 500 || array[j + 2] == 1000))) except2 = true; Console.WriteLine("Except2: "+ except2);
        }

        if (j == arrSize) 
        {
            num = num + array[j]; Console.WriteLine($"1. {j}, {arrSize}, {num}"); break;
        }

        if (except1 == false)
        {
            if (j + 1 == arrSize) 
            {
                num = num + array[j] + array[j + 1]; Console.WriteLine($"2. {j}, {arrSize}, {num}"); break;
            }
            if (except2 == false) 
            {
                num = num + array[j] + array[j + 1]; Console.WriteLine($"3. {j}, {arrSize}, {num}"); j+=2;
            }
            else 
            {
                num = num + array[j + 2] - array[j + 1] + array[j]; Console.WriteLine($"4. {j}, {arrSize}, {array[j+2]}-{array[j+1]}+{array[j]} {num}"); j+=3;
            }    
        }
        else
        {
            num = num + array[j + 1] - array[j]; Console.WriteLine($"5. {j}, {arrSize}, {num}"); j+=2;
        }
    }

    return num;
}

int Roman = RomanToInt("MCMXCVI");
Console.WriteLine(Roman);




//  0       1       2      3       4       5       6   
//  M       C       M      X       C       I       V 
// 1000    100     1000    10     100      1       5

// 1000+(1000-100)+(100-10)+(5-1)


// if array[i] > array[i + 1]
// {
//     //check i+1 and i+2 for IV, IX; XL, XC; CD, CM.
// }
// else //i.e. i < i+1
// {
//     //check i and i+1 for IV, IX; XL, XC; CD, CM.
//     //if yes - (i+1 - i); i++2
//     //if no

// }

// Compare n, n+1, n+2
// if i == size,  num = n; break
// if n and n+1 not except, do next
//     if i+1 == size, num = num + n + n+1, break
//     if n+1 and n+2 not except, num = num + n + n+1, i++2
//     if n+1 and n+2 except, (n+2 - n+1) + n, i++3
// if n and n+1 except, n+1 - n, i++2


