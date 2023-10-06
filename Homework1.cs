// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;
using static Controller;

public class HomeWork1 : BaseRoom
{
    int evenNumber = 0;
    int[] someNumbers;
    public override void Start()
    {
        CreateArray();
    }

    private void CreateArray()
    {
        int arrayNumber = RandomFiller(3, 11);
        someNumbers = new int[arrayNumber];

        for (int i = 0; i < arrayNumber; i++)
        {
            someNumbers[i] = RandomFiller(100, 1000);
            Console.WriteLine($"Число массива: {someNumbers[i]}");
        }

        foreach (int elem in someNumbers)
        {
            if ((elem % 2) == 0) evenNumber++;
        }

        Console.WriteLine($"Количество чётных чисел массива: {evenNumber}");
    }

    private int RandomFiller(int start, int end)
    {
        Random rnd = new Random();
        int evenarray = rnd.Next(start, end);
        return evenarray;
    }
}

