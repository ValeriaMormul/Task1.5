using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("10"); //Надання значення довжини прямокутника
        double lenght = double.Parse(Console.ReadLine());

        Console.WriteLine("20"); //Надання значення ширини прямокутника
        double width = double.Parse(Console.ReadLine());

        double area = lenght + width;

        Console.WriteLine($"Площа прямокутника: {area}");
    }
}