using ServiceReference1;
using System;

namespace CalculatorWrapper
{
    public class CalculatorService
    {
        private CalculatorSoapClient _client;
        public CalculatorService(CalculatorSoapClient client)
        {
            _client = client;
        }

        public int Add(int a, int b)
        {
            //var client = new ServiceReference1.CalculatorSoapClient(ServiceReference1.CalculatorSoapClient.EndpointConfiguration.CalculatorSoap, "");
            var result = _client.AddAsync(a, b).Result;
            return result;
        }
    }
}
