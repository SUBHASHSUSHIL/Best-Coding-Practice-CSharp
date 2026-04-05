using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Console
{
    public class PetrolEngine : IEngine
    {
        public void Run()
        {
            System.Console.WriteLine("Petrol engine running");
        }
    }
}
