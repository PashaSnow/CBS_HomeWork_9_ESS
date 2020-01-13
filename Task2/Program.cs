using System;

namespace Task2
{
    /*Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку деления на ноль.  
    Написать программу, которая будет выполнять арифметические действия, указанные пользователем. 
    */

    enum choseEvent
    {
        add,
        sub,
        mul,
        div
    }
    public delegate double Calc(double val1, double val2);
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = null;
            
            Console.WriteLine("Уведите операнд 1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведите операнд 2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Выбирете операцию add, sub, mul, div");
            switch (Enum.Parse(typeof(choseEvent), Console.ReadLine().ToLower()))
            {
                case choseEvent.add:
                    calc = (val1, val2) => val1 + val2;
                    break;
                case choseEvent.sub:
                    calc =  (val1, val2) => val1 - val2;
                    break;
                case choseEvent.mul:
                    calc = (val1, val2) => val1 * val2;
                    break;
                case choseEvent.div:
                    calc = (val1, val2) =>
                    {
                        if (val2 == 0)
                        {
                            Console.WriteLine("Попытка деления на ноль");
                            return 0d;
                        }
                        return val1 / val2;
                    };
                    break;
            }
            if (calc != null)
                Console.WriteLine(calc.Invoke(x1, x2));
            else
                Console.WriteLine("Нет указателя");
        }
    }
}
