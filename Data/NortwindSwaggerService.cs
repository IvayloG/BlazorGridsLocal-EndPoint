using System.Net.Http.Json;

namespace HolyGrailGridsLocalEndPoint.NortwindSwagger
{
    public class NortwindSwaggerService
    {
        private readonly HttpClient http;

        public NortwindSwaggerService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<EmployeesType[]?> GetEmployees()
        {
            using HttpResponseMessage response = http.GetAsync("https://appbuilder-public.s3.amazonaws.com/northwind/employees").Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<EmployeesType[]>().ConfigureAwait(false);
            }

            return null;
        }
    }
}