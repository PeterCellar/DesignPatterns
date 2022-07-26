using FactoryMethod.Pages;

namespace FactoryMethod.Documents
{
    class Resume : Document
    {
        // Factory method implementation
        public override void CreatePages()
        {
            Pages.Add(new EducationPage());
        }
    }
}
