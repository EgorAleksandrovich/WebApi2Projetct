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
        public List<Rating> GetRating(string id, Competition competition)
        {
            return _server.GetRatings(id, competition.Id);
        }
    }
}
