
namespace Mini.Console
{
    public class Program
    {
        public static void Minimalizar(string[] args)
        {
            var origem = string.Empty; //Recebe o nome do arquivo de origem
            var destino = string.Empty; // recebe o nome do arquivo de destino

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/o=")) //se o argumento iniciar com /o indica o arquivo de origem
                {
                    origem = args[i].Split("=")[1];
                }
                else if (args[i].StartsWith("/d=")) //senão, iniciando com /d, indica o arquivo de destino
                {
                    destino = args[i].Split("=")[1];
                }
            }

            var dadosOrigem = File.ReadAllText(origem); //lê os arquivos de origem
            var dadosDestino = dadosOrigem.Replace(Environment.NewLine, ""); //remove as quebras de linha
            dadosDestino = string.Join(" ", dadosDestino.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)); //retira espaços desnecessários
            File.WriteAllText(destino, dadosDestino); //escreve a versão minimalizada no arquivo de destino
        }

        static void Main(string[] args)
        {
            
            System.Console.Out.WriteLine("Minimalizando... Wait!");
            Minimalizar(args);

            System.Console.ReadKey();
        }
    }
}