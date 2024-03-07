//
//
//
//
Console.Clear();
Console.Write("Введите кол-во элементов массива : ");
int amount = Convert.ToInt32(Console.ReadLine());

string[] MakeStringArray(int a)
{
    string[] input_arr = new string[amount];
    for (int i = 0; i < amount; i++)
    {
        Console.Write($"Введите {i + 1} элемент строкового массива : ");
        input_arr[i] = Console.ReadLine();
    }
    return input_arr;
}

int AmountOfElements(string[] arr) // Метод подсчитывает кол-во элементов заданного размера.
{
    int j = 0; // Переменная int в которой сохраняется число введенное с клавиатуры.
    int count = 0; // Запускаем счётчик, возвратное значение.
    Console.Write("Введите максимальное (по умолчанию 3) допустимое кол-во символов, в каждой строке массива : ");
    string enter = Console.ReadLine()!; // Строковое значение введенное с клавиатуры.
    if (enter == "") // Проверка на ввод пустой строки.
    {
        j = 3; // По условию задачи длина элементов <= 3 (по умолчанию).
    }
    else
    {
        j = Convert.ToInt32(enter); // Присваиваем переменной j, число введенное с клавиатуры.
    }
    for (int i = 0; i < arr.Length; i++) // Цикл подсчитывает кол-во элементов, с заданными условиями.
    {
        if (arr[i].Length <= j)
        {
            count++;
        }
    }
    return count;
}

//string[] MaxFixCharArray(string[] arr, int amountChar)

Console.WriteLine(AmountOfElements(MakeStringArray(amount)));
