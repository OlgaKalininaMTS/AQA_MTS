using System.Net;
using System.Threading.Tasks;
using TestRailComplexApi.ApiTesting;

namespace TestRailComplexApi.Services;

public interface IProjectService
{
    Task<Project> GetProject(string projectId);  // т.к. у нас асинхронность, то пишем Task (результат запроса)
    Task<Projects> GetProjects();
    Task<Project> AddProject(Project project);
    Task<Project> UpdateProject(Project project);
    HttpStatusCode DeleteProject(string projectId);
}