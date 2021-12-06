using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW22
{
    class Program
    {
        static void Method1()// первый метод не принимает аргументов и не возвращает значения
        {
            Console.WriteLine("mETOD1 START WORK");
            for (int i=0;i<10;i++)//цикл на 10 итераций на каждом шаге выводим значения
            {
                Console.WriteLine($"metod1 vivod schetchik ={i}");
                Thread.Sleep(1000);//задержка на 1 секунду
            }
            Console.WriteLine("method1 end work");
        }
        static void Method2(int n)//метод2 принимает целочисленный элемент,но ничего не возвращает
        {
            Console.WriteLine("mETOD2 START WORK");
            for (int i = n; i <n+ 10; i++)
            {
                Console.WriteLine($"metod1 vivod schetchik ={i}");//выводим 10 значений начиная с n
                Thread.Sleep(800);//задержка 800мс
            }
            Console.WriteLine("method2 end work");
        }
        static int Method3()//не принимает аргументов,но возвращает значение
        {
            Console.WriteLine("mETOD3 START WORK");
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                S += i;//суммируем 10 чисел и на каждом шаге останавливаемся на 300мс
                Thread.Sleep(300);
            }
            Console.WriteLine("method3 end work");
            return (S);//возвращаем значение суммы
        }
        static int Method4(int a)//метод 4 принимает значение а,и возвращает целочисленное значение
        {
            Console.WriteLine("mETOD4 START WORK");
            int S = 0;
            for (int i = 0; i < 10; i++)//десять раз добавляем значение а к сумме
            {
                S += a;
                Thread.Sleep(500);
            }
            Console.WriteLine("method4 end work");
            return (S);//выводим его на экран
        }

        static void Main(string[] args)
        {
            //запускаем метод асинхронно
            Action action = new Action(Method1);// делегат action 
            Task task = new Task(action);//создаем экземпляр класска task(так как не возвращает значение используем необобщенный тип)
            task.Start();//запуск задачи
            //Method1();//запускаем метод 1 и метод 2 синхронно
            Method2(100);

            Console.WriteLine("Main end work");
            Console.ReadKey();
        }
    }
}
