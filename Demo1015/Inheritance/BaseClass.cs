using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseClass
    {
        //fields
        private int basePrivateInt;
        protected int baseProtectedInt;

        // constructors
        public BaseClass() { }
        public BaseClass(int privateInt, int protectedInt)
        {
            this.basePrivateInt = privateInt;
            this.baseProtectedInt = protectedInt;
        }

        // methods
        public void BaseMethod()
        {
            Console.WriteLine("BaseClass.BaseMethod");

        }

        
        public virtual void PrintState()
        {
            Console.WriteLine("BaseClass Object");
            Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            Console.WriteLine("\tbaseProtectedInt: {0}", baseProtectedInt);
        }
    }
}
