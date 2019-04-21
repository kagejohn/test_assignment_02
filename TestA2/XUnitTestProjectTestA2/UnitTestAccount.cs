using System;
using System.Linq.Expressions;
using System.Threading;
using TestA2;
using Xunit;

namespace XUnitTestProjectTestA2
{
    public class UnitTestAccount
    {
        /*"Implement tests for the following method:
                public double calculateYearlyInterest(Account account)"*/
        [Theory]
        [InlineData(-0.01, 0)]
        [InlineData(0.00, 3)]
        [InlineData(0.01, 3)]
        [InlineData(50, 3)]
        [InlineData(99.99, 3)]
        [InlineData(100, 3)]
        [InlineData(100.01, 5)]
        [InlineData(500, 5)]
        [InlineData(999.99, 5)]
        [InlineData(1000, 5)]
        [InlineData(1000.01, 7)]
        [InlineData(int.MaxValue, 7)]
        [InlineData(long.MaxValue, 7)]
        public void Test1(decimal balance, int interestRate)
        {
            Account account = new Account
            {
                Balance = balance
            };

            Assert.Equal(interestRate, account.InterestRate);
        }

        //"Implement test that uses at least 8 different assertions"
        [Fact(DisplayName = "Test2 new name", Timeout = 500, Skip = "Disable the “8 different assertions test” with annotation and verify the test has been disabled")]
        public void Test2()
        {
            Thread.Sleep(8000);//the timeout limit doesn't work for some reason

            Account account = new Account
            {
                Balance = 500
            };

            Assert.Equal(5, account.InterestRate);
            Assert.False(0 == account.InterestRate);
            Assert.NotEqual(0, account.InterestRate);
            Assert.True(5 == account.InterestRate);
            Assert.IsType<int>(account.InterestRate);
            Assert.StrictEqual(5, account.InterestRate);
            Assert.StartsWith("5", account.InterestRate.ToString());
            Assert.EndsWith("5", account.InterestRate.ToString());

            //"Use assertAll for the “8 different assertions” test"
            //that method is not a thing

            //"Set up an random Boolean and an assumption that the Boolean is true in the “8 different assertions“ test and verify the test skips when the assumption is not met"
            //Assert.Equal(0, new Random().Next(2));

            //this gives an error: "Cannot convert lambda expression to type 'IEnumerable<char>' because it is not a delegate type"
            //Assert.Equal("Test", () => { Console.WriteLine("Test"); return "Test";});
        }
    }
}
