using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace wooliesx.Controllers
{

    public class AnswersController : ApiController
    {

        private const string URL = "http://dev-wooliesx-recruitment.azurewebsites.net/api/Exercise/exercise1";
        private string urlParameters = "?api_key=542b72d5-5836-4014-8743-e943d151ef3a";

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "answer1", "answer2" };
        }


        // GET api/values/5
        public string Get(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "542b72d5-5836-4014-8743-e943d151ef3a");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(URL).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.


            var content =  client.GetStringAsync(URL);

            if (response.IsSuccessStatusCode)
            {


                return "answer";

            }

            return string.Empty;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
