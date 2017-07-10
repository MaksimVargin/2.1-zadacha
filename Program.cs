using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{

    class Treug
    {
        private int[] sides = new int[3]; //Задаём, сколько сторон в треугольнике
        private int P; //Периметр треугольника
        private double S; //Площадь треугольника
        double H1, H2, H3; //Высоты треугольника

        public Treug(int s1, int s2, int s3)
        {
            sides[0] = s1; //Первая сторона треугольника
            sides[1] = s2; //Вторая сторона треугольника
            sides[2] = s3; //Третья сторона треугольника
            P = s1 + s2 + s3; //Считает периметр
            double p = (s1 + s2 + s3) / 2; //Считает полупериметр 
            S = Math.Sqrt((double)(p*(p - s1) * (p - s2) * (p - s3))); //Считает площадь
            H1 = (2 * S) / s1; //Считает первую высоту
            H2 = (2 * S) / s2; //Считает вторую высоту
            H3 = (2 * S) / s3; //Считает третью высоту
            Console.Write("Периметр равен: {0}\n", P);
            Console.Write("Площадь равна: {0}\n", S);
            Console.Write("Высота, опущенная на первую сторону, равна: {0}\n", H1);
            Console.Write("Высота, опущенная на вторую сторону, равна: {0}\n", H2);
            Console.Write("Высота, опущенная на третью сторону, равна: {0}\n", H3);
        }

        public void func2(int angle1, int angle2, int angle3) //Вводим углы треугольника
        {
            if (angle1 == 90||angle2==90||angle3==90) //Проверяет, является ли треугольник прямоугольным
            {
                Console.Write("Треугольник является прямоугольным\n");
            }
            if (angle1 == 60 && angle2 == 60 && angle3 == 60) //Проверяет, является ли треугольник равносторонним
            {
                Console.Write("Треугольник является равносторонним\n");
            }
            else
                if (angle1 == angle2 || angle1 == angle3 || angle2 == angle3) //Проверяет, является ли треугольник равнобедренным 
                Console.Write("Треугольник является равнобедренным\n");
            if (angle1!=angle2 && angle1!=angle3 && angle2!=angle3) //Проверяет, является ли треугольник разносторонним
            {
                Console.Write("Треугольник является разносторонним\n");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длины сторон:\n");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int s3 = Convert.ToInt32(Console.ReadLine());
            Treug t = new Treug(s1, s2, s3);
            Console.Write("Введите угол от 1 до 180 для рассчетов:\n");
            int angle1 = Convert.ToInt32(Console.ReadLine());
            int angle2 = Convert.ToInt32(Console.ReadLine());
            int angle3 = Convert.ToInt32(Console.ReadLine());
            t.func2(angle1, angle2, angle3);
            Console.ReadKey();
        }
    }
}
