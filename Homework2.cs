// //  Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.


using static Controller;

public class HomeWork2 : BaseRoom
{
    double numberB1 = ValueNumbers("Введите число B1: ");
    double numberK1 = ValueNumbers("Введите число K1: ");
    double numberB2 = ValueNumbers("Введите число B2: ");
    double numberK2 = ValueNumbers("Введите число K2: ");

    public override void Start()
    {
        Crossinglines();
    }

    private void Crossinglines()
    {
        double x = (-numberB2 + numberB1) / (-numberK1 + numberK2);
        double y = numberK2 * x + numberB2;
        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }

    private static double ValueNumbers(string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}