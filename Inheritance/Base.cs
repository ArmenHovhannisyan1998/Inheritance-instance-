﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Base
    {
        public string publicfield = "BaseClass Public_field";
        private string privatefield = "BaseClass Private_field";
        protected string protectedfield = "BaseClass Protected_field";
        public void Show()
        {
            Console.WriteLine(privatefield);
        }

    }
}

