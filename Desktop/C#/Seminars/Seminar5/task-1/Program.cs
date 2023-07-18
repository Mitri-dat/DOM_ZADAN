Console.Clear();

int GetPosOrNegativeSum(int[] array, bool posOrNegative)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (posOrNegative)
        {
            if (array[i] > 0)
            {
                result += array[i];
            }
        }
        else
        {
            if (array[i] < 0)
            {
                result += array[i];
            }
        }

    }
    return result;
}
int[] MakeNewRandomArray(int size, int beginValue, int EndWalue)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            array[i] = new Random().Next(beginValue, EndWalue);
        return array;
    }

int[] array = MakeNewRandomArray(12, -9, 9);

Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"Сумма положительных чисел равна{GetPosOrNegativeSum(array,true)}"); // Console.WriteLine("[" + string.Join(",",array) + "]");
Console.WriteLine($"Сумма отрицательных чисел равна{GetPosOrNegativeSum(array,false)}");



// int positiveSum = 0;
// int negativeSum = 0;

// while (array[int++])
// {
//     if
// }



//  Console.WriteLine($"сумма положительных числ равна {GetPosOrNegativeSum}")







