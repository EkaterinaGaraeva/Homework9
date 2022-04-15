/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumbersFromMToN(int numberM, int numberN, int sum = 0)
{
    if (numberM <= numberN)
    {
        sum += numberM;
        sum = SumNumbersFromMToN(++numberM, numberN, sum);
    }
    return sum;
}

int numM = 4;
int numN = 8;
int sumNumbers = SumNumbersFromMToN(numM, numN);
Console.WriteLine($"Сумма чисел от {numM} до {numN} = {sumNumbers}");
