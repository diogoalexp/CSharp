namespace Basics.Concepts
{
    public static class Delegates
    {
        // define a method that returns sum of two int numbers 
        static int calculateSum(int x, int y)
        {
            return x + y;
        }

        // define a delegate
        public delegate int myDelegate(int num1, int num2);

        public static int StartDelegate()
        {
            // create an instance of delegate by passing method name 
            myDelegate instanceOfDelegate = new myDelegate(calculateSum);

            // calling calculateSum() using delegate
            int result = instanceOfDelegate(1, 1);

            return result;
        }
    }
}
