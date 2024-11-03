namespace Basics.Concepts
{
    public class Operators
    {
        #region Arithmetic
        public int addition(int x, int y)
        {
            return x + y;
        }

        public int subtraction(int x, int y)
        {
            return x - y;
        }

        public int multiplication(int x, int y)
        {
            return x * y;
        }

        public int division(int x, int y)
        {
            return x / y;
        }

        public int modulus(int x, int y)
        {
            return x % y;
        }

        public int xor(int x, int y)
        {
            return x ^ y;
        }

        public int and (int x, int y)
        {
            return x & y;
        }

        public int or (int x, int y)
        {
            return x | y;
        }

        public int rightShift (int x, int y)
        {
            return x >> y;
        }

        public int leftShift(int x, int y)
        {
            return x << y;
        }

        public int incrementLater(int x)
        {
            return x++;
        }

        public int incrementFirst(int x)
        {
            return ++x;
        }

        public int decrementLater(int x)
        {
            return x--;
        }

        public int decrementFirst(int x)
        {
            return --x;
        }
        #endregion Arithmetic

        #region Assigment
        public int assigment(int x, int y)
        {
            x = y;
            return x;
        }

        public int additionAssigment(int x, int y)
        {
            return x += y;
        }

        public int subtractionAssigment(int x, int y)
        {
            return x -= y;
        }

        public int multiplicationAssigment(int x, int y)
        {
            return x *= y;
        }

        public int divisionAssigment(int x, int y)
        {
            return x /= y;
        }

        public int modulusAssigment(int x, int y)
        {
            return x %= y;
        }

        public int xorAssigment(int x, int y)
        {
            return x ^ y;
        }

        public int andAssigment(int x, int y)
        {
            return x &= y;
        }

        public int orAssigment(int x, int y)
        {
            return x |= y;
        }

        public int rightShiftAssigment(int x, int y)
        {
            return x>>=y;
        }

        public int leftShiftAssigment(int x, int y)
        {
            return x <<= y;
        }
        #endregion Assigment

        #region Comparison
        public bool Equal(int x, int y)
        {
            return x == y;
        }

        public bool NotEqual(int x, int y)
        {
            return x != y;
        }

        public bool GreaterThan(int x, int y)
        {
            return x > y;
        }

        public bool LessThan(int x, int y)
        {
            return x < y;
        }

        public bool GreaterThanOrEqual(int x, int y)
        {
            return x >= y;
        }

        public bool LessThanOrEqual(int x, int y)
        {
            return x <= y;
        }

        public bool And (bool x, bool y)
        {
            return x && y;
        }

        public bool Or (bool x, bool y)
        {
            return x || y;
        }

        public bool Not(bool x)
        {
            return !x;
        }
        #endregion Compsarison

    }
}
