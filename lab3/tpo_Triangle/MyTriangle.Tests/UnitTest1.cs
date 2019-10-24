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
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(3,4,5),"������ �������� �������������� ������������");
        }
        [Fact]
        public void equilateralTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(3, 3, 3), "������ �������� ��������������� ������������");
        }
        [Fact]
        public void unrealTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(3, 3, 1), "������ �������� ��������������� ������������");
        }
        [Fact]
        public void withOneNegativeTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(-7, 8, 9), "������ �������� ������������ � 1-�� ������������� ��������");
        }
        [Fact]
        public void withTwoNegativeTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(-6, -7, 8), "������ �������� ������������ � 2-�� �������������� ���������");
        }
        [Fact]
        public void withThreeNegativeTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(-6, -7, -8), "������ �������� ������������ � 3-�� �������������� ���������");
        }
        [Fact]
        public void withOneZeroTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(0, 6, 7), "������ �������� ������������ � 1-�� ������� ��������");
        }
        [Fact]
        public void withTwoZeroTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(0, 0, 7), "������ �������� ������������ � 2-�� �������� ��������");
        }
        [Fact]
        public void withThreeZeroTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(0, 0, 0), "������ �������� ������������ � 3-�� �������� ��������");
        }
        [Fact]
        public void withOneNegativeAndOneZeroTriangle()
        {
            Assert.True(tpo_Triangle.MyTriangle.isTriangle(-3, 0, 3), "������ �������� ������������ � 1-�� ������������� � 1-�� ������� ��������");
        }
    }
}
