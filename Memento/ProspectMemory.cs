
namespace Memento
{
    // The Caretaker class
    public class ProspectMemory
    {
        Memento memento;

        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
