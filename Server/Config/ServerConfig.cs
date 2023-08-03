using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using AplicacaoDesafioDotNet.RoutesView;
using AplicacaoDesafioDotNet.Server.DatabaseConfig.Database;
using AplicacaoDesafioDotNet.RoutesTransaction;
using Microsoft.AspNetCore.Builder;
using System;
namespace AplicacaoDesafioDotNet.Server.Config.ServerConfig
{
    // Classe responsável por configurar rotas, iniciar o builder webapp e chamar a conexão com banco de dados
    public class ServerConfig
    {
        public static string local = "[SERVER-CONFIG]";

        // Método estático e public acessivel para o arquivo server.cs consiga iniciar o app sem
        // necessidade de criar uma instancia do tipo ServerConfig
        public static void BuildWebApp(string[] args)
        {
            try
            {
                var builder = WebApplication.CreateBuilder(args);
                var app = builder.Build();
                ConfigureMiddlewares(app);
                app.Run();
            }
            catch (Exception error)
            {
                Console.Error.WriteLine($"{local} - Falha ao tentar criar aplicativo da web: {error}");
                throw new Exception(error.Message);
            }
        }

        // Método privado acessivel somente a classe ServerConfig para de fato realizar as configurações do servidor
        private static void ConfigureMiddlewares(IApplicationBuilder app)
        {
            try
            {
                app.UseRouting();
                app.UseStaticFiles();
                if (Database.Client != null)
                {
                    app.UseEndpoints(endpoints =>
                    {
                        try
                        {
                            RoutesAPIView.MapRoutes(endpoints);
                            TransactionsAPI.MapRoutes(endpoints);
                        }
                        catch (Exception error)
                        {
                            Console.Error.Write($"Falha ao tentar definir rotas: {error}");
                            throw new Exception(error.Message);
                        }
                    });
                }
                else
                {
                    Console.Error.WriteLine("O servidor não pode iniciar se o banco de dados não estiver conectado.");
                }
            }
            catch (Exception error)
            {
                Console.Error.WriteLine($"{local} - Falha ao tentar configurar os middlewares do servidor: {error}");
                throw new Exception(error.Message);
            }
        }
    }
}