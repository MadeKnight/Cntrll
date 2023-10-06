// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


using System;
using System.Xml.XPath;
using static Controller;

public class HomeWork2 : BaseRoom
{
    int evenNumber = 0;
    int[] someNumbers;
    public override void Start()
    {
        CreateArray();
    }

    private void CreateArray()
    {
        int arrayNumber = RandomFiller(5, 10);
        someNumbers = new int[arrayNumber];

        for (int i = 0; i < arrayNumber; i++)
        {
            someNumbers[i] = RandomFiller(3, 10);
            Console.WriteLine($"Число массива: {someNumbers[i]}");
        }

        for(int i = 1; i < arrayNumber; i+=2 )
        {
            evenNumber += someNumbers[i];
        }
        Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {evenNumber}");
    }

    private int RandomFiller(int start, int end)
    {
        Random rnd = new Random();
        int evenarray = rnd.Next(start, end);
        return evenarray;
    }
}
