using MasGlobal.Contracts;
using MasGlobal.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace MasGlobal.Service.Layers
{
    public class ApiEmployeeClient : IApiEmployeeClient
    {
        private readonly IRestClient restClient;


        public ApiEmployeeClient(IRestClient restClient)
        {
            this.restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));
        }

        public async Task<IEnumerable<Employee>> Get()
        {
            var request = new RestRequest("http://masglobaltestapi.azurewebsites.net/api/Employees", Method.GET);

            request.RequestFormat = DataFormat.Json;

            var tcs = new TaskCompletionSource<IRestResponse>();

            restClient.ExecuteAsync(request, (response) =>
            {
                if (response.ErrorException != null)
                {
                    tcs.TrySetException(response.ErrorException);
                }
                else if (response.StatusCode == HttpStatusCode.OK)
                {
                    tcs.TrySetResult(response);
                }

            });

            var clientResponse = await tcs.Task;
            var responseDto = JsonConvert.DeserializeObject<List<Employee>>(clientResponse.Content);

            return responseDto;
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }



    }
}
