using TicTacToe.ViewModels;

namespace TicTacToeUnitTests.ViewModels
{
    public class AboutViewModelUnitTests
    {

        [Fact]
        public void AboutViewModel_Constructor()
        {
            var vm = new AboutViewModel();

            Assert.NotNull(vm);
        }

        

    }
}
