int[] GetNumsArray()
{
    Console.WriteLine("Enter the numbers separated by ',':");

    string NumsString = Console.ReadLine() ?? string.Empty;

    return NumsString.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
}

int CountOfPositiveNums(int[] NumsArray)
{
    int Result = 0;
    foreach(int num in NumsArray)
    {
        if (num > 0) Result++;
    }
    return Result;
}

int[] NumsArray = GetNumsArray();
Console.WriteLine($"Count of positive nums: {CountOfPositiveNums(NumsArray)}");
