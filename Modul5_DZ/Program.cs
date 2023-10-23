//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Modul5_DZ
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            try
//            {
//                int a = int.Parse(Console.ReadLine());
//                int b = int.Parse(Console.ReadLine());
//                int result = DivideNumbers(a, b);
//                Console.WriteLine("Результат деления: " + result);
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Произошла ошибка: " + ex.Message);
//            }
//            Console.ReadKey();
//        }


//        public static int DivideNumbers(int a, int b)
//        {
//            if (b == 0)
//            {

//                throw new DivideByZeroException("Деление на ноль недопустимо");
//            }

//            return a / b;
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace Modul5_DZ
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int[] array = { 1, 2, 3, 4, 5 };
//            int index = 7;

//            try
//            {
//                int element = array[index];
//                Console.WriteLine($"Элемент массива по индексу {index}: {element}");
//            }
//            catch (IndexOutOfRangeException)
//            {
//                Console.WriteLine($"Индекс {index} выходит за пределы массива.");
//            }
//            finally
//            {
//                Console.WriteLine("Завершение обработки массива.");
//            }
//            Console.ReadKey();
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//namespace Modul5_DZ
//{
//    public class ExceptionDemo
//    {
//        public void GenerateException()
//        {
//            Console.WriteLine("Метод начал выполнение.");
//            throw new ApplicationException("Произошла ошибка!");
//        }
//    }
//    public class Program
//    {
//        public static void Main()
//        {
//            ExceptionDemo demo = new ExceptionDemo();

//            try
//            {
//                Console.WriteLine("Вызываем метод GenerateException() из Main().");
//                demo.GenerateException();
//            }
//            catch (ApplicationException ex)
//            {
//                Console.WriteLine($"Произошла ошибка: {ex.Message}");
//            }
//            finally
//            {
//                Console.WriteLine("Завершение программы.");
//            }
//            Console.ReadKey();
//        }
//        public override bool Equals(object obj)
//        {
//            return base.Equals(obj);
//        }
//        public override int GetHashCode()
//        {
//            return base.GetHashCode();
//        }
//        public override string ToString()
//        {
//            return base.ToString();
//        }
//    }

//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Modul5_DZ

{
    public class ExceptionDemo
    {
        public void GenerateException()
        {
            Console.WriteLine("Метод  начал выполнение.");
            throw new ApplicationException("Произошла ошибка!");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Начало программы.");

            try
            {
                ExceptionDemo demo = new ExceptionDemo();
                CallGenerateException(demo);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершение программы.");
            }
            Console.ReadKey();
        }

        public static void CallGenerateException(ExceptionDemo demo)
        {
            Console.WriteLine("Вызываем метод GenerateException() из CallGenerateException().");
            demo.GenerateException();
        }
    }
}