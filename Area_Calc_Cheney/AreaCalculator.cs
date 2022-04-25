namespace Area_Calc_Cheney
{
    public static class AreaCalculator 
    {
        public static double getSquareArea(int a){return a*a;}
        public static double getSquareArea(string a)
        {
            a = a.ToLower();
            try
            {
                Dictionary<string, double> map = new Dictionary<string, double>();
                map.Add("one", 1);
                map.Add("two", 2);
                map.Add("three", 3);
                map.Add("four", 4);
                map.Add("five", 5);
                map.Add("six", 6);
                map.Add("seven", 7);
                map.Add("eight", 8);
                map.Add("nine", 9);
                map.Add("ten", 10);


                return map[a] * map[a];
            } catch(Exception) { throw; } 
        }
        public static double getRectangleArea(int a, int b)
        {
            return a * b; 
        }
        public static double getTriangleArea(int a, int b)
        {
            double TA = (a * b) * 0.5;
            return Math.Round((double)TA, 2); 
        }
        public static double getParallelogramArea(int a, int b)
        {
            return a * b;
        }
        public static double getCircleRadius(int a)
        {
            double R = a /2;
            return Math.Round((double)R, 2); 
        }
        public static double getCircleDiameter(int a)
        {
            return a * 2;
        }
    }
}