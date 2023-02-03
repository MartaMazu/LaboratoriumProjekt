namespace Laboratorium4Tests
{
    public class EquationSolverTests
    {
        [Theory]
        [InlineData(1, -5, 6, 3, 2)]
        [InlineData(1, -7, 10, 3, 2)]
        [InlineData(1, 2, -3, 1, -3)]
        public void Solve_PositiveTestCases_ReturnsCorrectRoots(double a, double b, double c, double root1, double root2)
        {
            var result = EquationSolver.Solve(a, b, c);

            Assert.Equal(root1, result.Item1);
            Assert.Equal(root2, result.Item2);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 2, -3)]
        public void Solve_NegativeTestCases_ThrowsException(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => EquationSolver.Solve(a, b, c));
        }
    }
}

