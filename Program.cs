// See https://aka.ms/new-console-template for more information
using DecoratorPatternExample.Classes;
using DecoratorPatternExample.Decorators;

Console.WriteLine("Hello, World!");

Margarita margarita= new();

var margaritaWithExtraCheese = new ExtraCheeseDecorator(margarita);
Console.WriteLine(margaritaWithExtraCheese.Cost());

var pizzaWithMushroomTopping = new MushroomDecorator(margaritaWithExtraCheese);
Console.WriteLine(pizzaWithMushroomTopping.Cost());

