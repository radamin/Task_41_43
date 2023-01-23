// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223 -> 4



Console.Write("Enter count numbers: ");
int num = Convert.ToInt32(Console.ReadLine());

countNumber(newArray(num));

int[] newArray(int a)
{

    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter {i + 1} number: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void countNumber(int[] a)
{
    int[] arr = a;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    Console.WriteLine($"you entered {count} positive numbers");
}

