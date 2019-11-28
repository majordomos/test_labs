using System;
using Xunit;
namespace Unit_Tests
{
    public class Triangle_Tests
    {
        [Fact]
        public void IsPossible_RectangularTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(3, 4, 5), "Error: non rectangular triangle!");
        }
        [Fact]
        public void IsPossible_EquilateralTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(3, 3, 3), "Error: non equilateral triangle!");
        }
        [Fact]
        public void IsPossible_UnrealTriangle()
        {
            Assert.True(Triangle.Triangle.IsPossible(3, 3, 20), "Error: such triangle can't exists!");
        }
        [Fact]
        public void IsPossible_WithOneNegativeSide()
        {
            Assert.True(Triangle.Triangle.IsPossible(-7, 8, 9), "Error: triangle has one negative side!");
        }
        [Fact]
        public void IsPossible_WithTwoNegativeSides()
        {
            Assert.True(Triangle.Triangle.IsPossible(-6, -7, 8), "Error: triangle has two negative sides!");
        }
        [Fact]
        public void IsPossible_AllNegativeSides()
        {
            Assert.True(Triangle.Triangle.IsPossible(-6, -7, -8), "Error: triangle has all negative sides!");
        }
        [Fact]
        public void IsPossible_WithOneZeroSide()
        {
            Assert.True(Triangle.Triangle.IsPossible(0, 6, 7), "Error: triangle has one zero side!");
        }
        [Fact]
        public void IsPossible_WithTwoZeroSides()
        {
            Assert.True(Triangle.Triangle.IsPossible(0, 0, 7), "Error: triangle has two zero sides!");
        }
        [Fact]
        public void IsPossible_AllNullSides()
        {
            Assert.True(Triangle.Triangle.IsPossible(0, 0, 0), "Error: triangle has all zero sides!");
        }
        [Fact]
        public void IsPossible_WithNegativeAndZeroSides()
        {
            Assert.True(Triangle.Triangle.IsPossible(-3, 0, 3), "Error: triangle has one negative and one zero side!");
        }
    }
}
