using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMAdvancedC_DotNet.RestClient
{
    internal class RestClientService
    {
        private readonly RestClient _restClient= new Uri("https://localhost:7225/api/Blog");
        private readonly string _blogEndpoint= "api/Blog";
    }
}
