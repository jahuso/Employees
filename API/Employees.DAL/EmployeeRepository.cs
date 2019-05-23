using Employees.DAL.Interface;
using Employees.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DAL
{
    public class EmployeeRepository:RepositoryBase, IEmployeeRepository
    {
        private HttpClient ClientHttp { get; set; }
        private string Url { get; set; }
        private List<Employee> lista = new List<Employee>();
        public EmployeeRepository()
        {

        }


        public async Task<List<Employee>> Get()
        {
            HttpResponseMessage response = this.ExecuteGet();
            if (response.IsSuccessStatusCode)
            {
                lista = await response.Content.ReadAsAsync<List<Employee>>();
            }
            return lista;
        }

        public Employee GetById(int id)
        {
            this.Get();
            return lista.FirstOrDefault(x => x.id.Equals(id));
        }
     }
}
