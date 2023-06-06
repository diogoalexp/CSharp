using Basics.Concepts;

namespace Test.Basics
{
    public class ClassTest
    {
        [Fact]
        public void InstanceClassTest()
        {
            //Not accessible
            //Class class = new Class();

            //Not accessible
            //InternalClass internalClass = new InternalClass();

            PublicClass publicClass = new PublicClass();

            //Cannot be created, only inherited
            //AbstracClass abstracClass = new AbstracClass();

            PartialClass partialClass = new PartialClass();

            SealedClass sealedClass = new SealedClass();

            //Cannot be instanced
            //StaticClass staticClass = new StaticClass();    

            Assert.IsType<PublicClass>(publicClass);
            Assert.IsAssignableFrom<PartialClass>(partialClass);
            Assert.IsType<SealedClass>(sealedClass);
        } 
    }
}