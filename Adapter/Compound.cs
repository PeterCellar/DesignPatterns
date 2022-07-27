
namespace Adapter
{

    // Target class
    public class Compound
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;

        public virtual void Display()
        {
            Console.WriteLine("Compound: Unknown -------");
        }
    }
}
