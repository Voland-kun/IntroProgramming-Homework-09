// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumMtoN(int n,int m)
{
    int sum=0;
    if(n == m) 
    {
        sum+=n;
    }
    else if(n>m)
    {
        sum = n+sumMtoN(n-1,m);
    }
    else if(n<m)
    {
        sum = n+sumMtoN(n+1,m);
    }
    return sum;

}

Console.WriteLine("Введите число N:");
int userNumberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M:");
int userNumberM = Convert.ToInt32(Console.ReadLine());
int summa = sumMtoN(userNumberN,userNumberM);
Console.WriteLine("Сумма равна:");
Console.WriteLine(summa);