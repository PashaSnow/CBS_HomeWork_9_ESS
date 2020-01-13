using System;

namespace Task3
{
    /*Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве. 
     * Методы, сообщенные с делегатами из массива, возвращают случайное значение типа */

    public delegate int SomeInt();
    public delegate double Average(SomeInt[] array);

    class Program
    {
        static Random rnd = new Random();
        static void Initialization(ref SomeInt[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () =>
                { 
                    return rnd.Next(-100, 100); 
                };
            }
        }
        static void Main(string[] args)
        {
            SomeInt[] array = new SomeInt[10];
            Initialization(ref array);
            Average anonim = delegate (SomeInt[] someArray)
            {
                double result = 0;
                for (int count = 0; count < someArray.Length; count++)
                {
                    result += someArray[count].Invoke();
                }
                return result / (double)someArray.Length;
            };

            Console.WriteLine(anonim(array));
        }
    }
}

