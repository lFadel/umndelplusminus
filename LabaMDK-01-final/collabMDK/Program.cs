using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

while (true)
{
    Console.WriteLine("Введите первое значение");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе значение");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите операцию");
    var o = Console.ReadLine();



    if (o == "+")
    {
        Console.WriteLine($"Ответ {a + b}");
    }
    else if (o == "-")
    {
        Console.WriteLine($"Ответ {a - b}");
    }
    else if (o == "*")
    {
        Console.WriteLine($"Ответ {a * b}");
    }
    else if (o == "/")
    {
        Console.WriteLine($"Ответ {a / b}");
    }
    else
    {
        Console.WriteLine("Недопустимая операция!");
    }
    
}



