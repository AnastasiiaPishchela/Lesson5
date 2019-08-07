using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCustomArray;

// Создать класс, представляющий пользовательский массив с произвольной нижней границей нумерации
//элементов(как в Паскале), например, состоящий из 5 элементов с индексами 11, 12, 13, 14, 15. Определить
//свойства длины массива, нижней и верхней границы индекса, индексатор для чтения и записи элемента по
//заданному индексу.Класс скомпилировать в динамическую библиотеку. В консольном приложении
//продемонстрировать работу созданного класса.

namespace ConsoleTask5._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int startIndex = 11;
            int endIndex = 15;
            var customArray = new CustomaArray(startIndex, endIndex);
            for (int i = startIndex; i <= endIndex; i++)
            {
                customArray[i] = rnd.Next(11);
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine($"customArray[{i}] = " + customArray[i]);
            }
            Console.ReadLine();
        }
    }
}
