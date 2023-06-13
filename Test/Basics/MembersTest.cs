using Basics.Concepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test.Basics
{
    public class MembersTest
    {
        [Fact]
        public void CSharpDataTypesTest()
        {
            CSharpDataTypes cSharpDataTypes = new CSharpDataTypes();

            Assert.IsType<bool>(cSharpDataTypes.propertyBool);
            Assert.IsType<char>(cSharpDataTypes.propertyChar);
            Assert.IsType<string>(cSharpDataTypes.propertyString);
            Assert.IsType<byte>(cSharpDataTypes.propertyByte);
            Assert.IsType<sbyte>(cSharpDataTypes.propertySbyte);
            Assert.IsType<decimal>(cSharpDataTypes.propertyDecimal);
            Assert.IsType<double>(cSharpDataTypes.propertyDouble);
            Assert.IsType<float>(cSharpDataTypes.propertyFloat);
            Assert.IsType<int>(cSharpDataTypes.propertyInt);
            Assert.IsType<uint>(cSharpDataTypes.propertyUint);
            Assert.IsType<nint>(cSharpDataTypes.propertyNint);
            Assert.IsType<nuint>(cSharpDataTypes.propertyNunit);
            Assert.IsType<long>(cSharpDataTypes.propertyLong);
            Assert.IsType<ulong>(cSharpDataTypes.propertyUlong);
            Assert.IsType<short>(cSharpDataTypes.propertyShort);
            Assert.IsType<ushort>(cSharpDataTypes.propertyUshor);
        }

        [Fact]
        public void DotNetDataTypesTest()
        {
            CSharpDataTypes cSharpDataTypes = new CSharpDataTypes();

            Assert.IsType<bool>(cSharpDataTypes.propertyBool);
            Assert.IsType<char>(cSharpDataTypes.propertyChar);
            Assert.IsType<string>(cSharpDataTypes.propertyString);
            Assert.IsType<byte>(cSharpDataTypes.propertyByte);
            Assert.IsType<sbyte>(cSharpDataTypes.propertySbyte);
            Assert.IsType<decimal>(cSharpDataTypes.propertyDecimal);
            Assert.IsType<double>(cSharpDataTypes.propertyDouble);
            Assert.IsType<float>(cSharpDataTypes.propertyFloat);
            Assert.IsType<int>(cSharpDataTypes.propertyInt);
            Assert.IsType<uint>(cSharpDataTypes.propertyUint);
            Assert.IsType<nint>(cSharpDataTypes.propertyNint);
            Assert.IsType<nuint>(cSharpDataTypes.propertyNunit);
            Assert.IsType<long>(cSharpDataTypes.propertyLong);
            Assert.IsType<ulong>(cSharpDataTypes.propertyUlong);
            Assert.IsType<short>(cSharpDataTypes.propertyShort);
            Assert.IsType<ushort>(cSharpDataTypes.propertyUshor);
        }

        [Fact]
        public void EnumerationTest()
        {
            Enumeration season = Enumeration.Winter;

            EnumerationValues weekend = EnumerationValues.Weekend;

            Assert.NotEqual(Enumeration.Summer, season);
            Assert.NotEqual(EnumerationValues.Saturday, weekend);
        }

        [Fact]
        public void StructureTest()
        {
            Structure structure = new Structure(1,2);

            Assert.Equal(structure.ToString(), $"({1}, {2})");
        }

        [Fact]
        public void FunctionsTest()
        {
            Functions functions = new Functions();


            //Assert.Equal(functions.noReturnFunction(), void); -- cannot compare voids
            Assert.IsType<bool>(functions.returnFunction());
            Assert.True(functions.paramFunction(true));
            Assert.False(functions.paramFunction(false));
            Assert.IsType<string>(functions.typedFunction<string>("test"));
        } 
    }
}
