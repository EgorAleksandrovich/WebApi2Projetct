using First_appl_MVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebGymnasticApp.Controllers
{
    public class RatingController : ApiController
    {
        Server _server = new Server();
        [HttpGet]
        [Route("api/rating/{id}/{discipline}")]
        public List<Rating> GetRating(int id, string discipline)
        {
            return _server.GetRatings(id, discipline);
        }
    }
}
