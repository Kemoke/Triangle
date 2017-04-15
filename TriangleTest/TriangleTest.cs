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
            Assert.True(TriangleUtils.IsEquilateral(sides));
        }

        [Fact]
        public void TestIsEquilateralFalse()
        {
            var sides = new double[] { 2, 2, 3 };
            Assert.False(TriangleUtils.IsEquilateral(sides));
        }

        [Fact]
        public void TestIsEquilateralBadInput()
        {
            var sides = new double[] { -1, 4 };
            try
            {
                TriangleUtils.IsEquilateral(sides);
                Assert.True(false, "Exception not thrown");
            }
            catch (ArgumentException)
            {
                //Test pass
            }
        }

        [Fact]
        public void TestIsRightAngledTrue()
        {
            var sides = new double[] { 3, 4, 5 };
            Assert.True(TriangleUtils.IsRightAngled(sides));
        }

        [Fact]
        public void TestIsRightAngledFalse()
        {
            var sides = new double[] { 3, 4, 6 };
            Assert.False(TriangleUtils.IsRightAngled(sides));
        }

        [Fact]
        public void TestIsRightAngledBadInput()
        {
            var sides = new double[] { -1, 2 };
            try
            {
                TriangleUtils.IsRightAngled(sides);
                Assert.True(false, "Exception not thrown");
            }
            catch (ArgumentException)
            {
                //Test pass
            }
        }

        [Fact]
        public void TestIsBluntAngledTrue()
        {
            var sides = new double[] { 10, 10, 19 };
            Assert.True(TriangleUtils.IsBluntAngled(sides));
        }

        [Fact]
        public void TestIsBluntAngledFalse()
        {
            var sides = new double[] { 4, 4, 3 };
            Assert.False(TriangleUtils.IsBluntAngled(sides));
        }

        [Fact]
        public void TestIsBluntAngledBadInput()
        {
            var sides = new double[] { -1, 2 };
            try
            {
                TriangleUtils.IsBluntAngled(sides);
                Assert.True(false, "Exception not thrown");
            }
            catch (ArgumentException)
            {
                //Test pass
            }
        }

        [Fact]
        public void TestIsSharpAngledTrue()
        {
            var sides = new double[] { 4, 4, 3 };
            Assert.True(TriangleUtils.IsSharpAngled(sides));
        }

        [Fact]
        public void TestIsSharpAngledFalse()
        {
            var sides = new double[] { 10, 10, 19 };
            Assert.False(TriangleUtils.IsSharpAngled(sides));
        }

        [Fact]
        public void TestIsSharpAngledBadInput()
        {
            var sides = new double[] { -1, 2 };
            try
            {
                TriangleUtils.IsSharpAngled(sides);
                Assert.True(false, "Exception not thrown");
            }
            catch (ArgumentException)
            {
                //Test pass
            }
        }
    }
}
