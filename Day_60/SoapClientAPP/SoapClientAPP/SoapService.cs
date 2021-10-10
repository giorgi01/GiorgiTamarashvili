using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoapClientAPP
{
    public class SoapService
    {
        private Service1Client _client;
        public SoapService(Service1Client client)
        {
            _client = client;
        }

        public string Get(int a)
        {
           return _client.GetData(a);
        }
    }
}
