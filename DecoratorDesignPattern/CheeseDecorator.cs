using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class CheeseDecorator:PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            
            var type =  base.GetPizzaType();
            type += "\r\n  with  extra Cheese 😋";
            return type;
                
        }

    }
}
