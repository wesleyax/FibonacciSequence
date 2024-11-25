namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonccini = new int[14];
            fibonccini[0] = 0;
            fibonccini[1] = 1;
            int aux = 0;

            for (int i = 2; i < 14; i++) {
                fibonccini[i] = fibonccini[i-2] + aux;
                aux = fibonccini[i];
                Console.WriteLine(fibonccini[i]);
            }
            Console.ReadKey();
        }
    }
}
