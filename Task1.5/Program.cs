using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть довжину прямокутиника:"); //Надання значення довжини прямокутника
        double lenght = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть ширину прямокутника: "); //Надання значення ширини прямокутника
        double width = double.Parse(Console.ReadLine());

        double area = lenght + width;

        Console.WriteLine($"Площа прямокутника: {area}");
    }
}
