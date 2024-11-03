namespace Basics.Concepts
{
    //you can't use class that is restricted by a modified
    //1. Class
    //2. Internal Class
    //3. SealedClass

    public class InheritanceClassFromPublicClass : PublicClass
    {
        //has all properties from the PublicClass
    }

    public class InheritanceClassFromAbstractClass : AbstractClass
    {
        //has all properties from the AbstracClass
    }

    public class InheritanceClassFromPartialClass : PartialClass
    {
        //has all properties from all the PartialClass(es)
    }
}
