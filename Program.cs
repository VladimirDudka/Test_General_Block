//
//
//
//
Console.Clear();
Console.Write("Введите кол-во элементов массива : ");
int amount = Convert.ToInt32(Console.ReadLine()!);

string[] MakeStringArray(int a) // Метод создаёт строчный массив на N заданных элементов
{
    string[] input_numeral = new string[a]; // Создаём массив из N элементов
    for (int i = 0; i < a; i++) // С помощью цикла заполняем каждый элемент массива
    {
        Console.Write($"Введите {i + 1} элемент строкового массива : ");
        input_numeral[i] = Console.ReadLine()!;
    }
    return input_numeral;
}
string[] array = MakeStringArray(amount); // Созданный массив

Console.WriteLine("! По условию задачи максимальное значение равно 3, но можно ввести любое число!");
Console.Write("Введите максимальное допустимое кол-во символов, в каждой строке массива : ");
int keyboardInput = Convert.ToInt32(Console.ReadLine()!); // 

int AmountOfElements(string[] arr, int amount) // Метод подсчитывает кол-во элементов заданного размера.
{
    int count = 0; // Запускаем счётчик, возвратное значение.
    for (int i = 0; i < arr.Length; i++) // Цикл подсчитывает кол-во элементов, с заданными условиями.
    {
        if (arr[i].Length <= amount)
        {
            count++;
        }
    }
    return count;
}
int amountElements = AmountOfElements(array, keyboardInput);


string[] MaxFixCharArray(string[] arr, int elements, int maxChar) // Метод создаёт массив из другого массива
// с ограниченными по длине элементами.
{
    string[] new_array = new string[elements]; // Создаём новый массив
    int j = 0;
    for (int i = 0; i < arr.Length; i++) // В цикле проверяем каждый элемент переданного массива
    // на соответствие условию и при выполнении условия записываем элемент в новый массив.
    {
        if (arr[i].Length <= maxChar)
        {
            new_array[j] = arr[i];
            j++;
        }
    }    
    return new_array;
}
string[] array_new = MaxFixCharArray(array, amountElements, keyboardInput); // Изменёный массив


void PrintArray(string[] arr_print) // Метод вывод на печать массива.
{
    Console.Write("[ ");
    int index = 0;
    if (arr_print.Length == 0) 
    {
        Console.Write("Нет элементов с заданными условиями.");
    }
    while (index < arr_print.Length)
    {
        Console.Write($"{arr_print[index]}");
        index++;
        if (index < arr_print.Length)
        {
            Console.Write(" , ");
        }
    }
     Console.Write(" ]");  
}

Console.WriteLine("Созданный массив : ");
PrintArray(array);
Console.WriteLine(); 
Console.WriteLine("Полученный массив : ");
PrintArray(array_new);
Console.WriteLine(); 