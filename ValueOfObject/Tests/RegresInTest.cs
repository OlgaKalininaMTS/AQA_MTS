using System.Net;
using NLog;
using RestSharp;

namespace RestSharpApi.Tests;

public class ReqresInTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger(); // вывод логов

    private const string BaseRestUri = "https://reqres.in";

    [Test]
    public void SimpleGetTest()
    {
        const string endpoint = "/api/users/2";     // 200 Ok
        //const string endpoint = "/api/users/23"; // 404 Not Found

        // Setup Rest Client делаем нового клиента на базовом юрл
        var client = new RestClient(BaseRestUri);

        // Setup Request  настройка нового запроса
        var request = new RestRequest(endpoint);

        // Execute Request  сам запрос
        var response = client.ExecuteGet(request);  //

       // Logger.Debug(response.Content);  
        Logger.Info(response.Content);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));  // 200=ok
    }
    
    [Test]
    public void SimplePostTest()
    {
        const string endpoint = "/api/users";

        // Setup Rest Client
        var client = new RestClient(BaseRestUri);

        // Setup Request
        var request = new RestRequest(endpoint);
        request.AddJsonBody("{\"name\": \"morpheus\",\"job\": \"leader\"}"); //

        // Execute Request
        var response = client.ExecutePost(request);

        Logger.Debug(response.Content);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
    }
    
}