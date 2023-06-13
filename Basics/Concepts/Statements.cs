namespace Basics.Concepts
{
    public class Statements
    {
        public bool IfStatement(bool param)
        {
            if (param == true)
                return true;

            return false;
        }

        public bool? IfElseStatement(bool? param)
        {
            if (param == true)
                return true;
            else if (param == false)
                return false;

            return null;
        }

        public string foorStatement(int loop)
        {
            string result = "";
            for (int counter = 1; counter <= loop; counter++)
            {
                result = result + counter.ToString();
            }
            return result;
        }

        public string foorEachStatement(int[] collection)
        {
            string result = "";
            foreach (var item in collection)
            {
                result = result + item.ToString();
            }
            return result;
        }

        public string whileStatement(int loop)
        {
            string result = "";
            int counter = 0;
            while (counter < loop)
            {
                counter++;
                result = result + counter.ToString();
            }
            return result;
        }

        public string doWhileStatement(int loop)
        {
            string result = "";
            int counter = 0;
            do
            {
                counter++;
                result = result + counter.ToString();
            } while (counter < loop);
            return result;
        }

        public string switchStatement(int expression)
        {
            string result = "";
            switch (expression)
            {
                case 1:
                    result = "first";
                    break;
                case 2:
                    result = "second";
                    break;
                default:
                    result = "other";
                    break;
            }
            return result;
        }

        public string breakAndContinueStatement(int loop, int skipParam, int breakParam)
        {
            string result = "";
            for (int counter = 1; counter <= loop; counter++)
            {
                if (counter == skipParam)
                {
                    continue; //skips the interation
                }
                if (counter == breakParam)
                {
                    break; //jump out of the loop
                }
                result = result + counter.ToString();
            }

            return result;
        }
    }
}
