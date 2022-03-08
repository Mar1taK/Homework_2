
/*5) Записать логическое условие, которое проверит, что в double числе нулевая дробная часть.
Например:
156.0(true)
156.2(false)
Подсказка: сравните само число double number и его явное приведение к (int)number
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число с плавающей запятой");

        double number  = Double.Parse(Console.ReadLine());
        Console.WriteLine("Проверка: " + IsNumberDouble(number));
        

        bool IsNumberDouble(double number)
        {
            if(number == (int)number) 
            {
                return true;
            }
            else 
            {
                return false;
            }
                

        }
    }
}