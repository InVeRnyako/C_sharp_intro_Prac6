// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 ; 3  -> 11 ; 2  -> 10

int initNum = GetIntNatFromUser("Введите число для преобразования в двоичную систему исчисления: ");
Console.WriteLine($"{initNum} -> {ConvertToDoub(initNum)}");


static int ConvertToDoub(int num)
{
    int i = 0;
    int result = 0;
    while (num > 0)
    {
        // result = result * (int)Math.Pow(10, i) + (num % 2); // 1 10
        result += num % 2 * (int)Math.Pow(10,i);
        // Console.WriteLine(result);
        num /= 2; // 2
        i++;
    }
    return result;
}

static int GetIntNatFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            if (num >0)
                return num;
        Console.WriteLine("Ошибка ввода!");
    }
}