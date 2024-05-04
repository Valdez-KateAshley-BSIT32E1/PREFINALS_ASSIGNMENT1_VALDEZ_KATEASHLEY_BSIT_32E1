using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet("userinfo")]
    [Authorize] // Requires authentication
    public IActionResult GetUserInfo()
    {
        // Get user information (you can retrieve this from claims)
        string username = User.Identity.Name; // Assuming username is stored in claims

        // Mock user data for demonstration purposes
        var userInfo = new
        {
            Name = "Kate Ashley Valdez",
            Section = "32E1",
            Course = "BSIT"
        };

        return Ok(userInfo);
    }

    [HttpGet("funfacts")]
    public IActionResult GetFunFacts()
    {
        // Fun facts about the API creator
        var funFacts = new List<string>
        {
            "I love programming challenges.",
            "I enjoy learning new technologies.",
            "I'm passionate about building useful applications.",
            "I enjoy hiking in my free time.",
            "I'm a fan of science fiction novels.",
            "I like experimenting with different cuisines.",
            "I enjoy playing musical instruments.",
            "I'm a coffee enthusiast.",
            "I love traveling to new places.",
            "I'm a big fan of open-source software."
        };

        return Ok(funFacts);
    }
}