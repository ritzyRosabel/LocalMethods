using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Methods
{
    class Program
    {
        //If this code works, then it was writen by Rosabel Olugbenga. If it doesn't, then i can only say one thing  "IT IS WHAT IT IS".
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
