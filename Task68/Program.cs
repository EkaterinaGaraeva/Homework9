/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 (29 при n = 2, m = 3; 9 при m = 2, n = 3)
*/

int AckermanFunction(int numberM, int numberN, int result = 0)
{
    if (numberM == 0)
    {
        result = numberN + 1;
    }
    else if (numberM > 0 && numberN == 0)
    {
        result = AckermanFunction(numberM - 1, 1, result);
    }
    else if (numberM > 0 && numberN > 0)
    {
        numberN = AckermanFunction(numberM, numberN - 1, result);
        result = AckermanFunction(numberM - 1, numberN, result);
    }
    return result;
}

int numN = 2;
int numM = 3;
int res = AckermanFunction(numM, numN);
Console.WriteLine($"n = {numN}, m = {numM} -> A(m,n) = {res}");

