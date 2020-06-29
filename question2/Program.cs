using System;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        { 

           string stairSet = "#";
           int stairSet1 = int.Parse(stairSet);
            string UserInput = Console.ReadLine();
        int setStaircaseSize = int.Parse(UserInput); 
            for (int i = 0; i < setStaircaseSize; i++)
            {
                stairSet1 ++; 
               Console.WriteLine(stairSet1);

                //int setStaircaseSize



            }


        }
    }
}
