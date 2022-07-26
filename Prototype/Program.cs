
/*
    Prototype design pattern specifies the kind of objects to create using a prototypical instance,
    and create new objects by copying this prototype.

    Participants
        Prototype          : declares an interface for cloning itself
        Concrete Prototype : implements an operation for cloning itself
        Client             : creates a new object by asking a prototype to clone itself
 */

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
           ColorManager manager = new ColorManager();

            manager["red"] = new Color(255, 0, 0);
            manager["green"] = new Color(0, 255, 0);
            manager["blue"] = new Color(0, 0, 255);
            
            // User adds personalized colors
            manager["angry"] = new Color(255, 54, 0);
            manager["peace"] = new Color(128, 211, 128);
            manager["flame"] = new Color(211, 34, 20);

            Color color1 = manager["red"].Clone() as Color;
            Color color2 = manager["peace"].Clone() as Color;
            Color color3 = manager["flame"].Clone() as Color;

            Console.ReadKey();
        }
    }
}