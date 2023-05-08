using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class OnionPizza:PizzaDecorator
    {
        public OnionPizza(IPizza pizza):base(pizza)
        {

        }
        public override string GetPizzaType()
        {
            var type= base.GetPizzaType();
            type += "\r\n  and with  extra Onion 😘";
            return type;
        }
    }
}
