// Пример использования if для возраста
Console.WriteLine("Сколько вам лет?");
int age = Convert.ToInt32(Console.ReadLine()); ;
if (age < 7)
{
    Console.WriteLine("Иди в детский сад");
}
else if (age >= 7 && age < 18)
{
    Console.WriteLine("Иди в школу");
}
else if (age >= 18 && age < 23)
{
    Console.WriteLine("Иди в университет");
}
else if (age >= 23 && age < 60)
{
    Console.WriteLine("Иди на работу");
}
else
{
    Console.WriteLine("На пенсию пора");
}

// Система оценивания школьников
Console.WriteLine("Какой балл?");
int x = Convert.ToInt32(Console.ReadLine()); ;
switch (x)
{
    case 12:
        Console.WriteLine("Отлично!");
        break;
    case 9:
    case 10:
        Console.WriteLine("Хорошо!");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Удовлетворительно");
        break;
    default:
        Console.WriteLine("Неудовлетворительно");
        break;
}

