using DecoratorDesignPattern;

IPizza Pizza = new Pizza();

IPizza cheese = new CheeseDecorator(Pizza);
IPizza Onion = new OnionPizza(cheese);
IPizza Mashroom = new  NoMashroomPizza(Onion);
Console.WriteLine(Mashroom.GetPizzaType());

