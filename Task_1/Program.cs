/*
    1) Посчитать сумму всех трех цифр трехзначного числа, заданного константой (const). Вывести сумму на печать.
    Например:
    735 = 15(7 + 3 + 5)
*/

class Programm
{
    static void Main()
    {
        int n = 735;
        int m = 10;
        int sum = n % m;
        Console.WriteLine("остаток числа {0} от деления на {1} равен: {2}", n, m, sum);
        // n = n / 10
        n /= 10;
        Console.WriteLine("n равно: {0}", n);
        // sum = sum + (n % 10)
        sum += n % 10;
        Console.WriteLine("Сумма равна: {0}", sum);
        n /= 10;
        Console.WriteLine("n равно: {0}", n);
        sum += n;
        Console.WriteLine("Сумма равна: {0}", sum);
    }
}


