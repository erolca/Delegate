using System;

delegate int CountIt(int end);

class MainClass
{

    static CountIt counter()
    {
        CountIt ctObj = delegate (int end) {
            Console.WriteLine("end:" + end);
            return end;
        };
        return ctObj;
    }

    public static void Main()
    {
        CountIt count = counter();

        int result = count(3);
        result = count(5);
    }
}
//end:3
//end:5