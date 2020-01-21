using System.ComponentModel.DataAnnotations;
using AspNetCore3.ApiDocs.Responses;
using Swashbuckle.AspNetCore.Filters;

namespace AspNetCore3.ApiDocs.Requests
{
    public class EchoRequest
    {
        public string Echo { get; set; }
    }

    internal class EchoRequestExample : IExamplesProvider<EchoRequest>
    {
        public EchoRequest GetExamples()
        {
            return new EchoRequest
            {
                Echo = "My string"
            };
        }
    }
}