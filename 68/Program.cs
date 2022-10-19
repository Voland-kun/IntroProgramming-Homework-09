// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m,int n)
{
    if(m==0) 
        return n+1;
    else if(m>0 && n==0)
        return Ackermann(m-1,1);
    else if(m>0 && n>0)
        return Ackermann(m-1,Ackermann(m,n-1));
    return -1;
}

Console.WriteLine("Введите число M:");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int userNumberN = Convert.ToInt32(Console.ReadLine());
int ackermannResult = Ackermann(userNumberM,userNumberN);
Console.WriteLine($"A({userNumberM},{userNumberN})={ackermannResult}");