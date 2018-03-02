using System;

delegate void Do();

class AnonMethDemo
{

    public static void Main()
    {
        Do count = delegate {
            for (int i = 0; i <= 5; i++)
                Console.WriteLine(i);
        };

        count();
    }
}
//0
//1
//2
//3
//4
//5