namespace Employee_Attandance
{
    public class Line
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public Line(double x1, double y1, double x2, double y2)
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Line otherLine = (Line)obj;
            return CalculateLength() == otherLine.CalculateLength();
        }

        public override int GetHashCode()
        {
            return CalculateLength().GetHashCode();
        }
    }

    public class LineEqualityChecker
    {
        public static void EqualityOfLines()
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

            Line line1 = new Line(x1, y1, x2, y2);

            Console.WriteLine("Enter the coordinates of the second line (x1, y1, x2, y2):");
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Line line2 = new Line(x1, y1, x2, y2);

            if (line1.Equals(line2))
            {
                Console.WriteLine("The lines are equal.");
            }
            else
            {
                Console.WriteLine("The lines are not equal.");
            }
        }
    }
}
