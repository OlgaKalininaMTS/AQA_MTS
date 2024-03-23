using System.Net;
using NLog;
using System.Text.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpApi.Models;

namespace RestSharpApi.Tests.Api;

public class TestRailSimpleTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    private const string BaseRestUri = "https://aqa2504.testrail.io/";
    /*
        [Test]
        public void SimpleGetTest()
        {
            const string endpoint = "index.php?/api/v2/get_user/1";

            var options = new RestClientOptions(BaseRestUri)
            {
                Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")  // авторизация
            };

            var client = new RestClient(options);  // передаем опции - авторизацию

            var request = new RestRequest(endpoint);  //

            var response = client.ExecuteGet(request);  // отправляем запрос

            Logger.Debug(response.Content);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void AdvancedGetTest()
        {
            const string endpoint = "index.php?/api/v2/get_user/{user_id}";

            var options = new RestClientOptions(BaseRestUri)
            {
                Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
            };

            var client = new RestClient(options);

            var request = new RestRequest(endpoint)
                .AddUrlSegment("user_id", 1);   // "index.php?/api/v2/get_user/1" в ендпоинте вместо 1 подставляем user_id

            var response = client.ExecuteGet(request);

            Logger.Debug(response.Content);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]   // post запрос
        public void SimplePostTest()
        {
            const string endpoint = "index.php?/api/v2/add_project";

            Dictionary<string, object> json = new Dictionary<string, object>();
            json.Add("name", "WP Project 2");  // обязательное
            json.Add("announcement", "Test project's description");
            json.Add("show_announcement", true);
            json.Add("suite_mode", 3);  // необязательное поле, без него тест отработает корректно

            var options = new RestClientOptions(BaseRestUri)   // авторизация
            {
                Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
            };


            // Тип содержимого RestSharp по умолчанию будет использовать правильный тип контента. 
           //  Не добавляйте заголовок Content-Type вручную. Вашим запросам, если вы не абсолютно уверены, что это необходимо. 
           //  Вы можете добавить собственный тип контента к самому параметру body.


            var client = new RestClient(options);

                var request = new RestRequest(endpoint)
                    .AddJsonBody(JsonSerializer.Serialize(json));

                var response = client.ExecutePost(request);

               Logger.Info(response.Content);

               Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));


            // Преобразуем тело ответа в объект JSON
            dynamic responseObject = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);

                // Получаем значение поля "id"
                int id = responseObject!.id;  // ! - проверяем что id не null

                // Используем значение "id" по своему усмотрению
                Console.WriteLine($"Значение поля 'id': {id}");

             //   Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            }
    */
    [Test]
    public void AdvancedPostTest()
    {
        const string endpoint = "index.php?/api/v2/add_project";

        Project expectedProject = new Project
        {
            Name = "WP Project 2",
            Announcement = "Test project description",
            IsShowAnnouncement = true,
            SuiteMode = 2
        };

        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };

        // Setup Rest Client
        var client = new RestClient(options);

        // Setup Request
        var request = new RestRequest(endpoint).AddJsonBody(expectedProject);

        // Execute Request
        var response = client.ExecutePost<Project>(request);
        Project actualProject = response.Data;

        Logger.Info(actualProject);

        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            Assert.That(actualProject.Name, Is.EqualTo(expectedProject.Name));

            Assert.That(actualProject.Equals(expectedProject));
        });

        // Получаем значение поля "id"
        int id = actualProject.Id;

        // Используем значение "id" по своему усмотрению
        Logger.Info($"Значение поля 'id': {id}");
    }
}