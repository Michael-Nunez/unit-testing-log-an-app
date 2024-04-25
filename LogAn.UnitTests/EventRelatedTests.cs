using NSubstitute;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class EventRelatedTests
    {
        [Test]
        public void ctor_WhenViewIsLoaded_CallsViewRender()
        {
            var mockView = Substitute.For<IView>();

            var p = new Presenter(mockView);
            mockView.Loaded += Raise.Event<Action>();

            mockView.Received().Render(Arg.Is<string>(s => s.Contains("Hello World")));
        }
    }
}