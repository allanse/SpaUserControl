using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaUserControl.Domain.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Allan", "allanstefanin@gmail.com", "allanse");

            Console.WriteLine(user.Name);
            Console.ReadKey();
        }
    }
}
