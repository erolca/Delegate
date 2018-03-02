using System;

delegate void CountIt(int end);

class MainClass
{

    public static void Main()
    {
        CountIt count = delegate (int end) {
            Console.WriteLine("end:" + end);
        };

        count(3);
        count(5);
    }
}
//end:3
//end:5