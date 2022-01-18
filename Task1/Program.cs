using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
            - метод, определяющий длину окружности по заданному радиусу;
            - метод, определяющий площадь круга по заданному радиусу;
            - метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
            */
            try
            {
                Console.WriteLine("Получение информации о свойствах окружности:\n");
                Console.Write("Введите радиус окружности: ");
                double rad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Длина окружности равна {0}, площадь круга равна {1}",
                                  Circle.Length(rad),
                                  Circle.Area(rad));
                Console.WriteLine("Введите координаты точки относительно центра круга:");
                Console.Write("\tx = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("\ty = ");
                double y = Convert.ToDouble(Console.ReadLine());
                if (Circle.IsPointInside(rad, x, y))
                {
                    Console.WriteLine("Точка с координатами x, y принадлежит кругу заданного радиуса.");
                }
                else
                {
                    Console.WriteLine("Точка с координатами x, y не принадлежит кругу заданного радиуса.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }

            Console.ReadKey();
        }
    }
    static class Circle
    {
        static public double Length(double radius)
        {
            if (radius < 0)
                throw new Exception("Радиус окружности не может быть меньше нуля.");
            return 2 * Math.PI * radius;
        }
        static public double Area(double radius)
        {
            if (radius < 0)
                throw new Exception("Радиус окружности не может быть меньше нуля.");
            return Math.PI * Math.Pow(radius, 2);
        }
        static public Boolean IsPointInside(double radius, double x, double y)
        {
            if (radius < 0)
                throw new Exception("Радиус окружности не может быть меньше нуля.");
            return (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y,2)) <= radius);
        }
    }
}
