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
            if (Math.Abs(sides[0] - sides[1]) < 0.0001)
                counter++;
            if (Math.Abs(sides[1] - sides[2]) < 0.0001)
                counter++;
            if (Math.Abs(sides[0] - sides[2]) < 0.0001)
                counter++;
            return counter;
        }

        public static bool IsEquilateral(double[] sides)
        {
            return EqualSideCount(sides) == 3;
        }

        public static bool IsRightAngled(double[] sides)
        {
            CheckInput(sides);
            Array.Sort(sides);
            var hypothenuse = Math.Sqrt(Math.Pow(sides[0],2) + Math.Pow(sides[1], 2));
            return Math.Abs(hypothenuse - sides[2]) < 0.0001;
        }

        public static bool IsBluntAngled(double[] sides)
        {
            CheckInput(sides);
            if (IsRightAngled(sides)) return false;
            return Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) < sides[2];
        }

        public static bool IsSharpAngled(double[] sides)
        {
            return false;
        }
    }
}
