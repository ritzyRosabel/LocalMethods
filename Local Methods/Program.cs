using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalMethodExample localMethod = new LocalMethodExample();
            localMethod.InstanceLocalMethod();
            //49

            localMethod.StaticLocalMethod();
            //49
           
            Console.ReadLine();

        }
    }
}
