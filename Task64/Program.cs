/*
Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от N до M.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 7"
*/

void NaturalNumbersFromNToM(int numberM, int numberN)
{
    if (numberN < numberM)
    {
        return;
    }
    else
    {
        Console.Write($"{numberN}");
        if (numberN > numberM)
        {
            Console.Write($", ");
        }
        NaturalNumbersFromNToM(numberM, --numberN);
    }
}

NaturalNumbersFromNToM(1, 5);
