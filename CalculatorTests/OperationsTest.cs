using Calculator;
using System;
using Xunit;


namespace CalculatorTests
{
    public class OperationsTest
    {
        
        [Fact]
        public void Sub_20minus10_res10()
        {
            //Arrange
            const double expected = 10;
            //Act
            double actual = Operations.Sub(20, 10);
            //Assert    
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Sum_20plus10_res30()
        {
            //Arrange
            const double expected = 30;
            //Act
            double actual = Operations.Sum(20, 10);
            //Assert    
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Div_20div10_res2()
        {
            //Arrange
            const double expected = 2;
            //Act
            double actual = Operations.Div(20, 10);
            //Assert    
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Multi_20mult10_res200()
        {
            //Arrange
            const double expected = 200;
            //Act
            double actual = Operations.Mul(20, 10);
            //Assert    
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Div_DivideByZero_exception()
        {
            //Arrange
            //Act + Assert 
            Assert.Throws<DivideByZeroException>(() => Operations.Div(20, 0));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(11)]
        public void isOdd_TheoryNotEvet_result(int value)
        {
            Assert.True(Operations.isOdd(value));
        }
    }
}
