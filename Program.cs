//
//
//
//
//
int AmountOfElements(string[] arr) // 
{
    int j = 0;
    int count = 0; // Запускаем счётчик, возвратное значение.
    Console.Write("Введите максимальное (по умолчанию 3) допустимое кол-во символов, в каждой строке массива : ");
    string enter = Console.ReadLine()!;
    if (enter == "")
    {
        j = 3;
    }
    else
    {
        j = Convert.ToInt32(enter);
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= j)
        {
            count++;
        }
    }
    return count;
}




string[] test = {"4g/x", "hasbdvojh", "541", "#%$&", "GIhj$3", "/4uhh76f", "4f", "*", "js9L4", "H"};
Console.WriteLine(AmountOfElements(test));
