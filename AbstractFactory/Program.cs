using System;

/*
    The Abstract factory design patter provides an interface 
    for creating families of related or dependent objects
    without specifying their concrete class.
    
    Participants
        Abstract Factory : declares an interface for operations that create abstract products
        Concrete Factory : implements the operations to create concrete product objects
        Abstract Product : declares an interface for a type of product object
        Product          : defines a product object to be created by the corresponing concrete factory
        Client           : uses interface declared by Abstract Factory and Abstract Product classes
 */
namespace AbstractFactory 
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
}