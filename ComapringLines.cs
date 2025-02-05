namespace Employee_Attandance
{
    public class Lines : IComparable<Lines>
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public Lines(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public double CalculateLength()
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }

        public int CompareTo(Lines other)
        {
            if (other == null)
            {
                return 1; 
            }

            double thisLength = CalculateLength();
            double otherLength = other.CalculateLength();

            if (thisLength < otherLength)
            {
                return -1; 
            }
            else if (thisLength > otherLength)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class LineComparison
    {
        public static void ComparingLines()
        {
            Console.WriteLine("Enter the coordinates of the first line (x1, y1, x2, y2):");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Lines line1 = new Lines(x1, y1, x2, y2);

            Console.WriteLine("Enter the coordinates of the second line (x1, y1, x2, y2):");
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Lines line2 = new Lines(x1, y1, x2, y2);

            int comparisonResult = line1.CompareTo(line2);

            if (comparisonResult < 0)
            {
                Console.WriteLine("The first line is shorter than the second line.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first line is longer than the second line.");
            }
            else
            {
                Console.WriteLine("The lines are equal in length.");
            }
        }
    }
}
