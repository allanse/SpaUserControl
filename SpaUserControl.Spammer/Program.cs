using System;
using System.Globalization;
using System.Threading;
using SpaUserControl.Domain.Contracts.Services;
using SpaUserControl.Startup;
using Unity;

namespace SpaUserControl.Spammer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Idioma
            CultureInfo ci = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IUserService>();
            try
            {
                service.Register("Allan", "allanstefanin@gmail.com", "allanse", "allanse");
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                service.Dispose();
            }

            Console.ReadKey();

        }
    }
}
