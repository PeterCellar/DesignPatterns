
/*
    Flyweight design pattern uses sharing to support large number of fine-grained objects efficiently

    Participants
        Flyweight                   : declares an interface through which flyweights can recieve and act on extrinsic state
        Concrete Flyweight          : implements the flyweight itnerface and adds storage for intrinsic state. A concrete flyweight object
                                      must by sharable. Any state it stores must be intrinsic -> must be independent of the concrete flyweight
                                      objects context
        Unshared Concrete Flyweight : not all flyweight subclasses need to be shared. The flyweight interface enables sharing, but it doesnt enforce it
        Flyweight Factory           : creates an manages flyweight objects. Ensures that flyweights are shared properly. When a client requests
                                      a flyweight, the FlyweightFactory objects asset an existing instance or creates one, if none exists.
        Client                      : maintains a reference to flyweights, computes or stores the extrinsic state of flyweights
 */

using Flyweight.Characters;

namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string document = "AAZBBZ";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach(char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            Console.ReadKey();
        }
    }
}