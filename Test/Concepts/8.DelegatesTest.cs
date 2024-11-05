using Basics.Concepts;

namespace Test.Concepts
{
    public class DelegatesTest
    {
        [Fact]
        public void Deletegates_Start()
        {
            var expected_result = 2;

            var result = Delegates.StartDelegate();

            Assert.Equal(expected_result, result);
        }
    }
}
