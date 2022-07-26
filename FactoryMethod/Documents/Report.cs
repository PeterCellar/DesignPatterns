using FactoryMethod.Pages;

namespace FactoryMethod.Documents
{
    class Report : Document
    {
        // Factory method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ConclusionPage());
        }
    }
}
