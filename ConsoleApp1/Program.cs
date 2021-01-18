using SpaUserControl.Domain.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Allan", "allanstefanin@gmail.com");

            try
            {
                user.SetPassword("allanse", "allanse");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(user.Name);
            Console.WriteLine(user.Password);

            var password  = user.ResetPassword();
            Console.WriteLine(password);
            Console.WriteLine(user.Password);

            Console.ReadKey();
        }
    }
}
