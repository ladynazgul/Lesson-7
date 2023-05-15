// Вычислить a^n (a в степени n)

int PowerFor(int a, int n) // итеративный подход
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n) // рекурсивный подход
{   // return n == 0 ? 1 : PowerRec(a, n - 1) * a; - написание в одну строку
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a,int n) // рекурсивный подход через мат. формулу
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}


Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024
