using CalculatorLogic;
using System;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.Equal(3, x);
        }

        [Fact]
        //checks with negative value
        public void Addingnegativevaluewithdecimal()
        {
            var x = new Calculator().Sum(1.6, -2);
            Assert.Equal(-0.4, x);
        }

        [Fact]
        //checks with decimal value
        public void AddingDecimalvalue()
        {
            var x = new Calculator().Sum(2.6, -2);
            Assert.Equal(0.6, x);
        }
        [Fact]
        //checks with decimal value
        public void Addingwithdecimalvalue()
        {
            var x = new Calculator().Sum(1.6, 2);
            Assert.Equal(3.6, x);
        }
        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.Equal(6, x);
        }
        [Fact]
        public void multiplywithnegativevalue()
        {
            var x = new Calculator().Multiply(3, -2);
            Assert.Equal(x, -6);
        }
        [Fact]
        public void multiplywithallnegativevalue()
        {
            var x = new Calculator().Multiply(-3, -2);
            Assert.Equal(6, x);
        }
        [Fact]
        public void multiplywithdecimalvalue()
        {
            var x = new Calculator().Multiply(3.5, 2);
            Assert.Equal(7, x);
        }
        [Fact]
        public void multiplywithnegativeanddecimalvalue()
        {
            var x = new Calculator().Multiply(3.5, -2);
            Assert.Equal(-7, x);
        }
        [Fact]
        public void ShouldSubtractNumber()
        {
            var x = new Calculator().Subtract(3, 2);
            Assert.Equal(1, x);
        }
        [Fact]
        public void SubtractwithnegativeNumber()
        {
            var x = new Calculator().Subtract(3, -2);
            Assert.Equal(5, x);
        }
        [Fact]
        public void SubtractwithallNumber()
        {
            var x = new Calculator().Subtract(-3, -2);
            Assert.Equal(-1, x);
        }
        [Fact]
        public void SubtractwithdecimalNumber()
        {
            var x = new Calculator().Subtract(3.2, 2);
            Assert.Equal(1.2, x);
        }
        [Fact]
        public void SubtractwithallnegativedecimalNumber()
        {
            var x = new Calculator().Subtract(-3.2, -2);
            Assert.Equal(-1.2, x);
        }
        [Fact]
        public void SubtractwithnegativedecimalNumber()
        {
            var x = new Calculator().Subtract(-3.2, 2);
            Assert.Equal(-5.2, x);
        }
        [Fact]
        public void ShouldDividetwoNumber()
        {
            var x = new Calculator().Divide(6, 2);
            Assert.Equal(3, x);
        }
        [Fact]
        public void ShouldDividelesserNumber()
        {
            var x = new Calculator().Divide(3, 20);
            Assert.Equal(0.15, x);
        }
        [Fact]
        public void ShouldDividelnegativeNumber()
        {
            var x = new Calculator().Divide(6, -2);
            Assert.Equal(-3, x);
        }
        [Fact]
        public void ShouldDividebothnegativeNumber()
        {
            var x = new Calculator().Divide(-6, -2);
            Assert.Equal(3, x);
        }
    }
}
