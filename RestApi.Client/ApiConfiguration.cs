using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Client
{
    public class ApiConfiguration : IApiConfiguration
    {
        public string Url { get; set; }

        public int Timeout { get; set; }

        public ApiConfiguration()
        {
            Url = "http://localhost:7061";
            Timeout = 60;
        }
    }
}
