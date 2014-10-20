using System;

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, 
//long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number
//to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual Studio project as part of your
//homework submission.
class Variables
{
    static void Main()
    {
        ushort people = 52130;
        sbyte degrees = -115;
        int distance = 4825932;
        byte seats = 97;
        short profit = -10000;
        Console.WriteLine("This is ushort type variable: {0}\nThis is sbyte type variable: {1}\nThis is int type variable: {2}\nThis is byte type variable: {3}\nThis is short type variable: {4}",people,degrees,distance,seats,profit);
    }
}
