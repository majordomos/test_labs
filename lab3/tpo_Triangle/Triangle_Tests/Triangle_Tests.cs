using System;
using Xunit;
namespace Unit_Tests
{
    public class Triangle_Tests
    {
        [Fact]
        public void RectangularTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(3, 4, 5), "Error: non rectangular triangle!");
        }
        [Fact]
        public void EquilateralTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(3, 3, 3), "Error: non equilateral triangle!");
        }
        [Fact]
        public void UnrealTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(3, 3, 1), "Error: such triangle can't exists!");
        }
        [Fact]
        public void WithOneNegativeTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(-7, 8, 9), "Error: triangle has one negative side!");
        }
        [Fact]
        public void WithTwoNegativeTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(-6, -7, 8), "Error: triangle has two negative sides!");
        }
        [Fact]
        public void WithThreeNegativeTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(-6, -7, -8), "Error: triangle has three negative sides!");
        }
        [Fact]
        public void WithOneZeroTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(0, 6, 7), "Error: triangle has one zero side!");
        }
        [Fact]
        public void WithTwoZeroTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(0, 0, 7), "Error: triangle has two zero sides!");
        }
        [Fact]
        public void WithThreeZeroTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(0, 0, 0), "Error: triangle has three zero sides!");
        }
        [Fact]
        public void WithOneNegativeAndOneZeroTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(-3, 0, 3), "Error: triangle has one negative and one zero side!");
        }
    }
}
