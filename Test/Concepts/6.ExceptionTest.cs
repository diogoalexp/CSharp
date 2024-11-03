using Basics.Concepts;
using System.Security.AccessControl;

namespace Test.Concepts
{
    public class ExceptionTest
    {
        [Fact]
        public void Exception_Throw()
        {
            Exeptions exeptions = new Exeptions();

            Assert.Throws<Exception>(() => exeptions.ThrowException());
        }

        [Fact]
        public void Exception_Throw_Value()
        {
            Exeptions exeptions = new Exeptions();

            try
            {
                exeptions.ThrowException();
            }
            catch (Exception e)
            {

                Assert.Contains("First Value", e.Message);
                Assert.Contains("Second Value", e.Message);
            }
        }
    }
}