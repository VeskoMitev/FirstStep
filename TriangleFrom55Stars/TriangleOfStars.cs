namespace TriangleFrom55Stars
{
    using System;
    class TriangleOfStars
    {
        static void Main()
        {
            for (int row = 1; row <= 10; row++)
            {
                string stars = "";
                for (int countStar = 0; countStar < row; countStar++)
                {
                    stars += "*"; 
                }
                Console.WriteLine(stars);
            }
        }
    }
}
