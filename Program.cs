/// find the largest integer in an array
/// find the frequency of a typed (user-inputted) number in an array

int[] integerArray = new int[] { 6, 29, 3, 207, 1, 1, 0, 29, 3, 17, 21893 };
int maxNumber = GetLargestInteger(integerArray);
Console.WriteLine(maxNumber);

maxNumber = GetLargestInteger(new int[] { 5, 6, 7, 8 });
Console.WriteLine(maxNumber);

//int input = Int32.Parse(Console.ReadLine());

Console.WriteLine(GetIntegerFrequency(new int[] {1, 2, 3, 3}, 3));


int GetLargestInteger(int[] myArray)
{
    int maxNumber = Int32.MinValue;

    for (int index = 0; index < myArray.Length; index++)
    {
        // is the current number greater than the greatest number that we've found so far?
        if (integerArray[index] > maxNumber)
        {
            maxNumber = myArray[index];
        }
    }

    return maxNumber;
}


int GetIntegerFrequency(int[] intArray, int searchValue)
{
    int counter = 0;

    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] == searchValue)
        {
            counter++;
        }
    }

    return counter;
}







