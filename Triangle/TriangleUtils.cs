using System;

namespace Triangle
{
    public static class TriangleUtils
    {
        private static void CheckInput(double[] sides)
        {
            if (sides.Length != 3)
                throw new ArgumentException("This function takes array with 3 sides only.");
            foreach (var side in sides)
                if (side <= 0)
                    throw new ArgumentException("Side must have length > 0");
        }

        public static bool IsTriangle(double[] sides)
        {
            CheckInput(sides);
            return sides[0] + sides[1] > sides[2] &&
                sides[1] + sides[2] > sides[0] &&
                sides[0] + sides[2] > sides[1];
        }

        public static int EqualSideCount(double[] sides)
        {
            CheckInput(sides);
            var counter = 0;
            if (Math.Abs(sides[0] - sides[1]) > 0.0001)
                counter++;
            if (Math.Abs(sides[1] - sides[2]) > 0.0001)
                counter++;
            if (Math.Abs(sides[0] - sides[2]) > 0.0001)
                counter++;
            return counter;
        }
    }
}
