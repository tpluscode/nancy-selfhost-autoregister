using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using NancyDependency;
using Owin;

namespace NancyRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            //var type = typeof(IMessageProcessor);

            using (WebApp.Start("http://localhost:17899", builder => builder.UseNancy()))
            {
                Console.WriteLine("started nancy");
                Console.ReadLine();
            }
        }
    }
}
