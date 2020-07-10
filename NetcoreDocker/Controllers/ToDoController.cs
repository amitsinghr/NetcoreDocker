using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetcoreDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        // GET: api/<ToDoController>
        [HttpGet]
        public string Get()
        {

            var client = new RestClient("https://tvjan-tvmaze-v1.p.rapidapi.com/schedule?filter=primetime");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "tvjan-tvmaze-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7bfdd80a92mshe0df8df1cc304c1p1e4147jsnb9d63a826474");
            IRestResponse response = client.Execute(request);
            return response.Content;
            //return new string[] { response.Content, "value2" };
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
