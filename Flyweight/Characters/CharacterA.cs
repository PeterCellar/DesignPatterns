
namespace Flyweight.Characters
{
    public class CharacterA : Character
    {
        // A concrete Flyweight class
        public CharacterA()
        {
            symbol = 'A';
            height = 100;
            width = 120;
            ascent = 70;
            descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(symbol + " (pointsize " + this.pointSize + ")");
        }
    }
}
