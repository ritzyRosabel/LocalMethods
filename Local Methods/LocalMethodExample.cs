﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Methods
{
   public  class LocalMethodExample
    {
        public static void InstanceLocalMethod() 
        {
            int x = 7;
            Console.WriteLine( Cal());
            int Cal ()  => x * x;
        }
        

    }
}
