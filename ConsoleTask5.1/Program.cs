//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

///*Создать класс, представляющий пользовательский массив с произвольной нижней границей нумерации
//элементов (как в Паскале), например, состоящий из 5 элементов с индексами 11, 12, 13, 14, 15. Определить
//свойства длины массива, нижней и верхней границы индекса, индексатор для чтения и записи элемента по
//заданному индексу. Класс скомпилировать в динамическую библиотеку. В консольном приложении
//продемонстрировать работу созданного класса.*/

//namespace ConsoleTask5._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//    public class MyArray
//    {
//        public Dictionary<int, int> Data = new Dictionary<int, int>();
//        public MyArray() { }
//            public int this[int index]
//            {
//             set { Data.Add(index, value); }
//             get { return Data[index]; }
//            }

//        private readonly MyArray my = new MyArray();
//              my[0] = 11;
//              my[1] = 12;
//              my[2] = 12;
//              my[3] = 14;
//              my[4] = 15;       
//             MessageBox.Show(my[-1].ToString());
//    }
//}
