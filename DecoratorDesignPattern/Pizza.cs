using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "this is a normal pizza";
        }
    }
}
