using Grpc.Net.Client;
using GrpcTeste;
using GrpcTeste.Services;

var channel = GrpcChannel.ForAddress("http://localhost:5080/");

var client = new Greeter.GreeterClient(channel);
var req = new HelloRequest
{
    Name = "Igor"
};

var reply = await client.SayHelloAsync(req);

Console.WriteLine("Saudacao: " + reply.Message);
Console.WriteLine("Pressione qualquer coisa para sair...");
Console.ReadKey();