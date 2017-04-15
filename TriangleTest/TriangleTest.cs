using System;
using Xunit;
using Triangle;

namespace TriangleTest
{
    public class TriangleTest
    {
        [Fact]
        public void TestIsTriangleTrue()
        {
            var sides = new double[] { 3, 4, 5 };
            Assert.True(TriangleUtils.IsTriangle(sides));
        }

        [Fact]
        public void TestIsTriangleFalse()
        {
            var sides = new double[] { 1, 2, 5 };
            Assert.False(TriangleUtils.IsTriangle(sides));
        }

        [Fact]
        public void TestIsTriangleBadInput()
        {
            var sides = new double[] { -1, 4 };
            try
            {
                TriangleUtils.IsTriangle(sides);
                Assert.True(false, "Exception not thrown");
            }
            catch (ArgumentException)
            {
                //Test pass
            }
        }


        [Fact]
        public void TestEqualSideCount1()
        {
            var sides = new double[] { 4, 2, 3 };
            Assert.Equal(0, TriangleUtils.EqualSideCount(sides));
        }

        [Fact]
        public void TestEqualSideCount2()
        {
            var sides = new double[] { 4, 4, 3 };
            Assert.Equal(1, TriangleUtils.EqualSideCount(sides));
        }

        [Fact]
        public void TestEqualSideCount3()
        {
            var sides = new double[] { 4, 4, 4 };
            Assert.Equal(3, TriangleUtils.EqualSideCount(sides));
        }

        [Fact]
        public void TestEqualSideCountBadInput()
        {
            var sides = new double[] { -1, 2 };
            try
            {
                TriangleUtils.EqualSideCount(sides);
                Assert.True(false, "Exception not thrown");
            }
            catch (ArgumentException)
            {
                //Test pass
            }
        }


        [Fact]
        public void TestIsEquilateralTrue()
        {
            var sides = new double[] { 3, 3, 3 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsEquilateralFalse()
        {
            var sides = new double[] { 2, 2, 3 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsEquilateralBadInput()
        {
            var sides = new double[] { -1, 4 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsRightAngledTrue()
        {
            var sides = new double[] { 3, 4, 5 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsRightAngledFalse()
        {
            var sides = new double[] { 3, 4, 6 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsRightAngledBadInput()
        {
            var sides = new double[] { -1, 2 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsBluntAngledTrue()
        {
            var sides = new double[] { 6, 3, 8 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsBluntAngledFalse()
        {
            var sides = new double[] { 4, 4, 3 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsBluntAngledBadInput()
        {
            var sides = new double[] { -1, 2 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsSharpAngledTrue()
        {
            var sides = new double[] { 4, 4, 3 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsSharpAngledFalse()
        {
            var sides = new double[] { 6, 3, 8 };
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestIsSharpAngledBadInput()
        {
            var sides = new double[] { -1, 2 };
            Assert.True(false, "Not implemented");
        }
    }
}
