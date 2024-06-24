using System;
using LoginBL;
using LoginModel;

namespace LoginUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginService loginService = new LoginService();

            Console.WriteLine("Enter Acc num: ");
            int accNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Pin Num: ");
            int pinNum = Convert.ToInt32(Console.ReadLine());

            if (loginService.verifyUser(accNum, pinNum))
            {
                Console.WriteLine("Correct");
            }
            else 
            {
                Console.WriteLine("Error");
                Main(args);
            }
        }
    }
}
