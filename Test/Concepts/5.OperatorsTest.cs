using Basics.Concepts;

namespace Test.Concepts
{
    public class OperatorsTest
    {
        #region Arithmetic
        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(10, 5, 15)]
        public void additionTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.addition(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        public void subtractionTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.subtraction(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(10, 5, 50)]
        public void multiplicationTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.multiplication(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(10, 5, 2)]
        public void divisionTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.division(x, y), expected);
        }

        [Theory]
        [InlineData(3, 4, 3)]
        [InlineData(8, 3, 2)]
        public void modulusTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.modulus(x, y), expected);
        }

        [Theory]
        [InlineData(5, 3, 6)] //0101 & 0011 will result with 0110
        [InlineData(2, 10, 8)] //0010 & 1010 will result with 1000
        public void xorTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.xor(x, y), expected);
        }

        [Theory]
        [InlineData(3, 2, 2)] //0011 & 0010 will result with 0010
        [InlineData(11, 6, 2)] //1011 & 0110 will result with 0010
        public void andTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.and(x, y), expected);
        }

        [Theory]
        [InlineData(3, 2, 3)] //0011 & 0010 will result with 0011
        [InlineData(11, 6, 15)] //1011 & 0110 will result with 1111
        public void orTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.or(x, y), expected);
        }

        [Theory]
        [InlineData(32, 2, 8)] //10000 > 2 will result with 00100
        [InlineData(32, 3, 4)] //10000 > 3 will result with 00010
        public void rightShiftTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.rightShift(x, y), expected);
        }

        [Theory]
        [InlineData(2, 2, 8)] //00010 < 2 will result with 01000
        [InlineData(2, 3, 16)] //00010 < 3 will result with 10000
        public void leftShiftTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.leftShift(x, y), expected);
        }

        [Theory]
        [InlineData(2, 3)] //increment than return
        [InlineData(4, 5)]
        public void incrementFirstTest(int x, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.incrementFirst(x), expected);
        }

        [Theory]
        [InlineData(2, 2)] //return than increment
        [InlineData(4, 4)]
        public void incrementLaterTest(int x, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.incrementLater(x), expected);
        }

        [Theory]
        [InlineData(2, 1)] //decrement than return
        [InlineData(4, 3)]
        public void decrementFirstTest(int x, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.decrementFirst(x), expected);
        }

        [Theory]
        [InlineData(2, 2)] //decrement than return
        [InlineData(4, 4)]
        public void decrementLaterTest(int x, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.decrementLater(x), expected);
        }
        #endregion Arithmetic

        #region Assigment
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        public void assigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.assigment(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(10, 5, 15)]
        public void additionAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.additionAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        public void subtractionAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.subtractionAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(10, 5, 50)]
        public void multiplicationAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.multiplicationAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(10, 5, 2)]
        public void divisionAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.divisionAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(3, 4, 3)]
        [InlineData(8, 3, 2)]
        public void modulusAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.modulusAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(5, 3, 6)] //0101 & 0011 will result with 0110
        [InlineData(2, 10, 8)] //0010 & 1010 will result with 1000
        public void xorAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.xorAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(3, 2, 2)] //0011 & 0010 will result with 0010
        [InlineData(11, 6, 2)] //1011 & 0110 will result with 0010
        public void andAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.andAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(3, 2, 3)] //0011 & 0010 will result with 0011
        [InlineData(11, 6, 15)] //1011 & 0110 will result with 1111
        public void orAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.orAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(32, 2, 8)] //10000 > 2 will result with 00100
        [InlineData(32, 3, 4)] //10000 > 3 will result with 00010
        public void rightShiftAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.rightShiftAssigment(x, y), expected);
        }

        [Theory]
        [InlineData(2, 2, 8)] //00010 < 2 will result with 01000
        [InlineData(2, 3, 16)] //00010 < 3 will result with 10000
        public void leftShiftAssigmentTest(int x, int y, int expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.leftShiftAssigment(x, y), expected);
        }
        #endregion Assigment

        #region Comparison
        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(5, 5, true)]
        public void EqualTest(int x, int y, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.Equal(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(5, 5, false)]
        public void NotEqualTest(int x, int y, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.NotEqual(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(4, 5, false)]
        [InlineData(5, 5, false)]
        public void GreaterThanTest(int x, int y, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.GreaterThan(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(4, 5, true)]
        [InlineData(5, 5, false)]
        public void LessThanTest(int x, int y, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.LessThan(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(4, 5, false)]
        [InlineData(5, 5, true)]
        public void GreaterThanOrEqualTest(int x, int y, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.GreaterThanOrEqual(x, y), expected);
        }

        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(4, 5, true)]
        [InlineData(5, 5, true)]
        public void LessThanOrEqualTest(int x, int y, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.LessThanOrEqual(x, y), expected);
        }

        [Theory]
        [InlineData(true, false, false)]
        [InlineData(false, false, false)]
        [InlineData(false, true, false)]
        [InlineData(true, true, true)]
        public void AndTest(bool x, bool y, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.And(x, y), expected);
        }

        [Theory]
        [InlineData(true, false, true)]
        [InlineData(false, false, false)]
        [InlineData(false, true, true)]
        [InlineData(true, true, true)]
        public void OrTest(bool x, bool y, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.Or(x, y), expected);
        }

        [Theory]
        [InlineData(false, true)]
        [InlineData(true, false)]
        public void NotTest(bool x, bool expected)
        {
            Operators operators = new Operators();

            Assert.Equal(operators.Not(x), expected);
        }
        #endregion Compsarison
    }
}
