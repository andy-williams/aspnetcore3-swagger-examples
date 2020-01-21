using Swashbuckle.AspNetCore.Filters;

namespace AspNetCore3.ApiDocs.Responses
{
    public class EchoResponse
    {
        public string Echo { get; set; }
    }

    internal class EchoResponseExample : IExamplesProvider<EchoResponse>
    {
        public EchoResponse GetExamples()
        {
            return new EchoResponse
            {
                Echo = "My string"
            };
        }
    }
}