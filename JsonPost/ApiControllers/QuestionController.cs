using JsonPost.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JsonPost.ApiControllers
{
    public class QuestionController : ApiController
    {
        // GET api/question
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/question/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/question
        public List<Question> Post([FromBody]string value)
        {
            List<Question> questions =  JsonConvert.DeserializeObject<List<Question>>(value);
            return questions;
        }

        // PUT api/question/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/question/5
        public void Delete(int id)
        {
        }
    }
}
