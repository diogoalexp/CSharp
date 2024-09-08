using Basics.Concepts;
using System.Security.AccessControl;

namespace Test.Concepts
{
    public class MembersTest
    {
        [Fact]
        public void Members_Modifiers()
        {
            MembersModifiers membersModifiers = new MembersModifiers() { Required  = 0};

            membersModifiers.Public = 1;

            //Not accessible
            //membersModifiers.Protected = 1;

            //Not accessible
            //membersModifiers.Internal = 1;

            //Not accessible
            //membersModifiers.Protected_Internal = 1;

            //Not accessible
            //membersModifiers.Private = 1;

            //Not accessible
            //membersModifiers.Private_Protected = 1;

            //Cannot be updated
            //membersModifiers.Readonly = 1;

            membersModifiers.Required = 1;

            //Cannot be updated
            //membersModifiers.Const = 1;

            Assert.Equal(1, membersModifiers.Public);
            Assert.Equal(1, membersModifiers.Required);
            Assert.Equal(1, membersModifiers.Readonly);
        }

        [Fact]
        public void Members_Fields()
        {
            MembersFields membersFields = new MembersFields();

            membersFields.Field_SByte = System.SByte.MinValue;
            membersFields.Field_Byte = System.Byte.MinValue;
            membersFields.Field_Int16 = System.Int16.MinValue;
            membersFields.Field_UInt16 = System.UInt16.MinValue;
            membersFields.Field_Int32 = System.Int32.MinValue;
            membersFields.Field_UInt32 = System.UInt32.MinValue;
            membersFields.Field_Int64 = System.Int64.MinValue;
            membersFields.Field_UInt64 = System.UInt64.MinValue;
            membersFields.Field_Float = System.Single.MinValue;
            membersFields.Field_Double = System.Double.MinValue;
            membersFields.Field_Decimal = System.Decimal.MinValue;
            membersFields.Field_Boolean = true;
            membersFields.Field_Char = 'C';
            membersFields.Field_String = "STRING";

            Assert.IsType<SByte>(membersFields.Field_SByte);
            Assert.IsType<Byte>(membersFields.Field_Byte);
            Assert.IsType<Int16>(membersFields.Field_Int16);
            Assert.IsType<UInt16>(membersFields.Field_UInt16);
            Assert.IsType<Int32>(membersFields.Field_Int32);
            Assert.IsType<UInt32>(membersFields.Field_UInt32);
            Assert.IsType<Int64>(membersFields.Field_Int64);
            Assert.IsType<UInt64>(membersFields.Field_UInt64);
            Assert.IsType<Single>(membersFields.Field_Float);
            Assert.IsType<Double>(membersFields.Field_Double);
            Assert.IsType<Decimal>(membersFields.Field_Decimal);
            Assert.IsType<Boolean>(membersFields.Field_Boolean);
            Assert.IsType<Char>(membersFields.Field_Char);
            Assert.IsType<String>(membersFields.Field_String);
        }
    }
}