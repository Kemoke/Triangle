using System;

namespace Triangle
{
    public static class TriangleUtils
    {
        public static bool IsTriangle(double[] sides)
        {
            if (sides.Length != 3)
                throw new ArgumentException("This function takes array with 3 sides only.");
            foreach (var side in sides)
                if (side <= 0)
                    throw new ArgumentException("Side must have length > 0");
            return sides[0] + sides[1] > sides[2] &&
                sides[1] + sides[2] > sides[0] &&
                sides[0] + sides[2] > sides[1];
        }
    }
}
