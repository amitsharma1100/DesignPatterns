namespace DesignPatterns.Patterns.Singleton
{
    public class Theatre
    {
        private const int rows = 20;
        private const int columns = 20;

        public int[,] seats = new int[20, 20];
    }
}
