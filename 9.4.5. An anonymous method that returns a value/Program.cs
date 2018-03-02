using System;

delegate int CountIt(int end);

class MainClass
{

    public static void Main()
    {
        CountIt count = delegate (int end) {
            Console.WriteLine("end:" + end);
            return end;
        };

        int result = count(3);
        Console.WriteLine("Summation of 3 is " + result);

        result = count(5);
        Console.WriteLine("Summation of 5 is " + result);
    }
}
//end:3
//Summation of 3 is 3
//end:5
//Summation of 5 is 5