// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;
using static Controller;

public class HomeWork3 : BaseRoom
{
    double minNumber = 0;
    double maxNumber = 0;
    double diff = 0;
    double[] someNumbers = new double[10];
    public override void Start()
    {
        ResultNumber(someNumbers);
    }

    private void CreateArray()
    {
        for (int i = 0; i < someNumbers.Length; i++)
        {
            someNumbers[i] = RandomFiller();
            Console.WriteLine($"Число массива: {someNumbers[i]}");
        }

    }

    private double RandomFiller()
    {
        Random rnd = new Random();
        double evenarray = Math.Round(rnd.NextDouble() * (100 - (-100)), 2);
        return evenarray;
    }

    private void ResultNumber(double[] array)
    {
        CreateArray();
        minNumber = array.Min();
        maxNumber = array.Max();
        diff = maxNumber - minNumber;
        Console.WriteLine($"Разницу между максимальным и минимальным элементов массива: {diff}");
    }
}
