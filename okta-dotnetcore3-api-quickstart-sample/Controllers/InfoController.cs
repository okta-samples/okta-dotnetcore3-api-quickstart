using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace okta_dotnetcore3_api_quickstart_sample.Controllers
{
    [EnableCors("AllowAll")]
    [ApiController]
    [Route("api")]
    public class InfoController : ControllerBase
    {
        // GET: api/whoami
        [Authorize] // require authorization
        [HttpGet]
        [Route("whoami")]
        public Dictionary<string, string> GetAuthorized()
        {
            var principal = HttpContext.User.Identity as ClaimsIdentity;
            return principal.Claims
                .GroupBy(claim => claim.Type)
                .ToDictionary(claim => claim.Key, claim => claim.First().Value);
        }


        // GET: api/hello
        [AllowAnonymous]
        [HttpGet]
        [Route("hello")]
        public string GetAnnonymous()
        {
            return "You are annonymous";
        }

    }
}
