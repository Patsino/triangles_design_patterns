namespace triangles.EntityClasses.Entities
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }


        //public override bool Equals(object obj)
        //{
        //    if (obj == null || GetType() != obj.GetType())
        //    {
        //        return false;
        //    }

        //    Point other = (Point)obj;
        //    return X == other.X && Y == other.Y;
        //}

        // Переопределение метода GetHashCode() для хэширования точек
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
