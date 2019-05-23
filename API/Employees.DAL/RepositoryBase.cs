using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Employees.DAL
{
    public class RepositoryBase
    {
        private HttpClient ClientHttp { get; set; }
        private string Url { get; set; }
        public RepositoryBase()
        {
            ClientHttp = new HttpClient();
            ClientHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Url = $"http://masglobaltestapi.azurewebsites.net/api/employees";
        }

        public HttpResponseMessage ExecuteGet()
        {
            HttpResponseMessage response = ClientHttp.GetAsync(Url).Result;
            return response;
        }
    }
}
