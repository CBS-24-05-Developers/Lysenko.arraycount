using System;

namespace test
{
    class MyClass
    {
        public string a, b, c;

        public MyClass(string a, string b, string c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
          
    class Program
    {
        static void Main()
        {
            MyClass[] Array = new MyClass[10];
            int arraycount = 0;
        StartPoint:
            Console.WriteLine("A :");
            string a = Console.ReadLine();
            Console.WriteLine("B :");
            string b = Console.ReadLine();
            Console.WriteLine("C :");
            string c = Console.ReadLine();
                       
            Console.WriteLine("Save?");
            string save = Console.ReadLine();
            
            if (save == "yes")
            {
                Array[arraycount] = new MyClass(a, b, c);
                arraycount++;
            }

            Console.WriteLine("More ABC?");
            string more = Console.ReadLine();

            if (more == "yes")
            {
                goto StartPoint;
            }

            for (int i = 0; i <= arraycount; i++)
            {
                Console.WriteLine(Array[i]?.a);
                Console.WriteLine(Array[i]?.b);
                Console.WriteLine(Array[i]?.c);
                Console.WriteLine(new string('-', 20));
            }

            Console.ReadKey();
          

        }
    }
}
