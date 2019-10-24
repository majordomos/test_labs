using System;
using Xunit;
using tpo_Triangle;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MyTriangle.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void rectangularTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(3,4,5),"Ошибка проверки прямоугольного треугольника");
        }
        [Fact]
        public void equilateralTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(3, 3, 3), "Ошибка проверки равностороннего треугольника");
        }
        [Fact]
        public void unrealTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(3, 3, 1), "Ошибка проверки несуществующего треугольника");
        }
        [Fact]
        public void withOneNegativeTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(-7, 8, 9), "Ошибка проверки треугольника с 1-ой отрицательной стороной");
        }
        [Fact]
        public void withTwoNegativeTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(-6, -7, 8), "Ошибка проверки треугольника с 2-мя отрицательными сторонами");
        }
        [Fact]
        public void withThreeNegativeTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(-6, -7, -8), "Ошибка проверки треугольника с 3-мя отрицательными сторонами");
        }
        [Fact]
        public void withOneZeroTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(0, 6, 7), "Ошибка проверки треугольника с 1-ой нулевой стороной");
        }
        [Fact]
        public void withTwoZeroTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(0, 0, 7), "Ошибка проверки треугольника с 2-мя нулевыми стороной");
        }
        [Fact]
        public void withThreeZeroTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(0, 0, 0), "Ошибка проверки треугольника с 3-мя нулевыми стороной");
        }
        [Fact]
        public void withOneNegativeAndOneZeroTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(-3, 0, 3), "Ошибка проверки треугольника с 1-ой отрицательной и 1-ой нулевой стороной");
        }
    }
}
