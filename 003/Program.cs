Console.Clear();
string act;
Console.WriteLine("Введите день недели в диапазоне от 1 до 7 включительно");
act = Console.ReadLine();

switch (act)
{
    case "1":
        Console.WriteLine("нет");
        break;
    case "2":
        Console.WriteLine("нет");
        break;
    case "3":
        Console.WriteLine("нет");
        break;
    case "4":
        Console.WriteLine("нет");
        break;
    case "5":
        Console.WriteLine("нет, но этот день лучше выходного drink.jpg");
        break;
    case "6":
        Console.WriteLine("да");
        break;
    case "7":
        Console.WriteLine("да");
        break;
    default:
        Console.WriteLine("Ошибка ввода, введите число от 1 до 7ми");
        break;
}

