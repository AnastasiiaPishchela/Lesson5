using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Разработать класс «многочлен» для работы с многочленами от одной переменной и перегрузить для класса
операции, допустимые для работы с многочленами (сложение, вычитание, умножение). В классе определить
свойства (например, степень многочлена), индексатор на чтение и запись (доступ к коэффициенту по индексу-
степени), метод, возвращающий строковое представление значения многочлена в удобном для восприятия
виде, например, «5х^3 + 2x^2 + 45»1. Класс скомпилировать в динамическую библиотеку. В консольном
приложении продемонстрировать работу созданного класса.*/

namespace ConsoleTask5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int maxPower = 5;
            var pol = new Polynom(maxPower + 1);
            for (int i = 0; i < maxPower + 1; i++)
            {
                pol[i] = rnd.Next(512);
            }
            var pol2 = new Polynom(maxPower + 1);
            for (int i = 0; i < maxPower + 1; i++)
            {
                pol2[i] = rnd.Next(100);
            }
            Console.WriteLine("Polynom 1 : " + pol.ToString());
            Console.WriteLine("Polynom 2 : " + pol2.ToString());
            Console.WriteLine("Polynom sum : " + pol.addPolynom(pol2).ToString());
            Console.ReadLine();
        }
    }

    class Polynom
    {
        int[] arr;
        public int PolynomPower { get { return arr.Length; } }
        public int this[int power]
        {
            get { return arr[power]; }
            set { arr[power] = value; }
        }

        public Polynom(int maxPower)
        {
            arr = new int[maxPower];
        }

        public Polynom addPolynom(Polynom secondPolynom)
        {
            int maxPower = arr.Length >= secondPolynom.PolynomPower ? arr.Length : secondPolynom.PolynomPower;
            Polynom polRes = new Polynom(maxPower);
            int i = 0;
            while (i < maxPower)
            {
                if (i > arr.Length - 1)
                {
                    polRes[i] = secondPolynom[i];
                }
                else if (i > secondPolynom.PolynomPower - 1)
                {
                    polRes[i] = arr[i];
                }
                else
                {
                    polRes[i] = arr[i] + secondPolynom[i];
                }
                i++;
            }
            return polRes;
        }

        public override string ToString()
        {
            string res = "";
            int i = arr.Length - 1;
            while (i > 1)
            {
                res += ($"{arr[i]}x ^ {i}");
                i--;
                res += (" + ");
            }
            if (arr.Length > 1)
            {
                if (arr[1] != 0)
                {
                    res += ($" + {arr[1]}x");
                }
            }
            if (arr.Length > 0)
            {
                if (arr[0] != 0)
                {
                    res += ($" + {arr[0]}");
                }
            }
            return res;
        }
    }
}
