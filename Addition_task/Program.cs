using System;

namespace Addition_task
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application. 
     * Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов. 
     */

    public delegate double Average(int val1, int val2, int val3);

    class Program
    {
        static void Main(string[] args)
        {
            int y1 = 16, y2 = 27, y3 = 22;
            Average myDel = delegate (int x1, int x2, int x3)
            {
                return (double)(x1 + x2 + x3) / 3d;
            };
            Console.WriteLine($" Среднее арифметическое чисел: {y1}, {y2}, {y3} = {myDel.Invoke(y1, y2, y3)} ");
        }
    }
}
