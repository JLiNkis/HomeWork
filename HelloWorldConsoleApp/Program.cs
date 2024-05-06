// Импорт сторонних пространств имён
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Пространство имён
/// Создание собственной библиотеки
/// </summary>
namespace HelloWorldConsoleApp
{
    /// <summary>
    /// Главная составляющая единица приложения - класс
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Код, который выполняется в первую очередь
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow "); // Вывод текста в консоль

            Console.WriteLine("World ");
                    
            Console.WriteLine("!!!");

            Console.Write("Hellow ");
               
            Console.Write("World ");
                    
            Console.Write("!!!");

            Console.ReadKey(); // Ожидание от пользователя нажатия какой-либокнопки
        }
    }
}
