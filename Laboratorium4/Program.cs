namespace Program
{
    public class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                var result = EquationSolver.Solve(1, -5, 6);
                Console.WriteLine($"{nameof(result.Item1)}: {result.Item1}");
                Console.WriteLine($"{nameof(result.Item2)}: {result.Item2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            Console.ReadLine();
        }
    }
}

public static class EquationSolver
{
   
    public static Tuple<double, double> Solve(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            throw new Exception("Równanie nie posiada pierwiastków rzeczywistych.");
        }
        else if (delta == 0)
        {
            return new Tuple<double, double>((-b) / (2 * a), double.NaN);
        }
        else
        {
            return new Tuple<double, double>((-b + Math.Sqrt(delta)) / (2 * a), (-b - Math.Sqrt(delta)) / (2 * a));
        }
    }
}