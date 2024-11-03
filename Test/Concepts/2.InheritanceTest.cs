using Basics.Concepts;
using System.Security.AccessControl;

namespace Test.Concepts
{
    public class InheritanceTest
    {
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