
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class NoMashroomPizza:PizzaDecorator
    {
        public NoMashroomPizza(IPizza pizza):base(pizza) { }

        public override string GetPizzaType()
        {
            var type  = base.GetPizzaType();
            type += "\r\n  and with  no Mashroom 😜 ";
            return type;
        }

    }
}
