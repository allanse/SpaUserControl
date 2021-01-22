using SpaUserControl.Domain.Models;
using System;
using SpaUserControl.Domain.Contracts.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaUserControl.Infraestructure.Repositories;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Allan", "allan.stefanin@gmail.com");

            user.SetPassword("allanse", "allanse");
            user.Validate();

            Console.WriteLine(user.Id);

            using (IUserRepository userRep = new UserRepository())
            {
                userRep.Create(user);
            }

            Console.WriteLine(user.Id);

            Console.ReadKey();

        }
    }
}
