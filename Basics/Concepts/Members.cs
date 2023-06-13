using System.ComponentModel;
using System.Xml.Linq;

namespace Basics.Concepts
{
    public class CSharpDataTypes
    {
        //type variableName = value;
        public bool    propertyBool = false;
        public char    propertyChar = '\0';
        public string  propertyString = "value";
         
        public byte    propertyByte = 0; //0 to 255
        public sbyte   propertySbyte = 0; //-128 to 127
         
        public decimal propertyDecimal = 0.1M; //±1.0 x 10-28 to ±7.9228 x 1028 (28-29 digits)
        public double  propertyDouble = 0.1; //±5.0 × 10−324 to ±1.7 × 10308 (~15-17 digits)
        public float   propertyFloat = 0.1F; //	±1.5 x 10−45 to ±3.4 x 1038 (~6-9 digits)
         
        public int     propertyInt = 0; //-2,147,483,648 to 2,147,483,647
        public uint    propertyUint = 0; //0 to 4,294,967,295
        public nint    propertyNint = 0; //Signed 32-bit or 64-bit integer - Depends on platform (computed at runtime)
        public nuint   propertyNunit = 0; //Unsigned 32-bit or 64-bit integer - Depends on platform (computed at runtime)
        public long    propertyLong = 0; //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        public ulong   propertyUlong = 0; //0 to 18,446,744,073,709,551,615
        public short   propertyShort = 0; //-32,768 to 32,767
        public ushort  propertyUshor = 0; //0 to 65,535
    }

    public class DotNetDataTypes
    {
        //sytem.type variableName = value;
        public System.Boolean propertyBool = false;
        public System.Char propertyChar = '\0';
        public System.String propertyString = "value";
         
        public System.Byte propertyByte = 0;
        public System.SByte propertySbyte = 0;
         
        public System.Decimal propertyDecimal = 0;
        public System.Double propertyDouble = 0;
        public System.Single propertyFloat = 0;
         
        public System.Int32 propertyInt = 0;
        public System.UInt32 propertyUnit = 0;
        public System.IntPtr propertyNint = 0;
        public System.UIntPtr propertyNunit = 0;
        public System.Int64 propertyLong = 0;
        public System.UInt64 propertyUlong = 0;
        public System.Int16 propertyShort = 0;
        public System.UInt16 propertyUshor = 0;
    }

    class DataModifiers
    {
	    public bool propertyPublic; //access is not restricted
        protected bool propertyProtected;//access is limited to the class which declares that member and the immediate class which inherits that class

        internal bool propertyInternal;//access is limited to the current assembly not by other assembly
        protected internal bool propertyProtectedInternal;//accessibility is limited to the code in assembly in which it is declared, or from within a drive class in another assembly
        private bool propertyPrivate; //accessibility is limited to the code that are only in containted type

        private protected bool propertyPrivateProtected;// 
        readonly bool propertyReadonly;//indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class
        public required bool propertyRequired; //is used to force client code to initialize any property or field
        const bool propertyConst = true;  //means unchangeable and read-only
    }


    public enum Enumeration
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public enum EnumerationValues
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
        Weekend = Saturday | Sunday
    }

    public struct Structure
    {
        public Structure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"({X}, {Y})";
    }

    public class Functions
    {

        public Functions()
        {
            //constructor is a special function to define how de class should be created.
        }

        public void noReturnFunction ()
        {

        }

        public bool returnFunction()
        {
            return true;
        }

        public bool paramFunction(bool param)
        {
            return param;
        }

        public T typedFunction<T>(T param)
        {
            return param;
        }
    }


}
