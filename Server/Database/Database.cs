using MongoDB.Driver;
using System.Net.NetworkInformation;

namespace AplicacaoDesafioDotNet.Server.DatabaseConfig.Database;

// Classe responsável por conectar em uma instancia local do mongodb
public class Database
{
    public static MongoClient Client { get; set; } = StartConnection();

    // Método public e estátivo que é atribuido ao Client(tipo MongoClient) para referenciar o banco de dados 
    // e a collection certa
    public static MongoClient StartConnection()
    {
        string local = "[DB-CONNECTION]";
        try
        {
            string databaseUrl = "mongodb://localhost:27017/DesafioDotNet";
            Client = new MongoClient(databaseUrl);
            Console.WriteLine($"{local} - Connected.");
            return Client;
        }
        catch (Exception error)
        {
            Console.Error.WriteLine($"{local} - Falha ao tentar iniciar a conexão: {error}");
            throw new Exception(error.Message);
        }
    }
}
