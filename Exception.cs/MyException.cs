using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home20.Exception.cs
{
    internal class MyException:Exception
    {
        public MyException(string meesaage) :base(meesaage)
        { 
        
        }
    }
}
