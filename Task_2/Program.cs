/*
    3) Пользователь вводит трехзначное число. Записать логическое условие, которые будет истинным тогда и только тогда,
    когда его средняя цифра меньше или равна (<=) первой(левой) и одновременно строго больше (>) последней(правой).
    Например: 
    742(true)
    773(true)
    755(false)
    354(false)
    335(false)

    4) Ввести целое трехзначное число. Поменять местами его первую и последнюю цифры. Собрать новое число в новой переменной!
    Например:
    365-> 563
    947-> 749
    Вспоминаем арифметику... 365 это 3*100 + 6*10 + 5 :)
*/

class Pogram
{

    static void Main()
    {
        int GetDigits(int n)
        {
            int digints = n % 10;
            return digints;
        }

        int GetDecade(int n)
        {
            int decade = n / 10;
            decade %= 10;
            return decade;
        }

        int GetHundred(int n)
        {
            int hundred = n / 100;
            return hundred;
        }

        int GetSum(int n, int m)
        {
            int sum = n + m;
            return sum;
        }


        bool GetTaskCondition(int n)
        {
            int digits = GetDigits(n);
            int decade = GetDecade(n);
            int hundred = GetHundred(n);

            if (decade <= hundred && decade > digits)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        int GetTaskReplace(int n)
        {
            int hundred = GetHundred(n);
            int decade = GetDecade(n);
            int digits = GetDigits(n);

            return digits * 100 + decade * 10 + hundred;
        }

        Console.WriteLine("Введите трехзначное число");

        int threeDigit = Int32.Parse(Console.ReadLine());

       Console.WriteLine("Единицы введенного числа: " + GetDigits(threeDigit));

        Console.WriteLine("Десятки введенного числа: " + GetDecade(threeDigit));

        Console.WriteLine("Сотни введенного числа: " + GetHundred(threeDigit));
        
        Console.WriteLine("Решение задачи 3: " + GetTaskCondition(threeDigit));

        Console.WriteLine("Новое число равно" +
            ": " + GetTaskReplace(threeDigit));
    }
}



