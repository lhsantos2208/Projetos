using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task parte 1
            // Pode ser utilizada dessa forma para trabalhar com Thread
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            // Ou dessa forma
            //Task t2 = Task.Run(Tarefa);

            // Ou dessa forma
            //Task.Run(Tarefa);   

            // Ou dessa forma
            //Task.Factory.StartNew(Tarefa);

            // Ou dessa forma
            //Task.Run(() => 
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa anônima.");
            //    }
            //});

            //// Thread principal
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Tarefa principal.");
            //}
            #endregion

            //Task[] tasks =
            //{
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #1");
            //    }),

            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #2");
            //    }),

            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #3");
            //    })
            //};

            //Task.WaitAll(tasks);

            Task t1 = Task.Run(() =>
            {
                Console.WriteLine("Comando #1");
            });

            Task t2 = Task.Run(() =>
            {
                Console.WriteLine("Comando #2");
            });

            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Comando #3");
            });

            Task.WaitAll(t1, t2, t3);

            Console.WriteLine("Pricipal");

            Console.ReadKey();
        }

        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa do Task.");
            }
        }
    }
}
