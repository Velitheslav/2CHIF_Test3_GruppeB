using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CHIF_Test3_GruppeB
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL list = new DLL();

            list.AddAtEnd(1);
            list.AddAtEnd(7);
            list.AddAtEnd(6);
            list.AddAtEnd(3);
            list.AddAtEnd(2);

            list.Print();

            Console.WriteLine();

            list.RemoveLast(3);

            list.Print();

            Console.WriteLine();

            list.RemoveLast(0);

            list.Print();
            Console.WriteLine();

            Console.WriteLine("sfal");
            list.SwapFirstAndLast();

            list.Print();

            Console.WriteLine();

            Console.WriteLine("adding 2 elements");
            list.AddAtEnd(3);
            list.AddAtEnd(2);

            list.Print();
            Console.WriteLine();

            Console.WriteLine("rlaf");
            list.RemoveFistAndLast();

            list.Print();
            Console.WriteLine();

            Console.WriteLine("set");
            list.Set(3, 40);

            list.Print();
            Console.WriteLine();

            Console.WriteLine("array");

            int[] ar= list.toArray();

            for (int i = 0; i < 3; i++)//nur zur probe
            {
                Console.WriteLine(ar[i]);
            }
            

            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //DLL list2 = new DLL();

            //list.AddAtEnd(1);
            //list.AddAtEnd(2);
            //list.AddAtEnd(3);
            //list.AddAtEnd(4);
            //list.AddAtEnd(5);
            //list.AddAtEnd(6);


            //list2.Print();
            //Console.WriteLine();

            //list2.SwapFirstAndLast();
            //list2.Print();

            Console.ReadKey();

            //DLL list = new DLL();
            //list.AddAtEnd(1);
            //list.AddAtEnd(2);
            //list.AddAtEnd(3);
            //list.AddAtEnd(4);
            //list.AddAtEnd(5);
            //list.AddAtEnd(6);


            //list.Print();

            //Console.WriteLine();

            //list.SwapFirstAndLast();
            //list.Print();

            //Console.WriteLine();
            //list.RemoveFistAndLast();
            //list.Print();





            //Console.ReadKey();
        }
    }
}
