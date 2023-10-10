// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using static Controller;

public class HomeWork1 : BaseRoom
{
    private string msg = "Введите число: ";
    private string cancelMsg = "Ддя прекращения опперации введите: стоп";
    private string resultMsg = "Колличество чисел больше 0: ";
    private int positivNum = 0;
    private bool itsCanceled = false;
    private List<int> numList = new List<int>();
    public override void Start()
    {
        CreateList();
        CompareToZero();
    }
    private bool CancelOpperation(bool cancel)
    {
        itsCanceled = cancel;
        return itsCanceled;
    }

    private void CreateList()
    {
        Console.WriteLine(cancelMsg);
        
        while (!itsCanceled)
        {
            Console.WriteLine(msg);
            string numX = Console.ReadLine();

            if (numX.ToLower() == "стоп")
            {
                CancelOpperation(true);
                break;
            }

            numList.Add(Convert.ToInt32(numX));
        }
    }

    private void CompareToZero()
    {
        foreach (int element in numList)
        {
            if (element > 0) positivNum++; 
        }

        Console.WriteLine(resultMsg + $"{positivNum}");
    }
}
    



