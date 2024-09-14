namespace Basics.Concepts
{
    public class MembersModifiers
    {
        public int Public; //access is not restricted
        protected int Protected; //access is limited to the class which declares that member and the immediate class which inherits that class
	    internal int Internal; //access is limited to the current assembly not by other assembly
	    protected internal int Protected_Internal; //accessibility is limited to the code in assembly in which it is declared, or from within a drive class in another assembly
        private int Private; //accessibility is limited to the code that are only in containted type
        private protected int Private_Protected;
        public readonly int Readonly = 1; // indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class
        public required int Required; //is used to force client code to initialize any property or field
        const int Consts = 1;  //means unchangeable and read-only
    }

    public class MembersFields
    {
        public sbyte Field_SByte; //The sbyte type represents signed 8-bit integers with values from -128 to 127, inclusive.

        public byte Field_Byte; //The byte type represents unsigned 8-bit integers with values from 0 to 255, inclusive

        public short Field_Int16;//The short type represents signed 16-bit integers with values from -32768 to 32767, inclusive.

        public ushort Field_UInt16;//The ushort type represents unsigned 16-bit integers with values from 0 to 65535, inclusive.

        public int Field_Int32; //The int type represents signed 32-bit integers with values from -2147483648 to 2147483647, inclusive.

        public uint Field_UInt32; //The uint type represents unsigned 32-bit integers with values from 0 to 4294967295, inclusive.

        public long Field_Int64; //The long type represents signed 64-bit integers with values from -9223372036854775808 to 9223372036854775807, inclusive.

        public ulong Field_UInt64; //The ulong type represents unsigned 64-bit integers with values from 0 to 18446744073709551615, inclusive.

        public float Field_Float; //The float type can represent values ranging from approximately 1.5 × 10⁻⁴⁵ to 3.4 × 10³⁸ with a precision of 7 digits.

        public double Field_Double; //The double type can represent values ranging from approximately 5.0 × 10⁻³²⁴ to 1.7 × 10³⁰⁸ with a precision of 15-16 digits.        

        public decimal Field_Decimal; //The decimal type is a 128-bit data type suitable for financial and monetary calculations. The decimal type can represent values including those in the range at least -7.9 × 10⁻²⁸ to 7.9 × 10²⁸, with at least 28-digit precision.

        public bool Field_Boolean; //The bool type represents Boolean logical quantities. The possible values of type bool are true and false. 

        public char Field_Char; //Stores a single character/letter, surrounded by single quotes

        public string Field_String;//Stores a sequence of characters, surrounded by double quotes
    }

    public class MembersProperties //is a a flexible mechanism for classes to expose fields. 
    {
        private string name;

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }

    public enum MembersEnumerations //is a value type defined by a set of named constants
    {
        Option_0,
        Option_1,
        Option_2,
        Option_3
    }

    public struct MembersStructs // is a value type that can encapsulate data and related functionality
    {
        public double X;
        public double Y;
    }

    public class MembersMethods //is usually a code snippet that does a specific task; 
    { 
        public int add(int a, int b)  //two int type Parameters method  
        {
            return a + b;
        }
        public int add(int a, int b, int c)  //three int type Parameters with same method same as above  
        {
            return a + b + c;
        }
    }

    public class MembersToBeOverride
    {
        public virtual int value()
        {
            return 10;
        }
    }
    public class MembersOverride : MembersToBeOverride
    {
        public override int value() //Method overriding is a language feature that allows a class to override a specific implementation of a a base class.
        {
            return 500;
        }
    }

    public class MembersConstructor // is a special method that is used to initialize objects.
    {
        public string name;  // Create a field

        public MembersConstructor() // Create a class constructor for the Car class
        {
            name = "default name"; // Set the initial value for name
        }

        public MembersConstructor(string newValue) // Create a class constructor for the Car class
        {
            name = newValue; // Set the new value for name
        }
    }

}
