// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

// принимает на вход три числа

int a = GetIntNatFromUser("Введите первое число: ");
int b = GetIntNatFromUser("Введите второе число: ");
int c = GetIntNatFromUser("Введите третье число: ");

if (CheckIfTriangable(a, b, c))
    Console.WriteLine($"{a}, {b}, {c} -> Треугольник существует");
else
    Console.WriteLine($"{a}, {b}, {c} -> Треугольник не существует");

static bool CheckIfTriangable(int a, int b, int c)
{
    return (a < b +c && b < a + c && c < a + b);
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