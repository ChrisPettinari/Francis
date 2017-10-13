using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiAi;
using ApiAi.Models;
using ApiAi.Exceptions;

namespace Francis
{
    class Program
    {
        private const string
            ClientAccessToken = "90e7e4435cda4b59aeb3e55bacd39661",
            DeveloperAccessToken = "b0471423a62b47879f849fb85c95276c",
            ExampleEntityId = "your_exists_entity_id";

        public static void QueryTest(String query)
        {
            try
            {
                var result = QueryService.SendRequest(new ConfigModel { AccesTokenClient = ClientAccessToken }, query);
                //Assert.IsFalse(string.IsNullOrEmpty(result.SessionId));

                foreach (var msg in result.Messages)
                {
                    Console.WriteLine(msg.Text);
                }

            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                //Assert.Fail();
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("> ");
                QueryTest(Console.ReadLine());
            }
        }
    }
}
