using Basics.Concepts;
using System.Security.AccessControl;

namespace Test.Concepts
{
    public class ClassTest
    {
        [Fact]
        public void Class_Instance()
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

        [Fact]
        public void Inheritance_Instance()
        {   
            InheritanceClassFromPublicClass inheritanceClassFromPublicClass = new InheritanceClassFromPublicClass();
                        
            InheritanceClassFromAbstractClass inheritanceClassFromAbstractClass = new InheritanceClassFromAbstractClass();
            
            InheritanceClassFromPartialClass inheritanceClassFromPartialClass = new InheritanceClassFromPartialClass();

            Assert.IsAssignableFrom<PublicClass>(inheritanceClassFromPublicClass);
            Assert.IsAssignableFrom<AbstractClass>(inheritanceClassFromAbstractClass);
            Assert.IsAssignableFrom<PartialClass>(inheritanceClassFromPartialClass);
        }
    }
}