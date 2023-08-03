using AplicacaoDesafioDotNet.Server.Config.ServerConfig;
namespace AplicacaoDesafioDotNet.Server;

// Classe principal. core da aplicação para iniciar o servidor.
public class Server
{
    public static string local = "[SERVER-MAIN]";

    //Método Main para inicar a aplicação
    private static void Main(string[] args)
    {
        try
        {
            ServerConfig.BuildWebApp(args);
        } catch (Exception error)
        {
            Console.Error.WriteLine($"{local} - Failed trying to start server: {error}");
            throw new Exception(error.Message);
        }
    }
}
