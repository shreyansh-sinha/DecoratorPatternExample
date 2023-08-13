using DecoratorPatternExample.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Decorators
{
    public class ExtraCheeseDecorator : BaseDecorator
    {
        private readonly Pizza _pizza;
        public ExtraCheeseDecorator(Pizza pizza) 
        {
            _pizza = pizza;
        }

        public override int Cost()
        {
            return _pizza.Cost() + 10;
        }
    }
}
