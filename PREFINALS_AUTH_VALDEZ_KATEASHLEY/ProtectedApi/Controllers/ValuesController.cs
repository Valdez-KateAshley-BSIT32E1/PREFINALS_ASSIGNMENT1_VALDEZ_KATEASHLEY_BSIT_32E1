using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ProtectedApi
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly string _ownerName = "John Doe"; // Replace with the actual owner name

        // GET api/values/about/me
        [HttpGet("about/me")]
        public ActionResult<IEnumerable<string>> GetFunFacts()
        {
            var funFacts = GenerateFunFacts();
            return Ok(funFacts);
        }

        // GET api/values/about
        [HttpGet("about")]
        public ActionResult<string> GetOwnerName()
        {
            return Ok(_ownerName);
        }

        // POST api/values/about
        [HttpPost("about")]
        public ActionResult<string> PostName([FromBody] string name)
        {
            return Ok($"Hi {name} from {_ownerName}");
        }

        private List<string> GenerateFunFacts()
        {
            var funFacts = new List<string>
            {
                "The creator loves coding in various languages.",
                "The creator enjoys outdoor activities like hiking and camping.",
                "The creator has a pet dog named Max.",
                "The creator's favorite programming language is C#.",
                "The creator is passionate about open-source projects.",
                "The creator is an avid reader and enjoys sci-fi novels.",
                "The creator is a coffee enthusiast and enjoys trying different blends.",
                "The creator is fascinated by artificial intelligence and machine learning.",
                "The creator is a fan of classic rock music.",
                "The creator enjoys cooking and experimenting with new recipes."
            };

            // Shuffle the list to randomize fun facts
            var rng = new Random();
            int n = funFacts.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = funFacts[k];
                funFacts[k] = funFacts[n];
                funFacts[n] = value;
            }

            return funFacts;
        }
    }
}
