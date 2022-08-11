using Classtask.metod;
using System;

namespace Classtask
{
    class Program
    {
        static void Main(string[] args)
        {
            User Lemusha = new User();
            Console.WriteLine("UserName");
            Lemusha.UserName = Console.ReadLine();
            Console.WriteLine("Password");
            Lemusha.Password = Console.ReadLine();
        }
    }
}
