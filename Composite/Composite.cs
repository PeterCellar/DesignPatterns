
namespace Composite
{
    public class Composite : Component
    {
        List<Component> children = new List<Component>();

        public Composite(string name) 
            : base(name) { }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach(Component c in children)
            {
                c.Display(depth + 2);
            }
        }
    }
}
