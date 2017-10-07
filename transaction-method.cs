using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodArg
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = 30;
            int teacher = 30;
            string msg = Transaction(ref student, ref teacher, 15);
            Console.WriteLine(msg);
            Console.ReadLine();
            msg = Transaction(ref student, ref teacher, 20);
            Console.WriteLine(msg);
            Console.ReadLine();


        }

        public static string Transaction (ref int payer, ref int receiver, int amount)
        {
            if (payer >= amount)
            {
                receiver += amount;
                payer -= amount;
                return "Transaction completed. Teacher's balance is " + receiver + ".";
            }
            else
            {
                return "Error: Insufficient funds.";
            }
        }



    }
}


