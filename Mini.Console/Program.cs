
using Mini.Classes;

namespace Mini.Console
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            System.Console.Out.WriteLine("Minimalizando... Wait!");
            Minificador.Executar(args);

            System.Console.ReadKey();
        }
    }
}