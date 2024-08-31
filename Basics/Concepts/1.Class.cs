using System.ComponentModel;

namespace Basics.Concepts
{
    class Class //this is a Class
    {
        //Internal by default
    }

    internal class InternalClass
    {
        //Internal types or members are accessible only within files in the same assembly
    }

    public class PublicClass 
    {
        //Accessible everywhere
    }

    public abstract class AbstracClass
    {
        //cannot be used to create objects (to access it, it must be inherited from another class).
    }

    public partial class PartialClass
    {
        //You can implement the functionality of a single class into multiple files, and these files should have the same name as the class, and all these files are combined into one class when the application is compiled.
    }

    public partial class PartialClass
    {
        //You can implement the functionality of a single class into multiple files, and these files should have the same name as the class, and all these files are combined into one class when the application is compiled.
    }

    public sealed class SealedClass
    {
        //is a class that cannot be inherited and used to restrict the properties. Once the class is Sealed then it can’t be inherited. 
    }

    public static class StaticClass
    {
        //is similar to a class that is both abstract and sealed. The difference between a static class and a non-static class is that a static class cannot be instantiated or inherited.
    }
}

