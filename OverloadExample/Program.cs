namespace OverloadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circleArea = Area(5); 
            Console.WriteLine("Çevrənin sahəsi: " + circleArea);

            // 2. Düzbucaqlının sahəsi
            double rectangleArea = Area(4, 6); 
            Console.WriteLine("Düzbucaqlının sahəsi: " + rectangleArea);

            // 3. Düzbucaqlı paralelpipedin tam səth sahəsi
            double parallelepipedArea = Area(3, 4, 5); // 
            Console.WriteLine("Paralelpipedin səthi: " + parallelepipedArea);

            // 4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi
            double triangleInCircleArea = Area(3.0, 4.0, 5.0, 2.0); 
            Console.WriteLine("Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi: " + triangleInCircleArea);
        }

        // 1. Overload - Çevrənin sahəsi: S = p * r^2
        public static double Area(double r)
        {
            double p = 3.14;
            return p * r * r;
        }

        // 2. Overload - Düzbucaqlının sahəsi: S = a * b
        public static double Area(double a, double b)
        {
            return a * b;
        }

        // 3. Overload - Paralelpipedin səthi: S = 2(a*b + a*c + b*c)
        public static double Area(double a, double b, double c)
        {
            return 2 * (a * b + a * c + b * c);
        }

        // 4. Overload - Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi: S = p * r, p = (a + b + c) / 2
        public static double Area(double a, double b, double c, double r)
        {
            double p = (a + b + c) / 2;
            return p * r;
        }
    }
    
}
