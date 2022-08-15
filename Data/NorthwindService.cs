using System.Text.Json;

namespace HolyGrailGridsLocalEndPoint.Northwind
{
    public class NorthwindService
    {
        private readonly IWebHostEnvironment _env;

        public NorthwindService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<EmployeesType[]?> GetEmployees()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var data = File.ReadAllText(_env.WebRootPath + "/static-data/northwind-employees.json");
            return await Task.FromResult(JsonSerializer.Deserialize<EmployeesType[]>(data, options));
        }
    }
}