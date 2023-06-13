using Basics.Concepts;
using System.Security.Claims;

namespace Test.Basics
{
    public class ClassTest
    {
        [Fact]
        public void DefaultInternalClassTest()
        {
            //Not accessible
            //Class class = new Class();
        }

        [Fact]
        public void InternalClassTest()
        {
            //Not accessible
            //InternalClass internalClass = new InternalClass();
        }

        [Fact]
        public void PublicClassTest()
        {
            PublicClass publicClass = new PublicClass();

            Assert.IsType<PublicClass>(publicClass);
        }

        [Fact]
        public void AbstractClassClassTest()
        {
            //Cannot be created, only inherited
            //AbstracClass abstracClass = new AbstracClass();

            ParentClass parentClass = new ParentClass();

            ParentFromAbstractClass parentFromAbstractClass = new ParentFromAbstractClass();

            Assert.IsType<ParentClass>(parentClass);
            Assert.IsType<ParentFromAbstractClass>(parentFromAbstractClass);
            Assert.IsAssignableFrom<AbstractClass>(parentFromAbstractClass);
        }

        [Fact]
        public void PartialClassTest()
        {
            PartialClass partialClass = new PartialClass();

            Assert.IsAssignableFrom<PartialClass>(partialClass);
        }

        [Fact]
        public void SealedClassTest()
        {
            SealedClass sealedClass = new SealedClass();

            Assert.IsType<SealedClass>(sealedClass);
        }

        [Fact]
        public void ParentClassTest()
        {
            ParentClass parentClass = new ParentClass();

            ParentFromAbstractClass parentFromAbstractClass = new ParentFromAbstractClass();
            
            Assert.IsType<ParentFromAbstractClass>(parentFromAbstractClass);
            Assert.IsAssignableFrom<AbstractClass>(parentFromAbstractClass);
        }

        [Fact]
        public void IStaticClassTest()
        {
            //Cannot be instanced
            StaticClass.staticMethod();

        }

        [Fact]
        public void InterfaceClassTest()
        {
            ClassDefinedByInterface classDefinedByInterface = new ClassDefinedByInterface();
            //Cannot be instanced
            //StaticClass staticClass = new StaticClass();    
            classDefinedByInterface.MethodToImplement();

            Assert.IsType<ClassDefinedByInterface>(classDefinedByInterface);
        }
    }
}