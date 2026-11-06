namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1;   
            double b = 2;
            double c = 3;
            double x = 4;

            double y = (2.0 / 5.0) * a * Math.Sqrt(Math.Abs(x))   
                     + b * Math.Log(Math.Abs(x * x - 1) + 1)     
                     + c * Math.Cos(x);                           

            Console.WriteLine(y);
        }
    }
}
