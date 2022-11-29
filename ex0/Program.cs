// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] ; [6 7 3 6] -> [6 3 7 6]

int[] array = GenerateArrayWithNumbers(10,0,10);
Console.WriteLine(String.Join(" ", array));

int[] reverseArray = ReverseArray1(array);
Console.WriteLine(String.Join(" ", reverseArray));

ReverseArray2(array);
Console.WriteLine(String.Join(" ", array));

int[] ReverseArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

void ReverseArray2(int[] inArray)
{
    int k;
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}

static int[] GenerateArrayWithNumbers(int arraySize, int lowLimit, int highLimitIncluded)
{
    Random random = new Random();
    int[] array = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = random.Next(lowLimit, highLimitIncluded + 1);
    }
    return array;
}