using System;

namespace question_3
{
    class Program
    {
int n; 



        void calculateResult(){
               int n = int.Parse(Console.ReadLine());
            if (n == 1 || n == 3 || n == 5 || n == 7 || n == 9 ) {
                (n *3) + 1;
                Console.WriteLine(n);  
            }
            else if (n == 2 || n == 4 || n == 6 || n == 8 || n == 10){

                n / 2; 
            }
            else {
                Console.WriteLine("Invalid option entered"); 
            }



        }


        static void Main(string[] args)
        { 
        
        Program p = new Program();
        p.calculateResult(); 
            
        }
    }
}
