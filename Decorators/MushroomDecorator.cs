using DecoratorPatternExample.Classes;

namespace DecoratorPatternExample.Decorators
{
    public class MushroomDecorator : BaseDecorator
    {
        private readonly Pizza _pizza;

        public MushroomDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override int Cost()
        {
            return _pizza.Cost() + 20;
        }
    }
}
