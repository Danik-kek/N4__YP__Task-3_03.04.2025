namespace N4__YP__Task_3_03._04._2025
{
    internal class Program
    {
        static void Main()
        {
            int A1 = 1;
            int A2 = 20;
            int A3 = 2;
            double C = 100;
            for (int X = A1; X <= A2; X += A3)
            {
                double X_cubed = Math.Pow(X, 3);
                double Y;
                if (X_cubed <= C)
                {
                    Y = X_cubed - C;
                }
                else
                {
                    Y = Math.Cbrt(X_cubed + C); // Кубический корень
                }
                Console.WriteLine($"X = {X}, Y = {Y}");
            }
        }
    }
}
