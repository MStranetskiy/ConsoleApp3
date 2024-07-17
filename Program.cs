using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*
        3. Задание по полиморфизму
        Задание: Реализуйте перегрузку и переопределение методов.
        Инструкции:
        Создайте класс под названием Calculator.
        Реализуйте перегрузку методов, создав два метода Add: один, который складывает два целых числа, и другой, который складывает три целых числа.
        Создайте базовый класс под названием Figure с методом Draw. Метод должен выводить на экран текст “Рисуем фигуру”.
        Создайте подкласс под названием Circle, который переопределяет метод Draw. Метод должен выводить на экран текст “Рисуем круг”.
 */

    public abstract class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public abstract class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("Рисуем фигуру");
        }
    }

    public abstract class Circle : Figure
    {
        public  override void Draw()
        {
            Console.WriteLine("Рисуем круг");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(1, 2);
            
        }
    }
}
