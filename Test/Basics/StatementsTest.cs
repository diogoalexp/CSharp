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
    public class StatementsTest
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void IfStatementTest(bool x, bool expected)
        {
            Statements statements = new Statements();

            Assert.Equal(statements.IfStatement(x), expected);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        [InlineData(null, null)]
        public void IfElseStatementTest(bool? x, bool? expected)
        {
            Statements statements = new Statements();

            Assert.Equal(statements.IfElseStatement(x), expected);
        }

        [Theory]
        [InlineData(3, "123")]
        [InlineData(5, "12345")]
        public void foorStatementTest(int x, string expected)
        {
            Statements statements = new Statements();

            Assert.Equal(statements.foorStatement(x), expected);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, "123")]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, "12345")]
        public void foorEachStatementTest(int[] x, string expected)
        {
            Statements statements = new Statements();

            Assert.Equal(statements.foorEachStatement(x), expected);
        }

        [Theory]
        [InlineData(3, "123")]
        [InlineData(5, "12345")]
        public void whileStatementStatementTest(int x, string expected)
        {
            Statements statements = new Statements();

            Assert.Equal(statements.whileStatement(x), expected);
        }

        [Theory]
        [InlineData(3, "123")]
        [InlineData(5, "12345")]
        public void doWhileStatementTest(int x, string expected)
        {
            Statements statements = new Statements();

            Assert.Equal(statements.doWhileStatement(x), expected);
        }

        [Theory]
        [InlineData(1, "first")]
        [InlineData(2, "second")]
        [InlineData(3, "other")]
        public void switchStatementTest(int x, string expected)
        {
            Statements statements = new Statements();

            Assert.Equal(statements.switchStatement(x), expected);
        }

        [Theory]
        [InlineData(5, 2, 4, "13")]
        [InlineData(5, 1, 5, "234")]
        public void breakAndContinueStatementTest(int x, int y, int z, string expected)
        {
            Statements statements = new Statements();

            Assert.Equal(statements.breakAndContinueStatement(x,y,z), expected);
        }
    }
}
