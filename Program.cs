namespace Z1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paczka paczka = new Paczka("ekonomiczna", 2,5,10);
            Console.WriteLine(paczka.ToString());
        }
    }
}
